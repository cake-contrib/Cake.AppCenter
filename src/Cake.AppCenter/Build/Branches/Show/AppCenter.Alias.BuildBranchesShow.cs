using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Show branch build status
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Build")] 
		public static void AppCenterBuildBranchesShow(this ICakeContext context, AppCenterBuildBranchesShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildBranchesShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("build branches show", settings ?? new AppCenterBuildBranchesShowSettings(), arguments);
		}


         /// <summary>
	    /// Show branch build status
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Build")] 
		public static IEnumerable<string> AppCenterBuildBranchesShowWithResult(this ICakeContext context, AppCenterBuildBranchesShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildBranchesShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("build branches show", settings ?? new AppCenterBuildBranchesShowSettings(), arguments);
		}

	}
}
