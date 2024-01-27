using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Starts a test run with Xamarin UI Tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static void AppCenterTestRunUitest(this ICakeContext context, AppCenterTestRunUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestRunUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("test run uitest", settings ?? new AppCenterTestRunUitestSettings(), arguments);
		}


         /// <summary>
	    /// Starts a test run with Xamarin UI Tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static IEnumerable<string> AppCenterTestRunUitestWithResult(this ICakeContext context, AppCenterTestRunUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestRunUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("test run uitest", settings ?? new AppCenterTestRunUitestSettings(), arguments);
		}

	}
}
