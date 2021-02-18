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
/// See <see cref="BaseEquipment_inventory_dispositionTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseEquipment_inventory_dispositionTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseEquipment_inventory_dispositionTable"></seealso>
/// <seealso cref="BaseEquipment_inventory_dispositionSqlTable"></seealso>
/// <seealso cref="Equipment_inventory_dispositionSqlTable"></seealso>
/// <seealso cref="Equipment_inventory_dispositionDefinition"></seealso>
/// <seealso cref="Equipment_inventory_dispositionRecord"></seealso>
/// <seealso cref="BaseEquipment_inventory_dispositionRecord"></seealso>
[SerializableAttribute()]
public class Equipment_inventory_dispositionTable : BaseEquipment_inventory_dispositionTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Equipment_inventory_dispositionTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Equipment_inventory_dispositionTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_inventory_dispositionTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Equipment_inventory_dispositionTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Equipment_inventory_dispositionTable_SerializationHelper"

    [SerializableAttribute()]
    private class Equipment_inventory_dispositionTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Equipment_inventory_dispositionTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Equipment_inventory_dispositionTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_inventory_dispositionTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Equipment_inventory_dispositionTable Instance = new Equipment_inventory_dispositionTable();

    public Equipment_inventory_dispositionTable()
    {
    }


} // End class Equipment_inventory_dispositionTable

}
