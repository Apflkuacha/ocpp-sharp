using System.Net;
using System.Net.WebSockets;
using OcppSharp.Client;
using OcppSharp.Protocol;

namespace OcppSharp.Server;

public class OcppClientConnection : OcppSharpClient
{
    public OcppSharpServer ParentServer { get; }
    public IPEndPoint EndPoint { get; set; }

    // propagate MaxIncomingData from ParentServer if MaxIncomingData is null
    protected override int MaxIncomingDataValue => MaxIncomingData ?? ParentServer.MaxIncomingData;

    public OcppClientConnection(OcppSharpServer parentServer, WebSocket socket, IPEndPoint endPoint, string id, ProtocolVersion version)
        : base(socket, id, version)
    {
        ParentServer = parentServer;
        EndPoint = endPoint;
    }

    private static InvalidOperationException HandlerException => new("Per-client handlers are not supported on a client instance that stems from a server.");

    public override ClientRequestHandler RegisterHandler(Type type, Client.RequestPayloadHandlerDelegate handler) => throw HandlerException;
    public override ClientRequestHandler RegisterHandler<T>(Client.RequestPayloadHandlerDelegateGeneric<T> handler) => throw HandlerException;
    public override void UnregisterHandler(ClientRequestHandler handler) => throw HandlerException;

    protected override ResponsePayload RunHandler(RequestPayload payload)
    {
        return ParentServer.RunHandler(this, payload);
    }
}
