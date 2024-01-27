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
        [CakeAliasCategory("Build")] 
		public static void AppCenterBuildQueue(this ICakeContext context, AppCenterBuildQueueSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildQueueSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("build queue", settings ?? new AppCenterBuildQueueSettings(), arguments);
		}


         /// <summary>
	    /// Queue a new build
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Build")] 
		public static IEnumerable<string> AppCenterBuildQueueWithResult(this ICakeContext context, AppCenterBuildQueueSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterBuildQueueSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("build queue", settings ?? new AppCenterBuildQueueSettings(), arguments);
		}

	}
}
