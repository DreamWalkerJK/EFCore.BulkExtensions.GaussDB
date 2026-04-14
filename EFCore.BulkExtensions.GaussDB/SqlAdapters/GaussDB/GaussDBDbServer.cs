using EFCore.BulkExtensions.SqlAdapters;
using EFCore.BulkExtensions.SqlAdapters.PostgreSql;
using GaussDB.EntityFrameworkCore.PostgreSQL.Metadata;
using GaussDB.EntityFrameworkCore.PostgreSQL.Metadata.Internal;
using Humanizer;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.BulkExtensions.GaussDB.SqlAdapters.GaussDB
{
    public class GaussDBDbServer : IDbServer
    {
        // 后续 fork EFCore.BulkExtensions 试试
        public SqlType Type => SqlType.PostgreSql;

        private GaussDBAdapter _adapter = new();

        public ISqlOperationsAdapter Adapter => _adapter;

        private GaussDBDialect _dialect = new();

        public IQueryBuilderSpecialization Dialect => _dialect;

        private SqlQueryBuilder _queryBuilder = new GaussDBQueryBuilder();

        public SqlQueryBuilder QueryBuilder => _queryBuilder;

        public string ValueGenerationStrategy => GaussDBAnnotationNames.ValueGenerationStrategy;

        public bool PropertyHasIdentity(IAnnotation annotation)
        {
            return (GaussDBValueGenerationStrategy?)annotation.Value == GaussDBValueGenerationStrategy.IdentityByDefaultColumn;
        }
    }
}
