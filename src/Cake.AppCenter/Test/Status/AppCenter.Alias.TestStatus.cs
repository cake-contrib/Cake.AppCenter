using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Checks the status of the started test run.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterTestStatus(this ICakeContext context, AppCenterTestStatusSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestStatusSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test status", settings ?? new AppCenterTestStatusSettings(), arguments);
		}
	}
}
