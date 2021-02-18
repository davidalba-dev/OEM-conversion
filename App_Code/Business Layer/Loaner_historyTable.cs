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
/// See <see cref="BaseLoaner_historyTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseLoaner_historyTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseLoaner_historyTable"></seealso>
/// <seealso cref="BaseLoaner_historySqlTable"></seealso>
/// <seealso cref="Loaner_historySqlTable"></seealso>
/// <seealso cref="Loaner_historyDefinition"></seealso>
/// <seealso cref="Loaner_historyRecord"></seealso>
/// <seealso cref="BaseLoaner_historyRecord"></seealso>
[SerializableAttribute()]
public class Loaner_historyTable : BaseLoaner_historyTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Loaner_historyTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Loaner_historyTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Loaner_historyTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Loaner_historyTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Loaner_historyTable_SerializationHelper"

    [SerializableAttribute()]
    private class Loaner_historyTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Loaner_historyTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Loaner_historyTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Loaner_historyTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Loaner_historyTable Instance = new Loaner_historyTable();

    public Loaner_historyTable()
    {
    }


} // End class Loaner_historyTable

}
