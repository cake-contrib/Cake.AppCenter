using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter crashes upload-symbols.
	/// Upload the crash symbols for the application.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterCrashesUploadSymbolsSettings : AutoToolSettings
	{
		/// <summary>
		/// --appxsym &lt;arg&gt;
		/// Path to an appxsym file containing UWP symbols.
		/// </summary>
		public string? Appxsym { get; set; }
		/// <summary>
		/// -b|--breakpad &lt;arg&gt;
		/// Path to a zip file containing Breakpad symbols, or native binaries from which to generate Breakpad symbols.
		/// </summary>
		public string? Breakpad { get; set; }
		/// <summary>
		/// -m|--sourcemap &lt;arg&gt;
		/// Path to a React Native sourcemap file. Only supported in combination with --symbol or --xcarchive.
		/// </summary>
		public string? Sourcemap { get; set; }
		/// <summary>
		/// -x|--xcarchive &lt;arg&gt;
		/// Path to a xcarchive package
		/// </summary>
		public string? Xcarchive { get; set; }
		/// <summary>
		/// -s|--symbol &lt;arg&gt;
		/// Path to a dSYM package, a directory containing dSYM packages, or a zip file containing the dSYM packages.
		/// </summary>
		public string? Symbol { get; set; }
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