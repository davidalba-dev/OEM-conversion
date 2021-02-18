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
/// See <see cref="BaseVw_device_repair_historyView"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseVw_device_repair_historyView"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseVw_device_repair_historyView"></seealso>
/// <seealso cref="BaseVw_device_repair_historySqlView"></seealso>
/// <seealso cref="Vw_device_repair_historySqlView"></seealso>
/// <seealso cref="Vw_device_repair_historyDefinition"></seealso>
/// <seealso cref="Vw_device_repair_historyRecord"></seealso>
/// <seealso cref="BaseVw_device_repair_historyRecord"></seealso>
[SerializableAttribute()]
public class Vw_device_repair_historyView : BaseVw_device_repair_historyView, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Vw_device_repair_historyView_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Vw_device_repair_historyView"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Vw_device_repair_historyView"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Vw_device_repair_historyView_SerializationHelper)); //No other values need to be added
    }

#region "Class Vw_device_repair_historyView_SerializationHelper"

    [SerializableAttribute()]
    private class Vw_device_repair_historyView_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Vw_device_repair_historyView.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Vw_device_repair_historyView"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Vw_device_repair_historyView"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Vw_device_repair_historyView Instance = new Vw_device_repair_historyView();

    public Vw_device_repair_historyView()
    {
    }


} // End class Vw_device_repair_historyView

}
