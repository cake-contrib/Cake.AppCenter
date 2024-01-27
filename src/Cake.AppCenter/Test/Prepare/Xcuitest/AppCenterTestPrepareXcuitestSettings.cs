using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter test prepare xcuitest.
	/// Creates an artifacts directory with XCUITest tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterTestPrepareXcuitestSettings : AutoToolSettings
	{
		/// <summary>
		/// --artifacts-dir &lt;arg&gt;
		/// Path to the artifacts directory to create
		/// </summary>
		public string? ArtifactsDir { get; set; }
		/// <summary>
		/// --test-ipa-path &lt;arg&gt;
		/// Path to the *.ipa file with the XCUITest tests
		/// </summary>
		public string? TestIpaPath { get; set; }
		/// <summary>
		/// --build-dir &lt;arg&gt;
		/// Path to the build output directory (usually &lt;project&gt;/Build/Products/Debug-iphoneos)
		/// </summary>
		public string? BuildDir { get; set; }
		/// <summary>
		/// -p|--test-parameter &lt;arg&gt;
		/// Additional test parameters. The value must be in format &quot;key=value&quot;
		/// </summary>
		public string? TestParameter { get; set; }
		/// <summary>
		/// --include &lt;arg&gt;
		/// Attribute is not supported for XCUITest
		/// </summary>
		public string? Include { get; set; }
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