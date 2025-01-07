namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Special type of activity that includes description of the resolution, billing status, and the duration of the case.</summary>
public sealed partial class IncidentResolution : Dictionary<string, object>
{
}

