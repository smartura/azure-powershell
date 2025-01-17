// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DeploymentScriptsOperations.
    /// </summary>
    public static partial class DeploymentScriptsOperationsExtensions
    {
            /// <summary>
            /// Creates a deployment script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='deploymentScript'>
            /// Deployment script supplied to the operation.
            /// </param>
            public static DeploymentScript Create(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, DeploymentScript deploymentScript)
            {
                return operations.CreateAsync(resourceGroupName, scriptName, deploymentScript).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a deployment script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='deploymentScript'>
            /// Deployment script supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentScript> CreateAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, DeploymentScript deploymentScript, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, scriptName, deploymentScript, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates deployment script tags with specified values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='deploymentScript'>
            /// Deployment script resource with the tags to be updated.
            /// </param>
            public static DeploymentScript Update(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, DeploymentScriptUpdateParameter deploymentScript = default(DeploymentScriptUpdateParameter))
            {
                return operations.UpdateAsync(resourceGroupName, scriptName, deploymentScript).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates deployment script tags with specified values.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='deploymentScript'>
            /// Deployment script resource with the tags to be updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentScript> UpdateAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, DeploymentScriptUpdateParameter deploymentScript = default(DeploymentScriptUpdateParameter), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, scriptName, deploymentScript, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a deployment script with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            public static DeploymentScript Get(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName)
            {
                return operations.GetAsync(resourceGroupName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a deployment script with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentScript> GetAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, scriptName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a deployment script. When operation completes, status code 200
            /// returned without content.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            public static void Delete(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName)
            {
                operations.DeleteAsync(resourceGroupName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a deployment script. When operation completes, status code 200
            /// returned without content.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, scriptName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all deployment scripts for a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DeploymentScript> ListBySubscription(this IDeploymentScriptsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all deployment scripts for a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentScript>> ListBySubscriptionAsync(this IDeploymentScriptsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets deployment script logs for a given deployment script name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            public static ScriptLogsList GetLogs(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName)
            {
                return operations.GetLogsAsync(resourceGroupName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets deployment script logs for a given deployment script name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScriptLogsList> GetLogsAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogsWithHttpMessagesAsync(resourceGroupName, scriptName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets deployment script logs for a given deployment script name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='tail'>
            /// The number of lines to show from the tail of the deployment script log.
            /// Valid value is a positive number up to 1000. If 'tail' is not provided, all
            /// available logs are shown up to container instance log capacity of 4mb.
            /// </param>
            public static ScriptLog GetLogsDefault(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, int? tail = default(int?))
            {
                return operations.GetLogsDefaultAsync(resourceGroupName, scriptName, tail).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets deployment script logs for a given deployment script name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='tail'>
            /// The number of lines to show from the tail of the deployment script log.
            /// Valid value is a positive number up to 1000. If 'tail' is not provided, all
            /// available logs are shown up to container instance log capacity of 4mb.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScriptLog> GetLogsDefaultAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, int? tail = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogsDefaultWithHttpMessagesAsync(resourceGroupName, scriptName, tail, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists deployments scripts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IPage<DeploymentScript> ListByResourceGroup(this IDeploymentScriptsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists deployments scripts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentScript>> ListByResourceGroupAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a deployment script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='deploymentScript'>
            /// Deployment script supplied to the operation.
            /// </param>
            public static DeploymentScript BeginCreate(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, DeploymentScript deploymentScript)
            {
                return operations.BeginCreateAsync(resourceGroupName, scriptName, deploymentScript).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a deployment script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='scriptName'>
            /// Name of the deployment script.
            /// </param>
            /// <param name='deploymentScript'>
            /// Deployment script supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentScript> BeginCreateAsync(this IDeploymentScriptsOperations operations, string resourceGroupName, string scriptName, DeploymentScript deploymentScript, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, scriptName, deploymentScript, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all deployment scripts for a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeploymentScript> ListBySubscriptionNext(this IDeploymentScriptsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all deployment scripts for a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentScript>> ListBySubscriptionNextAsync(this IDeploymentScriptsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists deployments scripts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeploymentScript> ListByResourceGroupNext(this IDeploymentScriptsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists deployments scripts.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentScript>> ListByResourceGroupNextAsync(this IDeploymentScriptsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
