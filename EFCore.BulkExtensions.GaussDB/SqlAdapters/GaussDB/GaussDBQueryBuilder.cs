using EFCore.BulkExtensions.SqlAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace EFCore.BulkExtensions.GaussDB.SqlAdapters.GaussDB
{
    public class GaussDBQueryBuilder : SqlQueryBuilder
    {
        public override DbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public override DbParameter CreateParameter(string parameterName, object? parameterValue = null)
        {
            throw new NotImplementedException();
        }

        public override DbType Dbtype()
        {
            throw new NotImplementedException();
        }

        public override string RestructureForBatch(string sql, bool isDelete = false)
        {
            throw new NotImplementedException();
        }

        public override void SetDbTypeParam(DbParameter parameter, DbType dbType)
        {
            throw new NotImplementedException();
        }
    }
}
