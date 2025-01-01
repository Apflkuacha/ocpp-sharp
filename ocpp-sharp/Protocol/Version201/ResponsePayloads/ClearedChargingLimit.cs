namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearedChargingLimit", OcppMessageAttribute.Direction.CentralToPoint)]
public class ClearedChargingLimitResponse : ResponsePayload
{
}
