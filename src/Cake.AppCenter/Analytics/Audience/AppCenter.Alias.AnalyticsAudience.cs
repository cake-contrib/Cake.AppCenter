using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Show audience statistics
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static void AppCenterAnalyticsAudience(this ICakeContext context, AppCenterAnalyticsAudienceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsAudienceSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("analytics audience", settings ?? new AppCenterAnalyticsAudienceSettings(), arguments);
		}


         /// <summary>
	    /// Show audience statistics
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static IEnumerable<string> AppCenterAnalyticsAudienceWithResult(this ICakeContext context, AppCenterAnalyticsAudienceSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsAudienceSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("analytics audience", settings ?? new AppCenterAnalyticsAudienceSettings(), arguments);
		}

	}
}
