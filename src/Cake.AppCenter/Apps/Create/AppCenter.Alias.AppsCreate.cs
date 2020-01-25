using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Create a new app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Apps")] 
		public static void AppCenterAppsCreate(this ICakeContext context, AppCenterAppsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("apps create", settings ?? new AppCenterAppsCreateSettings(), arguments);
		}


         /// <summary>
	    /// Create a new app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Apps")] 
		public static IEnumerable<string> AppCenterAppsCreateWithResult(this ICakeContext context, AppCenterAppsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterAppsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("apps create", settings ?? new AppCenterAppsCreateSettings(), arguments);
		}

	}
}
