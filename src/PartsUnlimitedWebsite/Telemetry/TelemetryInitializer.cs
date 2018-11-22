using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartsUnlimitedWebsite.Telemetry
{
    public class TelemetryInitializer : ITelemetryInitializer
    {
        void ITelemetryInitializer.Initialize(Microsoft.ApplicationInsights.Channel.ITelemetry telemetry)
        {
            telemetry.Context.Cloud.RoleName = "Parts Unlimited";
        }
    }
}
