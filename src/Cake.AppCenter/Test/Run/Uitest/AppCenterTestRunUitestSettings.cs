using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter test run uitest.
	/// Starts a test run with Xamarin UI Tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterTestRunUitestSettings : AutoToolSettings
	{
		/// <summary>
		/// --devices &lt;arg&gt;
		/// Device selection slug
		/// </summary>
		public string Devices { get; set; }
		/// <summary>
		/// --fixture-chunk
		/// Run tests in parallel by fixture, ignore the use of include- / exclude-category
		/// </summary>
		public bool? FixtureChunk { get; set; }
		/// <summary>
		/// --test-chunk
		/// Run tests in parallel by method
		/// </summary>
		public bool? TestChunk { get; set; }
		/// <summary>
		/// --merge-nunit-xml &lt;arg&gt;
		/// Merge the xml files into the &lt;arg&gt; file. Requires --test-output-dir to specify the directory where the &lt;arg&gt; file will be. This parameter is ignored when used with the --async option because we have to wait for test results.
		/// </summary>
		public string MergeNunitXml { get; set; }
		/// <summary>
		/// --exclude-category &lt;arg&gt;
		/// NUnit category to not run. (Can be used multiple times) (When include and/or fixture are combined with exclude, all tests with the included categories are run, except for those also marked with the excluded categories)
		/// </summary>
		public string[] ExcludeCategory { get; set; }
		/// <summary>
		/// --include-category &lt;arg&gt;
		/// NUnit category to run. (Can be used multiple times)
		/// </summary>
		public string[] IncludeCategory { get; set; }
		/// <summary>
		/// --fixture &lt;arg&gt;
		/// NUnit fixture / namespace to run. If used with include- / exclude-category the fixture filter is applied first (Can be used multiple times)
		/// </summary>
		public string Fixture { get; set; }
		/// <summary>
		/// --uitest-tools-dir &lt;arg&gt;
		/// Path to the directory containing the Xamarin UI Tests tools including test-cloud.exe
		/// </summary>
		public string UitestToolsDir { get; set; }
		/// <summary>
		/// --sign-info &lt;arg&gt;
		/// Use Signing Info for signing the test server.
		/// </summary>
		public string SignInfo { get; set; }
		/// <summary>
		/// --key-password &lt;arg&gt;
		/// Password to the matching private key in the keystore. Corresponds to the &quot;-keypass&quot; argument in jarsigner
		/// </summary>
		public string KeyPassword { get; set; }
		/// <summary>
		/// --key-alias &lt;arg&gt;
		/// Alias to the key in the keystore. Corresponds to the &quot;-alias&quot; argument in jarsigner
		/// </summary>
		public string KeyAlias { get; set; }
		/// <summary>
		/// --store-password &lt;arg&gt;
		/// Password to the keystore. Corresponds to the &quot;-storepass&quot; argument in jarsigner
		/// </summary>
		public string StorePassword { get; set; }
		/// <summary>
		/// --store-path &lt;arg&gt;
		/// Path to the keystore file
		/// </summary>
		public string StorePath { get; set; }
		/// <summary>
		/// --assembly-dir &lt;arg&gt;
		/// Obsolete. Please use --build-dir instead
		/// </summary>
		public string AssemblyDir { get; set; }
		/// <summary>
		/// --build-dir &lt;arg&gt;
		/// Path to the directory with the built test assemblies (usually &lt;project&gt;/bin/&lt;configuration&gt;)
		/// </summary>
		public string BuildDir { get; set; }
		/// <summary>
		/// --test-output-dir &lt;arg&gt;
		/// Path to the directory for test results. This parameter won&#39;t work when you run using --async because we have to wait for test results. The results will be saved in the working directory if a relative path is specified
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
		/// Path to the directory with iOS symbol files. This option is deprecated and ignored
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