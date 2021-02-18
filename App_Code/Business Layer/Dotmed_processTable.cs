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
/// See <see cref="BaseDotmed_processTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseDotmed_processTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseDotmed_processTable"></seealso>
/// <seealso cref="BaseDotmed_processSqlTable"></seealso>
/// <seealso cref="Dotmed_processSqlTable"></seealso>
/// <seealso cref="Dotmed_processDefinition"></seealso>
/// <seealso cref="Dotmed_processRecord"></seealso>
/// <seealso cref="BaseDotmed_processRecord"></seealso>
[SerializableAttribute()]
public class Dotmed_processTable : BaseDotmed_processTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Dotmed_processTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Dotmed_processTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Dotmed_processTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Dotmed_processTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Dotmed_processTable_SerializationHelper"

    [SerializableAttribute()]
    private class Dotmed_processTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Dotmed_processTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Dotmed_processTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Dotmed_processTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Dotmed_processTable Instance = new Dotmed_processTable();

    public Dotmed_processTable()
    {
    }


} // End class Dotmed_processTable

}
