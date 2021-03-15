using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Update existing distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static void AppCenterDistributeGroupsUpdate(this ICakeContext context, AppCenterDistributeGroupsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("distribute groups update", settings ?? new AppCenterDistributeGroupsUpdateSettings(), arguments);
		}


         /// <summary>
	    /// Update existing distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static IEnumerable<string> AppCenterDistributeGroupsUpdateWithResult(this ICakeContext context, AppCenterDistributeGroupsUpdateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsUpdateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("distribute groups update", settings ?? new AppCenterDistributeGroupsUpdateSettings(), arguments);
		}

	}
}
