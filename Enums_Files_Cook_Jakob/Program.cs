using System


namespace Enum_Files_Cook_Jakob
{
    enum Months
    {
        Jan = 1
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }


    class Program
    {

        static void Main(string[] args) 
        {
            int myBirthMonth = (int)Months.Dec;
            int myBirthDay = 23;
            int myBirthYear = 1997;

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("myFile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more tet added to the file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("myFile.txt"));
        }
    }
}