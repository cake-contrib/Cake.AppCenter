using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Starts a test run with Calabash tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterTestRunCalabash(this ICakeContext context, AppCenterTestRunCalabashSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestRunCalabashSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("test run calabash", settings ?? new AppCenterTestRunCalabashSettings(), arguments);
		}


         /// <summary>
	    /// Starts a test run with Calabash tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterTestRunCalabashWithResult(this ICakeContext context, AppCenterTestRunCalabashSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestRunCalabashSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("test run calabash", settings ?? new AppCenterTestRunCalabashSettings(), arguments);
		}

	}
}
