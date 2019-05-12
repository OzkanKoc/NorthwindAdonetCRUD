using AdoNetCRUD.Entities;
using AdoNetCRUD.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCRUD.DataMappers
{
    class ShipperDataMapper
    {
        public Shipper Get(int id)
        {
            const string commandText = "select * from Shippers where ShipperID = @id";

            var shipper = default(Shipper);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@id", id);

                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        shipper = new Shipper
                        {
                            ShipperID = (int)dataReader["ShipperID"],
                            CompanyName = (string)dataReader["CompanyName"],
                            Phone = (string)dataReader["Phone"]
                        };
                    }
                }
            }
            catch (Exception)
            {
                // TODO: Loglama yapılacak
                throw;
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }

            return shipper;
        }
        public List<Shipper> GetAll()
        {
            const string queryText = "select * from Shippers";
            var shipperList = new List<Shipper>();
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        shipperList.Add(new Shipper
                        {
                            ShipperID = (int)dataReader["ShipperID"],
                            CompanyName = (string)dataReader["CompanyName"],
                            Phone = dataReader["Phone"] as string
                        });
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
            return shipperList;
        }
        public void Insert(Shipper shipper)
        {
            const string commandText = @"insert into Shippers values (
                                                                @companyName,
                                                                @phone)";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@companyName", shipper.CompanyName);
                dbCommand.Parameters.AddWithValue("@phone", shipper.Phone);

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
        public void Update(Shipper shipper)
        {
            const string commandText = @"update Shippers set CompanyName=@CompanyName,
                                            Phone=@Phone where ShipperId=@ShipperId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@ShipperId", shipper.ShipperID);
                dbCommand.Parameters.AddWithValue("@CompanyName", shipper.CompanyName);
                dbCommand.Parameters.AddWithValue("@Phone", shipper.Phone);
                dbCommand.ExecuteNonQuery();
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
        }
        public void Delete(int id)
        {
            const string commandText = "delete from shippers where shipperId=@id";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@id", id);

                dbCommand.ExecuteNonQuery();
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
        }
    }
}
