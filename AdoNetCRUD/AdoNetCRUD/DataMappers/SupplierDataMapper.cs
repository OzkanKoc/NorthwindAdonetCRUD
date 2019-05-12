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
    public class SupplierDataMapper
    {
        public Supplier Get(int id)
        {
            const string queryText = "select * from Suppliers where SupplierID=@supplierId";
            var supplier = default(Supplier);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                dbCommand.Parameters.AddWithValue("@supplierId", id);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        supplier = MapToEntity(dataReader);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }
            return supplier;
        }

        private static Supplier MapToEntity(SqlDataReader dataReader)
        {
            return new Supplier
            {
                Id = (int)dataReader["SupplierID"],
                CompanyName = (string)dataReader["CompanyName"],
                ContactName = dataReader["ContactName"] as string,
                ContactTitle = dataReader["ContactTitle"] as string,
                Address = dataReader["Address"] as string,
                City = dataReader["City"] as string,
                Region = dataReader["Region"] as string,
                PostalCode = dataReader["PostalCode"] as string,
                Country = dataReader["Country"] as string,
                Phone = dataReader["Phone"] as string,
                Fax = dataReader["Fax"] as string,
                HomePage = dataReader["HomePage"] as string
            };
        }

        public List<Supplier> GetAll()
        {
            var commandQuery = "select * from Suppliers";
            var supplierList = new List<Supplier>();
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandQuery);

                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        supplierList.Add(MapToEntity(dataReader));
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

            return supplierList;
        }

        public void Insert(Supplier supplier)
        {
            const string commandText = @"
                                        insert into Suppliers
                                        values(
                                                @companyName,
                                                @contactName,
                                                @contactTitle,
                                                @address,
                                                @city,
                                                @region,
                                                @postalCode,
                                                @country,
                                                @phone,
                                                @fax,
                                                @homePage
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@companyName", supplier.CompanyName);
                dbCommand.Parameters.AddWithValue("@contactName", supplier.ContactName ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@contactTitle", supplier.ContactTitle ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@address", supplier.Address ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@city", supplier.City ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@region", supplier.Region ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@postalCode", supplier.PostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@country", supplier.Country ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@phone", supplier.Phone ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@fax", supplier.Fax ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@homePage", supplier.HomePage ?? (object)DBNull.Value);

                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }
        }

        public void Update(Supplier supplier)
        {
            const string commandText = @"update Suppliers
                                          set CompanyName=@companyName,
                                                ContactName=@contactName,
                                                ContactTitle=@contactTitle,
                                                Address=@address,
                                                City=@city,
                                                Region=@region,
                                                PostalCode=@postalCode,
                                                Country=@country,
                                                Phone=@phone,
                                                Fax=@Fax,
                                                HomePage=@homePage
                                          where SupplierID=@supplierId";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@supplierId", supplier.Id);
                dbCommand.Parameters.AddWithValue("@companyName", supplier.CompanyName);
                dbCommand.Parameters.AddWithValue("@contactName", supplier.ContactName ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@contactTitle", supplier.ContactTitle ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@address", supplier.Address ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@city", supplier.City ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@region", supplier.Region ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@postalCode", supplier.PostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@country", supplier.Country ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@phone", supplier.Phone ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Fax", supplier.Fax ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@homePage", supplier.HomePage ?? (object)DBNull.Value);

                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Updating Operation..");
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }
        }

        public void Delete(int supplierId)
        {
            const string commandText = "delete from Suppliers where SupplierID=@supplierId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@supplierId", supplierId);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
