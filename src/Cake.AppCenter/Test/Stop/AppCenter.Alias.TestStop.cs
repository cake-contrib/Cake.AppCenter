using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Stop the started test run.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterTestStop(this ICakeContext context, AppCenterTestStopSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestStopSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test stop", settings ?? new AppCenterTestStopSettings(), arguments);
		}
	}
}
