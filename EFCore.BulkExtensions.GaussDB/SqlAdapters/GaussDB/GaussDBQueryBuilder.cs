using EFCore.BulkExtensions.SqlAdapters;
using GaussDB;
using GaussDBTypes;
using Npgsql;
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
            return new GaussDBCommand();
        }

        public override DbParameter CreateParameter(string parameterName, object? parameterValue = null)
        {
            return new GaussDBParameter(parameterName, parameterValue);
        }

        public override DbType Dbtype()
        {
            return (DbType)GaussDBDbType.Jsonb;
        }

        public override string RestructureForBatch(string sql, bool isDelete = false)
        {
            throw new NotImplementedException();
        }

        public override void SetDbTypeParam(DbParameter parameter, DbType dbType)
        {
            ((GaussDBParameter)parameter).GaussDBDbType = (GaussDBDbType)dbType;
        }
    }
}
