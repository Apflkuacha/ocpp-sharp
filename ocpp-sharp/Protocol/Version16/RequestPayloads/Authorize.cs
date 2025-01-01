using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "Authorize", OcppMessageAttribute.Direction.PointToCentral)]
public class AuthorizeRequest : RequestPayload
{
    [JsonProperty("idTag")]
    public CiString IdTag { get; set; } = string.Empty;
}
