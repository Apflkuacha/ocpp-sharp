using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetCompositeSchedule", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetCompositeSchedule : RequestPayload
    {
        public long connectorId;
        public long duration;
        
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ChargingRateUnitType"/>
        /// </summary>
        public MessageConstants.ChargingRateUnitType.Enum? ChargingRateUnitType;

    }
}