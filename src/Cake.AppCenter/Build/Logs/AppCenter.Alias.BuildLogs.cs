using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Displays log for build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterBuildLogs(this ICakeContext context, AppCenterBuildLogsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildLogsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build logs", settings ?? new AppCenterBuildLogsSettings(), arguments);
		}
	}
}
