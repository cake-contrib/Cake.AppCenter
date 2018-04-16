using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter analytics log-flow.
	/// Command to see the incoming logs in real time.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterAnalyticsLogFlowSettings : AutoToolSettings
	{
		/// <summary>
		/// -c|--continue
		/// Continue to return logs, press Ctrl+C to exit
		/// </summary>
		public bool? Continue { get; set; }
		/// <summary>
		/// -i|--install-id &lt;arg&gt;
		/// Filter the logs by install ID
		/// </summary>
		public string InstallId { get; set; }
		/// <summary>
		/// -l|--num-logs &lt;arg&gt;
		/// Introduce the number of logs (max 100) that are being displayed, default number is 100
		/// </summary>
		public string NumLogs { get; set; }
		/// <summary>
		/// -a|--app &lt;arg&gt;
		/// Specify app in the &lt;ownerName&gt;/&lt;appName&gt; format
		/// </summary>
		public string App { get; set; }
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
		public string Env { get; set; }
		/// <summary>
		/// --token &lt;arg&gt;
		/// API token
		/// </summary>
		public string Token { get; set; }
		/// <summary>
		/// --output &lt;arg&gt;
		/// Output format: json
		/// </summary>
		public string Output { get; set; }
		/// <summary>
		/// --debug
		/// Display extra output for debugging
		/// </summary>
		public bool? Debug { get; set; }
	}
}