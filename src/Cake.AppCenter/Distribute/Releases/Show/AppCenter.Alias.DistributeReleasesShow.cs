using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Shows full details about release
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterDistributeReleasesShow(this ICakeContext context, AppCenterDistributeReleasesShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeReleasesShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("distribute releases show", settings ?? new AppCenterDistributeReleasesShowSettings(), arguments);
		}


         /// <summary>
	    /// Shows full details about release
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterDistributeReleasesShowWithResult(this ICakeContext context, AppCenterDistributeReleasesShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeReleasesShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("distribute releases show", settings ?? new AppCenterDistributeReleasesShowSettings(), arguments);
		}

	}
}
