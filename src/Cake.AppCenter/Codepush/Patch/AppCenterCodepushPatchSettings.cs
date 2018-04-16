using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter codepush patch.
	/// Update the metadata for an existing CodePush release.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterCodepushPatchSettings : AutoToolSettings
	{
		/// <summary>
		/// -r|--rollout &lt;arg&gt;
		/// Specifies percentage of users this release should be immediately available to. (The specified number must be an integer between 1 and 100)
		/// </summary>
		public string Rollout { get; set; }
		/// <summary>
		/// -d|--description &lt;arg&gt;
		/// Specifies description of the changes made to the app with this release
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// -t|--target-binary-version &lt;arg&gt;
		/// Specifies binary app version(s) that specifies this release is targeting for. (The value must be a semver expression such as 1.1.0, ~1.2.3)
		/// </summary>
		public string TargetBinaryVersion { get; set; }
		/// <summary>
		/// -l|--existing-release-label &lt;arg&gt;
		/// Specifies label of one existing release to update. (Defaults to the latest release within the specified deployment)
		/// </summary>
		public string ExistingReleaseLabel { get; set; }
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