using AdoNetCRUD.DataMappers;
using AdoNetCRUD.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCRUD.Views
{
    public partial class EmployeeEditForm : Form
    {
        private int _employeeId;

        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        public EmployeeEditForm(int employeeId) : this()
        {
            _employeeId = employeeId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = CreateEmployeeByForm();
            var employeeDataMapper = new EmployeeDataMapper();
            if (_employeeId == 0)
            {
                employeeDataMapper.Insert(employee);
            }
            else
            {
                employee.Id = _employeeId;
                employeeDataMapper.Update(employee);
            }
            Dispose();
        }

        private Employee CreateEmployeeByForm()
        {
            return new Employee
            {
                FirstName = txtFirstNane.Text,
                LastName = txtLastName.Text,
                Title = txtTitle.Text,
                TitleOfCourTesy = txtTitleOfCourtesy.Text,
                DateOfBirth = DateTime.TryParse(maskedTxtBirthDate.Text, out DateTime birthDate)
                    ? birthDate
                    : default(DateTime?),
                HireDate = DateTime.TryParse(maskedTxtHireDate.Text, out DateTime hireDate)
                    ? hireDate
                    : default(DateTime?),
                Address = rtxtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone = txtHomePhone.Text,
                Extension = txtExtension.Text,
                Notes = txtNotes.Text,
                ReportsTo = (int?)numTxtReportsTo.Value
            };
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            if (_employeeId != 0)
            {
                EmployeeDataMapper employeeDataMapper = new EmployeeDataMapper();
                var employee = employeeDataMapper.Get(_employeeId);
                FillForm(employee);
            }
        }

        private void FillForm(Employee employee)
        {
            if (employee != null)
            {
                txtCity.Text = employee.City;
                txtCountry.Text = employee.Country;
                txtFirstNane.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtNotes.Text = employee.Notes;
                txtPostalCode.Text = employee.PostalCode;
                txtExtension.Text = employee.Extension;
                txtHomePhone.Text = employee.HomePhone;
                txtTitle.Text = employee.Title;
                txtRegion.Text = employee.Region;
                txtTitleOfCourtesy.Text = employee.TitleOfCourTesy;
                rtxtAddress.Text = employee.Address;
                numTxtReportsTo.Value = employee.ReportsTo.HasValue ? employee.ReportsTo.Value : 0;
                maskedTxtBirthDate.Text = employee.DateOfBirth.Value.ToShortDateString();
                maskedTxtHireDate.Text = employee.HireDate.Value.ToShortDateString();
            }
        }
    }
}
