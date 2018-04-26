namespace Singleton
{
    /// <summary>
    /// Singleton Class.
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;

        /// <summary>
        /// Creates a new instance of the Singleton class.
        /// </summary>
        private Singleton()
        {
            // Make this constructor protected if you want to extend this class.
        }

        public static Singleton Instance()
        {
            // Lazy initialization.
            // Not thread safe.
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
