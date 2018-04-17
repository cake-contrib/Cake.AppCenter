using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Lists applications of organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterOrgsAppsList(this ICakeContext context, AppCenterOrgsAppsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsAppsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("orgs apps list", settings ?? new AppCenterOrgsAppsListSettings(), arguments);
		}


         /// <summary>
	    /// Lists applications of organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterOrgsAppsListWithResult(this ICakeContext context, AppCenterOrgsAppsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsAppsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("orgs apps list", settings ?? new AppCenterOrgsAppsListSettings(), arguments);
		}

	}
}
