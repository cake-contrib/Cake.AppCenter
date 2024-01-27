using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Create a new release for the destination deployment, which includes the exact code and metadata from the latest release of the source deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static void AppCenterCodepushPromote(this ICakeContext context, AppCenterCodepushPromoteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCodepushPromoteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("codepush promote", settings ?? new AppCenterCodepushPromoteSettings(), arguments);
		}


         /// <summary>
	    /// Create a new release for the destination deployment, which includes the exact code and metadata from the latest release of the source deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static IEnumerable<string> AppCenterCodepushPromoteWithResult(this ICakeContext context, AppCenterCodepushPromoteSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCodepushPromoteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("codepush promote", settings ?? new AppCenterCodepushPromoteSettings(), arguments);
		}

	}
}
