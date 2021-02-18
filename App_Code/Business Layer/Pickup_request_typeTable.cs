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
/// See <see cref="BasePickup_request_typeTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BasePickup_request_typeTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BasePickup_request_typeTable"></seealso>
/// <seealso cref="BasePickup_request_typeSqlTable"></seealso>
/// <seealso cref="Pickup_request_typeSqlTable"></seealso>
/// <seealso cref="Pickup_request_typeDefinition"></seealso>
/// <seealso cref="Pickup_request_typeRecord"></seealso>
/// <seealso cref="BasePickup_request_typeRecord"></seealso>
[SerializableAttribute()]
public class Pickup_request_typeTable : BasePickup_request_typeTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Pickup_request_typeTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Pickup_request_typeTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Pickup_request_typeTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Pickup_request_typeTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Pickup_request_typeTable_SerializationHelper"

    [SerializableAttribute()]
    private class Pickup_request_typeTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Pickup_request_typeTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Pickup_request_typeTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Pickup_request_typeTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Pickup_request_typeTable Instance = new Pickup_request_typeTable();

    public Pickup_request_typeTable()
    {
    }


} // End class Pickup_request_typeTable

}
