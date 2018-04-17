using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Show statistics for sessions
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterAnalyticsSessions(this ICakeContext context, AppCenterAnalyticsSessionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsSessionsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("analytics sessions", settings ?? new AppCenterAnalyticsSessionsSettings(), arguments);
		}


         /// <summary>
	    /// Show statistics for sessions
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterAnalyticsSessionsWithResult(this ICakeContext context, AppCenterAnalyticsSessionsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsSessionsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("analytics sessions", settings ?? new AppCenterAnalyticsSessionsSettings(), arguments);
		}

	}
}
