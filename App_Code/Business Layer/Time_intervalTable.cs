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
/// See <see cref="BaseTime_intervalTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseTime_intervalTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseTime_intervalTable"></seealso>
/// <seealso cref="BaseTime_intervalSqlTable"></seealso>
/// <seealso cref="Time_intervalSqlTable"></seealso>
/// <seealso cref="Time_intervalDefinition"></seealso>
/// <seealso cref="Time_intervalRecord"></seealso>
/// <seealso cref="BaseTime_intervalRecord"></seealso>
[SerializableAttribute()]
public class Time_intervalTable : BaseTime_intervalTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Time_intervalTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Time_intervalTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Time_intervalTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Time_intervalTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Time_intervalTable_SerializationHelper"

    [SerializableAttribute()]
    private class Time_intervalTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Time_intervalTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Time_intervalTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Time_intervalTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Time_intervalTable Instance = new Time_intervalTable();

    public Time_intervalTable()
    {
    }


} // End class Time_intervalTable

}
