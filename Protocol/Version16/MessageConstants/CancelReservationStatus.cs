using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class CancelReservationStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(CancelReservationStatus.Accepted)]
            Accepted,
            [StringValue(CancelReservationStatus.Rejected)]
            Rejected
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
    }
}