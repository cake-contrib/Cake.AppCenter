using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Creates an artifacts directory with XCUITest tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterTestPrepareXcuitest(this ICakeContext context, AppCenterTestPrepareXcuitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareXcuitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("test prepare xcuitest", settings ?? new AppCenterTestPrepareXcuitestSettings(), arguments);
		}


         /// <summary>
	    /// Creates an artifacts directory with XCUITest tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterTestPrepareXcuitestWithResult(this ICakeContext context, AppCenterTestPrepareXcuitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareXcuitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("test prepare xcuitest", settings ?? new AppCenterTestPrepareXcuitestSettings(), arguments);
		}

	}
}
