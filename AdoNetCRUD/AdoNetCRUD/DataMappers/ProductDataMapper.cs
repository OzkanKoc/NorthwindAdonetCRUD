using AdoNetCRUD.Entities;
using AdoNetCRUD.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCRUD.DataMappers
{
    public class ProductDataMapper
    {
        public Product Get(int id)
        {
            const string queryText = "select * from Products where ProductID=@productId";
            var product = default(Product);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                dbCommand.Parameters.AddWithValue("@productId", id);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        product = MapToEntity(dataReader);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return product;
        }

        private static Product MapToEntity(SqlDataReader dataReader)
        {
            return new Product
            {
                Id = (int)dataReader["ProductID"],
                ProductName = dataReader["ProductName"] as string,
                CategoryId = dataReader["CategoryID"] as int?,
                SupplierId = dataReader["SupplierID"] as int?,
                QuantityPerUnit = dataReader["QuantityPerUnit"] as string,
                UnitPrice = dataReader["UnitPrice"] as decimal?,
                UnitsInStock = dataReader["UnitsInStock"] as short?,
                UnitsOnOrder = dataReader["UnitsOnOrder"] as short?,
                ReorderLevel = dataReader["ReorderLevel"] as short?,
                Discontinued = (bool)dataReader["Discontinued"]
            };
        }

        public List<Product> GettAll()
        {
            const string commandText = "select * from Products";

            var productList = new List<Product>();
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        productList.Add(MapToEntity(dataReader));
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }

            return productList;
        }

        public void Insert(Product product)
        {
            const string commandText = @"
                                        insert into Products
                                        values(
                                                @productName, @supplierId, @categoryId,
                                                @quantityPerUnit, @unitPrice, @unitsInStock,
                                                @unitsOnOrder, @reorderLevel, @discontinued
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@productName", product.ProductName);
                dbCommand.Parameters.AddWithValue("@supplierId", product.SupplierId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@categoryId", product.CategoryId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@discontinued", product.Discontinued);

                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new MemberAccessException();
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }
        }

        public void Update(Product product)
        {
            const string commandText = @"update Products
                                          set ProductName=@productName, SupplierID=@supplierId, 
                                                CategoryID=@categoryId,
                                                QuantityPerUnit=@quantityPerUnit, 
                                                UnitPrice=@unitPrice, UnitsInStock=@unitsInStock,
                                                UnitsOnOrder=@unitsOnOrder, 
                                                ReorderLevel=@reorderLevel, 
                                                Discontinued=@discontinued
                                          where ProductID=@ProductID";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@productName", product.ProductName);
                dbCommand.Parameters.AddWithValue("@supplierId", product.SupplierId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@categoryId", product.CategoryId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@discontinued", product.Discontinued);
                dbCommand.Parameters.AddWithValue("@ProductID", product.Id);

                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Updating Operation..");
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }
        }

        public void Delete(int productId)
        {
            const string commandText = "delete from Products where ProductID=@productId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@productId", productId);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
