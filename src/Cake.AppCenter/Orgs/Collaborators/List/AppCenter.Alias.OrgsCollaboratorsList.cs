using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Lists collaborators of organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Orgs")] 
		public static void AppCenterOrgsCollaboratorsList(this ICakeContext context, AppCenterOrgsCollaboratorsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsCollaboratorsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("orgs collaborators list", settings ?? new AppCenterOrgsCollaboratorsListSettings(), arguments);
		}


         /// <summary>
	    /// Lists collaborators of organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Orgs")] 
		public static IEnumerable<string> AppCenterOrgsCollaboratorsListWithResult(this ICakeContext context, AppCenterOrgsCollaboratorsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsCollaboratorsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("orgs collaborators list", settings ?? new AppCenterOrgsCollaboratorsListSettings(), arguments);
		}

	}
}
