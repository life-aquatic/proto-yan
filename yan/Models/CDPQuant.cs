using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.Models
{
    public class CDPQuant
    {
        public DateTime LogTime { get; set; }
        public string ReplicationId { get; set; }
        public Guid SourceConnectionId { get; set; }
        public Guid TargetConnectionId { get; set; }
        public DateTime TimestampUTC { get; set; }
        public DateTime LastResetTimeUTC { get; set; }
        public long LongIntervalTotalTransferBytes { get; set; }
        public long LongTermPeriodTransferredBytes { get; set; }
        public long CurrentMicrosnapDurationMillisec { get; set; }
        public long CurrentMicrosnapIncomingSizeBytes { get; set; }
        public long CurrentTransferredBytes { get; set; }
        public int LastCleanTrafficMicrosnapAgeMillisec { get; set; }
        public int MicrosnapAvgLifetimeMillisec { get; set; }
        public int MicrosnapMaxLifetimeMillisec { get; set; }
        public long MicrosnapAvgSizeBytes { get; set; }
        public long MicrosnapMaxSizeBytes { get; set; }
        public long MaxTransferredBytes { get; set; }
        public int ConfirmedDirty { get; set; }
        public int ConfirmedError { get; set; }
        public int ConfirmedLate { get; set; }
        public int ConfirmedOnTime { get; set; }
        public int RequiredBandwith { get; set; }
        public int Rpo { get; set; }
        public int NotConfirmedDirty { get; set; }
        public int NotConfirmedError { get; set; }
        public int NotConfirmedLate { get; set; }
        public int NotConfirmedOnTime { get; set; }
        public int FirstSyncProgress { get; set; }
        public string Bottleneck { get; set; }
    }
}
