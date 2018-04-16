using System;
using System.Runtime.CompilerServices;

namespace Cake.AppCenter
{
	/// <summary>
	/// Settings for appcenter orgs collaborators update.
	/// Update list of organization collaborators.
	/// </summary>
	[CompilerGenerated]
	public sealed class AppCenterOrgsCollaboratorsUpdateSettings : AutoToolSettings
	{
		/// <summary>
		/// -n|--name &lt;arg&gt;
		/// Name of the organization
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// -M|--make-collaborators-file &lt;arg&gt;
		/// Path to the list of admins to make collaborators
		/// </summary>
		public string MakeCollaboratorsFile { get; set; }
		/// <summary>
		/// -m|--make-collaborators &lt;arg&gt;
		/// List of admins to make collaborators
		/// </summary>
		public string MakeCollaborators { get; set; }
		/// <summary>
		/// -A|--make-admins-file &lt;arg&gt;
		/// Path to the list of collaborators to make admins
		/// </summary>
		public string MakeAdminsFile { get; set; }
		/// <summary>
		/// -a|--make-admins &lt;arg&gt;
		/// List of collaborators to make admins
		/// </summary>
		public string MakeAdmins { get; set; }
		/// <summary>
		/// -D|--delete-collaborators-file &lt;arg&gt;
		/// Path to the list of collaborators to delete
		/// </summary>
		public string DeleteCollaboratorsFile { get; set; }
		/// <summary>
		/// -d|--delete-collaborators &lt;arg&gt;
		/// List of collaborators to delete
		/// </summary>
		public string DeleteCollaborators { get; set; }
		/// <summary>
		/// -C|--add-collaborators-file &lt;arg&gt;
		/// Path to the list of collaborators to add
		/// </summary>
		public string AddCollaboratorsFile { get; set; }
		/// <summary>
		/// -c|--add-collaborators &lt;arg&gt;
		/// List of collaborators to add
		/// </summary>
		public string AddCollaborators { get; set; }
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