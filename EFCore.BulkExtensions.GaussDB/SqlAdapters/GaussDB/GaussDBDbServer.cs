using EFCore.BulkExtensions.SqlAdapters;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.BulkExtensions.GaussDB.SqlAdapters.GaussDB
{
    public class GaussDBDbServer : IDbServer
    {
        public SqlType Type => throw new NotImplementedException();

        public ISqlOperationsAdapter Adapter => throw new NotImplementedException();

        public IQueryBuilderSpecialization Dialect => throw new NotImplementedException();

        public SqlQueryBuilder QueryBuilder => throw new NotImplementedException();

        public string ValueGenerationStrategy => throw new NotImplementedException();

        public bool PropertyHasIdentity(IAnnotation annotation)
        {
            throw new NotImplementedException();
        }
    }
}
