using AdoNetCRUD.Entities;
using AdoNetCRUD.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCRUD.DataMappers
{
    class EmployeeDataMapper
    {
        public Employee Get(int id)
        {
            const string queryText = "select * from Employees where EmployeeID=@employeeId";
            var employee = default(Employee);
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(queryText);
                dbCommand.Parameters.AddWithValue("@employeeId", id);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        employee = MapToEntity(dataReader);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return employee;
        }

        private static Employee MapToEntity(SqlDataReader dataReader)
        {
            return new Employee
            {
                Id = (int)dataReader["EmployeeID"],
                FirstName = dataReader["FirstName"] as string,
                LastName = dataReader["LastName"] as string,
                Title = dataReader["Title"] as string,
                TitleOfCourTesy = dataReader["TitleOfCourTesy"] as string,
                DateOfBirth = dataReader["BirthDate"] as DateTime?,
                HireDate = dataReader["HireDate"] as DateTime?,
                Address = dataReader["Address"] as string,
                City = dataReader["City"] as string,
                Region = dataReader["Region"] as string,
                PostalCode = dataReader["PostalCode"] as string,
                Country = dataReader["Country"] as string,
                HomePhone = dataReader["HomePhone"] as string,
                Extension = dataReader["Extension"] as string,
                Notes = dataReader["Extension"] as string,
                ReportsTo = dataReader["ReportsTo"] as int?
            };
        }

        public List<Employee> GettAll()
        {
            const string commandText = "select * from Employees";

            var employeesList = new List<Employee>();
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                using (var dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        employeesList.Add(MapToEntity(dataReader));
                    }
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

            return employeesList;
        }

        public void Insert(Employee employee)
        {
            const string commandText = @"
                                        insert into Employees
                                        values(
                                                @LastName, @FirstName, @Title,
                                                @TitleOfCourtesy, @BirthDate, @HireDate,
                                                @Address, @City, @Region,
                                                @PostalCode, @Country, @HomePhone,
                                                @Extension, @Photo, @Notes, @ReportsTo,
                                                @PhotoPath
                                                )";

            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                dbCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
                dbCommand.Parameters.AddWithValue("@Title", employee.Title ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourTesy ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@BirthDate", employee.DateOfBirth ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@HireDate", employee.HireDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Address", employee.Address ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@City", employee.City ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Region", employee.Region ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@PostalCode", employee.PostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Country", employee.Country ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@HomePhone", employee.HomePhone ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Extension", employee.Extension ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Notes", employee.Notes ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ReportsTo", employee.ReportsTo == 0 ? (object)DBNull.Value : employee.ReportsTo);
                dbCommand.Parameters.AddWithValue("@Photo", DBNull.Value).DbType = DbType.Binary;
                dbCommand.Parameters.AddWithValue("@PhotoPath", DBNull.Value);


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

        public void Update(Employee employee)
        {
            const string commandText = @"update Employees
                                          set LastName=@LastName, FirstName=@FirstName, Title=@Title,
                                                TitleOfCourtesy=@TitleOfCourtesy, BirthDate=@BirthDate, HireDate=@HireDate,
                                                Address=@Address, City=@City, Region=@Region,
                                                PostalCode=@PostalCode, Country=@Country, HomePhone=@HomePhone,
                                                Extension=@Extension, Notes=@Notes, ReportsTo=@ReportsTo
                                          where EmployeeID=@employeeId";
            var dbCommand = default(SqlCommand);

            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                dbCommand.Parameters.AddWithValue("@FirstName", employee.FirstName ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Title", employee.Title ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourTesy ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@BirthDate", employee.DateOfBirth);
                dbCommand.Parameters.AddWithValue("@HireDate", employee.HireDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Address", employee.Address ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@City", employee.City ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Region", employee.Region ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@PostalCode", employee.PostalCode ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Country", employee.Country ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@HomePhone", employee.HomePhone ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Extension", employee.Extension ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@Notes", employee.Notes ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@ReportsTo", employee.ReportsTo);
                dbCommand.Parameters.AddWithValue("@EmployeeID", employee.Id);

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

        public void Delete(int employeeId)
        {
            const string commandText = "delete from Employees where EmployeeID=@employeeId";
            var dbCommand = default(SqlCommand);
            try
            {
                dbCommand = DbHelper.CreateCommand(commandText);
                dbCommand.Parameters.AddWithValue("@employeeId", employeeId);
                dbCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
