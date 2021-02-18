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
/// See <see cref="BaseStatusesTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseStatusesTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseStatusesTable"></seealso>
/// <seealso cref="BaseStatusesSqlTable"></seealso>
/// <seealso cref="StatusesSqlTable"></seealso>
/// <seealso cref="StatusesDefinition"></seealso>
/// <seealso cref="StatusesRecord"></seealso>
/// <seealso cref="BaseStatusesRecord"></seealso>
[SerializableAttribute()]
public class StatusesTable : BaseStatusesTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="StatusesTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="StatusesTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="StatusesTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(StatusesTable_SerializationHelper)); //No other values need to be added
    }

#region "Class StatusesTable_SerializationHelper"

    [SerializableAttribute()]
    private class StatusesTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return StatusesTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="StatusesTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="StatusesTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static StatusesTable Instance = new StatusesTable();

    public StatusesTable()
    {
    }


} // End class StatusesTable

}
