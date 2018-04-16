using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter test generate uitest.
	/// Generates a Xamarin.UITest project.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterTestGenerateUitestSettings : AutoToolSettings
	{
		/// <summary>
		/// --output-path &lt;arg&gt;
		/// The path where the tests will be generated
		/// </summary>
		public string OutputPath { get; set; }
		/// <summary>
		/// --platform &lt;arg&gt;
		/// The app&#39;s platform (&#39;ios&#39; or &#39;android&#39;)
		/// </summary>
		public string Platform { get; set; }
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