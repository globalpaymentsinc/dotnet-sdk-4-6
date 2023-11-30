﻿using System;
using System.Threading;
using GlobalPayments.Api.Utils;

namespace GlobalPayments.Api.Tests.GpApi {
    public abstract class BaseGpApiTests {
        protected const string Success = "SUCCESS";
        protected const string Declined = "DECLINED";
        protected const string Verified = "VERIFIED";
        protected const string Closed = "CLOSED";

        protected static readonly string AppId = "4gPqnGBkppGYvoE5UX9EWQlotTxGUDbs";
        protected static readonly string AppKey = "FQyJA5VuEQfcji2M";

        protected static readonly string AppIdForMerchant = "A1feRdMmEB6m0Y1aQ65H0bDi9ZeAEB2t";
        protected static readonly string AppKeyForMerchant = "5jPt1OpB6LLitgi7";

        protected static readonly int ExpMonth = DateTime.Now.Month;
        protected static readonly int ExpYear = DateTime.Now.Year + 1;

        protected static readonly DateTime StartDate = DateTime.UtcNow.AddDays(-30);
        protected static readonly DateTime EndDate = DateTime.UtcNow;

        protected string GetMapping<T>(T value, Target target = Target.GP_API) where T : Enum {
            return EnumConverter.GetMapping(target, value);
        }

        protected static void WaitForGpApiReplication() {
            Thread.Sleep(2000);
        }
    }
}