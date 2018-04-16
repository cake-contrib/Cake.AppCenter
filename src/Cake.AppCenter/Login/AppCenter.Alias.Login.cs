using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
     /// <summary>
	    /// Log in
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
		[CakeMethodAlias]
		public static void AppCenterLogin(this ICakeContext context, AppCenterLoginSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterLoginSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			runner.Run("login", settings ?? new AppCenterLoginSettings(), arguments);
		}
	}
}
