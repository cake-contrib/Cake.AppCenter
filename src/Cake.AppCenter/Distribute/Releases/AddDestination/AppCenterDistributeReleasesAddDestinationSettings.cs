using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter distribute releases add-destination.
	/// Distribute an existing release to an additional destination.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterDistributeReleasesAddDestinationSettings : AutoToolSettings
	{
		/// <summary>
		/// -d|--destination &lt;arg&gt;
		/// The name of the store or group, or the email of the tester
		/// </summary>
		public string? Destination { get; set; }
		/// <summary>
		/// -t|--type &lt;arg&gt;
		/// The type of destination: [store, group, tester]
		/// </summary>
		public string? Type { get; set; }
		/// <summary>
		/// -r|--release-id &lt;arg&gt;
		/// The ID of the release
		/// </summary>
		public string? ReleaseId { get; set; }
		/// <summary>
		/// -s|--silent
		/// If set, do not send a notification to the testers (Not used for stores)
		/// </summary>
		public bool? Silent { get; set; }
		/// <summary>
		/// -m|--mandatory
		/// Whether the release is mandatory for the testers (Not used for stores)
		/// </summary>
		public bool? Mandatory { get; set; }
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