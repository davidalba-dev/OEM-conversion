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
/// See <see cref="BaseLead_sourceTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseLead_sourceTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseLead_sourceTable"></seealso>
/// <seealso cref="BaseLead_sourceSqlTable"></seealso>
/// <seealso cref="Lead_sourceSqlTable"></seealso>
/// <seealso cref="Lead_sourceDefinition"></seealso>
/// <seealso cref="Lead_sourceRecord"></seealso>
/// <seealso cref="BaseLead_sourceRecord"></seealso>
[SerializableAttribute()]
public class Lead_sourceTable : BaseLead_sourceTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Lead_sourceTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Lead_sourceTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Lead_sourceTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Lead_sourceTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Lead_sourceTable_SerializationHelper"

    [SerializableAttribute()]
    private class Lead_sourceTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Lead_sourceTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Lead_sourceTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Lead_sourceTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Lead_sourceTable Instance = new Lead_sourceTable();

    public Lead_sourceTable()
    {
    }


} // End class Lead_sourceTable

}
