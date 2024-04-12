namespace day4ConsoleAppDoctor
{
    internal class Program
    {
        Doctor CreateDoctor(int id)
        {
            Doctor doctor = new Doctor(id);
            Console.WriteLine("Doctor's Name:");
            doctor.Name=Console.ReadLine();
            Console.WriteLine("Doctor's Age:");
            doctor.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doctor's Exp:");
            doctor.Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doctor's Qualification:");
            doctor.Qualification = Console.ReadLine();
            Console.WriteLine("Doctor's Speciality:");
            doctor.Speciality = Console.ReadLine();
            return doctor;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
           Doctor[] doctors = new Doctor[3];
            for (int i = 0; i < doctors.Length; i++)
            {
                doctors[i] = program.CreateDoctor(1000 + i);
            }
            for (int i = 0; i < doctors.Length; i++)
            {
                doctors[i].PrintDetails();
            }
            for (int i = 0; i < doctors.Length; i++)
            {
                if (doctors[i].Speciality=="neuro")
                {
                    doctors[i].PrintDetails();
                }
            }
        }
    }
}
