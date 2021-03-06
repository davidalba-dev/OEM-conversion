﻿using System;
using System.Data;
using System.IO;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using BaseClasses;
using BaseClasses.Utils;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using BaseClasses.Web.UI.WebControls;

namespace OEMConversion.UI
{
    /// <summary>
    /// Summary description for ImportDataItems
    /// </summary>
    public class ImportDataItems
    {
        long NumberOfRecordImported = 0;
        long RowCount = 1;
        int ColumnCount = 1;
        const string SEPARATOR = ", ";

        #region "Properties"

            /// <summary>
            /// The path of the file from which data is to be retrieved for import.
            /// </summary>
            private string _fPath;
            public string FilePath
            {
                get
                {
                    return _fPath;
                }
                set
                {
                    _fPath = value;
                }
            }
            
            /// <summary>
            /// Type of the file to be imported
            /// </summary>
            private Parser.FileTypes _fType;
            public Parser.FileTypes FileType
            {
                get
                {
                    return _fType;
                }
                set
                {
                    _fType = value;
                }
            }

            /// <summary>
            /// The database table to which the records from CSV file has to be imported.
            /// </summary>
            private BaseTable _tbl;
            private BaseTable DBTable
            {
                get
                {
                    return this._tbl;
                }
                set
                {
                    this._tbl = value;
                }
            }

            /// <summary>
            /// Stores the list of column names for which the data from CSV file is to be imported to database table..
            /// </summary>
            private ArrayList _columnNameList;
            private ArrayList ColumnNameList
            {
                get
                {
                    return this._columnNameList;
                }
                set
                {
                    this._columnNameList = value;
                }

            }

            /// <summary>
            /// Stores the list of checkboxes which indicate whether corresponding column should be imported or not.
            /// </summary>
            private ArrayList _cbxList;
            private ArrayList ImportList
            {
                get
                {
                    return this._cbxList;
                }
                set
                {
                    this._cbxList = value;
                }

            }

        #endregion

        #region "Constructor"
            public ImportDataItems(string path, Parser.FileTypes type, BaseTable bTable, ArrayList ddListSelected, ArrayList chkBoxList)
            {
                //
                // Add constructor logic here
                //
                this.DBTable = bTable;
                this.ColumnNameList = ddListSelected;
                this.ImportList = chkBoxList;
                this.FilePath = path;
                this.FileType = type;
            }
        #endregion

        #region "Public Methods"

        private void AddSkippedRecordToList(System.Collections.Generic.List<BaseClasses.Utils.SkippedLine> recordsList, long RowCount, string[] rowValues, string exMsg)
        {
            if (!string.IsNullOrEmpty(exMsg)) exMsg = exMsg.Replace("'", "\\'");
            BaseClasses.Utils.SkippedLine skippedRecord = new BaseClasses.Utils.SkippedLine("", exMsg, RowCount);
            foreach (string rv in rowValues)
            {
                if (!string.IsNullOrEmpty(rv)) skippedRecord.LineContent += rv + SEPARATOR;
            }
            if (skippedRecord.LineContent.EndsWith(", "))
            {
                skippedRecord.LineContent = skippedRecord.LineContent.Substring(0, skippedRecord.LineContent.Length - 2);
            }

            recordsList.Add(skippedRecord);
        }

