using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proto.Models;


namespace proto.Data
{
    public class DbInitializer
    {
        public static void Initialize(CDPContext context)
        {
            context.Database.EnsureCreated();
            //if (context.CDPQuants.Any())
            //{
            //    return;   // DB has been seeded
            //}
            
            //context.CDPQuants.Add(new CDPQuant
            //{
            //    LogTime = DateTime.Parse("2021-03-09 14:19:23.000"),
            //    ReplicationId = "ReplicationID_500b815b-7f0d-44e4-3c7d-8dbdefcae99c_6000c292-da38-c46d-93e1-6ea38504e380",
            //    SourceConnectionId = new Guid("72C75AA1-2F4E-4484-AAA1-CE13A7AC8891"),
            //    TargetConnectionId = new Guid("CB185A23-68EF-4FED-B921-CC7CCD659932"),
            //    TimestampUTC = DateTime.Parse("2021-03-09 13:19:23.163"),
            //    LastResetTimeUTC = DateTime.Parse("2021-03-09 13:19:04.937"),
            //    LongIntervalTotalTransferBytes = 125829120,
            //    LongTermPeriodTransferredBytes = 125829120,
            //    CurrentMicrosnapDurationMillisec = 300000,
            //    CurrentMicrosnapIncomingSizeBytes = 114294784,
            //    CurrentTransferredBytes = 114294784,
            //    LastCleanTrafficMicrosnapAgeMillisec = 0,
            //    MicrosnapAvgLifetimeMillisec = 6128,
            //    MicrosnapMaxLifetimeMillisec = 6128,
            //    MicrosnapAvgSizeBytes = 116391936,
            //    MicrosnapMaxSizeBytes = 125829120,
            //    MaxTransferredBytes = 125829120,
            //    ConfirmedDirty = 1,
            //    ConfirmedError = 0,
            //    ConfirmedLate = 0,
            //    ConfirmedOnTime = 0,
            //    RequiredBandwith = 38449,
            //    Rpo = 600,
            //    NotConfirmedDirty = 0,
            //    NotConfirmedError = 0,
            //    NotConfirmedLate = 0,
            //    NotConfirmedOnTime = 0,
            //    FirstSyncProgress = 0,
            //    Bottleneck = @"<Bottleneck><OutputArguments><srcProxyRecv value=""10""/><trgProxySend value=""100""/><trgDaemonRecv value=""100""/><trgDaemonWrite value=""1""/></OutputArguments></Bottleneck>"
            //}); 

            context.SaveChanges();

        }
    }
}
