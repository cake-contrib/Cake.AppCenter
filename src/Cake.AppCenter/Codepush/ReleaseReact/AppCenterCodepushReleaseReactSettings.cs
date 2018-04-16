using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter codepush release-react.
	/// Release a React Native update to an app deployment.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterCodepushReleaseReactSettings : AutoToolSettings
	{
		/// <summary>
		/// -t|--target-binary-version &lt;arg&gt;
		/// Semver expression that specifies the binary app version(s) this release is targeting (e.g. 1.1.0, ~1.2.3)
		/// </summary>
		public string TargetBinaryVersion { get; set; }
		/// <summary>
		/// -o|--output-dir &lt;arg&gt;
		/// Path to where the bundle and sourcemap should be written. If omitted, a bundle and sourcemap will not be written
		/// </summary>
		public string OutputDir { get; set; }
		/// <summary>
		/// -s|--sourcemap-output &lt;arg&gt;
		/// Path to where the sourcemap for the resulting bundle should be written. If omitted, a sourcemap will not be generated
		/// </summary>
		public string SourcemapOutput { get; set; }
		/// <summary>
		/// --plist-file-prefix &lt;arg&gt;
		/// Prefix to append to the file name when attempting to find your app&#39;s Info.plist file (iOS only)
		/// </summary>
		public string PlistFilePrefix { get; set; }
		/// <summary>
		/// -p|--plist-file &lt;arg&gt;
		/// Path to the plist file which specifies the binary version you want to target this release at (iOS only)
		/// </summary>
		public string PlistFile { get; set; }
		/// <summary>
		/// -g|--gradle-file &lt;arg&gt;
		/// Path to the gradle file which specifies the binary version you want to target this release at (android only)
		/// </summary>
		public string GradleFile { get; set; }
		/// <summary>
		/// -e|--entry-file &lt;arg&gt;
		/// Path to the app&#39;s entry Javascript file. If omitted, &quot;index.&lt;platform&gt;.js&quot; and then &quot;index.js&quot; will be used (if they exist)
		/// </summary>
		public string EntryFile { get; set; }
		/// <summary>
		/// --development
		/// Specifies whether to generate a dev or release build
		/// </summary>
		public bool? Development { get; set; }
		/// <summary>
		/// -b|--bundle-name &lt;arg&gt;
		/// Name of the generated JS bundle file. If unspecified, the standard bundle name will be used, depending on the specified platform: &quot;main.jsbundle&quot; (iOS), &quot;index.android.bundle&quot; (Android) or &quot;index.windows.bundle&quot; (Windows)
		/// </summary>
		public string BundleName { get; set; }
		/// <summary>
		/// -r|--rollout &lt;arg&gt;
		/// Percentage of users this release should be available to
		/// </summary>
		public string Rollout { get; set; }
		/// <summary>
		/// --disable-duplicate-release-error
		/// When this flag is set, releasing a package that is identical to the latest release will produce a warning instead of an error
		/// </summary>
		public bool? DisableDuplicateReleaseError { get; set; }
		/// <summary>
		/// -k|--private-key-path &lt;arg&gt;
		/// Specifies the location of a RSA private key to sign the release with.NOTICE: use it for react native applications only, client SDK on other platforms will be ignoring signature verification for now!
		/// </summary>
		public string PrivateKeyPath { get; set; }
		/// <summary>
		/// -m|--mandatory
		/// Specifies whether this release should be considered mandatory
		/// </summary>
		public bool? Mandatory { get; set; }
		/// <summary>
		/// -x|--disabled
		/// Specifies whether this release should be immediately downloadable
		/// </summary>
		public bool? Disabled { get; set; }
		/// <summary>
		/// --description &lt;arg&gt;
		/// Description of the changes made to the app in this release
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// -d|--deployment-name &lt;arg&gt;
		/// Deployment to release the update to
		/// </summary>
		public string DeploymentName { get; set; }
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