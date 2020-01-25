using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Create new distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static void AppCenterDistributeGroupsCreate(this ICakeContext context, AppCenterDistributeGroupsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("distribute groups create", settings ?? new AppCenterDistributeGroupsCreateSettings(), arguments);
		}


         /// <summary>
	    /// Create new distribution group
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Distribute")] 
		public static IEnumerable<string> AppCenterDistributeGroupsCreateWithResult(this ICakeContext context, AppCenterDistributeGroupsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeGroupsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("distribute groups create", settings ?? new AppCenterDistributeGroupsCreateSettings(), arguments);
		}

	}
}
