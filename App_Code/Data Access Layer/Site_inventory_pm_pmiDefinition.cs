﻿using System;

namespace OEMConversion.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="Site_inventory_pm_pmiTable">OEMConversion.Site_inventory_pm_pmiTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="Site_inventory_pm_pmiTable"></seealso>
public class Site_inventory_pm_pmiDefinition
{
#region "Definition (XML) for Site_inventory_pm_pmiDefinition table"
	//Next 186 lines contain Table Definition (XML) for table "Site_inventory_pm_pmiDefinition"
	private static string _DefinitionString = "";
	
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="Site_inventory_pm_pmiTable"></see>
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
         tbf.Append(      @"<columnName>site_inventory_pm_id</columnName>");
         tbf.Append(      @"<columnUIName>Site Inventory PM</columnUIName>");
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
         tbf.Append(      @"<columnName>site_inventory_d</columnName>");
         tbf.Append(      @"<columnUIName>Site Inventory D</columnUIName>");
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
         tbf.Append(        @"<columnFKName>FK_site_inventory_pm_pmi_site_inventory</columnFKName>");
         tbf.Append(        @"<columnFKTable>OEMConversion.Business.Site_inventoryTable, App_Code</columnFKTable>");
         tbf.Append(        @"<columnFKOwner>dbo</columnFKOwner>");
         tbf.Append(        @"<columnFKColumn>site_inventory_id</columnFKColumn>");
         tbf.Append(        @"<columnFKColumnDisplay>custname</columnFKColumnDisplay>");
         tbf.Append(        @"<foreignKeyType>Explicit</foreignKeyType>");
         tbf.Append(      "</foreignKey>");
         tbf.Append(      @"<applyDFKA>Y</applyDFKA>");
         tbf.Append(    "</Column>");
         tbf.Append(    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">");
         tbf.Append(      @"<columnName>PMI</columnName>");
         tbf.Append(      @"<columnUIName>PMI</columnUIName>");
         tbf.Append(      @"<columnType>Boolean</columnType>");
         tbf.Append(      @"<columnDBType>bit</columnDBType>");
         tbf.Append(      @"<columnLengthSet></columnLengthSet>");
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
         tbf.Append(    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">");
         tbf.Append(      @"<columnName>PM_minutes</columnName>");
         tbf.Append(      @"<columnUIName>PM Minutes</columnUIName>");
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
         tbf.Append(    @"<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">");
         tbf.Append(      @"<columnName>PM_Interval</columnName>");
         tbf.Append(      @"<columnUIName>PM Interval</columnUIName>");
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
         tbf.Append(    @"<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">");
         tbf.Append(      @"<columnName>PMI_Interval</columnName>");
         tbf.Append(      @"<columnUIName>PMI Interval</columnUIName>");
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
         tbf.Append(  @"<TableName>site_inventory_pm_pmi</TableName>");
         tbf.Append(  @"<Version></Version>");
         tbf.Append(  @"<Owner>dbo</Owner>");
         tbf.Append(  @"<TableAliasName>site_inventory_pm_pmi_</TableAliasName>");
         tbf.Append(  @"<ConnectionName>DatabaseAYS_OEM</ConnectionName>");
         tbf.Append(  @"<PagingMethod>RowNum</PagingMethod>");
         tbf.Append(  @"<canCreateRecords Source=""Database"">Y</canCreateRecords>");
         tbf.Append(  @"<canEditRecords Source=""Database"">Y</canEditRecords>");
         tbf.Append(  @"<canDeleteRecords Source=""Database"">Y</canDeleteRecords>");
         tbf.Append(  @"<canViewRecords Source=""Database"">Y</canViewRecords>");
         tbf.Append(  @"<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>");
         tbf.Append(  @"<AppShortName>OEMConversion</AppShortName>");
         tbf.Append(  @"<FolderName>site_inventory_pm_pmi</FolderName>");
         tbf.Append(  @"<MenuName>Site Inventory PM PMI</MenuName>");
         tbf.Append(  @"<QSPath>../site_inventory_pm_pmi/Site-inventory-pm-pmi-QuickSelector.aspx</QSPath>");
         tbf.Append(  @"<TableCodeName>Site_inventory_pm_pmi</TableCodeName>");
         tbf.Append(  @"<TableStoredProcPrefix>pOEMConversionSite_inventory_pm_pmi</TableStoredProcPrefix>");
         tbf.Append("</XMLDefinition>");
         _DefinitionString = tbf.ToString();
	
		}	
		return _DefinitionString;		
	}
}

}
