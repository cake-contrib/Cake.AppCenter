using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter distribute groups create.
	/// Create new distribution group.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterDistributeGroupsCreateSettings : AutoToolSettings
	{
		/// <summary>
		/// -n|--name &lt;arg&gt;
		/// Distribution group name
		/// </summary>
		public string? Name { get; set; }
		/// <summary>
		/// -T|--testers-file &lt;arg&gt;
		/// Path to file containing list of testers
		/// </summary>
		public string? TestersFile { get; set; }
		/// <summary>
		/// -t|--testers &lt;arg&gt;
		/// List of testers (space-separated list of e-mails)
		/// </summary>
		public string? Testers { get; set; }
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