using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Upload the Android mappings for the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
		[CakeMethodAlias]
        [CakeAliasCategory("Crashes")] 
		public static void AppCenterCrashesUploadMappings(this ICakeContext context, AppCenterCrashesUploadMappingsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCrashesUploadMappingsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			 runner.Run("crashes upload-mappings", settings ?? new AppCenterCrashesUploadMappingsSettings(), arguments);
		}


         /// <summary>
	    /// Upload the Android mappings for the application
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Crashes")] 
		public static IEnumerable<string> AppCenterCrashesUploadMappingsWithResult(this ICakeContext context, AppCenterCrashesUploadMappingsSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterCrashesUploadMappingsSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
			return runner.RunWithResult("crashes upload-mappings", settings ?? new AppCenterCrashesUploadMappingsSettings(), arguments);
		}

	}
}
