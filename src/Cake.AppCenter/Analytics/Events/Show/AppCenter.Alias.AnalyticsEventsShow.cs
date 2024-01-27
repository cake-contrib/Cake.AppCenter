using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Show statistics for events
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static void AppCenterAnalyticsEventsShow(this ICakeContext context, AppCenterAnalyticsEventsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsEventsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("analytics events show", settings ?? new AppCenterAnalyticsEventsShowSettings(), arguments);
		}


         /// <summary>
	    /// Show statistics for events
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static IEnumerable<string> AppCenterAnalyticsEventsShowWithResult(this ICakeContext context, AppCenterAnalyticsEventsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsEventsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("analytics events show", settings ?? new AppCenterAnalyticsEventsShowSettings(), arguments);
		}

	}
}
