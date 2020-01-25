using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Shows versions of the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static void AppCenterAnalyticsAppVersions(this ICakeContext context, AppCenterAnalyticsAppVersionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsAppVersionsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("analytics app-versions", settings ?? new AppCenterAnalyticsAppVersionsSettings(), arguments);
		}


         /// <summary>
	    /// Shows versions of the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static IEnumerable<string> AppCenterAnalyticsAppVersionsWithResult(this ICakeContext context, AppCenterAnalyticsAppVersionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsAppVersionsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("analytics app-versions", settings ?? new AppCenterAnalyticsAppVersionsSettings(), arguments);
		}

	}
}
