using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Show list of branches
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Build")] 
		public static void AppCenterBuildBranchesList(this ICakeContext context, AppCenterBuildBranchesListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildBranchesListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("build branches list", settings ?? new AppCenterBuildBranchesListSettings(), arguments);
		}


         /// <summary>
	    /// Show list of branches
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Build")] 
		public static IEnumerable<string> AppCenterBuildBranchesListWithResult(this ICakeContext context, AppCenterBuildBranchesListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildBranchesListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("build branches list", settings ?? new AppCenterBuildBranchesListSettings(), arguments);
		}

	}
}
