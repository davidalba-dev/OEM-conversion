﻿using System;

namespace OEMConversion.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="Vw_current_inventory_locationView">OEMConversion.Vw_current_inventory_locationView</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="Vw_current_inventory_locationView"></seealso>
public class Vw_current_inventory_locationDefinition
{
#region "Definition (XML) for Vw_current_inventory_locationDefinition table"
	//Next 199 lines contain Table Definition (XML) for table "Vw_current_inventory_locationDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="Vw_current_inventory_locationView"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		if(_DefinitionString == "")
		{
			         System.Text.StringBuilder tbf = new System.Text.StringBuilder();
         tbf.Append(@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""12.2"" Type=""VIEW"">");
         tbf.Append(  @"<ColumnDefinition>");
         tbf.Append(    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">");
         tbf.Append(      @"<columnName>warehouse_id</columnName>");
         tbf.Append(      @"<columnUIName>Warehouse</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>numeric</columnDBType>");
         tbf.Append(      @"<columnLengthSet>18.0</columnLengthSet>");
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
         tbf.Append(    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">");
         tbf.Append(      @"<columnName>warehouse_location_id</columnName>");
         tbf.Append(      @"<columnUIName>Warehouse Location</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>numeric</columnDBType>");
         tbf.Append(      @"<columnLengthSet>18.0</columnLengthSet>");
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
         tbf.Append(    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">");
         tbf.Append(      @"<columnName>datetime_entered</columnName>");
         tbf.Append(      @"<columnUIName>Date And Time Entered</columnUIName>");
         tbf.Append(      @"<columnType>Date</columnType>");
         tbf.Append(      @"<columnDBType>datetime</columnDBType>");
         tbf.Append(      @"<columnLengthSet></columnLengthSet>");
         tbf.Append(      @"<columnDefault></columnDefault>");
         tbf.Append(      @"<columnDBDefault></columnDBDefault>");
         tbf.Append(      @"<columnIndex>N</columnIndex>");
         tbf.Append(      @"<columnUnique>N</columnUnique>");
         tbf.Append(      @"<columnFunction>notrim</columnFunction>");
         tbf.Append(      @"<columnFormat>g</columnFormat>");
         tbf.Append(      @"<columnDBFormat>g</columnDBFormat>");
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
         tbf.Append(    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">");
         tbf.Append(      @"<columnName>inventory_id</columnName>");
         tbf.Append(      @"<columnUIName>Inventory</columnUIName>");
         tbf.Append(      @"<columnType>Number</columnType>");
         tbf.Append(      @"<columnDBType>numeric</columnDBType>");
         tbf.Append(      @"<columnLengthSet>18.0</columnLengthSet>");
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
         tbf.Append(      @"<InternalName>3</InternalName>");
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
         tbf.Append(        @"<columnFKName>VFK_vw_current_inventory_location_inventory_id_1</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.Equipment_inventoryTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>inventory_id</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>=Equipment_inventory.inventory_id</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Implicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">");
         tbf.Append(      @"<columnName>warehouse_location</columnName>");
         tbf.Append(      @"<columnUIName>Warehouse Location</columnUIName>");
         tbf.Append(      @"<columnType>String</columnType>");
         tbf.Append(      @"<columnDBType>varchar</columnDBType>");
         tbf.Append(      @"<columnLengthSet>50</columnLengthSet>");
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
         tbf.Append(      @"<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">");
         tbf.Append(      @"<columnName>warehouse_name</columnName>");
         tbf.Append(      @"<columnUIName>Warehouse Name</columnUIName>");
         tbf.Append(      @"<columnType>String</columnType>");
         tbf.Append(      @"<columnDBType>varchar</columnDBType>");
         tbf.Append(      @"<columnLengthSet>50</columnLengthSet>");
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
         tbf.Append(      @"<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>");
         tbf.Append(      @"<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>");
         tbf.Append(      @"<columnFullText>N</columnFullText>");
         tbf.Append(      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>");
         tbf.Append(      @"<columnTableAliasName></columnTableAliasName>");
         tbf.Append(      @"<applyLabelText>Y</applyLabelText>");
         tbf.Append(    "</Column>");
         tbf.Append(  "</ColumnDefinition>");
         tbf.Append(  @"<TableName>vw_current_inventory_location</TableName>");
         tbf.Append(  @"<Version></Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>vw_current_inventory_location_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseAYS_OEM</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""Database"">N</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""Database"">N</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""Database"">N</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">N</canViewRecords>");
         tbf.Append(  @"<AppShortName>OEMConversion</AppShortName>");
         tbf.Append(  @"<FolderName>vw_current_inventory_location</FolderName>");
         tbf.Append(  @"<MenuName>Current Inventory Location</MenuName>");
         tbf.Append(  @"<QSPath>../vw_current_inventory_location/Vw-current-inventory-location-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableCodeName>Vw_current_inventory_location</TableCodeName>");
         tbf.Append(  @"<TableStoredProcPrefix>pOEMConversionVw_current_inventory_location</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
