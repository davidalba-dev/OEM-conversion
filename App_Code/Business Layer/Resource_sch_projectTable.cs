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
/// See <see cref="BaseResource_sch_projectTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseResource_sch_projectTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseResource_sch_projectTable"></seealso>
/// <seealso cref="BaseResource_sch_projectSqlTable"></seealso>
/// <seealso cref="Resource_sch_projectSqlTable"></seealso>
/// <seealso cref="Resource_sch_projectDefinition"></seealso>
/// <seealso cref="Resource_sch_projectRecord"></seealso>
/// <seealso cref="BaseResource_sch_projectRecord"></seealso>
[SerializableAttribute()]
public class Resource_sch_projectTable : BaseResource_sch_projectTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Resource_sch_projectTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Resource_sch_projectTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Resource_sch_projectTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Resource_sch_projectTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Resource_sch_projectTable_SerializationHelper"

    [SerializableAttribute()]
    private class Resource_sch_projectTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Resource_sch_projectTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Resource_sch_projectTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Resource_sch_projectTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Resource_sch_projectTable Instance = new Resource_sch_projectTable();

    public Resource_sch_projectTable()
    {
    }


} // End class Resource_sch_projectTable

}
