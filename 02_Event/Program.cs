namespace _02_Event
{
    internal class Program
    {
        #region Declaration of a Events
        public static event Action<string> OnMessageReceived; // Declare an event using the built-in Action delegate
        public static void RaiseEvent(string message)
        {
            OnMessageReceived?.Invoke(message); // Raise the event
        }


        #endregion

        static void Main(string[] args)
        {
            #region Events
            /*
             * Events are a way for a class to provide notifications to clients of that class when something of interest occurs.
             */
            OnMessageReceived = (message) => Console.WriteLine($"Event received: {message}"); // Subscribe to the event
            OnMessageReceived += (message) => Console.WriteLine($"Another subscriber received: {message}"); // Subscribe another method to the event
            RaiseEvent("Hello, World!"); // Raise the event



            #endregion

        }
    }
}
