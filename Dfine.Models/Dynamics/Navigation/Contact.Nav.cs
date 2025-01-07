namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Person with whom a business unit has a relationship, such as customer, supplier, and colleague.</summary>
public sealed partial class Contact : Dictionary<string, object>
{
}

