using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetNetworkProfile", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class SetNetworkProfile : RequestPayload
    {
        public int configurationSlot;
        public NetworkConnectionProfile connectionData;
        
    }
}