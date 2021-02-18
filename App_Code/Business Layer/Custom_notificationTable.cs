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
/// See <see cref="BaseCustom_notificationTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseCustom_notificationTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseCustom_notificationTable"></seealso>
/// <seealso cref="BaseCustom_notificationSqlTable"></seealso>
/// <seealso cref="Custom_notificationSqlTable"></seealso>
/// <seealso cref="Custom_notificationDefinition"></seealso>
/// <seealso cref="Custom_notificationRecord"></seealso>
/// <seealso cref="BaseCustom_notificationRecord"></seealso>
[SerializableAttribute()]
public class Custom_notificationTable : BaseCustom_notificationTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Custom_notificationTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Custom_notificationTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Custom_notificationTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Custom_notificationTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Custom_notificationTable_SerializationHelper"

    [SerializableAttribute()]
    private class Custom_notificationTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Custom_notificationTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Custom_notificationTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Custom_notificationTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Custom_notificationTable Instance = new Custom_notificationTable();

    public Custom_notificationTable()
    {
    }


} // End class Custom_notificationTable

}
