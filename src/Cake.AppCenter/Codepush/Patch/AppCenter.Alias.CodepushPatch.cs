using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Update the metadata for an existing CodePush release
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterCodepushPatch(this ICakeContext context, AppCenterCodepushPatchSettings settings, string x, string m, string deploymentName)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(x))
            {
                throw new ArgumentNullException(nameof(x));
            }
            if (string.IsNullOrEmpty(m))
            {
                throw new ArgumentNullException(nameof(m));
            }
            if (string.IsNullOrEmpty(deploymentName))
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            var arguments = new string[] { x, m, deploymentName };
            var runner = new GenericRunner<AppCenterCodepushPatchSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("codepush patch", settings ?? new AppCenterCodepushPatchSettings(), arguments);
		}
	}
}
