using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Queue a new build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterBuildQueue(this ICakeContext context, AppCenterBuildQueueSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildQueueSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("build queue", settings ?? new AppCenterBuildQueueSettings(), arguments);
		}


         /// <summary>
	    /// Queue a new build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterBuildQueueWithResult(this ICakeContext context, AppCenterBuildQueueSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildQueueSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("build queue", settings ?? new AppCenterBuildQueueSettings(), arguments);
		}

	}
}
