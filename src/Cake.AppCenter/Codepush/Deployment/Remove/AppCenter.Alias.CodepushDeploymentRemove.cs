using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Remove CodePush deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="deploymentName">The deploymentName.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static void AppCenterCodepushDeploymentRemove(this ICakeContext context, AppCenterCodepushDeploymentRemoveSettings settings, string? deploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(deploymentName))
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            var arguments = new string[] { deploymentName };
            var runner = new GenericRunner<AppCenterCodepushDeploymentRemoveSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("codepush deployment remove", settings ?? new AppCenterCodepushDeploymentRemoveSettings(), arguments);
		}


         /// <summary>
	    /// Remove CodePush deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="deploymentName">The deploymentName.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static IEnumerable<string> AppCenterCodepushDeploymentRemoveWithResult(this ICakeContext context, AppCenterCodepushDeploymentRemoveSettings settings, string? deploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(deploymentName))
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            var arguments = new string[] { deploymentName };
            var runner = new GenericRunner<AppCenterCodepushDeploymentRemoveSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("codepush deployment remove", settings ?? new AppCenterCodepushDeploymentRemoveSettings(), arguments);
		}

	}
}
