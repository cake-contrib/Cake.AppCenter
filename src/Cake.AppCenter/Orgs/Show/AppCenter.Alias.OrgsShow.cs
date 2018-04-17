using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Show information about organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterOrgsShow(this ICakeContext context, AppCenterOrgsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("orgs show", settings ?? new AppCenterOrgsShowSettings(), arguments);
		}


         /// <summary>
	    /// Show information about organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterOrgsShowWithResult(this ICakeContext context, AppCenterOrgsShowSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsShowSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("orgs show", settings ?? new AppCenterOrgsShowSettings(), arguments);
		}

	}
}
