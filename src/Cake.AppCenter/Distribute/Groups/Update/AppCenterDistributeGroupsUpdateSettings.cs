using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter distribute groups update.
	/// Update existing distribution group.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterDistributeGroupsUpdateSettings : AutoToolSettings
	{
		/// <summary>
		/// -g|--group &lt;arg&gt;
		/// Distribution group name
		/// </summary>
		public string Group { get; set; }
		/// <summary>
		/// --private
		/// Make the distribution group private (allowing only members to download the releases). Don&#39;t use with opposite --public.
		/// </summary>
		public bool? Private { get; set; }
		/// <summary>
		/// -p|--public
		/// Make the distribution group public (allowing anyone to download the releases). Don&#39;t use with opposite --private.
		/// </summary>
		public bool? Public { get; set; }
		/// <summary>
		/// -D|--delete-testers-file &lt;arg&gt;
		/// Path to file containing list of testers to delete
		/// </summary>
		public string DeleteTestersFile { get; set; }
		/// <summary>
		/// -T|--add-testers-file &lt;arg&gt;
		/// Path to file containing list of testers to add
		/// </summary>
		public string AddTestersFile { get; set; }
		/// <summary>
		/// -d|--delete-testers &lt;arg&gt;
		/// List of testers to delete (use space-separated list of e-mails)
		/// </summary>
		public string DeleteTesters { get; set; }
		/// <summary>
		/// -t|--add-testers &lt;arg&gt;
		/// List of testers to add (use space-separated list of e-mails)
		/// </summary>
		public string AddTesters { get; set; }
		/// <summary>
		/// -n|--name &lt;arg&gt;
		/// New distribution group name
		/// </summary>
		public string Name { get; set; }
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