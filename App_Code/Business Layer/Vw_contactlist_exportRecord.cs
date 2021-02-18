﻿// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// Provides access to the data in a database record from a table (or view) that lacks a primary key.
/// Also provides access to the <see cref="Vw_contactlist_exportView"></see> that each record is associated with.
/// </summary>
/// <remarks>
/// <para>
/// This is a "safe" class, meaning that it is generated once and never overwritten. 
/// Any changes you make to this class will be preserved when you regenerate your application.
/// </para>
/// </remarks>
/// <seealso cref="Vw_contactlist_exportView"></seealso>
[SerializableAttribute()]
public class Vw_contactlist_exportRecord : BaseVw_contactlist_exportRecord
{

}

}