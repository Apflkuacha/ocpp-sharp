using System;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "BootNotification", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class BootNotification : ResponsePayload
    {
        public DateTime currentTime;
        public long interval;
        
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.RegistrationStatus"/>
        /// </summary>
        public MessageConstants.RegistrationStatus.Enum status;
    }
}