using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace externaldurable
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static async Task Run( [QueueTrigger("approval-queue")] string instanceId,
    [DurableClient] IDurableOrchestrationClient client)
        {
            await client.RaiseEventAsync(instanceId, "Approval", true);
        }
    }
}
