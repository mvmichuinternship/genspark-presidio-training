using ClinicTrackerModelLibrary;

namespace ClinicAppBlLibrary
{
    public interface IClinicalServices 
    {
        Appointment AddNewAppointment(Appointment item);
        Appointment CancelAppointment(Appointment item);
        Appointment GetAppointmentDetails(Appointment item);
        Appointment SortAppointmentBasedOnDate(Appointment item);
       

    }
}
