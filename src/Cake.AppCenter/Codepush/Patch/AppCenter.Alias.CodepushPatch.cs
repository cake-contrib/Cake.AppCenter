using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Update the metadata for an existing CodePush release
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="deploymentName">The deploymentName.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static void AppCenterCodepushPatch(this ICakeContext context, AppCenterCodepushPatchSettings settings, string? deploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(deploymentName))
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            var arguments = new string[] { deploymentName };
            var runner = new GenericRunner<AppCenterCodepushPatchSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("codepush patch", settings ?? new AppCenterCodepushPatchSettings(), arguments);
		}


         /// <summary>
	    /// Update the metadata for an existing CodePush release
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="deploymentName">The deploymentName.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Codepush")] 
		public static IEnumerable<string> AppCenterCodepushPatchWithResult(this ICakeContext context, AppCenterCodepushPatchSettings settings, string? deploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(deploymentName))
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            var arguments = new string[] { deploymentName };
            var runner = new GenericRunner<AppCenterCodepushPatchSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("codepush patch", settings ?? new AppCenterCodepushPatchSettings(), arguments);
		}

	}
}
