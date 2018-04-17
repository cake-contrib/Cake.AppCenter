using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Clear the release history associated with a deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterCodepushDeploymentClear(this ICakeContext context, AppCenterCodepushDeploymentClearSettings settings, string deploymentName)
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
            var runner = new GenericRunner<AppCenterCodepushDeploymentClearSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("codepush deployment clear", settings ?? new AppCenterCodepushDeploymentClearSettings(), arguments);
		}


         /// <summary>
	    /// Clear the release history associated with a deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterCodepushDeploymentClearWithResult(this ICakeContext context, AppCenterCodepushDeploymentClearSettings settings, string deploymentName)
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
            var runner = new GenericRunner<AppCenterCodepushDeploymentClearSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("codepush deployment clear", settings ?? new AppCenterCodepushDeploymentClearSettings(), arguments);
		}

	}
}
