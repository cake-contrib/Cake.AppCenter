using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter test run appium.
	/// Starts a test run with Appium tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterTestRunAppiumSettings : AutoToolSettings
	{
		/// <summary>
		/// --build-dir &lt;arg&gt;
		/// Path to the directory with the Appium tests (usually &lt;project&gt;/target/upload)
		/// </summary>
		public string BuildDir { get; set; }
		/// <summary>
		/// --devices &lt;arg&gt;
		/// Device selection slug
		/// </summary>
		public string Devices { get; set; }
		/// <summary>
		/// --merge-junit-xml &lt;arg&gt;
		/// Merge the xml files in to the &lt;output.xml&gt; file. This parameter won&#39;t work when you run using --async because we have to wait for test results
		/// </summary>
		public string MergeJunitXml { get; set; }
		/// <summary>
		/// --test-output-dir &lt;arg&gt;
		/// Path to the directory for test results. This parameter won&#39;t work when you run using --async because we have to wait for test results. The results will be saved in the working directory if the relative path is specified
		/// </summary>
		public string TestOutputDir { get; set; }
		/// <summary>
		/// --vsts-id-variable &lt;arg&gt;
		/// Outputs the Test Run Id to the named VSTS variable
		/// </summary>
		public string VstsIdVariable { get; set; }
		/// <summary>
		/// --timeout &lt;arg&gt;
		/// Maximum time (in seconds) to wait for test results
		/// </summary>
		public string Timeout { get; set; }
		/// <summary>
		/// --async
		/// Exit the command when tests are uploaded, without waiting for test results
		/// </summary>
		public bool? Async { get; set; }
		/// <summary>
		/// -p|--test-parameter &lt;arg&gt;
		/// Additional test parameters. The value must be in format &quot;key=value&quot;
		/// </summary>
		public string TestParameter { get; set; }
		/// <summary>
		/// --include &lt;arg&gt;
		/// Additional files and directories to include. The value must be either path relative to the input directory, or be in format &quot;targetDir=sourceDir&quot;
		/// </summary>
		public string Include { get; set; }
		/// <summary>
		/// --test-series &lt;arg&gt;
		/// Name of the test series
		/// </summary>
		public string TestSeries { get; set; }
		/// <summary>
		/// --language &lt;arg&gt;
		/// Override the language (iOS only) for the test run
		/// </summary>
		public string Language { get; set; }
		/// <summary>
		/// --locale &lt;arg&gt;
		/// The system locale for the test run. For example, en_US
		/// </summary>
		public string Locale { get; set; }
		/// <summary>
		/// --dsym-dir &lt;arg&gt;
		/// Path to the directory with iOS symbol files
		/// </summary>
		public string DsymDir { get; set; }
		/// <summary>
		/// --app-path &lt;arg&gt;
		/// Path to an application file
		/// </summary>
		public string AppPath { get; set; }
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