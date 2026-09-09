using System;

namespace ExceptionHandlingExercise
{
    // Custom exception class for invalid time components
    public class InvalidTimeException : Exception
    {
        public InvalidTimeException(string message) : base(message) { }
    }

    public class Time
    {
        // Data members
        private int hours;
        private int minutes;
        private int seconds;

        // Function to accept and validate time inputs
        public void GetTime()
        {
            Console.Write("Enter Hours (1-12): ");
            int h = Convert.ToInt32(Console.ReadLine());
            if (h < 1 || h > 12)
            {
                throw new InvalidTimeException("Invalid hour! Value must be between 1 and 12.");
            }

            Console.Write("Enter Minutes (0-59): ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m < 0 || m > 59)
            {
                throw new InvalidTimeException("Invalid minute! Value must be between 0 and 59.");
            }

            Console.Write("Enter Seconds (0-59): ");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s < 0 || s > 59)
            {
                throw new InvalidTimeException("Invalid second! Value must be between 0 and 59.");
            }

            // Assign values if all inputs are valid
            hours = h;
            minutes = m;
            seconds = s;
        }

        // Function to display the formatted time
        public void DisplayTime()
        {
            // Formats integers with leading zeros (HH:MM:SS)
            Console.WriteLine($"The time is: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time();

            try
            {
                t.GetTime();
                t.DisplayTime();
            }
            catch (InvalidTimeException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception caught: Invalid input format! Please enter numeric digits only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.ReadLine(); // Keeps the console open
        }
    }
}
