using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Publish an app file to a group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static void AppCenterDistributeGroupsPublish(this ICakeContext context, AppCenterDistributeGroupsPublishSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsPublishSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("distribute groups publish", settings ?? new AppCenterDistributeGroupsPublishSettings(), arguments);
		}


         /// <summary>
	    /// Publish an app file to a group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static IEnumerable<string> AppCenterDistributeGroupsPublishWithResult(this ICakeContext context, AppCenterDistributeGroupsPublishSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsPublishSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("distribute groups publish", settings ?? new AppCenterDistributeGroupsPublishSettings(), arguments);
		}

	}
}
