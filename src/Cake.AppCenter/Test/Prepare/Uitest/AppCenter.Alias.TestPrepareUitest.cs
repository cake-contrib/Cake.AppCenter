using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Creates an artifacts directory with Xamarin UI Tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterTestPrepareUitest(this ICakeContext context, AppCenterTestPrepareUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("test prepare uitest", settings ?? new AppCenterTestPrepareUitestSettings(), arguments);
		}


         /// <summary>
	    /// Creates an artifacts directory with Xamarin UI Tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterTestPrepareUitestWithResult(this ICakeContext context, AppCenterTestPrepareUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("test prepare uitest", settings ?? new AppCenterTestPrepareUitestSettings(), arguments);
		}

	}
}
