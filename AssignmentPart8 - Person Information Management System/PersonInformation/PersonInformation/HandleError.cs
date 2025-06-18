
namespace PersonInformation.Utilities {
    public static class HandleError {
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
