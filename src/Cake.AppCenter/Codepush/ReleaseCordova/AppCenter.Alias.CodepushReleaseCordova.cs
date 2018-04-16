using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Release a Cordova update to an app deployment
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterCodepushReleaseCordova(this ICakeContext context, AppCenterCodepushReleaseCordovaSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCodepushReleaseCordovaSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("codepush release-cordova", settings ?? new AppCenterCodepushReleaseCordovaSettings(), arguments);
		}
	}
}
