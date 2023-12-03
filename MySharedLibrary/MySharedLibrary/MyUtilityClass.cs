// MySharedLibrary project

using System;

namespace MySharedLibrary
{
    public class MyUtilityClass
    {
        public static bool ValidateData(string data)
        {
            // Implement data validation logic
            return !string.IsNullOrEmpty(data);
        }

        public static void LogMessage(string message)
        {
            // Implement logging logic
            Console.WriteLine($"Log: {message}");
        }

        // Add more utility methods as needed
    }
}
