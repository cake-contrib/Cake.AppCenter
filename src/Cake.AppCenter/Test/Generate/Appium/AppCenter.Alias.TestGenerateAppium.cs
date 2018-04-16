using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Generates an Appium project
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterTestGenerateAppium(this ICakeContext context, AppCenterTestGenerateAppiumSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestGenerateAppiumSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test generate appium", settings ?? new AppCenterTestGenerateAppiumSettings(), arguments);
		}
	}
}