            /// <summary>
            /// Reads  rows of values for CSV file and import it to Database.
            /// </summary>
        public BaseClasses.Utils.ImportedResults ImportRecords(bool isImportFirstRowChecked, bool isResolvedForeignKeysChecked)
        {
            Parser parsr = null;
            BaseClasses.Utils.ImportedResults results = new BaseClasses.Utils.ImportedResults();
            try
            {
                if (this.FilePath == null || this.DBTable == null || this.ColumnNameList == null || this.ImportList == null)
                    return results;

                DbUtils.StartTransaction();
                parsr = Parser.GetParser(this.FilePath, this.FileType);
                string[] rowValues = parsr.GetNextRow(); // get the first row
                if ((!isImportFirstRowChecked) && rowValues != null)
                {
                    try
                    {
                        DoImport(rowValues, isResolvedForeignKeysChecked);
                        RowCount++;
                    }
                    catch (Exception ex) {
                        results.NumberOfSkipped += 1;
                        this.AddSkippedRecordToList(results.ListOfSkipped, RowCount + results.NumberOfSkipped, rowValues, ex.Message);
                    }
                    
                }
                while (rowValues != null)
                {
                    rowValues = parsr.GetNextRow();
                    if (rowValues != null)
                    {
                        try
                        {
                            DoImport(rowValues, isResolvedForeignKeysChecked);
                            RowCount++;
                        }
                        catch (Exception ex)
                        {
                            results.NumberOfSkipped += 1;
                            this.AddSkippedRecordToList(results.ListOfSkipped, RowCount + results.NumberOfSkipped, rowValues, ex.Message);
                        }
                       
                    }
                }
                DbUtils.CommitTransaction();
                parsr.Close();
               
            }
            catch (Exception e)
            {
                DbUtils.RollBackTransaction();
                results.NumberOfImported = 0;
                parsr.Close();
                string errorMsg = e.Message;
                if (File.Exists(this.FilePath))
                {
                    File.Delete(this.FilePath);
                }
                errorMsg = string.Format("- " + errorMsg + Environment.NewLine + "- Import error occurred at Row = {0},Column = {1}", RowCount, ColumnCount);
                throw new Exception(errorMsg);
            }
            finally
            {
                DbUtils.EndTransaction();
                if (File.Exists(this.FilePath))
                {
                    File.Delete(this.FilePath);
                }

            }
            results.NumberOfImported = NumberOfRecordImported;
            return results;
        }

            /// <summary>
            /// Creates a database record and calls UpdateColumnValuesInRecord to set the record values.
            /// </summary>
        private void DoImport(string[] rowValues, bool isResolvedForeignKeysChecked)
            {
                IRecord r;
                r = this.DBTable.CreateRecord();
                if ((UpdateColumnValuesInRecord(rowValues, r, isResolvedForeignKeysChecked)))
                {
                    r.Save();
                    NumberOfRecordImported = NumberOfRecordImported + 1;
                } 


            }

