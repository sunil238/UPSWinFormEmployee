using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using EmployeeDetails.Interface;
using EmployeeDetails.Model;

namespace EmployeeDetails.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _client;
        public EmployeeService(HttpClient client)
        {
            _client = client;
            // Add bearer token
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.API_Key);
        }
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<bool> AddEmployee(Employee employee)
        {
            //Serialize the employee object to JSON
            string json = JsonConvert.SerializeObject(employee).ToString();
            //Add the employee to the RESTful service
            var response = await _client.PostAsync(Config.Uri, new StringContent(json, Encoding.UTF8, "application/json"));

            //Check if the employee was added successfully
            return response.IsSuccessStatusCode;
        }
        /// <summary>
        /// List of all users 
        /// </summary>
        /// <returns></returns>
        public async Task<List<Employee>> GetEmployees()
        {

            //Get the list of employees from the RESTful service
            var response = await _client.GetAsync(Config.Uri);

            //Deserialize the JSON response to a list of Employee objects
            var employees = JsonConvert.DeserializeObject<List<Employee>>(await response.Content.ReadAsStringAsync());

            return employees;
        }
        /// <summary>
        /// Get deatils of an existing user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeData(int id)
        {
            // Fetch employee details by passing user id
            var response = await _client.GetAsync(Config.Uri + $"/{id}");
            Employee? employee = null;
            if (response.IsSuccessStatusCode)
            {
                 employee = JsonConvert.DeserializeObject<Employee>(await response.Content.ReadAsStringAsync());
               
            }
            return employee ?? new Employee();
        }

        /// <summary>
        /// Get Existing user by Name
        /// </summary>
        /// <param name="searchtext"></param>
        /// <returns></returns>
        public async Task<List<Employee>> FetchEmployeesDataByName(string searchtext)
        {

            // Fetch employee details by passing user first name
            var response = await _client.GetAsync(Config.Uri + $"?name={searchtext}");

            if (response.IsSuccessStatusCode)
            {
                var employee = JsonConvert.DeserializeObject<List<Employee>>(await response.Content.ReadAsStringAsync());
                return employee;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Remove existing user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> RemoveUser(int id)
        {
            var response = await _client.DeleteAsync(Config.Uri + $"/{id}");
            return response.IsSuccessStatusCode;
        }
        /// <summary>
        /// Export the file into Local Directory
        /// </summary>
        /// <param name="dataGridView"></param>
        public bool ExportDataGridViewToCSV(DataGridView dataGridView)
        {
            bool isexported = true;
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sb.Append(dataGridView.Columns[i].HeaderText + ",");
                }
                sb.Append(Environment.NewLine);
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        sb.Append(dataGridView.Rows[i].Cells[j].Value.ToString() + ",");
                    }
                    sb.Append(Environment.NewLine);
                }
                if (!Directory.Exists(Config.ExportLocation))
                {
                    Directory.CreateDirectory(Config.ExportLocation);
                }
                File.WriteAllText(Config.ExportLocation + @"\dataGridView.csv", sb.ToString());
                return isexported;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
