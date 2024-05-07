using ClinicTrackerModelLibrary;

namespace ClinicAppBlLibrary
{
    public interface IClinicalServices 
    {
        Appointment AddNewAppointment(Appointment item);
        Appointment CancelAppointment(int id);
        Appointment GetAppointmentDetails(int id);
        //Appointment SortAppointmentBasedOnDate(Appointment item);
       

    }
}
