using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Get the details of an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterAppsShow(this ICakeContext context, AppCenterAppsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("apps show", settings ?? new AppCenterAppsShowSettings(), arguments);
		}


         /// <summary>
	    /// Get the details of an app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterAppsShowWithResult(this ICakeContext context, AppCenterAppsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("apps show", settings ?? new AppCenterAppsShowSettings(), arguments);
		}

	}
}
