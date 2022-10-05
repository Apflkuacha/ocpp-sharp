using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetConfiguration", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetConfiguration : RequestPayload
    {
        public CiString[]? key;

    }
}