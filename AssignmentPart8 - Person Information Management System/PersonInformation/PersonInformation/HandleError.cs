namespace PersonInformation.Utilities {
    /// <summary>
    /// Provides utility methods for handling and displaying 
    /// validation errors during execution.
    /// </summary>
    public static class HandleError {
        /// <summary>
        /// Executes the specified action and catches common validation exceptions.
        /// If a <see cref="FormatException"/>, <see cref="OverflowException"/>, 
        /// or <see cref="ArgumentException"/> is thrown,
        /// the exception message is displayed to the console and the 
        /// exception is suppressed.
        /// </summary>
        /// <param name="action">The action to execute.</param>
        /// <remarks>
        /// Any other exceptions not listed will propagate normally.
        /// </remarks>
        public static void RunWithValidation(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex) when
                (ex is FormatException ||
                ex is OverflowException ||
                ex is ArgumentException)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}