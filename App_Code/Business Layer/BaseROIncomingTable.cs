// This class is "generated" and will be overwritten.
// Your customizations should be made in ROIncomingTable.cs


using System;
using System.Data;
using System.Collections;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using OEMConversion.Data;

namespace OEMConversion.Business
{

/// <summary>
/// The generated superclass for the <see cref="ROIncomingTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseAYS_OEM%dbo.ROIncoming.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="ROIncomingTable.Instance">ROIncomingTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="ROIncomingTable"></seealso>
[SerializableAttribute()]
public class BaseROIncomingTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = ROIncomingDefinition.GetXMLString();







    protected BaseROIncomingTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.ROIncomingTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "OEMConversion.Business.ROIncomingRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new ROIncomingSqlTable();
        ((ROIncomingSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        ROIncoming_idColumn.CodeName = "ROIncoming_id";
        passColumn.CodeName = "pass";
        failColumn.CodeName = "fail";
        tech_observationsColumn.CodeName = "tech_observations";
        incoming_uColumn.CodeName = "incoming_u";
        incoming_dColumn.CodeName = "incoming_d";
        in_angulation_lColumn.CodeName = "in_angulation_l";
        in_angulatoin_rColumn.CodeName = "in_angulatoin_r";
        outgoing_uColumn.CodeName = "outgoing_u";
        outgoing_dColumn.CodeName = "outgoing_d";
        out_angulation_lColumn.CodeName = "out_angulation_l";
        out_angulation_dColumn.CodeName = "out_angulation_d";
        ronoColumn.CodeName = "rono";
        technician_idColumn.CodeName = "technician_id";
        incoming_datetimeColumn.CodeName = "incoming_datetime";
        comp_leaktestColumn.CodeName = "comp_leaktest";
        comp_leaktestColumn.Name = EvaluateFormula("\"Leak Test\"");
        comp_leaktest_obsColumn.CodeName = "comp_leaktest_obs";
        comp_fluidcheckColumn.CodeName = "comp_fluidcheck";
        comp_fluidcheckColumn.Name = EvaluateFormula("\"Fluid Check\"");
        comp_fluidcheck_obsColumn.CodeName = "comp_fluidcheck_obs";
        comp_ocularColumn.CodeName = "comp_ocular";
        comp_ocularColumn.Name = EvaluateFormula("\"Ocular\"");
        comp_ocular_obsColumn.CodeName = "comp_ocular_obs";
        comp_imageColumn.CodeName = "comp_image";
        comp_imageColumn.Name = EvaluateFormula("\"Image\"");
        comp_image_obsColumn.CodeName = "comp_image_obs";
        comp_lightoutColumn.CodeName = "comp_lightout";
        comp_lightoutColumn.Name = EvaluateFormula("\"Light Output\"");
        comp_lightout_obsColumn.CodeName = "comp_lightout_obs";
        comp_switchesColumn.CodeName = "comp_switches";
        comp_switchesColumn.Name = EvaluateFormula("\" Switches 1-4\"");
        comp_switches_obsColumn.CodeName = "comp_switches_obs";
        comp_awColumn.CodeName = "comp_aw";
        comp_awColumn.Name = EvaluateFormula("\"A/W System\"");
        comp_aw_obsColumn.CodeName = "comp_aw_obs";
        comp_suctionColumn.CodeName = "comp_suction";
        comp_suctionColumn.Name = EvaluateFormula("\"Suction Sys\"");
        comp_suction_obsColumn.CodeName = "comp_suction_obs";
        comp_elevationColumn.CodeName = "comp_elevation";
        comp_elevationColumn.Name = EvaluateFormula("\"Elevation Sys\"");
        comp_elevation_obsColumn.CodeName = "comp_elevation_obs";
        comp_controlColumn.CodeName = "comp_control";
        comp_controlColumn.Name = EvaluateFormula("\"Control Knobs\"");
        comp_control_obsColumn.CodeName = "comp_control_obs";
        comp_biopsyColumn.CodeName = "comp_biopsy";
        comp_biopsyColumn.Name = EvaluateFormula("\"Biopsy Channel\"");
        comp_biopsy_obsColumn.CodeName = "comp_biopsy_obs";
        comp_bendingColumn.CodeName = "comp_bending";
        comp_bendingColumn.Name = EvaluateFormula("\"Bending Section\"");
        comp_bending_obsColumn.CodeName = "comp_bending_obs";
        comp_insertionColumn.CodeName = "comp_insertion";
        comp_insertionColumn.Name = EvaluateFormula("\"Insertion Tube\"");
        comp_insertion_obsColumn.CodeName = "comp_insertion_obs";
        comp_lightguideColumn.CodeName = "comp_lightguide";
        comp_lightguideColumn.Name = EvaluateFormula("\"Light Guide Tube\"");
        comp_lightguide_obsColumn.CodeName = "comp_lightguide_obs";
        comp_lgconnColumn.CodeName = "comp_lgconn";
        comp_lgconnColumn.Name = EvaluateFormula("\"LG Connector\"");
        comp_lgconn_obsColumn.CodeName = "comp_lgconn_obs";
        comp_bootsColumn.CodeName = "comp_boots";
        comp_bootsColumn.Name = EvaluateFormula("\"Boots\"");
        comp_boots_obsColumn.CodeName = "comp_boots_obs";
        comp_controlbodyColumn.CodeName = "comp_controlbody";
        comp_controlbodyColumn.Name = EvaluateFormula("\"Control Body\"");
        comp_controlbody_obsColumn.CodeName = "comp_controlbody_obs";
        comp_ccoverColumn.CodeName = "comp_ccover";
        comp_ccoverColumn.Name = EvaluateFormula("\"C-Cover\"");
        comp_ccover_obsColumn.CodeName = "comp_ccover_obs";
        comp_objectiveColumn.CodeName = "comp_objective";
        comp_objectiveColumn.Name = EvaluateFormula("\"Objective Lens\"");
        comp_objective_obsColumn.CodeName = "comp_objective_obs";
        comp_lightlensColumn.CodeName = "comp_lightlens";
        comp_lightlensColumn.Name = EvaluateFormula("\"Light Guide Lens\"");
        comp_lightlens_obsColumn.CodeName = "comp_lightlens_obs";
        comp_bendrubberColumn.CodeName = "comp_bendrubber";
        comp_bendrubberColumn.Name = EvaluateFormula("\"Bending Rubber\"");
        comp_bendrubber_obsColumn.CodeName = "comp_bendrubber_obs";
        comp_other1Column.CodeName = "comp_other1";
        comp_other1Column.Name = EvaluateFormula("\"Other 1\"");
        comp_other1_obsColumn.CodeName = "comp_other1_obs";
        comp_other2Column.CodeName = "comp_other2";
        comp_other2Column.Name = EvaluateFormula("\"Other 2\"");
        comp_other2_obsColumn.CodeName = "comp_other2_obs";
        comp_other1_nameColumn.CodeName = "comp_other1_name";
        comp_other1_nameColumn.Name = EvaluateFormula("\"Other 1 Name\"");
        comp_other2_nameColumn.CodeName = "comp_other2_name";
        comp_other2_nameColumn.Name = EvaluateFormula("\"Other 2 Name\"");
        tech_notesColumn.CodeName = "tech_notes";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.ROIncoming_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ROIncoming_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.ROIncoming_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ROIncoming_id
    {
        get
        {
            return ROIncomingTable.Instance.ROIncoming_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.pass column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn passColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.pass column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn pass
    {
        get
        {
            return ROIncomingTable.Instance.passColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.fail column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn failColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.fail column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn fail
    {
        get
        {
            return ROIncomingTable.Instance.failColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.tech_observations column object.
    /// </summary>
    public BaseClasses.Data.StringColumn tech_observationsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.tech_observations column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn tech_observations
    {
        get
        {
            return ROIncomingTable.Instance.tech_observationsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.incoming_u column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn incoming_uColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.incoming_u column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn incoming_u
    {
        get
        {
            return ROIncomingTable.Instance.incoming_uColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.incoming_d column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn incoming_dColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.incoming_d column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn incoming_d
    {
        get
        {
            return ROIncomingTable.Instance.incoming_dColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.in_angulation_l column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn in_angulation_lColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.in_angulation_l column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn in_angulation_l
    {
        get
        {
            return ROIncomingTable.Instance.in_angulation_lColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.in_angulatoin_r column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn in_angulatoin_rColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.in_angulatoin_r column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn in_angulatoin_r
    {
        get
        {
            return ROIncomingTable.Instance.in_angulatoin_rColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.outgoing_u column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn outgoing_uColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.outgoing_u column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn outgoing_u
    {
        get
        {
            return ROIncomingTable.Instance.outgoing_uColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.outgoing_d column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn outgoing_dColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.outgoing_d column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn outgoing_d
    {
        get
        {
            return ROIncomingTable.Instance.outgoing_dColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.out_angulation_l column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn out_angulation_lColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.out_angulation_l column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn out_angulation_l
    {
        get
        {
            return ROIncomingTable.Instance.out_angulation_lColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.out_angulation_d column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn out_angulation_dColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.out_angulation_d column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn out_angulation_d
    {
        get
        {
            return ROIncomingTable.Instance.out_angulation_dColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.rono column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ronoColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.rono column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn rono
    {
        get
        {
            return ROIncomingTable.Instance.ronoColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.technician_id column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn technician_idColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.technician_id column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn technician_id
    {
        get
        {
            return ROIncomingTable.Instance.technician_idColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.incoming_datetime column object.
    /// </summary>
    public BaseClasses.Data.DateColumn incoming_datetimeColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.incoming_datetime column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn incoming_datetime
    {
        get
        {
            return ROIncomingTable.Instance.incoming_datetimeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_leaktest column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_leaktestColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_leaktest column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_leaktest
    {
        get
        {
            return ROIncomingTable.Instance.comp_leaktestColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_leaktest_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_leaktest_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_leaktest_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_leaktest_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_leaktest_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_fluidcheck column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_fluidcheckColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_fluidcheck column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_fluidcheck
    {
        get
        {
            return ROIncomingTable.Instance.comp_fluidcheckColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_fluidcheck_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_fluidcheck_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_fluidcheck_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_fluidcheck_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_fluidcheck_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ocular column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_ocularColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ocular column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_ocular
    {
        get
        {
            return ROIncomingTable.Instance.comp_ocularColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ocular_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_ocular_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ocular_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_ocular_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_ocular_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_image column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_imageColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[21];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_image column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_image
    {
        get
        {
            return ROIncomingTable.Instance.comp_imageColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_image_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_image_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[22];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_image_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_image_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_image_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightout column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_lightoutColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[23];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightout column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_lightout
    {
        get
        {
            return ROIncomingTable.Instance.comp_lightoutColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightout_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_lightout_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[24];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightout_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_lightout_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_lightout_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_switches column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_switchesColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[25];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_switches column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_switches
    {
        get
        {
            return ROIncomingTable.Instance.comp_switchesColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_switches_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_switches_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[26];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_switches_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_switches_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_switches_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_aw column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_awColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[27];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_aw column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_aw
    {
        get
        {
            return ROIncomingTable.Instance.comp_awColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_aw_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_aw_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[28];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_aw_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_aw_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_aw_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_suction column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_suctionColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[29];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_suction column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_suction
    {
        get
        {
            return ROIncomingTable.Instance.comp_suctionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_suction_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_suction_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[30];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_suction_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_suction_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_suction_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_elevation column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_elevationColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[31];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_elevation column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_elevation
    {
        get
        {
            return ROIncomingTable.Instance.comp_elevationColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_elevation_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_elevation_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[32];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_elevation_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_elevation_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_elevation_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_control column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_controlColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[33];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_control column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_control
    {
        get
        {
            return ROIncomingTable.Instance.comp_controlColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_control_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_control_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[34];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_control_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_control_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_control_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_biopsy column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_biopsyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[35];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_biopsy column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_biopsy
    {
        get
        {
            return ROIncomingTable.Instance.comp_biopsyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_biopsy_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_biopsy_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[36];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_biopsy_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_biopsy_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_biopsy_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bending column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_bendingColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[37];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bending column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_bending
    {
        get
        {
            return ROIncomingTable.Instance.comp_bendingColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bending_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_bending_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[38];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bending_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_bending_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_bending_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_insertion column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_insertionColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[39];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_insertion column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_insertion
    {
        get
        {
            return ROIncomingTable.Instance.comp_insertionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_insertion_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_insertion_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[40];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_insertion_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_insertion_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_insertion_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightguide column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_lightguideColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[41];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightguide column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_lightguide
    {
        get
        {
            return ROIncomingTable.Instance.comp_lightguideColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightguide_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_lightguide_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[42];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightguide_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_lightguide_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_lightguide_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lgconn column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_lgconnColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[43];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lgconn column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_lgconn
    {
        get
        {
            return ROIncomingTable.Instance.comp_lgconnColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lgconn_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_lgconn_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[44];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lgconn_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_lgconn_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_lgconn_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_boots column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_bootsColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[45];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_boots column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_boots
    {
        get
        {
            return ROIncomingTable.Instance.comp_bootsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_boots_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_boots_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[46];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_boots_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_boots_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_boots_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_controlbody column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_controlbodyColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[47];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_controlbody column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_controlbody
    {
        get
        {
            return ROIncomingTable.Instance.comp_controlbodyColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_controlbody_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_controlbody_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[48];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_controlbody_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_controlbody_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_controlbody_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ccover column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_ccoverColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[49];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ccover column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_ccover
    {
        get
        {
            return ROIncomingTable.Instance.comp_ccoverColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ccover_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_ccover_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[50];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_ccover_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_ccover_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_ccover_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_objective column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_objectiveColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[51];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_objective column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_objective
    {
        get
        {
            return ROIncomingTable.Instance.comp_objectiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_objective_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_objective_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[52];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_objective_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_objective_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_objective_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightlens column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_lightlensColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[53];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightlens column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_lightlens
    {
        get
        {
            return ROIncomingTable.Instance.comp_lightlensColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightlens_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_lightlens_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[54];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_lightlens_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_lightlens_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_lightlens_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bendrubber column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_bendrubberColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[55];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bendrubber column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_bendrubber
    {
        get
        {
            return ROIncomingTable.Instance.comp_bendrubberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bendrubber_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_bendrubber_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[56];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_bendrubber_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_bendrubber_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_bendrubber_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other1 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_other1Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[57];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other1 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_other1
    {
        get
        {
            return ROIncomingTable.Instance.comp_other1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other1_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_other1_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[58];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other1_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_other1_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_other1_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other2 column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn comp_other2Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[59];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other2 column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn comp_other2
    {
        get
        {
            return ROIncomingTable.Instance.comp_other2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other2_obs column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_other2_obsColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[60];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other2_obs column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_other2_obs
    {
        get
        {
            return ROIncomingTable.Instance.comp_other2_obsColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other1_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_other1_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[61];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other1_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_other1_name
    {
        get
        {
            return ROIncomingTable.Instance.comp_other1_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other2_name column object.
    /// </summary>
    public BaseClasses.Data.StringColumn comp_other2_nameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[62];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.comp_other2_name column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn comp_other2_name
    {
        get
        {
            return ROIncomingTable.Instance.comp_other2_nameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.tech_notes column object.
    /// </summary>
    public BaseClasses.Data.StringColumn tech_notesColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[63];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's ROIncoming_.tech_notes column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn tech_notes
    {
        get
        {
            return ROIncomingTable.Instance.tech_notesColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of ROIncomingRecord records using a where clause.
    /// </summary>
    public static ROIncomingRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of ROIncomingRecord records using a where clause.
    /// </summary>
    public static ROIncomingRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of ROIncomingRecord records using a where and order by clause.
    /// </summary>
    public static ROIncomingRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of ROIncomingRecord records using a where and order by clause.
    /// </summary>
    public static ROIncomingRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of ROIncomingRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ROIncomingRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (ROIncomingRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ROIncomingRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of ROIncomingRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ROIncomingRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (ROIncomingRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ROIncomingRecord"));
    }   


    public static ROIncomingRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (ROIncomingRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ROIncomingRecord"));
    }

    public static ROIncomingRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (ROIncomingRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ROIncomingRecord"));
    }


    public static ROIncomingRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (ROIncomingRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ROIncomingRecord"));
    }

    public static ROIncomingRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (ROIncomingRecord[])recList.ToArray(Type.GetType("OEMConversion.Business.ROIncomingRecord"));
    }


    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)ROIncomingTable.Instance.GetRecordListCount(null, whereFilter, null, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(BaseFilter join, string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)ROIncomingTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)ROIncomingTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)ROIncomingTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a ROIncomingRecord record using a where clause.
    /// </summary>
    public static ROIncomingRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a ROIncomingRecord record using a where clause.
    /// </summary>
    public static ROIncomingRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a ROIncomingRecord record using a where and order by clause.
    /// </summary>
    public static ROIncomingRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        ROIncomingRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (ROIncomingRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a ROIncomingRecord record using a where and order by clause.
    /// </summary>
    public static ROIncomingRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = ROIncomingTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        ROIncomingRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (ROIncomingRecord)recList[0];
        }

        return rec;
    }


    public static String[] GetValues(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return ROIncomingTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }

    public static String[] GetValues(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return ROIncomingTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        ROIncomingRecord[] recs = GetRecords(where);
        return  ROIncomingTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        ROIncomingRecord[] recs = GetRecords(join, where);
        return  ROIncomingTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        ROIncomingRecord[] recs = GetRecords(where, orderBy);
        return  ROIncomingTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        ROIncomingRecord[] recs = GetRecords(join, where, orderBy);
        return  ROIncomingTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        ROIncomingRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  ROIncomingTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        ROIncomingRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  ROIncomingTable.Instance.CreateDataTable(recs, null);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to delete records using a where clause.
    /// </summary>
    public static void DeleteRecords(string where)
    {
        if (where == null || where.Trim() == "")
        {
           return;
        }
        
        SqlFilter whereFilter = new SqlFilter(where);
        ROIncomingTable.Instance.DeleteRecordList(whereFilter);
    }
    
    /// <summary>
    /// This is a shared function that can be used to export records using a where clause.
    /// </summary>
    public static string Export(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        return  ROIncomingTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return ROIncomingTable.Instance.ExportRecordData(whereFilter);
    }
    
	public static string GetSum(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return ROIncomingTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
	public static string GetSum(
		BaseColumn col,
		BaseFilter join, 
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return ROIncomingTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }    
    
    public static string GetCount(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return ROIncomingTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
    public static string GetCount(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return ROIncomingTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return ROIncomingTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return ROIncomingTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return ROIncomingTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return ROIncomingTable.Instance.CreateRecord(tempId);
    }

    /// <summary>
    /// This method checks if column is editable.
    /// </summary>
    /// <param name="columnName">Name of the column to check.</param>
    public static bool isReadOnlyColumn(string columnName) 
    {
        BaseColumn column = GetColumn(columnName);
        if (!(column == null)) 
        {
            return column.IsValuesReadOnly;
        }
        else 
        {
            return true;
        }
    }

    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    public static BaseColumn GetColumn(string uniqueColumnName) 
    {
        BaseColumn column = ROIncomingTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = ROIncomingTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static ROIncomingRecord GetRecord(string id, bool bMutable)
        {
            return (ROIncomingRecord)ROIncomingTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static ROIncomingRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (ROIncomingRecord)ROIncomingTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string passValue, 
        string failValue, 
        string tech_observationsValue, 
        string incoming_uValue, 
        string incoming_dValue, 
        string in_angulation_lValue, 
        string in_angulatoin_rValue, 
        string outgoing_uValue, 
        string outgoing_dValue, 
        string out_angulation_lValue, 
        string out_angulation_dValue, 
        string ronoValue, 
        string technician_idValue, 
        string incoming_datetimeValue, 
        string comp_leaktestValue, 
        string comp_leaktest_obsValue, 
        string comp_fluidcheckValue, 
        string comp_fluidcheck_obsValue, 
        string comp_ocularValue, 
        string comp_ocular_obsValue, 
        string comp_imageValue, 
        string comp_image_obsValue, 
        string comp_lightoutValue, 
        string comp_lightout_obsValue, 
        string comp_switchesValue, 
        string comp_switches_obsValue, 
        string comp_awValue, 
        string comp_aw_obsValue, 
        string comp_suctionValue, 
        string comp_suction_obsValue, 
        string comp_elevationValue, 
        string comp_elevation_obsValue, 
        string comp_controlValue, 
        string comp_control_obsValue, 
        string comp_biopsyValue, 
        string comp_biopsy_obsValue, 
        string comp_bendingValue, 
        string comp_bending_obsValue, 
        string comp_insertionValue, 
        string comp_insertion_obsValue, 
        string comp_lightguideValue, 
        string comp_lightguide_obsValue, 
        string comp_lgconnValue, 
        string comp_lgconn_obsValue, 
        string comp_bootsValue, 
        string comp_boots_obsValue, 
        string comp_controlbodyValue, 
        string comp_controlbody_obsValue, 
        string comp_ccoverValue, 
        string comp_ccover_obsValue, 
        string comp_objectiveValue, 
        string comp_objective_obsValue, 
        string comp_lightlensValue, 
        string comp_lightlens_obsValue, 
        string comp_bendrubberValue, 
        string comp_bendrubber_obsValue, 
        string comp_other1Value, 
        string comp_other1_obsValue, 
        string comp_other2Value, 
        string comp_other2_obsValue, 
        string comp_other1_nameValue, 
        string comp_other2_nameValue, 
        string tech_notesValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(passValue, passColumn);
        rec.SetString(failValue, failColumn);
        rec.SetString(tech_observationsValue, tech_observationsColumn);
        rec.SetString(incoming_uValue, incoming_uColumn);
        rec.SetString(incoming_dValue, incoming_dColumn);
        rec.SetString(in_angulation_lValue, in_angulation_lColumn);
        rec.SetString(in_angulatoin_rValue, in_angulatoin_rColumn);
        rec.SetString(outgoing_uValue, outgoing_uColumn);
        rec.SetString(outgoing_dValue, outgoing_dColumn);
        rec.SetString(out_angulation_lValue, out_angulation_lColumn);
        rec.SetString(out_angulation_dValue, out_angulation_dColumn);
        rec.SetString(ronoValue, ronoColumn);
        rec.SetString(technician_idValue, technician_idColumn);
        rec.SetString(incoming_datetimeValue, incoming_datetimeColumn);
        rec.SetString(comp_leaktestValue, comp_leaktestColumn);
        rec.SetString(comp_leaktest_obsValue, comp_leaktest_obsColumn);
        rec.SetString(comp_fluidcheckValue, comp_fluidcheckColumn);
        rec.SetString(comp_fluidcheck_obsValue, comp_fluidcheck_obsColumn);
        rec.SetString(comp_ocularValue, comp_ocularColumn);
        rec.SetString(comp_ocular_obsValue, comp_ocular_obsColumn);
        rec.SetString(comp_imageValue, comp_imageColumn);
        rec.SetString(comp_image_obsValue, comp_image_obsColumn);
        rec.SetString(comp_lightoutValue, comp_lightoutColumn);
        rec.SetString(comp_lightout_obsValue, comp_lightout_obsColumn);
        rec.SetString(comp_switchesValue, comp_switchesColumn);
        rec.SetString(comp_switches_obsValue, comp_switches_obsColumn);
        rec.SetString(comp_awValue, comp_awColumn);
        rec.SetString(comp_aw_obsValue, comp_aw_obsColumn);
        rec.SetString(comp_suctionValue, comp_suctionColumn);
        rec.SetString(comp_suction_obsValue, comp_suction_obsColumn);
        rec.SetString(comp_elevationValue, comp_elevationColumn);
        rec.SetString(comp_elevation_obsValue, comp_elevation_obsColumn);
        rec.SetString(comp_controlValue, comp_controlColumn);
        rec.SetString(comp_control_obsValue, comp_control_obsColumn);
        rec.SetString(comp_biopsyValue, comp_biopsyColumn);
        rec.SetString(comp_biopsy_obsValue, comp_biopsy_obsColumn);
        rec.SetString(comp_bendingValue, comp_bendingColumn);
        rec.SetString(comp_bending_obsValue, comp_bending_obsColumn);
        rec.SetString(comp_insertionValue, comp_insertionColumn);
        rec.SetString(comp_insertion_obsValue, comp_insertion_obsColumn);
        rec.SetString(comp_lightguideValue, comp_lightguideColumn);
        rec.SetString(comp_lightguide_obsValue, comp_lightguide_obsColumn);
        rec.SetString(comp_lgconnValue, comp_lgconnColumn);
        rec.SetString(comp_lgconn_obsValue, comp_lgconn_obsColumn);
        rec.SetString(comp_bootsValue, comp_bootsColumn);
        rec.SetString(comp_boots_obsValue, comp_boots_obsColumn);
        rec.SetString(comp_controlbodyValue, comp_controlbodyColumn);
        rec.SetString(comp_controlbody_obsValue, comp_controlbody_obsColumn);
        rec.SetString(comp_ccoverValue, comp_ccoverColumn);
        rec.SetString(comp_ccover_obsValue, comp_ccover_obsColumn);
        rec.SetString(comp_objectiveValue, comp_objectiveColumn);
        rec.SetString(comp_objective_obsValue, comp_objective_obsColumn);
        rec.SetString(comp_lightlensValue, comp_lightlensColumn);
        rec.SetString(comp_lightlens_obsValue, comp_lightlens_obsColumn);
        rec.SetString(comp_bendrubberValue, comp_bendrubberColumn);
        rec.SetString(comp_bendrubber_obsValue, comp_bendrubber_obsColumn);
        rec.SetString(comp_other1Value, comp_other1Column);
        rec.SetString(comp_other1_obsValue, comp_other1_obsColumn);
        rec.SetString(comp_other2Value, comp_other2Column);
        rec.SetString(comp_other2_obsValue, comp_other2_obsColumn);
        rec.SetString(comp_other1_nameValue, comp_other1_nameColumn);
        rec.SetString(comp_other2_nameValue, comp_other2_nameColumn);
        rec.SetString(tech_notesValue, tech_notesColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			ROIncomingTable.Instance.DeleteOneRecord(kv);
		}

		/// <summary>
		/// This method checks if record exist in the database using the keyvalue provided.
		/// </summary>
		/// <param name="kv">Key value of the record.</param>
		public static bool DoesRecordExist(KeyValue kv)
		{
			bool recordExist = true;
			try
			{
				ROIncomingTable.GetRecord(kv, false);
			}
			catch (Exception)
			{
				recordExist = false;
			}
			return recordExist;
		}

        /// <summary>
        ///  This method returns all the primary columns in the table.
        /// </summary>
        public static ColumnList GetPrimaryKeyColumns() 
        {
            if (!(ROIncomingTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return ROIncomingTable.Instance.TableDefinition.PrimaryKey.Columns;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This method takes a key and returns a keyvalue.
        /// </summary>
        /// <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
        public static KeyValue GetKeyValue(object key) 
        {
            KeyValue kv = null;
            if (!(ROIncomingTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = ROIncomingTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = ROIncomingTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (ROIncomingTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
                            {
                                kv.AddElement(pkColumn.UniqueName, keyString);
                            }
                            else 
                            {
                                kv.AddElement(pkColumn.InternalName, keyString);
                            }

                            index = (index + 1);
                        }
                    }
                }
                else 
                {
                    //  If the key is not composite, then get the key value.
                    kv = ROIncomingTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = ROIncomingTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }
                            
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
		public static string GetDFKA(String keyValue, BaseColumn col, String formatPattern)
		{
		    if (keyValue == null)
				return null;
			ForeignKey fkColumn = ROIncomingTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				PrimaryKeyTable t = (PrimaryKeyTable)DatabaseObjects.GetTableObject(tableName);
				BaseRecord rec = null;
				
				if (t != null)
				{
					try
					{
						rec = (BaseRecord)t.GetRecordData(keyValue, false);
					}
					catch
					{
						rec = null;
					}
				}
				if( rec == null)
					return "";

                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }	            
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, string name)
		{
			BaseFormulaEvaluator e = new BaseFormulaEvaluator();
			if(dataSourceForEvaluate != null)
				e.Evaluator.Variables.Add(name, dataSourceForEvaluate);
			e.DataSource = dataSourceForEvaluate;
	        object resultObj = e.Evaluate(formula);
	
		    if (resultObj == null)
			    return "";
	        if (!string.IsNullOrEmpty(format))
	            return BaseFormulaUtils.Format(resultObj, format);
		    else
            return resultObj.ToString();
		}
		
		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula)
		{
			return EvaluateFormula(formula,null,null,null);
		}
		
				
	#endregion
	}

}
