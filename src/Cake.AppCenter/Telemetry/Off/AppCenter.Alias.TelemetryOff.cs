using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Turn off the sending of telemetry
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Telemetry")] 
		public static void AppCenterTelemetryOff(this ICakeContext context, AppCenterTelemetryOffSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTelemetryOffSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("telemetry off", settings ?? new AppCenterTelemetryOffSettings(), arguments);
		}


         /// <summary>
	    /// Turn off the sending of telemetry
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Telemetry")] 
		public static IEnumerable<string> AppCenterTelemetryOffWithResult(this ICakeContext context, AppCenterTelemetryOffSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTelemetryOffSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("telemetry off", settings ?? new AppCenterTelemetryOffSettings(), arguments);
		}

	}
}
