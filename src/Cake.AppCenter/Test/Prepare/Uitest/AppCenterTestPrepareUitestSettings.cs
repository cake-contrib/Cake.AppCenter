using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter test prepare uitest.
	/// Creates an artifacts directory with Xamarin UI Tests..
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterTestPrepareUitestSettings : AutoToolSettings
	{
		/// <summary>
		/// --build-dir &lt;arg&gt;
		/// Path to the directory with the built test assemblies (usually &lt;project&gt;/bin/&lt;configuration&gt;)
		/// </summary>
		public string BuildDir { get; set; }
		/// <summary>
		/// --app-path &lt;arg&gt;
		/// Path to an application file
		/// </summary>
		public string AppPath { get; set; }
		/// <summary>
		/// --artifacts-dir &lt;arg&gt;
		/// Path to the artifacts directory to create
		/// </summary>
		public string ArtifactsDir { get; set; }
		/// <summary>
		/// --fixture-chunk
		/// Run tests in parallel by fixture
		/// </summary>
		public bool? FixtureChunk { get; set; }
		/// <summary>
		/// --test-chunk
		/// Run tests in parallel by method
		/// </summary>
		public bool? TestChunk { get; set; }
		/// <summary>
		/// --exclude-category &lt;arg&gt;
		/// NUnit category to not run. (Can be used multiple times) (When include and/or fixture are combined with exclude, all tests with the included categories are run, except for those also marked with the excluded categories)
		/// </summary>
		public string ExcludeCategory { get; set; }
		/// <summary>
		/// --include-category &lt;arg&gt;
		/// NUnit category to run. (Can be used multiple times)
		/// </summary>
		public string IncludeCategory { get; set; }
		/// <summary>
		/// --fixture &lt;arg&gt;
		/// NUnit fixture / namespace to run. If used with include / exclude the fixture filter is applied first (Can be used multiple times)
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