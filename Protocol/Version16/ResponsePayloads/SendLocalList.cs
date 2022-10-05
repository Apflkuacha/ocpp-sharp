using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "SendLocalList", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class SendLocalList : ResponsePayload
    {
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.UpdateStatus"/>
        /// </summary>
        public MessageConstants.UpdateStatus.Enum CiString;
    }
}