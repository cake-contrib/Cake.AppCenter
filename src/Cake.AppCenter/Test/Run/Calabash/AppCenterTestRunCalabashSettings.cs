using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter test run calabash.
	/// Starts a test run with Calabash tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterTestRunCalabashSettings : AutoToolSettings
	{
		/// <summary>
		/// --project-dir &lt;arg&gt;
		/// Path to the Calabash workspace directory (usually &lt;project&gt;/features)
		/// </summary>
		public string? ProjectDir { get; set; }
		/// <summary>
		/// --devices &lt;arg&gt;
		/// Device selection slug
		/// </summary>
		public string? Devices { get; set; }
		/// <summary>
		/// --skip-config-check
		/// Force running without Cucumber profile
		/// </summary>
		public bool? SkipConfigCheck { get; set; }
		/// <summary>
		/// --profile &lt;arg&gt;
		/// Profile to run. It must exist in the configuration file
		/// </summary>
		public string? Profile { get; set; }
		/// <summary>
		/// --config-path &lt;arg&gt;
		/// Path to the Cucumber configuration file (usually cucumber.yml)
		/// </summary>
		public string? ConfigPath { get; set; }
		/// <summary>
		/// --sign-info &lt;arg&gt;
		/// Use Signing Info for signing the test server
		/// </summary>
		public string? SignInfo { get; set; }
		/// <summary>
		/// --workspace &lt;arg&gt;
		/// Obsolete. Please use --project-dir instead
		/// </summary>
		public string? Workspace { get; set; }
		/// <summary>
		/// --vsts-id-variable &lt;arg&gt;
		/// Outputs the Test Run Id to the named VSTS variable
		/// </summary>
		public string? VstsIdVariable { get; set; }
		/// <summary>
		/// --timeout &lt;arg&gt;
		/// Maximum time (in seconds) to wait for test results
		/// </summary>
		public string? Timeout { get; set; }
		/// <summary>
		/// --async
		/// Exit the command when tests are uploaded, without waiting for test results
		/// </summary>
		public bool? Async { get; set; }
		/// <summary>
		/// -p|--test-parameter &lt;arg&gt;
		/// Additional test parameters. The value must be in format &quot;key=value&quot;
		/// </summary>
		public string? TestParameter { get; set; }
		/// <summary>
		/// --include &lt;arg&gt;
		/// Additional files and directories to include. The value must be either path relative to the input directory, or be in format &quot;targetDir=sourceDir&quot;
		/// </summary>
		public string? Include { get; set; }
		/// <summary>
		/// --test-series &lt;arg&gt;
		/// Name of the test series
		/// </summary>
		public string? TestSeries { get; set; }
		/// <summary>
		/// --language &lt;arg&gt;
		/// Override the language (iOS only) for the test run
		/// </summary>
		public string? Language { get; set; }
		/// <summary>
		/// --locale &lt;arg&gt;
		/// The system locale for the test run. For example, en_US
		/// </summary>
		public string? Locale { get; set; }
		/// <summary>
		/// --dsym-dir &lt;arg&gt;
		/// Path to the directory with iOS symbol files. This option is deprecated and ignored
		/// </summary>
		public string? DsymDir { get; set; }
		/// <summary>
		/// --app-path &lt;arg&gt;
		/// Path to an application file
		/// </summary>
		public string? AppPath { get; set; }
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