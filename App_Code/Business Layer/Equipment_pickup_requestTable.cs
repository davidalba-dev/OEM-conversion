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
/// See <see cref="BaseEquipment_pickup_requestTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseEquipment_pickup_requestTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseEquipment_pickup_requestTable"></seealso>
/// <seealso cref="BaseEquipment_pickup_requestSqlTable"></seealso>
/// <seealso cref="Equipment_pickup_requestSqlTable"></seealso>
/// <seealso cref="Equipment_pickup_requestDefinition"></seealso>
/// <seealso cref="Equipment_pickup_requestRecord"></seealso>
/// <seealso cref="BaseEquipment_pickup_requestRecord"></seealso>
[SerializableAttribute()]
public class Equipment_pickup_requestTable : BaseEquipment_pickup_requestTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Equipment_pickup_requestTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Equipment_pickup_requestTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_pickup_requestTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Equipment_pickup_requestTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Equipment_pickup_requestTable_SerializationHelper"

    [SerializableAttribute()]
    private class Equipment_pickup_requestTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Equipment_pickup_requestTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Equipment_pickup_requestTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Equipment_pickup_requestTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Equipment_pickup_requestTable Instance = new Equipment_pickup_requestTable();

    public Equipment_pickup_requestTable()
    {
    }


} // End class Equipment_pickup_requestTable

}
