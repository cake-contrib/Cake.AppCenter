using Cake.Core;
using Cake.Core.Annotations;
using System;

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
		public static void AppCenterCodepushPromote(this ICakeContext context, AppCenterCodepushPromoteSettings settings, string x, string m)
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
            var arguments = new string[] { x, m };
            var runner = new GenericRunner<AppCenterCodepushPromoteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("codepush promote", settings ?? new AppCenterCodepushPromoteSettings(), arguments);
		}
	}
}
