using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

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


         /// <summary>
	    /// Download the report artifacts, unpack and merge them.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterTestDownloadWithResult(this ICakeContext context, AppCenterTestDownloadSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestDownloadSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("test download", settings ?? new AppCenterTestDownloadSettings(), arguments);
		}

	}
}
