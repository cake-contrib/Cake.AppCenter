using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Set default application for all CLI commands. Not compatible when authenticating with '--token' or an environment variable. Use environment variable 'MOBILE_CENTER_CURRENT_APP' to set the default app instead.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Apps")] 
		public static void AppCenterAppsSetCurrent(this ICakeContext context, AppCenterAppsSetCurrentSettings settings, string app)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(app))
            {
                throw new ArgumentNullException(nameof(app));
            }
            var arguments = new string[] { app };
            var runner = new GenericRunner<AppCenterAppsSetCurrentSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("apps set-current", settings ?? new AppCenterAppsSetCurrentSettings(), arguments);
		}


         /// <summary>
	    /// Set default application for all CLI commands. Not compatible when authenticating with '--token' or an environment variable. Use environment variable 'MOBILE_CENTER_CURRENT_APP' to set the default app instead.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Apps")] 
		public static IEnumerable<string> AppCenterAppsSetCurrentWithResult(this ICakeContext context, AppCenterAppsSetCurrentSettings settings, string app)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(app))
            {
                throw new ArgumentNullException(nameof(app));
            }
            var arguments = new string[] { app };
            var runner = new GenericRunner<AppCenterAppsSetCurrentSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("apps set-current", settings ?? new AppCenterAppsSetCurrentSettings(), arguments);
		}

	}
}
