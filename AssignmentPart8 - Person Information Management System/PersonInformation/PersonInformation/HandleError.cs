using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformation.Utilities {
    public static class HandleError {
        public static void RunWithValidation(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex) when
                (ex is ArgumentNullException ||
                ex is FormatException ||
                ex is OverflowException ||
                ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
