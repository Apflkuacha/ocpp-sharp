using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "RemoteStopTransaction", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class RemoteStopTransactionRequest : RequestPayload
    {
        public long transactionId;

    }
}