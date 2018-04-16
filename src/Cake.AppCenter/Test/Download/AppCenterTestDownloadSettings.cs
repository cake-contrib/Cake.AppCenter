using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter test download.
	/// Download the report artifacts, unpack and merge them..
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterTestDownloadSettings : AutoToolSettings
	{
		/// <summary>
		/// --test-output-dir &lt;arg&gt;
		/// Directory to download the .zip file(s) into for merging
		/// </summary>
		public string TestOutputDir { get; set; }
		/// <summary>
		/// --test-run-id &lt;arg&gt;
		/// ID of the started test run
		/// </summary>
		public string TestRunId { get; set; }
		/// <summary>
		/// -c|--continuous
		/// Continuously checks the test run status until it completes
		/// </summary>
		public bool? Continuous { get; set; }
		/// <summary>
		/// --merged-file-name &lt;arg&gt;
		/// Name of the merged XML file
		/// </summary>
		public string MergedFileName { get; set; }
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