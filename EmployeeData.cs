using EmployeeDetails.Interface;
using EmployeeDetails.Model;

namespace EmployeeDetails
{
    public partial class EmployeeData : Form
    {
        private readonly IEmployeeService _employeeService;
        public List<Employee>? Userdata { get; set; }

        public EmployeeData(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var errorMessage = "Error adding employee!";
            if(txtName.Text.ToString().Length <1)
            {
                errorMessage = errorMessage + "\n" + "Empty Name";
            }
            if (txtEmail.Text.ToString().Length < 1)
            {
                errorMessage = errorMessage + "\n" + "Empty Email";
            }
            if (comboGender.Text.ToString().Length < 1)
            {
                errorMessage = errorMessage + "\n" + "Empty Gender";
            }
            //Create an Employee object with the user input
            Employee employee = new Employee()
            {
                name = txtName.Text,
                email = txtEmail.Text,
                gender = comboGender.Text,
                status = chkActive.Checked ? "Active" : "Inactive"
            };

            //Add the employee to the service
            var success = await _employeeService.AddEmployee(employee);

            if (success)
            {
                MessageBox.Show("Employee added successfully!");
                Userdata = await _employeeService.GetEmployees();
                dgvEmployee.DataSource = Userdata;
                dgvEmployee.Refresh();
                txtEmail.Text = txtName.Text = comboGender.Text = string.Empty;
                pnlAddEmployee.Visible = false;
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private async void EmployeeData_Load(object sender, EventArgs e)
        {
            pnlAddEmployee.Visible = false;

            // Fetch users
            Userdata = await _employeeService.GetEmployees();
            dgvEmployee.DataSource = Userdata;
            dgvEmployee.AutoGenerateColumns = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pnlAddEmployee.Visible)
                pnlAddEmployee.Visible = false;

            else
                pnlAddEmployee.Visible = true;
        }

        private async void btnSearchUser_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchUser.Text;
            bool userExists = true;
            if (searchValue.Length == 0)
            {
                MessageBox.Show("Searh field is blank! Enter user Id or name to search");
                return;
            }
            var isNumeric = int.TryParse(searchValue, out int userid);
            List<Employee> employees = new List<Employee>();
            Employee employee;
            if (isNumeric)
            {
                employee = await _employeeService.GetEmployeeData(userid);
                if (employee.id > 0)
                {
                    employees.Add(employee);
                }
                else
                {
                    userExists = false;
                }
                
            }
            else if (isNumeric == false)
            {
                employees = await _employeeService.FetchEmployeesDataByName(searchValue);
                
            }
            if(userExists == false)
            {
                MessageBox.Show("User does not exist");
                dgvEmployee.DataSource = _employeeService.GetEmployees();
            }
            else
            {
                dgvEmployee.DataSource = employees;
                dgvEmployee.Refresh();
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var success = _employeeService.ExportDataGridViewToCSV(dgvEmployee);
                if (success)
                {
                    MessageBox.Show(@"Data exported on D\Export folder");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnDeleteRow_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvEmployee.SelectedRows;
            if (selectedRows.Count > 0)
            {
                // Display a message box to confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row/s?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Loop through the selected rows and delete them
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        await _employeeService.RemoveUser((int)row.Cells[0].Value);

                    }
                    MessageBox.Show("Employee deleted successfully!");
                    // Reload the gridview after delete.
                    Userdata = await _employeeService.GetEmployees();
                    dgvEmployee.DataSource = Userdata;
                    dgvEmployee.Refresh();
                }
                else
                {
                    // clear selection
                    dgvEmployee.SelectedRows.Clear();
                    return;

                }
            }
            else
            {
                MessageBox.Show("Select a row to delete");
            }
        }

        private void dgvEmployee_MultiSelectChanged(object sender, EventArgs e)
        {
            btnDeleteRow.Enabled = true;
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchUser.Text.Length == 0)
            {
                dgvEmployee.DataSource = Userdata;
                dgvEmployee.Refresh();
            }
        }
    }
}
