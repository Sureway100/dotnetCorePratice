namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository() 
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){
                Id = 1,
                Name = "May",
                Email = "May@gmail.com",
                Department = "HR"
                },
                new Employee(){
                Id = 2,
                Name = "Febuary",
                Email = "Febuary@gmail.com",
                Department = "Admin"
                },
                new Employee(){
                Id = 3,
                Name = "December",
                Email = "December@gmail.com",
                Department = "UIUX"
                }
            };
        }
        public Employee GetEmployee(int id) 
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }
    }
}
