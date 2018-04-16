using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Turn on the sending of telemetry
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterTelemetryOn(this ICakeContext context, AppCenterTelemetryOnSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTelemetryOnSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("telemetry on", settings ?? new AppCenterTelemetryOnSettings(), arguments);
		}
	}
}
