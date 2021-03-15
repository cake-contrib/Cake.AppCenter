using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Get the application that's set as default for all CLI commands
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Apps")] 
		public static void AppCenterAppsGetCurrent(this ICakeContext context, AppCenterAppsGetCurrentSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsGetCurrentSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("apps get-current", settings ?? new AppCenterAppsGetCurrentSettings(), arguments);
		}


         /// <summary>
	    /// Get the application that's set as default for all CLI commands
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Apps")] 
		public static IEnumerable<string> AppCenterAppsGetCurrentWithResult(this ICakeContext context, AppCenterAppsGetCurrentSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsGetCurrentSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("apps get-current", settings ?? new AppCenterAppsGetCurrentSettings(), arguments);
		}

	}
}
