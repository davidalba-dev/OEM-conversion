using System;

namespace OEMConversion.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="BudgetTable">OEMConversion.BudgetTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="BudgetTable"></seealso>
public class BudgetDefinition
{
#region "Definition (XML) for BudgetDefinition table"
	//Next 200 lines contain Table Definition (XML) for table "BudgetDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="BudgetTable"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		if(_DefinitionString == "")
		{
			         System.Text.StringBuilder tbf = new System.Text.StringBuilder();
         tbf.Append(@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""11.1"" Type=""GENERIC"">");
         tbf.Append(  @"<ColumnDefinition>");
         tbf.Append(    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">");
         tbf.Append(      @"<columnName>budget_id</columnName>");
         tbf.Append(      @"<columnUIName>Budget</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>Y</columnIndex>");
         tbf.Append(      @"<columnUnique>Y</columnUnique>");
         tbf.Append(      @"<columnFunction>notrim</columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>Y</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>Y</columnComputed>");
         tbf.Append(      @"<columnIdentity>Y</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>Y</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>Y</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">");
         tbf.Append(      @"<columnName>budget_amount</columnName>");
         tbf.Append(      @"<columnUIName>Budget Amount</columnUIName>");
         tbf.Append(      @"<columnType>Currency</columnType>");
         tbf.Append(      @"<columnDBType>money</columnDBType>");
         tbf.Append(      @"<columnLengthSet>19.4</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnFormat>C</columnFormat>");
         tbf.Append(      @"<columnDBFormat>C</columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">");
         tbf.Append(      @"<columnName>budget_created_by</columnName>");
         tbf.Append(      @"<columnUIName>Budget Created By</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction>notrim</columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>FK_budget_corporate_contacts</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.Corporate_contactsTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>CorporateContact_Id</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>corporatecontact_title</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Explicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<applyDFKA>Y</applyDFKA>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">");
         tbf.Append(      @"<columnName>contract_id</columnName>");
         tbf.Append(      @"<columnUIName>Contract</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction>notrim</columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed>N</columnComputed>");
         tbf.Append(      @"<columnIdentity>N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly>N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive>N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>FK_budget_contract</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.ContractTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>contract_id</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>contract_name</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Explicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<applyDFKA>Y</applyDFKA>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">");
         tbf.Append(      @"<columnName>custno</columnName>");
         tbf.Append(      @"<columnUIName>Custno</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault Source=""User""></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>N</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed Source=""User"">N</columnComputed>");
         tbf.Append(      @"<columnIdentity Source=""User"">N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly Source=""User"">N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive Source=""User"">N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText Source=""User"">N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>FK_budget_Customers</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.CustomersTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>CustNo</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>= Customers.CustName</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Explicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<applyDFKA>Y</applyDFKA>");
         tbf.Append(      @"<InternalName>4</InternalName>");
         tbf.Append(      @"<columnTableClassName></columnTableClassName>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>VFK_budget_custno_1</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.CustomersTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>CustNo</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay></columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Implicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(    "</Column>");
         tbf.Append(  "</ColumnDefinition>");
         tbf.Append(  @"<TableName>budget</TableName>");
         tbf.Append(  @"<Version></Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>budget_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseAYS_OEM</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""Database"">Y</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""Database"">Y</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""Database"">Y</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">Y</canViewRecords>");
         tbf.Append(  @"<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>");
         tbf.Append(  @"<AppShortName>OEMConversion</AppShortName>");
         tbf.Append(  @"<FolderName>budget</FolderName>");
         tbf.Append(  @"<MenuName>Budget</MenuName>");
         tbf.Append(  @"<QSPath>../budget/Budget-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableCodeName>Budget</TableCodeName>");
         tbf.Append(  @"<TableStoredProcPrefix>pOEMConversionBudget</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
