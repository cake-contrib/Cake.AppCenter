using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Lists all stores of the app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static void AppCenterDistributeStoresList(this ICakeContext context, AppCenterDistributeStoresListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeStoresListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("distribute stores list", settings ?? new AppCenterDistributeStoresListSettings(), arguments);
		}


         /// <summary>
	    /// Lists all stores of the app
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static IEnumerable<string> AppCenterDistributeStoresListWithResult(this ICakeContext context, AppCenterDistributeStoresListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeStoresListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("distribute stores list", settings ?? new AppCenterDistributeStoresListSettings(), arguments);
		}

	}
}
