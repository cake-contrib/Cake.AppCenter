using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Get information about logged in user
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterProfileList(this ICakeContext context, AppCenterProfileListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterProfileListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("profile list", settings ?? new AppCenterProfileListSettings(), arguments);
		}
	}
}
