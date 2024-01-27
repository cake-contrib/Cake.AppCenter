using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// List the deployments associated with an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static void AppCenterCodepushDeploymentList(this ICakeContext context, AppCenterCodepushDeploymentListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCodepushDeploymentListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("codepush deployment list", settings ?? new AppCenterCodepushDeploymentListSettings(), arguments);
		}


         /// <summary>
	    /// List the deployments associated with an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static IEnumerable<string> AppCenterCodepushDeploymentListWithResult(this ICakeContext context, AppCenterCodepushDeploymentListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCodepushDeploymentListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("codepush deployment list", settings ?? new AppCenterCodepushDeploymentListSettings(), arguments);
		}

	}
}
