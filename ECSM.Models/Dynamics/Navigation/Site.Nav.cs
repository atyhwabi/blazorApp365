namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Location or branch office where an organization does business. An organization can have multiple sites.</summary>
public sealed partial class Site : Dictionary<string, object>
{
}

