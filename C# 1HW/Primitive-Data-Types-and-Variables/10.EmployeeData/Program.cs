using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
           // A marketing company wants to keep record of its employees. Each record would have the following characteristics:
           // First name
           // Last name
           // Age (0...100)
           //  Gender (m or f)
           // Personal ID number (e.g. 8306112507)
           //  Unique employee number (27560000…27569999)
           //  Declare the variables needed to keep the information for a single employee using
           //  appropriate primitive data types. Use descriptive names. Print the data at the console.


            string fName = "Kiro";
            string lName = "Skalata";
            byte age = 69;
            string gender = "M" ;
            long iD = 6969969969 ;
            int number = 27566969;
            Console.WriteLine(fName + Environment.NewLine + lName 
                + Environment.NewLine + age + Environment.NewLine 
                + gender + Environment.NewLine + iD + Environment.NewLine + number);


        }
    }
}
