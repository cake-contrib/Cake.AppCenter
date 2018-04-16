using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Download the report artifacts, unpack and merge them.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterTestDownload(this ICakeContext context, AppCenterTestDownloadSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestDownloadSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("test download", settings ?? new AppCenterTestDownloadSettings(), arguments);
		}
	}
}
