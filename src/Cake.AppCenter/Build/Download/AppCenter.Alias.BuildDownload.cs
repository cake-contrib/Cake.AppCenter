using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Download the binary, logs or symbols for a completed build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterBuildDownload(this ICakeContext context, AppCenterBuildDownloadSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildDownloadSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("build download", settings ?? new AppCenterBuildDownloadSettings(), arguments);
		}
	}
}
