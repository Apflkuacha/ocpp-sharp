using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class ClearCacheStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ClearCacheStatus.Accepted)]
            Accepted,
            [StringValue(ClearCacheStatus.Rejected)]
            Rejected
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
    }
}