using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Log out
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Logout")] 
		public static void AppCenterLogout(this ICakeContext context, AppCenterLogoutSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterLogoutSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("logout", settings ?? new AppCenterLogoutSettings(), arguments);
		}


         /// <summary>
	    /// Log out
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Logout")] 
		public static IEnumerable<string> AppCenterLogoutWithResult(this ICakeContext context, AppCenterLogoutSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterLogoutSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("logout", settings ?? new AppCenterLogoutSettings(), arguments);
		}

	}
}
