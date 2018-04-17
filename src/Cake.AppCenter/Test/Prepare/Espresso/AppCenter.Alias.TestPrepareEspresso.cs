using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Creates an artifacts directory with Espresso tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterTestPrepareEspresso(this ICakeContext context, AppCenterTestPrepareEspressoSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareEspressoSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("test prepare espresso", settings ?? new AppCenterTestPrepareEspressoSettings(), arguments);
		}


         /// <summary>
	    /// Creates an artifacts directory with Espresso tests.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterTestPrepareEspressoWithResult(this ICakeContext context, AppCenterTestPrepareEspressoSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestPrepareEspressoSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("test prepare espresso", settings ?? new AppCenterTestPrepareEspressoSettings(), arguments);
		}

	}
}
