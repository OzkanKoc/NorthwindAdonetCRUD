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
    class OrderDetailDataMapper
    {

        public List<OrderDetail> Get(int orderId)
        {
            var orderDetailsList = new List<OrderDetail>();
            const string commandText = "select * from [Order Details] where OrderID=@orderId";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@orderId", orderId);

                var dataReader = dbCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    orderDetailsList.Add(MapToEntity(dataReader));
                }
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

            return orderDetailsList;
        }
        public void Insert(OrderDetail orderDetail)
        {
            const string commandText = @"
                                        insert into [Order Details]
                                        values(
                                                @OrderID,
                                                @ProductID,
                                                @UnitPrice,
                                                @Quantity,
                                                @Discount
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@OrderID", orderDetail.OrderId);
                dbCommand.Parameters.AddWithValue("@ProductID", orderDetail.ProductId);
                dbCommand.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
                dbCommand.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                dbCommand.Parameters.AddWithValue("@Discount", orderDetail.Discount);
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

        public void Update(OrderDetail orderDetail)
        {
            const string commandText = @"update [Order Details]
                                          set UnitPrice=@UnitPrice,
                                                Quantity=@Quantity,
                                                Discount=@Discount
                                          where OrderID=@OrderID and ProductID=@ProductID";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@OrderID", orderDetail.OrderId);
                dbCommand.Parameters.AddWithValue("@ProductID", orderDetail.ProductId);
                dbCommand.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
                dbCommand.Parameters.AddWithValue("@Discount", orderDetail.Quantity);
                dbCommand.Parameters.AddWithValue("@Quantity", orderDetail.Discount);

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
            const string commandText = "delete from [Order Details] where OrderID=@OrderID";
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
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }
        }
        private static OrderDetail MapToEntity(SqlDataReader dataReader)
        {
            return new OrderDetail
            {
                ProductId = (int)dataReader["ProductID"],
                OrderId = (int)dataReader["OrderID"],
                UnitPrice = (decimal)dataReader["UnitPrice"],
                Quantity = (short)dataReader["Quantity"],
                Discount = (float)dataReader["Discount"]
            };
        }
    }
}
