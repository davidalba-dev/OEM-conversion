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
/// See <see cref="BaseOpportunityTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseOpportunityTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseOpportunityTable"></seealso>
/// <seealso cref="BaseOpportunitySqlTable"></seealso>
/// <seealso cref="OpportunitySqlTable"></seealso>
/// <seealso cref="OpportunityDefinition"></seealso>
/// <seealso cref="OpportunityRecord"></seealso>
/// <seealso cref="BaseOpportunityRecord"></seealso>
[SerializableAttribute()]
public class OpportunityTable : BaseOpportunityTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="OpportunityTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="OpportunityTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="OpportunityTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(OpportunityTable_SerializationHelper)); //No other values need to be added
    }

#region "Class OpportunityTable_SerializationHelper"

    [SerializableAttribute()]
    private class OpportunityTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return OpportunityTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="OpportunityTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="OpportunityTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static OpportunityTable Instance = new OpportunityTable();

    public OpportunityTable()
    {
    }


} // End class OpportunityTable

}
