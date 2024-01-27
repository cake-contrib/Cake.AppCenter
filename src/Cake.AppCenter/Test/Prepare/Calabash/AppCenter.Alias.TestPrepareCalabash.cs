using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Creates an artifacts directory with Calabash tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static void AppCenterTestPrepareCalabash(this ICakeContext context, AppCenterTestPrepareCalabashSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareCalabashSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("test prepare calabash", settings ?? new AppCenterTestPrepareCalabashSettings(), arguments);
		}


         /// <summary>
	    /// Creates an artifacts directory with Calabash tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static IEnumerable<string> AppCenterTestPrepareCalabashWithResult(this ICakeContext context, AppCenterTestPrepareCalabashSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareCalabashSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("test prepare calabash", settings ?? new AppCenterTestPrepareCalabashSettings(), arguments);
		}

	}
}
