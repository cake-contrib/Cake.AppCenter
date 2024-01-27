using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter build download.
	/// Download the binary, logs or symbols for a completed build.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterBuildDownloadSettings : AutoToolSettings
	{
		/// <summary>
		/// -t|--type &lt;arg&gt;
		/// Type of download. &#39;build&#39;, &#39;bundle&#39;, &#39;logs&#39;, and &#39;symbols&#39; are allowed values
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// -i|--id &lt;arg&gt;
		/// ID of build to download
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// -f|--file &lt;arg&gt;
		/// Destination file. Optional parameter to override the default auto-generated file name
		/// </summary>
		public string File { get; set; }
		/// <summary>
		/// -d|--dest &lt;arg&gt;
		/// Destination path. Optional parameter to override the default destination path of the downloaded build
		/// </summary>
		public string Dest { get; set; }
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