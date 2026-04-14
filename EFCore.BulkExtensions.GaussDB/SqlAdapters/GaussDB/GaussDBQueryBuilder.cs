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

        #region DDL
        public static string DropTableUseCascade(string tableName, bool isCascadeDelete = false)
        {
            var sql = string.Empty;

            if (isCascadeDelete)
            {
                sql = $"DROP TABLE IF EXISTS {tableName} CASCADE CONSTRAINTS PURGE";
            }
            else
            {
                sql = $"DROP TABLE IF EXISTS {tableName} PURGE";
            }

            return sql;
        }

        /// <summary>
        /// Drop会删除表的结构及其数据，和该表相关的索引、触发器和权限
        /// 在Navicat中实验使用DROP [TEMPORARY] TABLE报错，故直接去除isTempTable操作
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="isTempTable"></param>
        /// <returns></returns>
        public override string DropTable(string tableName, bool isTempTable) => DropTableUseCascade(tableName);
        #endregion
    }
}
