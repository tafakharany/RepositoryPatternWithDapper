using Dapper;
using RepositoryPatternWithDapper.Infrastructure;
using RepositoryPatternWithDapper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithDapper.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool DeleteProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            using (IDbConnection db = new SqlConnection(AppConnection.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Product>("select * from Products", CommandType.Text);
            }
        }

        public bool InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
