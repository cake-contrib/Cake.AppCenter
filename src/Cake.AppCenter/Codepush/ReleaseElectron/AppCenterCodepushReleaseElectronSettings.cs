using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter codepush release-electron.
	/// Release an Electron update to a deployment.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterCodepushReleaseElectronSettings : AutoToolSettings
	{
		/// <summary>
		/// --extra-bundler-option &lt;arg&gt;
		/// Option that gets passed to webpack bundler. Can be specified multiple times
		/// </summary>
		public string ExtraBundlerOption { get; set; }
		/// <summary>
		/// -t|--target-binary-version &lt;arg&gt;
		/// Semver expression that specifies the binary app version(s) this release is targeting (e.g. 1.1.0, ~1.2.3)
		/// </summary>
		public string TargetBinaryVersion { get; set; }
		/// <summary>
		/// -o|--output-dir &lt;arg&gt;
		/// Output path for the bundle and sourcemap. If omitted, a bundle and sourcemap will not be generated
		/// </summary>
		public string OutputDir { get; set; }
		/// <summary>
		/// --sourcemap-output-dir &lt;arg&gt;
		/// Path to directory where the sourcemap for the resulting bundle should be written. Name of sourcemap file will be generated automatically. This argument will be ignored if &#39;sourcemap-output&#39; argument is provided. If &#39;sourcemap-output&#39; and &#39;sourcemap-output-dir&#39; are omitted, a sourcemap will not be generated
		/// </summary>
		public string SourcemapOutputDir { get; set; }
		/// <summary>
		/// -s|--sourcemap-output &lt;arg&gt;
		/// Filename (including path) for the sourcemap of the resulting bundle. If &#39;sourcemap-output&#39; and &#39;sourcemap-output-dir&#39; are omitted, a sourcemap will not be generated
		/// </summary>
		public string SourcemapOutput { get; set; }
		/// <summary>
		/// -e|--entry-file &lt;arg&gt;
		/// Path to the app&#39;s entry Javascript file. If omitted, &quot;index.&lt;platform&gt;.js&quot; and then &quot;index.js&quot; will be used (if they exist)
		/// </summary>
		public string EntryFile { get; set; }
		/// <summary>
		/// -c|--config &lt;arg&gt;
		/// Path to the webpack config file. If omitted, &quot;webpack.config.js&quot; will be used (if they exist)
		/// </summary>
		public string Config { get; set; }
		/// <summary>
		/// --development
		/// Specifies whether to generate a Development or Production build
		/// </summary>
		public bool? Development { get; set; }
		/// <summary>
		/// -b|--bundle-name &lt;arg&gt;
		/// Name of the generated JS bundle file. If unspecified, the standard bundle name will be used &#39;index.electron.bundle&#39;
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