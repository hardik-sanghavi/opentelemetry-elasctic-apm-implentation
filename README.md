# Implentation of OpenTelemetry to Elastic APM

**Packages:**
- OpenTelemetry.Exporter.Console
- OpenTelemetry.Exporter.OpenTelemetryProtocol
- OpenTelemetry.Exporter.OpenTelemetryProtocol.Logs
- OpenTelemetry.Extensions.Hosting
- OpenTelemetry.Instrumentation.AspNetCore
- OpenTelemetry.Instrumentation.SqlClient

<br/>

**Need to set some enviornment variables**
- OTEL_EXPORTER_OTLP_ENDPOINT
- OTEL_EXPORTER_OTLP_HEADERS
- OTEL_METRICS_EXPORTER
- OTEL_LOGS_EXPORTER
- OTEL_RESOURCE_ATTRIBUTES

<br/>
After that need to add some code in program.cs file.
