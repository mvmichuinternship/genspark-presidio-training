using RefundMngtModelLibrary;

namespace RefundMngtDALLibrary
{
    public class EmployeeRepository : IRepository<int, Employee>
    {
        readonly Dictionary<int, Employee> _employee;
        public EmployeeRepository()
        {
            _employee = new Dictionary<int, Employee>();
        }
        int GenerateId()
        {
            if (_employee.Count == 0)
                return 1;
            int id = _employee.Keys.Max();
            return ++id;
        }
        public Employee Add(Employee item)
        {
            if (_employee.ContainsValue(item))
            {
                return null;
            }
            _employee.Add(GenerateId(), item);
            return item;
        }

        public void Delete(int key)
        {
            if (_employee.ContainsKey(key))
            {
                var department = _employee[key];
                _employee.Remove(key);
            }
            
        }

        public Employee Get(int key)
        {
            return _employee.ContainsKey(key) ? _employee[key] : null;
        }

        public List<Employee> GetAll()
        {
            if (_employee.Count == 0)
                return null;
            return _employee.Values.ToList();
        }

        public Employee Update(Employee item)
        {
            if (_employee.ContainsKey(item.Id))
            {
                _employee[item.Id] = item;
                return item;
            }
            return null;
        }
    }
    }
