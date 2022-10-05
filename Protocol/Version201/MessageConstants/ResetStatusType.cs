using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ResetStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ResetStatusType.Accepted)]
            Accepted,
            [StringValue(ResetStatusType.Rejected)]
            Rejected,
            [StringValue(ResetStatusType.Scheduled)]
            Scheduled
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
        public const string Scheduled = "Scheduled";
    }
}