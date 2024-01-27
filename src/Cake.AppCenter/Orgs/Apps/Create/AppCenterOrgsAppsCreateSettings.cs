using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter orgs apps create.
	/// Create a new app in an organization.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterOrgsAppsCreateSettings : AutoToolSettings
	{
		/// <summary>
		/// -p|--platform &lt;arg&gt;
		/// The platform of the app. Supported values: Cordova, Java, Objective-C-Swift, React-Native, Unity, UWP, WinForms, WPF, Xamarin, Custom
		/// </summary>
		public string? Platform { get; set; }
		/// <summary>
		/// -o|--os &lt;arg&gt;
		/// The OS the app will be running on. Supported values: Android, Custom, iOS, macOS, tvOS, Windows
		/// </summary>
		public string? Os { get; set; }
		/// <summary>
		/// -d|--display-name &lt;arg&gt;
		/// The descriptive name of the app. This can contain any characters
		/// </summary>
		public string? DisplayName { get; set; }
		/// <summary>
		/// -n|--org-name &lt;arg&gt;
		/// Name of the organization
		/// </summary>
		public string? OrgName { get; set; }
		/// <summary>
		/// -r|--release-type &lt;arg&gt;
		/// The app release type. Suggested values are Alpha, Beta, Production, Store, Enterprise. Custom values are allowed and must be must be one word, alphanumeric, first letter capitalized.
		/// </summary>
		public string? ReleaseType { get; set; }
		/// <summary>
		/// --description &lt;arg&gt;
		/// Description of the app
		/// </summary>
		public string? Description { get; set; }
		/// <summary>
		/// -a|--app-name &lt;arg&gt;
		/// The name of the app used in URLs. Can optionally be provided specifically, otherwise a generated name will be derived from display-name
		/// </summary>
		public string? AppName { get; set; }
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