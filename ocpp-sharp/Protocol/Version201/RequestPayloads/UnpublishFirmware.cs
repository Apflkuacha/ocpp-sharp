using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "UnpublishFirmware", OcppMessageAttribute.Direction.CentralToPoint)]
public class UnpublishFirmwareRequest : RequestPayload
{
    [JsonProperty("checksum")]
    public CiString Checksum { get; set; } // md5
}
