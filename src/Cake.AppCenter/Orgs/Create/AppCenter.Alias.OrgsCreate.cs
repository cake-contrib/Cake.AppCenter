using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Create a new organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterOrgsCreate(this ICakeContext context, AppCenterOrgsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("orgs create", settings ?? new AppCenterOrgsCreateSettings(), arguments);
		}


         /// <summary>
	    /// Create a new organization
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterOrgsCreateWithResult(this ICakeContext context, AppCenterOrgsCreateSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterOrgsCreateSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("orgs create", settings ?? new AppCenterOrgsCreateSettings(), arguments);
		}

	}
}
