using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter analytics events show.
	/// Show statistics for events.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterAnalyticsEventsShowSettings : AutoToolSettings
	{
		/// <summary>
		/// -n|--event-name &lt;arg&gt;
		/// Filter the metrics to a specific event name
		/// </summary>
		public string? EventName { get; set; }
		/// <summary>
		/// -c|--number-of-events &lt;arg&gt;
		/// Introduce the number of events that are being displayed. By default, all the events will be shown
		/// </summary>
		public string? NumberOfEvents { get; set; }
		/// <summary>
		/// -V|--app-version &lt;arg&gt;
		/// Filter the list of events by app version
		/// </summary>
		public string? AppVersion { get; set; }
		/// <summary>
		/// -e|--end &lt;arg&gt;
		/// End date. &#39;1970/01/01 00:00&#39; (system time zone), RFC2822, and ISO 8601 dates are supported. Defaults to now
		/// </summary>
		public string? End { get; set; }
		/// <summary>
		/// -s|--start &lt;arg&gt;
		/// Start date. &#39;1970/01/01 00:00&#39; (system time zone), RFC2822, and ISO 8601 dates are supported. Defaults to start of current UTC day
		/// </summary>
		public string? Start { get; set; }
		/// <summary>
		/// --properties
		/// Show statistics about event properties
		/// </summary>
		public bool? Properties { get; set; }
		/// <summary>
		/// -a|--app &lt;arg&gt;
		/// Specify app in the &lt;ownerName&gt;/&lt;appName&gt; format
		/// </summary>
		public string? App { get; set; }
		/// <summary>
		/// --output &lt;arg&gt;
		/// Format of output for this command: json, csv
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --disable-telemetry
		/// Disable telemetry for this command
		/// </summary>
		public bool? DisableTelemetry { get; set; }
		/// <summary>
		/// -v|--version
		/// Display appcenter version
		/// </summary>
		public bool? Version { get; set; }
		/// <summary>
		/// --quiet
		/// Auto-confirm any prompts without waiting for input
		/// </summary>
		public bool? Quiet { get; set; }
		/// <summary>
		/// -h|--help
		/// Display help for current command
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --env &lt;arg&gt;
		/// Environment when using API token
		/// </summary>
		public string? Env { get; set; }
		/// <summary>
		/// --token &lt;arg&gt;
		/// API token
		/// </summary>
		public string? Token { get; set; }
		/// <summary>
		/// --debug
		/// Display extra output for debugging
		/// </summary>
		public bool? Debug { get; set; }
	}
}