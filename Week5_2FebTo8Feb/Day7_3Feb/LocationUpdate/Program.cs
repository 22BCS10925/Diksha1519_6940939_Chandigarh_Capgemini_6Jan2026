using System;
using System.Text.RegularExpressions;

class LocationUpdate
{
    static void Main()
    {
        // Inputs
        string invoiceNumber = "CAP-HYD-1234";
        string newLocation = "BAN";

        // Regex pattern to capture location code
        string pattern = @"CAP-([A-Z]{3})-(\d+)";
        Regex regex = new Regex(pattern);

        Match match = regex.Match(invoiceNumber);

        if (match.Success)
        {
            // Replace only the location code
            string updatedInvoice =
                regex.Replace(invoiceNumber, "CAP-" + newLocation + "-$2");

            // Output
            Console.WriteLine("Updated Invoice Number: " + updatedInvoice);
        }
        else
        {
            Console.WriteLine("Invalid Invoice Format");
        }
    }
}
