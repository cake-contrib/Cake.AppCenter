using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Delete event
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static void AppCenterAnalyticsEventsDelete(this ICakeContext context, AppCenterAnalyticsEventsDeleteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsEventsDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("analytics events delete", settings ?? new AppCenterAnalyticsEventsDeleteSettings(), arguments);
		}


         /// <summary>
	    /// Delete event
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static IEnumerable<string> AppCenterAnalyticsEventsDeleteWithResult(this ICakeContext context, AppCenterAnalyticsEventsDeleteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsEventsDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("analytics events delete", settings ?? new AppCenterAnalyticsEventsDeleteSettings(), arguments);
		}

	}
}
