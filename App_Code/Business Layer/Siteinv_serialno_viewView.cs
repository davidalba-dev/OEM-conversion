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
/// See <see cref="BaseSiteinv_serialno_viewView"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseSiteinv_serialno_viewView"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseSiteinv_serialno_viewView"></seealso>
/// <seealso cref="BaseSiteinv_serialno_viewSqlView"></seealso>
/// <seealso cref="Siteinv_serialno_viewSqlView"></seealso>
/// <seealso cref="Siteinv_serialno_viewDefinition"></seealso>
/// <seealso cref="Siteinv_serialno_viewRecord"></seealso>
/// <seealso cref="BaseSiteinv_serialno_viewRecord"></seealso>
[SerializableAttribute()]
public class Siteinv_serialno_viewView : BaseSiteinv_serialno_viewView, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Siteinv_serialno_viewView_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Siteinv_serialno_viewView"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Siteinv_serialno_viewView"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Siteinv_serialno_viewView_SerializationHelper)); //No other values need to be added
    }

#region "Class Siteinv_serialno_viewView_SerializationHelper"

    [SerializableAttribute()]
    private class Siteinv_serialno_viewView_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Siteinv_serialno_viewView.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Siteinv_serialno_viewView"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Siteinv_serialno_viewView"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Siteinv_serialno_viewView Instance = new Siteinv_serialno_viewView();

    public Siteinv_serialno_viewView()
    {
    }


} // End class Siteinv_serialno_viewView

}
