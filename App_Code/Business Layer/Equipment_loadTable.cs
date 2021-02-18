// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// Provides access to the schema information and record data of a database table (or view).
/// See <see cref="BaseEquipment_loadTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseEquipment_loadTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseEquipment_loadTable"></seealso>
/// <seealso cref="BaseEquipment_loadSqlTable"></seealso>
/// <seealso cref="Equipment_loadSqlTable"></seealso>
/// <seealso cref="Equipment_loadDefinition"></seealso>
/// <seealso cref="Equipment_loadRecord"></seealso>
/// <seealso cref="BaseEquipment_loadRecord"></seealso>
[SerializableAttribute()]
public class Equipment_loadTable : BaseEquipment_loadTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Equipment_loadTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Equipment_loadTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_loadTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Equipment_loadTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Equipment_loadTable_SerializationHelper"

    [SerializableAttribute()]
    private class Equipment_loadTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Equipment_loadTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Equipment_loadTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_loadTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Equipment_loadTable Instance = new Equipment_loadTable();

    public Equipment_loadTable()
    {
    }


} // End class Equipment_loadTable

}
