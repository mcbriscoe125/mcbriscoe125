using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Calculate Kinetic Energy      

            int mass = 73;
            int velocity = 54;

            Console.WriteLine($"The kinetic energy of mass {mass} and velocity {velocity} is: {KineticEnrgy(mass, velocity)} ");

            static double KineticEnrgy(int num1, int num2)
            {
                double kenergy = ((num1 * 0.5) * (num2 * num2));
                return kenergy;
            }
        }
    }
}
