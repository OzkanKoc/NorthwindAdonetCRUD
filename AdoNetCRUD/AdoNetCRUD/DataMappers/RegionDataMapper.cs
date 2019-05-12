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
    class RegionDataMapper
    {
        public Region Get(int id)
        {
            const string queryText = "select * from Region where RegionID=@regionId";
            var region = default(Region);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                dbCommand.Parameters.AddWithValue("@regionId", id);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        region = MapToEntity(dataReader);
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
            return region;
        }

        private static Region MapToEntity(SqlDataReader dataReader)
        {
            return new Region
            {
                Id = (int)dataReader["RegionID"],
                RegionDescription = dataReader["RegionDescription"] as string
            };
        }

        public List<Region> GetAll()
        {
            var commandQuery = "select * from Region";
            var regionList = new List<Region>();
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandQuery);

                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        regionList.Add(MapToEntity(dataReader));
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dbCommand?.Connection?.Dispose();
                dbCommand?.Dispose();
            }

            return regionList;
        }

        public void Insert(Region region)
        {
            const string commandText = @"
                                        insert into Region
                                        values(
                                                @regionId,
                                                @regionDescriotion
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@regionId", GetLastID(region) + 1);
                dbCommand.Parameters.AddWithValue("@regionDescriotion", region.RegionDescription ?? (object)DBNull.Value);

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

        private int GetLastID(Region region)
        {
            const string commandText = "SELECT max(RegionID) FROM Region";

            var dbCommand = DbHelper.CreateCommand(commandText);

            return Convert.ToInt32(dbCommand.ExecuteScalar());
        }

        public void Update(Region region)
        {
            const string commandText = @"update Region
                                          set RegionDescription=@regionDescription
                                          where RegionID=@regionId";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@regionId", region.Id);
                dbCommand.Parameters.AddWithValue("@regionDescription", region.RegionDescription);

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

        public void Delete(int regionId)
        {
            const string commandText = "delete from Region where RegionId=@regionId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@regionId", regionId);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
