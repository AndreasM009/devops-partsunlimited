// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;

namespace PartsUnlimited.Telemetry
{
    public class EmptyTelemetryProvider : ITelemetryProvider
    {
        TelemetryClient _client = new TelemetryClient();

        public void TrackEvent(string message)
        {
            _client.TrackEvent(message);
        }

        public void TrackEvent(string message, Dictionary<string, string> properties, Dictionary<string, double> measurements)
        {
            _client.TrackEvent(message, properties, measurements);
        }

        public void TrackException(Exception exception)
        {
            _client.TrackException(exception);
        }

        public void TrackTrace(string message)
        {
            _client.TrackTrace(message);
        }
    }
}