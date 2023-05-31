using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using Wolverine.Runtime;
using Wolverine.Runtime.Agents;

namespace Wolverine.RDBMS.Durability;

internal class NodeRecoveryOperation : IAgentCommand
{
    private readonly int _ownerNodeId;

    public NodeRecoveryOperation(int ownerNodeId)
    {
        _ownerNodeId = ownerNodeId;
    }

    public async IAsyncEnumerable<object> ExecuteAsync(IWolverineRuntime runtime,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        runtime.Logger.LogInformation("Releasing node ownership in the inbox/outbox from dormant node {Node}", _ownerNodeId);
        await runtime.Storage.Admin.ReleaseAllOwnershipAsync();

        yield break;
    }
}