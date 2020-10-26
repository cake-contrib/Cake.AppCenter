using Cake.Core;
using Cake.Core.Annotations;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
    partial class AppCenterAliases
    {
        /// <summary>
        /// Publish an app file to a store.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The settings.</param>
        [CakeMethodAlias]
        public static void AppCenterDistributeStoresPublish(this ICakeContext context, AppCenterDistributeStoresPublishSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeStoresPublishSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            runner.Run("distribute stores publish", settings ?? new AppCenterDistributeStoresPublishSettings(), arguments);
        }

        /// <summary>
        /// Publish an app file to a store.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>Output lines.</returns>
        [CakeMethodAlias]
        public static IEnumerable<string> AppCenterDistributeStoresPublishWithResult(this ICakeContext context, AppCenterDistributeStoresPublishSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var arguments = new string[0];
            var runner = new GenericRunner<AppCenterDistributeStoresPublishSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            return runner.RunWithResult("distribute stores publish", settings ?? new AppCenterDistributeStoresPublishSettings(), arguments);
        }
    }
}
