using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Command to see the incoming logs in real time
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static void AppCenterAnalyticsLogFlow(this ICakeContext context, AppCenterAnalyticsLogFlowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsLogFlowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("analytics log-flow", settings ?? new AppCenterAnalyticsLogFlowSettings(), arguments);
		}


         /// <summary>
	    /// Command to see the incoming logs in real time
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Analytics")] 
		public static IEnumerable<string> AppCenterAnalyticsLogFlowWithResult(this ICakeContext context, AppCenterAnalyticsLogFlowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAnalyticsLogFlowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("analytics log-flow", settings ?? new AppCenterAnalyticsLogFlowSettings(), arguments);
		}

	}
}
