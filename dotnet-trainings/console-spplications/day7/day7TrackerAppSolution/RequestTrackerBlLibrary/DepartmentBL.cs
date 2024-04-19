using RequestTrackerAppModel;
using RequestTrackerBLLibrary;
using RequestTrackerDalLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBlLibrary
{
    public class DepartmentBL : IDepartmentService
    {
        readonly IRepository<int, Department> _departmentRepository;
        public DepartmentBL()
        {
            _departmentRepository = new DepartmentRepository();
        }
        public int AddDepartment(Department department)
        {
            var result = _departmentRepository.Add(department);

            if (result != null)
            {
                return result.Id;
            }
            throw new DuplicateDepartmentNameException();
        }

        public Department ChangeDepartmentName(string departmentOldName, string departmentNewName)
        {
            if(departmentOldName==departmentNewName)
            {
                throw new DuplicateDepartmentNameException();
            }
            Department dept = GetDepartmentByName(departmentOldName);
            dept=_departmentRepository.Update(dept);
            if (dept != null)
            {
                return dept;
            }
            throw new NewDepartmentNotFoundException();
        }

        public Department GetDepartmentById(int id)
        {
            var result = _departmentRepository.Get(id);

            if (result != null)
            {
                return result;
            }
            throw new DepartmentNotFoundException();
        }

        public Department GetDepartmentByName(string departmentName)
        {
            List<Department> deptList = new List<Department>();
            deptList= _departmentRepository.GetAll();
            foreach (Department department in deptList) { 
                if(department.Name==departmentName)
                {
                    return department;
                }
                }
            
            throw new DepartmentNotFoundException();

        }

        public int GetDepartmentHeadId(int departmentId)
        {
            List<Department> deptList = new List<Department>();
            deptList = _departmentRepository.GetAll();
            foreach (Department department in deptList)
            {
                if (department.Department_Head == departmentId)
                {
                    return department.Department_Head;
                }
            }

            throw new DepartmentHeadNotFoundException();
        }
    }
}
