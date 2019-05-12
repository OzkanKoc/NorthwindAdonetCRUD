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
    class OrderDataMapper
    {
        public Order Get(int id)
        {
            const string queryText = "select * from Orders where OrderID=@orderId";
            var order = default(Order);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                dbCommand.Parameters.AddWithValue("@orderId", id);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        order = MapToEntity(dataReader);
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
            return order;
        }

        private static Order MapToEntity(SqlDataReader dataReader)
        {
            return new Order
            {
                Id = (int)dataReader["OrderID"],
                CustomerId = dataReader["CustomerID"] as string,
                EmployeeId = dataReader["EmployeeID"] as int?,
                RequiredDate = dataReader["RequiredDate"] as DateTime?,
                ShippedDate = dataReader["ShippedDate"] as DateTime?,
                OrderDate = dataReader["OrderDate"] as DateTime?,
                ShipVia = dataReader["ShipVia"] as int?,
                ShipAddress = dataReader["ShipAddress"] as string,
                ShipCity = dataReader["ShipCity"] as string,
                ShipCountry = dataReader["ShipCountry"] as string,
                ShipName = dataReader["ShipName"] as string,
                ShipPostalCode = dataReader["ShipPostalCode"] as string,
                ShipRegion = dataReader["ShipRegion"] as string,
                Freight = dataReader["Freight"] as decimal?
            };
        }

        public List<Order> GetAll()
        {
            var commandQuery = "select * from Orders";
            var orderList = new List<Order>();
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandQuery);

                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        orderList.Add(MapToEntity(dataReader));
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

            return orderList;
        }

        public void Insert(Order order)
        {
            const string commandText = @"
                                        insert into Orders
                                        values(
                                                @CustomerID,
                                                @EmployeeID,
                                                @OrderDate,
                                                @RequiredDate,
                                                @ShippedDate,
                                                @ShipVia,
                                                @Freight,
                                                @ShipName,
                                                @ShipAddress,
                                                @ShipCity,
                                                @ShipRegion,
                                                @ShipPostalCode,
                                                @ShipCountry
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@CustomerID", order.CustomerId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@EmployeeID", order.EmployeeId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@RequiredDate", order.RequiredDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShippedDate", order.ShippedDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipVia", order.ShipVia ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Freight", order.Freight ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipName", order.ShipName ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipAddress", order.ShipAddress ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipCity", order.ShipCity ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipRegion", order.ShipRegion ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipPostalCode", order.ShipPostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipCountry", order.ShipCountry ?? (object)DBNull.Value);

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

        public void Update(Order order)
        {
            const string commandText = @"update Orders
                                          set CustpmerID= @CustomerID,
                                                EmployeeID=@EmployeeID,
                                                OrderDate=@OrderDate,
                                                RequiredDate=@RequiredDate,
                                                ShippedDate=@ShippedDate,
                                                ShipVia=@ShipVia,
                                                Freight=@Freight,
                                                ShipName=@ShipName,
                                                ShipAddress=@ShipAddress,
                                                ShipCity=@ShipCity,
                                                ShipRegion=@ShipRegion,
                                                ShipPostalCode=@ShipPostalCode,
                                                ShipCountry=@ShipCountry
                                          where OrderID=@OrderID";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@OrderID", order.Id);
                dbCommand.Parameters.AddWithValue("@CustomerID", order.CustomerId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@EmployeeID", order.EmployeeId ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@RequiredDate", order.RequiredDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShippedDate", order.ShippedDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipVia", order.ShipVia ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Freight", order.Freight ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipName", order.ShipName ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipAddress", order.ShipAddress ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipCity", order.ShipCity ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipRegion", order.ShipRegion ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipPostalCode", order.ShipPostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ShipCountry", order.ShipCountry ?? (object)DBNull.Value);

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

        public void Delete(int orderId)
        {
            const string commandText = "delete from Orders where OrderID=@OrderID";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@OrderID", orderId);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
