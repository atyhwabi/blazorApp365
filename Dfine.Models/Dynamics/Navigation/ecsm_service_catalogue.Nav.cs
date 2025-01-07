namespace ECSM.Models.Dynamics;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>Service Catalogues enable Admins to create unique collections of Service Catalogue Items to make them available in the Portal to relevant Personas</summary>
public sealed partial class ecsm_service_catalogue : Dictionary<string, object>
{
}

