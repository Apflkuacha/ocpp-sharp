namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "FirmwareStatusNotification", OcppMessageAttribute.Direction.CentralToPoint)]
public class FirmwareStatusNotificationResponse : ResponsePayload
{
}
