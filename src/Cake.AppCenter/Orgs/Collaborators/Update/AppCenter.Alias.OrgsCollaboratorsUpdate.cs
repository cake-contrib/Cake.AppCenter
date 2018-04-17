using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Update list of organization collaborators
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterOrgsCollaboratorsUpdate(this ICakeContext context, AppCenterOrgsCollaboratorsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsCollaboratorsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("orgs collaborators update", settings ?? new AppCenterOrgsCollaboratorsUpdateSettings(), arguments);
		}


         /// <summary>
	    /// Update list of organization collaborators
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterOrgsCollaboratorsUpdateWithResult(this ICakeContext context, AppCenterOrgsCollaboratorsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsCollaboratorsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("orgs collaborators update", settings ?? new AppCenterOrgsCollaboratorsUpdateSettings(), arguments);
		}

	}
}
