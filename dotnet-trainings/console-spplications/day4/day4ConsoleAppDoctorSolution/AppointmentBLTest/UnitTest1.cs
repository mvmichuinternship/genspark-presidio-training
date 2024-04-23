using ClinicAppBlLibrary;
using ClinicAppDalLibrary;
using ClinicTrackerModelLibrary;

namespace AppointmentBLTest
{
    public class Tests
    {
        IRepository<int, Appointment> repository;
        IClinicalServices appointmentService;
        [SetUp]
        public void Setup()
        {
            repository = new AppointmentRepository();
            Appointment appointment = new Appointment() {Date = Convert.ToDateTime("12-04-2024"), PatientName="mv"};
            repository.Add(appointment);
            appointmentService = new ClinicalServiceBL(repository);
        }

        /// <summary>
        /// Get apointment testing
        /// </summary>

        [Test]
        public void GetAppointmentTest()
        {
            var appt = appointmentService.GetAppointmentDetails(1);
            Assert.IsNotNull(appt);
            Assert.AreEqual(1,appt.AppId);
        }
        [Test]
        public void GetAppointmentFailureTest()
        {
            var appt = appointmentService.GetAppointmentDetails(1);
            Assert.IsNull(appt);
            Assert.AreNotEqual(1,appt.AppId);
        }
        [Test]
            public void GetAppointmentExceptionTest()
            {
            var exception = Assert.Throws<AppointmentNotFoundException>(() => appointmentService.GetAppointmentDetails(2));
            Assert.AreEqual("Appointment not found", exception.Message);
        }


        /// <summary>
        /// Add Appointment testing
        /// </summary>

        [Test]
        public void AddAppointmentTest()
        {
            Appointment appointment = new Appointment() { Date = Convert.ToDateTime("13-04-2024"), PatientName = "vk" };
            var appt = appointmentService.AddNewAppointment(appointment);
            Assert.IsNotNull(appt);
            Assert.AreEqual(2, appt.AppId);
        }
        [Test]
        public void AddAppointmentFailureTest()
        {
            Appointment appointment = new Appointment() { Date = Convert.ToDateTime("13-04-2024"), PatientName = "vk" };
            var appt = appointmentService.AddNewAppointment(appointment);
            Assert.IsNull(appt);
            Assert.AreNotEqual(1, appt.AppId);
        }
        [Test]
        public void AddAppointmentExceptionTest()
        {
            Appointment appointment = new Appointment() { Date = Convert.ToDateTime("12-04-2024"), PatientName = "vk" };
            var exception = Assert.Throws<DuplicateTimeException>(() => appointmentService.AddNewAppointment(appointment));
            Assert.AreEqual("The time has already been scheduled", exception.Message);
        }

        /// <summary>
        /// Delete appointment testing
        /// </summary>

        [Test]
        public void DeleteAppointmentTest()
        {
            var appt = appointmentService.CancelAppointment(1);
            Assert.IsNotNull(appt);
        }
        [Test]
        public void DeleteAppointmentFailureTest()
        {
            var appt = appointmentService.CancelAppointment(1);
            Assert.IsNull(appt);
        }
        [Test]
        public void DeleteAppointmentExceptionTest()
        {
            var exception = Assert.Throws<AppointmentDeleteFailedException>(() => appointmentService.CancelAppointment(2));
            Assert.AreEqual("Faild to delete appointment", exception.Message);
        }


    }
}