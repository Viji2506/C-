using System;

namespace DelegateExercise
{
    // Define the delegate outside the class as requested
    public delegate void TrafficDel();

    public class TrafficSignal
    {
        // 1. Method for Yellow Light
        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }

        // 2. Method for Green Light
        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }

        // 3. Method for Red Light
        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }

        // Array to store delegates
        private TrafficDel[] signalArray;

        // 4. Method to initialize the delegate array with the methods
        public void IdentifySignal()
        {
            signalArray = new TrafficDel[]
            {
                new TrafficDel(Yellow),
                new TrafficDel(Green),
                new TrafficDel(Red)
            };
        }

        // 5. Method to invoke the members of the delegate array
        public void show()
        {
            if (signalArray != null)
            {
                foreach (TrafficDel del in signalArray)
                {
                    del(); // Invoke the delegate method
                }
            }
            else
            {
                Console.WriteLine("Delegate array is not initialized.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the TrafficSignal class
            TrafficSignal traffic = new TrafficSignal();

            // Initialize the delegate array
            traffic.IdentifySignal();

            // Invoke and show the outputs
            traffic.show();

            Console.ReadLine(); // Keeps console open
        }
    }
}