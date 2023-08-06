namespace crudApp.Models
{
    public static class Repository
    {
        private static List<Employee> allEmployee = new List<Employee>();
        public static IEnumerable<Employee> AllEmployee
        {
            get { return allEmployee; } 
        }
        public static void AddEmployee(Employee employee)
        {
            allEmployee.Add(employee);
        }
        public static void Delete(Employee employee)
        {
            allEmployee.Remove(employee);
        }

    }
}
