using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter distribute release.
	/// Upload release binary and trigger distribution.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterDistributeReleaseSettings : AutoToolSettings
	{
		/// <summary>
		/// -g|--group &lt;arg&gt;
		/// Distribution group name
		/// </summary>
		public string Group { get; set; }
		/// <summary>
		/// -f|--file &lt;arg&gt;
		/// Path to binary file
		/// </summary>
		public string File { get; set; }
		/// <summary>
		/// -R|--release-notes-file &lt;arg&gt;
		/// Path to release notes file
		/// </summary>
		public string ReleaseNotesFile { get; set; }
		/// <summary>
		/// -r|--release-notes &lt;arg&gt;
		/// Release notes text
		/// </summary>
		public string ReleaseNotes { get; set; }
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
		/// <summary>
		/// --silent 
		/// Do not notify testers of this release
		/// </summary>
		public bool? Silent { get; set; }
	}
}