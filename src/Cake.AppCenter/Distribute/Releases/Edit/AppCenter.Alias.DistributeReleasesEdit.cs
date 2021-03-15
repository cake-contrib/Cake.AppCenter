using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Toggles enabling and disabling the specified release
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static void AppCenterDistributeReleasesEdit(this ICakeContext context, AppCenterDistributeReleasesEditSettings settings, string state)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(state))
            {
                throw new ArgumentNullException(nameof(state));
            }
            var arguments = new string[] { state };
            var runner = new GenericRunner<AppCenterDistributeReleasesEditSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("distribute releases edit", settings ?? new AppCenterDistributeReleasesEditSettings(), arguments);
		}


         /// <summary>
	    /// Toggles enabling and disabling the specified release
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static IEnumerable<string> AppCenterDistributeReleasesEditWithResult(this ICakeContext context, AppCenterDistributeReleasesEditSettings settings, string state)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(state))
            {
                throw new ArgumentNullException(nameof(state));
            }
            var arguments = new string[] { state };
            var runner = new GenericRunner<AppCenterDistributeReleasesEditSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("distribute releases edit", settings ?? new AppCenterDistributeReleasesEditSettings(), arguments);
		}

	}
}
