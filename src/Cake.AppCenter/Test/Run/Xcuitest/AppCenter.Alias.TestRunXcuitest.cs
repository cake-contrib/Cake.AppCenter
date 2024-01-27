using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Starts a test run with XCUITest tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static void AppCenterTestRunXcuitest(this ICakeContext context, AppCenterTestRunXcuitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestRunXcuitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("test run xcuitest", settings ?? new AppCenterTestRunXcuitestSettings(), arguments);
		}


         /// <summary>
	    /// Starts a test run with XCUITest tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static IEnumerable<string> AppCenterTestRunXcuitestWithResult(this ICakeContext context, AppCenterTestRunXcuitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestRunXcuitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("test run xcuitest", settings ?? new AppCenterTestRunXcuitestSettings(), arguments);
		}

	}
}
