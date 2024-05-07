using ClinicTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBlLibrary
{
    public interface IDoctor
    {
        Doctor AddDoctor(Doctor doctor);
        Doctor DeleteDoctor(int id);
        Doctor GetDoctor(int id);
        Doctor UpdateDoctor(Doctor doctor); 
    }
}
