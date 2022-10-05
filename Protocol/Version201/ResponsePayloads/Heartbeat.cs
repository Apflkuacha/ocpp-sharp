using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "Heartbeat", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class Heartbeat : ResponsePayload
    {
        public DateTime currentTime;
    }
}