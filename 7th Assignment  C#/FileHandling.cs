using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    public class FileHandling
    {
      public  static void Main()
        {

            string writeText = "Hello World!";  // Create a text string


            File.WriteAllText(@"C:\\filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText(@"C:\filename.txt");  // Read the contents of the file


            Console.WriteLine(readText);  // Output the content

            /* Created Copy*/

            File.Copy(@"C:\filename.txt", @"C:\Test.txt");


            File.AppendAllText(@"C:\Test.txt", "Append this content");



            File.Copy(@"C:\Test.txt", @"C:\Test1.txt");

            /*Delete File*/

            File.Delete(@"C:\Test1.txt");


            File.Encrypt(@"C:\Test.txt");

            /*Decrypt the file*/

            File.Decrypt(@"C:\Test.txt");


            /*Create File Info*/

            string myPath = @"C:\MyDir\hey.txt";

            FileInfo fileinfo = new FileInfo(myPath);
            /* Created the file using FileInfo*/

            FileStream fs = fileinfo.Create();
            Console.WriteLine("created");

           
            

            fs.Close();


            /* to open the text file*/

            StreamReader sr = fileinfo.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }


            sr.Close();




        }
    }
}
