﻿// This is a "safe" class, meaning that it is created once 
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
/// See <see cref="BaseInventory_locationTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseInventory_locationTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseInventory_locationTable"></seealso>
/// <seealso cref="BaseInventory_locationSqlTable"></seealso>
/// <seealso cref="Inventory_locationSqlTable"></seealso>
/// <seealso cref="Inventory_locationDefinition"></seealso>
/// <seealso cref="Inventory_locationRecord"></seealso>
/// <seealso cref="BaseInventory_locationRecord"></seealso>
[SerializableAttribute()]
public class Inventory_locationTable : BaseInventory_locationTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Inventory_locationTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Inventory_locationTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Inventory_locationTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Inventory_locationTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Inventory_locationTable_SerializationHelper"

    [SerializableAttribute()]
    private class Inventory_locationTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Inventory_locationTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Inventory_locationTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Inventory_locationTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Inventory_locationTable Instance = new Inventory_locationTable();

    public Inventory_locationTable()
    {
    }


} // End class Inventory_locationTable

}
