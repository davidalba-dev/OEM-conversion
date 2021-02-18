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
/// See <see cref="BaseWarehouseTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseWarehouseTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseWarehouseTable"></seealso>
/// <seealso cref="BaseWarehouseSqlTable"></seealso>
/// <seealso cref="WarehouseSqlTable"></seealso>
/// <seealso cref="WarehouseDefinition"></seealso>
/// <seealso cref="WarehouseRecord"></seealso>
/// <seealso cref="BaseWarehouseRecord"></seealso>
[SerializableAttribute()]
public class WarehouseTable : BaseWarehouseTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="WarehouseTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="WarehouseTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="WarehouseTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(WarehouseTable_SerializationHelper)); //No other values need to be added
    }

#region "Class WarehouseTable_SerializationHelper"

    [SerializableAttribute()]
    private class WarehouseTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return WarehouseTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="WarehouseTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="WarehouseTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static WarehouseTable Instance = new WarehouseTable();

    public WarehouseTable()
    {
    }


} // End class WarehouseTable

}
