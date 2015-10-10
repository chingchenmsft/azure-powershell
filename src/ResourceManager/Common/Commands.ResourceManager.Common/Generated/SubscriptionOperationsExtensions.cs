// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Internal.Subscriptions.Models;

namespace Microsoft.Azure.Internal.Subscriptions
{
    public static partial class SubscriptionOperationsExtensions
    {
        /// <summary>
        /// Gets details about particular subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Internal.Subscriptions.ISubscriptionOperations.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Id of the subscription.
        /// </param>
        /// <returns>
        /// Subscription detailed information.
        /// </returns>
        public static GetSubscriptionResult Get(this ISubscriptionOperations operations, string subscriptionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionOperations)s).GetAsync(subscriptionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets details about particular subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Internal.Subscriptions.ISubscriptionOperations.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Id of the subscription.
        /// </param>
        /// <returns>
        /// Subscription detailed information.
        /// </returns>
        public static Task<GetSubscriptionResult> GetAsync(this ISubscriptionOperations operations, string subscriptionId)
        {
            return operations.GetAsync(subscriptionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of the subscriptionIds.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Internal.Subscriptions.ISubscriptionOperations.
        /// </param>
        /// <returns>
        /// Subscription list operation response.
        /// </returns>
        public static SubscriptionListResult List(this ISubscriptionOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of the subscriptionIds.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Internal.Subscriptions.ISubscriptionOperations.
        /// </param>
        /// <returns>
        /// Subscription list operation response.
        /// </returns>
        public static Task<SubscriptionListResult> ListAsync(this ISubscriptionOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of the subscription locations.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Internal.Subscriptions.ISubscriptionOperations.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Id of the subscription
        /// </param>
        /// <returns>
        /// Location list operation response.
        /// </returns>
        public static LocationListResult ListLocations(this ISubscriptionOperations operations, string subscriptionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionOperations)s).ListLocationsAsync(subscriptionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of the subscription locations.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Internal.Subscriptions.ISubscriptionOperations.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Id of the subscription
        /// </param>
        /// <returns>
        /// Location list operation response.
        /// </returns>
        public static Task<LocationListResult> ListLocationsAsync(this ISubscriptionOperations operations, string subscriptionId)
        {
            return operations.ListLocationsAsync(subscriptionId, CancellationToken.None);
        }
    }
}
