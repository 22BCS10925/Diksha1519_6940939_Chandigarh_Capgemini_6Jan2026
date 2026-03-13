using System.Text.RegularExpressions;

namespace InvoiceNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string invoiceNumber = "CAP-123";
            int increment = 7;

            // Regex pattern to capture numeric part
            string pattern = @"CAP-(\d+)";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(invoiceNumber);

            if (match.Success)
            {
                // Extract numeric part
                int currentNumber = int.Parse(match.Groups[1].Value);

                // Update number
                int updatedNumber = currentNumber + increment;

                // Replace old number with updated number
                string updatedInvoice =
                    regex.Replace(invoiceNumber, "CAP-" + updatedNumber);

                // Output
                Console.WriteLine("Updated Invoice Number: " + updatedInvoice);
            }
            else
            {
                Console.WriteLine("Invalid Invoice Format");
            }
        }
    }

}
