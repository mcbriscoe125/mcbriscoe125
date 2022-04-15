using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Validate Pin

            int passcode1 = 4526;
            int passcode2 = 4568;

            bool pin1 = false;
            pin1 = IsValidPin(passcode1);

            bool pin2 = false;
            pin2 = IsValidPin(passcode2);

                if (SamePin(passcode1, passcode2))
                {
                    Console.WriteLine($"{passcode1} is the same as {passcode2}");
                }
                else
                {
                    Console.WriteLine($"{passcode1} is not the same as {passcode2}");
                }

                bool SamePin(int pin1, int pin2)
                {
                    bool isSame = false;
                    if (pin1 == pin2)
                    {
                        isSame = true;
                    }
                    else
                    {
                        isSame = false;
                    }
                    return isSame;
                }
            
                bool IsValidPin(int pin)
            {
                bool isValid = false;

                if (pin < 1000)
                {
                    Console.WriteLine($"The pin {pin} is not valid");
                    isValid = false;
                }
                else
                {
                    Console.WriteLine($"The pin {pin} is valid");
                    isValid = true;
                }
                    
                return isValid;
            }
        }
    }
}


