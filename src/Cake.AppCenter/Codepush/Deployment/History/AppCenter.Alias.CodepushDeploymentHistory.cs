using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Display the release history for a CodePush deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterCodepushDeploymentHistory(this ICakeContext context, AppCenterCodepushDeploymentHistorySettings settings, string deploymentName)
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
            var runner = new GenericRunner<AppCenterCodepushDeploymentHistorySettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("codepush deployment history", settings ?? new AppCenterCodepushDeploymentHistorySettings(), arguments);
		}
	}
}
