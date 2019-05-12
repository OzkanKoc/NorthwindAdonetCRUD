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
    class TerritoryDataMapper
    {
        public Territory Get(string id)
        {
            const string commandText = "select * from Territories where TerritoryID = @id";
            var territory = default(Territory);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@id", id ?? (object)DBNull.Value);

                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        territory = new Territory
                        {
                            Id = (string)dataReader["TerritoryID"],
                            TerritoryDescription = (string)dataReader["TerritoryDescription"],
                            RegionID = (int)dataReader["RegionID"]
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

            return territory;
        }
        public List<Territory> GetAll()
        {
            const string queryText = "select * from Territories";
            var territoryList = new List<Territory>();
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        territoryList.Add(new Territory()
                        {
                            Id = (string)dataReader["territoryID"],
                            TerritoryDescription = (string)dataReader["territoryDescription"],
                            RegionID = (int)dataReader["regionID"]
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
            return territoryList;
        }
        public void Insert(Territory territory)
        {
            const string commandText = @"insert into Territories values (
@TerritoryId,
@TerritoryDescription,@RegionId)";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@TerritoryId", territory.Id);
                dbCommand.Parameters.AddWithValue("@TerritoryDescription", territory.TerritoryDescription);
                dbCommand.Parameters.AddWithValue("@RegionId", territory.RegionID);

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
        public void Update(Territory territory)
        {
            const string commandText = @"update Territories set TerritoryId=@territoryId,
                                                               TerritoryDescription=@territoryDescription
                                                                RegionId=@regionId
                                         where territoryId=@territoryId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@TerritoryId", territory.Id);
                dbCommand.Parameters.AddWithValue("@TerritoryDescription", territory.TerritoryDescription);
                dbCommand.Parameters.AddWithValue("@RegionId", territory.RegionID);
                dbCommand.ExecuteNonQuery();
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

        }
        public void Delete(string ID)
        {
            const string commandText = "delete from Territories where territoryId=@ID";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@ID", ID);

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
