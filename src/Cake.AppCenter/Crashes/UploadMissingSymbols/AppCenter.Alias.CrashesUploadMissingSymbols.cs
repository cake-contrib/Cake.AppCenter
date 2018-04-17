using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Upload missing crash symbols for the application (only from macOS)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterCrashesUploadMissingSymbols(this ICakeContext context, AppCenterCrashesUploadMissingSymbolsSettings settings, string searchPath)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(searchPath))
            {
                throw new ArgumentNullException(nameof(searchPath));
            }
            var arguments = new string[] { searchPath };
            var runner = new GenericRunner<AppCenterCrashesUploadMissingSymbolsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("crashes upload-missing-symbols", settings ?? new AppCenterCrashesUploadMissingSymbolsSettings(), arguments);
		}


         /// <summary>
	    /// Upload missing crash symbols for the application (only from macOS)
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterCrashesUploadMissingSymbolsWithResult(this ICakeContext context, AppCenterCrashesUploadMissingSymbolsSettings settings, string searchPath)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
            if (string.IsNullOrEmpty(searchPath))
            {
                throw new ArgumentNullException(nameof(searchPath));
            }
            var arguments = new string[] { searchPath };
            var runner = new GenericRunner<AppCenterCrashesUploadMissingSymbolsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("crashes upload-missing-symbols", settings ?? new AppCenterCrashesUploadMissingSymbolsSettings(), arguments);
		}

	}
}
