using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Add a new deployment to an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static void AppCenterCodepushDeploymentAdd(this ICakeContext context, AppCenterCodepushDeploymentAddSettings settings, string newDeploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(newDeploymentName))
            {
                throw new ArgumentNullException(nameof(newDeploymentName));
            }
            var arguments = new string[] { newDeploymentName };
            var runner = new GenericRunner<AppCenterCodepushDeploymentAddSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("codepush deployment add", settings ?? new AppCenterCodepushDeploymentAddSettings(), arguments);
		}


         /// <summary>
	    /// Add a new deployment to an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static IEnumerable<string> AppCenterCodepushDeploymentAddWithResult(this ICakeContext context, AppCenterCodepushDeploymentAddSettings settings, string newDeploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(newDeploymentName))
            {
                throw new ArgumentNullException(nameof(newDeploymentName));
            }
            var arguments = new string[] { newDeploymentName };
            var runner = new GenericRunner<AppCenterCodepushDeploymentAddSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("codepush deployment add", settings ?? new AppCenterCodepushDeploymentAddSettings(), arguments);
		}

	}
}
