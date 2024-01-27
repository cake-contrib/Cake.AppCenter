using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter orgs update.
	/// Update organization information.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterOrgsUpdateSettings : AutoToolSettings
	{
		/// <summary>
		/// -n|--name &lt;arg&gt;
		/// Name of the organization
		/// </summary>
		public string? Name { get; set; }
		/// <summary>
		/// -r|--new-name &lt;arg&gt;
		/// New organization name
		/// </summary>
		public string? NewName { get; set; }
		/// <summary>
		/// -d|--new-display-name &lt;arg&gt;
		/// New organization display name
		/// </summary>
		public string? NewDisplayName { get; set; }
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