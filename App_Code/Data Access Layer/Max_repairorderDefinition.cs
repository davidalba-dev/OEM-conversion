using System;

namespace OEMConversion.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="Max_repairorderView">OEMConversion.Max_repairorderView</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="Max_repairorderView"></seealso>
public class Max_repairorderDefinition
{
#region "Definition (XML) for Max_repairorderDefinition table"
	//Next 167 lines contain Table Definition (XML) for table "Max_repairorderDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="Max_repairorderView"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		if(_DefinitionString == "")
		{
			         System.Text.StringBuilder tbf = new System.Text.StringBuilder();
         tbf.Append(@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""11.1"" Type=""VIEW"">");
         tbf.Append(  @"<ColumnDefinition>");
         tbf.Append(    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">");
         tbf.Append(      @"<columnName>OEM</columnName>");
         tbf.Append(      @"<columnUIName>OEM</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault Source=""User""></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>Y</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed Source=""User"">N</columnComputed>");
         tbf.Append(      @"<columnIdentity Source=""User"">N</columnIdentity>");
         tbf.Append(      @"<columnReadOnly Source=""User"">N</columnReadOnly>");
         tbf.Append(      @"<columnRequired>Y</columnRequired>");
         tbf.Append(      @"<columnNotNull>N</columnNotNull>");
         tbf.Append(      @"<columnCaseSensitive Source=""User"">N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation></columnCollation>");
         tbf.Append(      @"<columnFullText Source=""User"">N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(      @"<InternalName>0</InternalName>");
         tbf.Append(      @"<columnTableClassName></columnTableClassName>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<applyDFKA>N</applyDFKA>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>VFK_max_repairorder_OEM_1</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.RepairOrdersTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>RONo</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>=RepairOrders.Link</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Implicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<columnVirtualPK Source=""User"">Y</columnVirtualPK>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">");
         tbf.Append(      @"<columnName>Metal</columnName>");
         tbf.Append(      @"<columnUIName Source=""User"">Metal</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault Source=""User""></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>Y</columnPK>");
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
         tbf.Append(      @"<InternalName>1</InternalName>");
         tbf.Append(      @"<columnTableClassName></columnTableClassName>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<applyDFKA>N</applyDFKA>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>VFK_max_repairorder_Metal_1</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.RepairOrdersTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>RONo</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>=RepairOrders.Link</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Implicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<columnVirtualPK Source=""User"">Y</columnVirtualPK>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">");
         tbf.Append(      @"<columnName>BIO</columnName>");
         tbf.Append(      @"<columnUIName Source=""User"">Bio</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault Source=""User""></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>Y</columnPK>");
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
         tbf.Append(      @"<InternalName>2</InternalName>");
         tbf.Append(      @"<columnTableClassName></columnTableClassName>");
         tbf.Append(      @"<applyInitializeReadingRecord>N</applyInitializeReadingRecord>");
         tbf.Append(      @"<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>");
         tbf.Append(      @"<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>");
         tbf.Append(      @"<applyValidateInsertingRecord>N</applyValidateInsertingRecord>");
         tbf.Append(      @"<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>");
         tbf.Append(      @"<applyDefaultValue>N</applyDefaultValue>");
         tbf.Append(      @"<applyDFKA>N</applyDFKA>");
         tbf.Append(      @"<readingRecordFormula></readingRecordFormula>");
         tbf.Append(      @"<insertingRecordFormula></insertingRecordFormula>");
         tbf.Append(      @"<updatingRecordFormula></updatingRecordFormula>");
         tbf.Append(      @"<insertingFormula></insertingFormula>");
         tbf.Append(      @"<updatingFormula></updatingFormula>");
         tbf.Append(      @"<foreignKey>");
         tbf.Append(        @"<columnFKName>VFK_max_repairorder_BIO_1</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.RepairOrdersTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>RONo</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>=RepairOrders.Link</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Implicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<columnVirtualPK Source=""User"">Y</columnVirtualPK>");
         tbf.Append(    "</Column>");
         tbf.Append(  "</ColumnDefinition>");
         tbf.Append(  @"<TableName>max_repairorder</TableName>");
         tbf.Append(  @"<Version>1</Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>max_repairorder_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseAYS_OEM</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""User"">Y</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""User"">Y</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""User"">Y</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">Y</canViewRecords>");
         tbf.Append(  @"<AppShortName>OEMConversion</AppShortName>");
         tbf.Append(  @"<TableCodeName>Max_repairorder</TableCodeName>");
         tbf.Append(  @"<FolderName>max_repairorder</FolderName>");
         tbf.Append(  @"<MenuName>Maximum Repairorder</MenuName>");
         tbf.Append(  @"<QSPath>../max_repairorder/Max-repairorder-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableStoredProcPrefix>pOEMConversionMax_repairorder</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
