using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Download release package for the distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static void AppCenterDistributeGroupsDownload(this ICakeContext context, AppCenterDistributeGroupsDownloadSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsDownloadSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("distribute groups download", settings ?? new AppCenterDistributeGroupsDownloadSettings(), arguments);
		}


         /// <summary>
	    /// Download release package for the distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static IEnumerable<string> AppCenterDistributeGroupsDownloadWithResult(this ICakeContext context, AppCenterDistributeGroupsDownloadSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsDownloadSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("distribute groups download", settings ?? new AppCenterDistributeGroupsDownloadSettings(), arguments);
		}

	}
}
