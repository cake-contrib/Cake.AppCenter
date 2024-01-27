using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Setup tab completion for your shell
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="shellProfilePath">The shellProfilePath.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Setup Autocomplete")] 
		public static void AppCenterSetupAutocomplete(this ICakeContext context, AppCenterSetupAutocompleteSettings settings, string? shellProfilePath)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(shellProfilePath))
            {
                throw new ArgumentNullException(nameof(shellProfilePath));
            }
            var arguments = new string[] { shellProfilePath };
            var runner = new GenericRunner<AppCenterSetupAutocompleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("setup-autocomplete", settings ?? new AppCenterSetupAutocompleteSettings(), arguments);
		}


         /// <summary>
	    /// Setup tab completion for your shell
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <param name="shellProfilePath">The shellProfilePath.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Setup Autocomplete")] 
		public static IEnumerable<string> AppCenterSetupAutocompleteWithResult(this ICakeContext context, AppCenterSetupAutocompleteSettings settings, string? shellProfilePath)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(shellProfilePath))
            {
                throw new ArgumentNullException(nameof(shellProfilePath));
            }
            var arguments = new string[] { shellProfilePath };
            var runner = new GenericRunner<AppCenterSetupAutocompleteSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("setup-autocomplete", settings ?? new AppCenterSetupAutocompleteSettings(), arguments);
		}

	}
}
