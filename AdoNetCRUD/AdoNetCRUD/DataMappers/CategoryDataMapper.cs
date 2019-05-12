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
    public class CategoryDataMapper
    {
        public Category Get(int id)
        {
            const string queryText = "select * from Categories where CategoryId=@categoryId";
            var category = default(Category);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                dbCommand.Parameters.AddWithValue("@categoryId", id);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        category = MapToEntity(dataReader);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return category;
        }

        private static Category MapToEntity(SqlDataReader dataReader)
        {
            return new Category
            {
                Id = (int)dataReader["CategoryID"],
                Description = dataReader["Description"] as string,
                Name = dataReader["CategoryName"] as string
            };
        }

        public List<Category> GetAll()
        {
            const string queryText = "select * from Categories";
            var categoryList = new List<Category>();
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        categoryList.Add(MapToEntity(dataReader));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }

            return categoryList;
        }

        public void Insert(Category category)
        {
            const string commandText = @"
                                        insert into Categories
                                        values(
                                                @categorytName, 
                                                @description,
                                                @picture
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@categorytName", category.Name);
                dbCommand.Parameters.AddWithValue("@description", category.Description ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@picture", DBNull.Value).DbType = System.Data.DbType.Binary;

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

        public void Update(Category category)
        {
            const string commandText = @"update Categories
                                          set CategoryName=@categorytName,
                                              Description=@description
                                          where CategoryID=@categoryId";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@categoryId", category.Id);
                dbCommand.Parameters.AddWithValue("@categorytName", category.Name);
                dbCommand.Parameters.AddWithValue("@description", category.Description ?? (object)DBNull.Value);

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


        public void Delete(int categoryId)
        {
            const string commandText = "delete from Categories where CategoryID=@categoryId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@categoryId", categoryId);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}