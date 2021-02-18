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
/// See <see cref="BaseEquipment_inventory_laborTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseEquipment_inventory_laborTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseEquipment_inventory_laborTable"></seealso>
/// <seealso cref="BaseEquipment_inventory_laborSqlTable"></seealso>
/// <seealso cref="Equipment_inventory_laborSqlTable"></seealso>
/// <seealso cref="Equipment_inventory_laborDefinition"></seealso>
/// <seealso cref="Equipment_inventory_laborRecord"></seealso>
/// <seealso cref="BaseEquipment_inventory_laborRecord"></seealso>
[SerializableAttribute()]
public class Equipment_inventory_laborTable : BaseEquipment_inventory_laborTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Equipment_inventory_laborTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Equipment_inventory_laborTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_inventory_laborTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Equipment_inventory_laborTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Equipment_inventory_laborTable_SerializationHelper"

    [SerializableAttribute()]
    private class Equipment_inventory_laborTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Equipment_inventory_laborTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Equipment_inventory_laborTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_inventory_laborTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Equipment_inventory_laborTable Instance = new Equipment_inventory_laborTable();

    public Equipment_inventory_laborTable()
    {
    }


} // End class Equipment_inventory_laborTable

}