            /// <summary>
            /// Sets a database record values with values retrieved from data file.
            /// </summary>
            /// <param name="rowValues"></param>
            /// <param name="record"></param>
        private bool UpdateColumnValuesInRecord(string[] rowValues, IRecord record, bool isResolvedForeignKeysChecked)
            {
                int j = 0;
                bool isRecordUpdated = false;
                ColumnCount = 1;
                foreach (string data in rowValues)
                {
                    ColumnCount++;
                    if (j > this.ImportList.Count - 1)
                    {
                        return isRecordUpdated;
                    }
                    try
                    {
                        if (this.ColumnNameList[j].ToString() != "" && ((CheckBox)this.ImportList[j]).Checked)
                        {
                            ForeignKey fkColumn = null;
                            BaseColumn currentColumn = this.DBTable.TableDefinition.ColumnList.GetByAnyName((string)this.ColumnNameList[j]);
                            if (isResolvedForeignKeysChecked)
                                fkColumn = this.DBTable.TableDefinition.GetForeignKeyByColumnName(currentColumn.InternalName);
                            String colValue = "";

                            // Check if the foreign key has DFKA. If so, then check the calue from csv file agains the DFKA column in the parent/foreign key table.
                            // If a match is found retrieve its ID and set that as value to be insterted in the current table where you are adding records.
                            if (fkColumn != null)
                            {

                                TableDefinition originalTableDef = fkColumn.PrimaryKeyTableDefinition;
                                BaseTable originalBaseTable = originalTableDef.CreateBaseTable();
                                WhereClause wc = null;
                                ArrayList records = new ArrayList();
                                BaseColumn pkColumn = (BaseColumn)originalTableDef.PrimaryKey.Columns[0];//Index is zero because we handle only those tables which has single PK column not composite keys.
                                if (fkColumn.PrimaryKeyDisplayColumns != null && fkColumn.PrimaryKeyDisplayColumns != "" && (!fkColumn.PrimaryKeyDisplayColumns.Trim().StartsWith("=")))
                                {
                                    wc = new WhereClause(originalTableDef.ColumnList.GetByAnyName(fkColumn.PrimaryKeyDisplayColumns), BaseFilter.ComparisonOperator.EqualsTo, data);

                                } else if (fkColumn.PrimaryKeyDisplayColumns != null && fkColumn.PrimaryKeyDisplayColumns != "" && (fkColumn.PrimaryKeyDisplayColumns.Trim().StartsWith("="))) {
	                                string primaryKeyDisplay = GetDFKA(fkColumn);
	                                if (primaryKeyDisplay != null) {
		                                wc = new WhereClause(originalTableDef.ColumnList.GetByAnyName(primaryKeyDisplay), BaseFilter.ComparisonOperator.EqualsTo, data);
	                                } 
                                    else {
		                                wc = new WhereClause(pkColumn, BaseFilter.ComparisonOperator.EqualsTo, data);
	                                }
                                }
                                else
                                {
                                    // if the foreign key does not have DFKA then just check in the foreign key table if the id exists. If not create a record with the specified ID
                                    // before adding to current table
                                    wc = new WhereClause(pkColumn, BaseFilter.ComparisonOperator.EqualsTo, data);

                                }
                                BaseClasses.Data.BaseFilter join = null; 
                                records = originalBaseTable.GetRecordList(join, wc.GetFilter(), null, null, 0, 100);
                                if (records.Count > 0)
                                {
                                    // take the first record and retrieve its ID.
                                    BaseRecord rec = (BaseRecord)records[0];

                                    colValue = (rec.GetValue(pkColumn)).ToString();

                                }
                                else
                                {
                                    //  IF there is not match found then you have to create a record in the foreign key table with DFKA value and then retreive its ID
                                    if (data != null & data != "")
                                    {

                                        IRecord tempRec;
                                        if (fkColumn.PrimaryKeyDisplayColumns != null && fkColumn.PrimaryKeyDisplayColumns != "" && (!fkColumn.PrimaryKeyDisplayColumns.Trim().StartsWith("=")))
                                        {
                                            tempRec = originalBaseTable.CreateRecord();
                                            TableDefinition tableDef = originalBaseTable.TableDefinition;
                                            foreach (BaseColumn newCol in tableDef.Columns)
                                            {
                                                if (fkColumn.PrimaryKeyDisplayColumns == newCol.InternalName)
                                                {
                                                    tempRec.SetValue(data, newCol.UniqueName);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            tempRec = originalBaseTable.CreateRecord(data);
                                        }
                                        tempRec.Save();
                                        colValue = (tempRec.GetValue(pkColumn)).ToString();
                                    }
                                   // colValue = data;
                                }
                            }
                            else
                            {
                                colValue = data;
                            }
                            // set the table row's column for value
                            record.SetValue(colValue, currentColumn.UniqueName);
                            isRecordUpdated = true;
                        }
                        j++;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.InnerException.Message);
                    }
                }
                return isRecordUpdated;
            }

        public static string GetDFKA(ForeignKey fkColumn)
        {
	    	bool isDFKA = false;
	        if (fkColumn == null) {
		        return null;
	        }
	        string _DFKA = fkColumn.PrimaryKeyDisplayColumns;

	        // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
	        string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
	        string column = _DFKA.Trim('=').Trim();
	        if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase)) {
		        column = column.Substring(tableCodeName.Length + 1);
	        }

	        foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns) {
		    if (column == c.CodeName) {
			    isDFKA = true;
			    break; 
		        }
	        }

	        if (isDFKA) {
		        return column;
	        } else {
		        return null;
	        }
        }
        #endregion
    }
}
