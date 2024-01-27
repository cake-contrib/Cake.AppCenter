using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
	partial class AppCenterAliases
	{
         /// <summary>
	    /// Generates a Xamarin.UITest project
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static void AppCenterTestGenerateUitest(this ICakeContext context, AppCenterTestGenerateUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestGenerateUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			 runner.Run("test generate uitest", settings ?? new AppCenterTestGenerateUitestSettings(), arguments);
		}


         /// <summary>
	    /// Generates a Xamarin.UITest project
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="settings">The settings.</param>
        
        /// <returns>Output lines.</returns>
		[CakeMethodAlias]
        [CakeAliasCategory("Test")] 
		public static IEnumerable<string> AppCenterTestGenerateUitestWithResult(this ICakeContext context, AppCenterTestGenerateUitestSettings settings)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
                 var arguments = new string[0];
            var runner = new GenericRunner<AppCenterTestGenerateUitestSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
			return runner.RunWithResult("test generate uitest", settings ?? new AppCenterTestGenerateUitestSettings(), arguments);
		}

	}
}
