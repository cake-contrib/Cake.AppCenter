using Cake.Core;
using Cake.Core.Annotations;
using System;

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
	}
}
