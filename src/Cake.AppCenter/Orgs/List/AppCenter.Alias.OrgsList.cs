using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Lists organizations in which current user is collaborator
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        
		[CakeMethodAlias]
        [CakeAliasCategory("Orgs")] 
		public static void AppCenterOrgsList(this ICakeContext context, AppCenterOrgsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("orgs list", settings ?? new AppCenterOrgsListSettings(), arguments);
		}


         /// <summary>
	    /// Lists organizations in which current user is collaborator
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Orgs")] 
		public static IEnumerable<string> AppCenterOrgsListWithResult(this ICakeContext context, AppCenterOrgsListSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsListSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("orgs list", settings ?? new AppCenterOrgsListSettings(), arguments);
		}

	}
}
