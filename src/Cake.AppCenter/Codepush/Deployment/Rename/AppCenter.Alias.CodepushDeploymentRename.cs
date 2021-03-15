using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Rename CodePush deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static void AppCenterCodepushDeploymentRename(this ICakeContext context, AppCenterCodepushDeploymentRenameSettings settings, string currentDeploymentName, string newDeploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(currentDeploymentName))
            {
                throw new ArgumentNullException(nameof(currentDeploymentName));
            }
            if (string.IsNullOrEmpty(newDeploymentName))
            {
                throw new ArgumentNullException(nameof(newDeploymentName));
            }
            var arguments = new string[] { currentDeploymentName, newDeploymentName };
            var runner = new GenericRunner<AppCenterCodepushDeploymentRenameSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("codepush deployment rename", settings ?? new AppCenterCodepushDeploymentRenameSettings(), arguments);
		}


         /// <summary>
	    /// Rename CodePush deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static IEnumerable<string> AppCenterCodepushDeploymentRenameWithResult(this ICakeContext context, AppCenterCodepushDeploymentRenameSettings settings, string currentDeploymentName, string newDeploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(currentDeploymentName))
            {
                throw new ArgumentNullException(nameof(currentDeploymentName));
            }
            if (string.IsNullOrEmpty(newDeploymentName))
            {
                throw new ArgumentNullException(nameof(newDeploymentName));
            }
            var arguments = new string[] { currentDeploymentName, newDeploymentName };
            var runner = new GenericRunner<AppCenterCodepushDeploymentRenameSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("codepush deployment rename", settings ?? new AppCenterCodepushDeploymentRenameSettings(), arguments);
		}

	}
}
