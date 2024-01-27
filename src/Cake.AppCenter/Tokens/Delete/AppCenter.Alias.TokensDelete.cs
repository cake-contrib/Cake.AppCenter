using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Delete an API token
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="token">The token.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Tokens")] 
		public static void AppCenterTokensDelete(this ICakeContext context, AppCenterTokensDeleteSettings settings, string? token)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentNullException(nameof(token));
            }
            var arguments = new string[] { token };
            var runner = new GenericRunner<AppCenterTokensDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("tokens delete", settings ?? new AppCenterTokensDeleteSettings(), arguments);
		}


         /// <summary>
	    /// Delete an API token
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="token">The token.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Tokens")] 
		public static IEnumerable<string> AppCenterTokensDeleteWithResult(this ICakeContext context, AppCenterTokensDeleteSettings settings, string? token)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentNullException(nameof(token));
            }
            var arguments = new string[] { token };
            var runner = new GenericRunner<AppCenterTokensDeleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("tokens delete", settings ?? new AppCenterTokensDeleteSettings(), arguments);
		}

	}
}
