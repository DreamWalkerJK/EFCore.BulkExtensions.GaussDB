using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.BulkExtensions.GaussDB.Extensions
{
    public static class BulkConfigExtensions
    {
        public static BulkConfig UseGaussDB(this BulkConfig config)
        {
            return config;
        }
    }
}
