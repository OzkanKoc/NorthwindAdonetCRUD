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
    class CustomerDataMapper
    {
        public Customer Get(string id)
        {
            const string queryText = "select * from Customers where CustomerID=@customerId";
            var customer = default(Customer);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                dbCommand.Parameters.AddWithValue("@customerId", id);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        customer = MapToEntity(dataReader);
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
            return customer;
        }

        private static Customer MapToEntity(SqlDataReader dataReader)
        {
            return new Customer
            {
                Id = (string)dataReader["CustomerID"],
                CompanyName = (string)dataReader["CompanyName"],
                ContactName = dataReader["ContactName"] as string,
                ContactTitle = dataReader["ContactTitle"] as string,
                Address = dataReader["Address"] as string,
                City = dataReader["City"] as string,
                Region = dataReader["Region"] as string,
                PostalCode = dataReader["PostalCode"] as string,
                Country = dataReader["Country"] as string,
                Phone = dataReader["Phone"] as string,
                Fax = dataReader["Fax"] as string
            };
        }

        public List<Customer> GetAll()
        {
            var commandQuery = "select * from Customers";
            var customerList = new List<Customer>();
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandQuery);

                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        customerList.Add(MapToEntity(dataReader));
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

            return customerList;
        }

        public void Insert(Customer customer)
        {
            const string commandText = @"
                                        insert into Customers
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
                                                @fax
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@companyName", customer.CompanyName);
                dbCommand.Parameters.AddWithValue("@contactName", customer.ContactName ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@contactTitle", customer.ContactTitle ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@address", customer.Address ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@city", customer.City ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@region", customer.Region ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@postalCode", customer.PostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@country", customer.Country ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@phone", customer.Phone ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@fax", customer.Fax ?? (object)DBNull.Value);

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

        public void Update(Customer customer)
        {
            const string commandText = @"update Customers
                                          set CompanyName=@companyName,
                                                ContactName=@contactName,
                                                ContactTitle=@contactTitle,
                                                Address=@address,
                                                City=@city,
                                                Region=@region,
                                                PostalCode=@postalCode,
                                                Country=@country,
                                                Phone=@phone,
                                                Fax=@Fax
                                          where CustomerID=@customerId";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@customerId", customer.Id);
                dbCommand.Parameters.AddWithValue("@companyName", customer.CompanyName);
                dbCommand.Parameters.AddWithValue("@contactName", customer.ContactName ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@contactTitle", customer.ContactTitle ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@address", customer.Address ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@city", customer.City ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@region", customer.Region ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@postalCode", customer.PostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@country", customer.Country ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@phone", customer.Phone ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Fax", customer.Fax ?? (object)DBNull.Value);

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

        public void Delete(int customerId)
        {
            const string commandText = "delete from Customers where CustomerID=@customerId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@customerId", customerId);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
