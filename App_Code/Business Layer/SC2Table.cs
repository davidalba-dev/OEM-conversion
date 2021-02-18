﻿// This is a "safe" class, meaning that it is created once 
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
/// See <see cref="BaseSC2Table"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseSC2Table"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseSC2Table"></seealso>
/// <seealso cref="BaseSC2SqlTable"></seealso>
/// <seealso cref="SC2SqlTable"></seealso>
/// <seealso cref="SC2Definition"></seealso>
/// <seealso cref="SC2Record"></seealso>
/// <seealso cref="BaseSC2Record"></seealso>
[SerializableAttribute()]
public class SC2Table : BaseSC2Table, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="SC2Table_SerializationHelper"></see> class 
    /// for deserialization of <see cref="SC2Table"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="SC2Table"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(SC2Table_SerializationHelper)); //No other values need to be added
    }

#region "Class SC2Table_SerializationHelper"

    [SerializableAttribute()]
    private class SC2Table_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return SC2Table.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="SC2Table"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="SC2Table"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static SC2Table Instance = new SC2Table();

    public SC2Table()
    {
    }


} // End class SC2Table

}
