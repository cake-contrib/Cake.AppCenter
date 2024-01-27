using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter build logs.
	/// Displays log for build.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterBuildLogsSettings : AutoToolSettings
	{
		/// <summary>
		/// -i|--id &lt;arg&gt;
		/// ID of build to show logs for
		/// </summary>
		public string? Id { get; set; }
		/// <summary>
		/// -c|--continue
		/// Continue to return logs, press Ctrl+C to exit
		/// </summary>
		public bool? Continue { get; set; }
		/// <summary>
		/// -l|--lines &lt;arg&gt;
		/// Number of last lines to be shown
		/// </summary>
		public string? Lines { get; set; }
		/// <summary>
		/// -a|--app &lt;arg&gt;
		/// Specify app in the &lt;ownerName&gt;/&lt;appName&gt; format
		/// </summary>
		public string? App { get; set; }
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
		/// --output &lt;arg&gt;
		/// Output format: json
		/// </summary>
		public string? Output { get; set; }
		/// <summary>
		/// --debug
		/// Display extra output for debugging
		/// </summary>
		public bool? Debug { get; set; }
	}
}