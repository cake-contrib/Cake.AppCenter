using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Upload the crash symbols for the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
		public static void AppCenterCrashesUploadSymbols(this ICakeContext context, AppCenterCrashesUploadSymbolsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCrashesUploadSymbolsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("crashes upload-symbols", settings ?? new AppCenterCrashesUploadSymbolsSettings(), arguments);
		}


         /// <summary>
	    /// Upload the crash symbols for the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
		public static IEnumerable<string> AppCenterCrashesUploadSymbolsWithResult(this ICakeContext context, AppCenterCrashesUploadSymbolsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCrashesUploadSymbolsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("crashes upload-symbols", settings ?? new AppCenterCrashesUploadSymbolsSettings(), arguments);
		}

	}
}
