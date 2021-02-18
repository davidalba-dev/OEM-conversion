using System;

namespace OEMConversion.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="Repair_request_countView">OEMConversion.Repair_request_countView</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="Repair_request_countView"></seealso>
public class Repair_request_countDefinition
{
#region "Definition (XML) for Repair_request_countDefinition table"
	//Next 46 lines contain Table Definition (XML) for table "Repair_request_countDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="Repair_request_countView"></see>
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
         tbf.Append(      @"<columnName>repair_request_count</columnName>");
         tbf.Append(      @"<columnUIName>Repair Request Count</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
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
         tbf.Append(    "</Column>");
         tbf.Append(  "</ColumnDefinition>");
         tbf.Append(  @"<TableName>repair_request_count</TableName>");
         tbf.Append(  @"<Version></Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>repair_request_count_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseAYS_OEM</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""Database"">N</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""Database"">N</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""Database"">N</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">N</canViewRecords>");
         tbf.Append(  @"<AppShortName>OEMConversion</AppShortName>");
         tbf.Append(  @"<FolderName>repair_request_count</FolderName>");
         tbf.Append(  @"<MenuName>Repair Request Count</MenuName>");
         tbf.Append(  @"<QSPath>../repair_request_count/Repair-request-count-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableCodeName>Repair_request_count</TableCodeName>");
         tbf.Append(  @"<TableStoredProcPrefix>pOEMConversionRepair_request_count</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
