using System;

namespace OEMConversion.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="Pickup_request_typeTable">OEMConversion.Pickup_request_typeTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="Pickup_request_typeTable"></seealso>
public class Pickup_request_typeDefinition
{
#region "Definition (XML) for Pickup_request_typeDefinition table"
	//Next 141 lines contain Table Definition (XML) for table "Pickup_request_typeDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="Pickup_request_typeTable"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		if(_DefinitionString == "")
		{
			         System.Text.StringBuilder tbf = new System.Text.StringBuilder();
         tbf.Append(@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""12.2"" Type=""GENERIC"">");
         tbf.Append(  @"<ColumnDefinition>");
         tbf.Append(    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">");
         tbf.Append(      @"<columnName>pickup_request_type_id</columnName>");
         tbf.Append(      @"<columnUIName Source=""User"">= &quot;Transaction Type&quot;</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>int</columnDBType>");
         tbf.Append(      @"<columnLengthSet>10.0</columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault Source=""User""></columnDBDefault>");
         tbf.Append(      @"<columnIndex>Y</columnIndex>");
         tbf.Append(      @"<columnUnique>Y</columnUnique>");
         tbf.Append(      @"<columnFunction></columnFunction>");
         tbf.Append(      @"<columnDBFormat></columnDBFormat>");
         tbf.Append(      @"<columnPK>Y</columnPK>");
         tbf.Append(      @"<columnPermanent>N</columnPermanent>");
         tbf.Append(      @"<columnComputed Source=""User"">Y</columnComputed>");
         tbf.Append(      @"<columnIdentity Source=""User"">Y</columnIdentity>");
         tbf.Append(      @"<columnReadOnly Source=""User"">Y</columnReadOnly>");
         tbf.Append(      @"<columnRequired>N</columnRequired>");
         tbf.Append(      @"<columnNotNull>Y</columnNotNull>");
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
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">");
         tbf.Append(      @"<columnName>pickup_request_type</columnName>");
         tbf.Append(      @"<columnUIName Source=""User"">= &quot;Type&quot;</columnUIName>");
         tbf.Append(      @"<columnType>String</columnType>");
         tbf.Append(      @"<columnDBType>varchar</columnDBType>");
         tbf.Append(      @"<columnLengthSet>50</columnLengthSet>");
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
         tbf.Append(      @"<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>");
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
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">");
         tbf.Append(      @"<columnName>pickup_request_active</columnName>");
         tbf.Append(      @"<columnUIName Source=""User"">= &quot;Active&quot;</columnUIName>");
         tbf.Append(      @"<columnType>Boolean</columnType>");
         tbf.Append(      @"<columnDBType>bit</columnDBType>");
         tbf.Append(      @"<columnLengthSet></columnLengthSet>");
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
         tbf.Append(    "</Column>");
         tbf.Append(  "</ColumnDefinition>");
         tbf.Append(  @"<TableName>pickup_request_type</TableName>");
         tbf.Append(  @"<Version></Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>pickup_request_type_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseAYS_OEM</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""Database"">Y</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""Database"">Y</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""Database"">Y</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">Y</canViewRecords>");
         tbf.Append(  @"<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>");
         tbf.Append(  @"<AppShortName>OEMConversion</AppShortName>");
         tbf.Append(  @"<FolderName>pickup_request_type</FolderName>");
         tbf.Append(  @"<MenuName>Pickup Request Type</MenuName>");
         tbf.Append(  @"<QSPath>../pickup_request_type/Pickup-request-type-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableCodeName>Pickup_request_type</TableCodeName>");
         tbf.Append(  @"<TableStoredProcPrefix>pOEMConversionPickup_request_type</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
