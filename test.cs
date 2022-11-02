using System;
public class Exercise16
{
    public static void Main()
    {
        string username, password;
        int ctr = 0;
        int ay = 0;
        int mebleg = 0;
        int faiz = 0;
        int ayliqOdenis = 0;
        int emeliyyat = 0;
        int umumiOdenilecekMebleg = 0;
        Console.WriteLine("\t\t\t\t\t\t\tWelcome to Bank ! ");
        Console.WriteLine("\t\t\t\t\t\t-------------------------------------------");
        Console.Write("\n\nCheck username and password :\n");
        Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
        Console.Write("------------------------------------------------------\n");

        do
        {
            Console.Write("username: ");
            username = Console.ReadLine();

            Console.Write("password: ");
            password = Console.ReadLine();

            if (username != "fuad" || password != "1234")
                ctr++;
            else
                ctr = 1;

        }
        while ((username != "fuad" || password != "1234") && (ctr != 3));

        if (ctr == 3)
            Console.Write("\nLogin attemp three or more times. Try later!\n\n");
        else
            Console.Write("\nThe password entered successfully!\n\n");

        if (username == "fuad" && password == "1234")
        {
            Console.WriteLine("\t\t\t\t\t---------------------------");
            Console.WriteLine("1.Kredit goturmek");
            Console.WriteLine("2.Kredit odemek");
            Console.WriteLine("3.Hesabat");
        }
        else if (emeliyyat == 1)
        {

            Console.WriteLine("Ayliq odenis: ");
            ayliqOdenis = Int32.Parse(Console.ReadLine());
            string odemekUcunBasin = Console.ReadLine();
            umumiOdenilecekMebleg = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Odenilecek mebleg");
            Console.Write("emeliyyat ugurlu oldu!");
            Console.WriteLine("Meblegi daxil edin: ");

        }
        else if (emeliyyat == 2)
        {
            Console.WriteLine("Odemek ucun 1 basin: ");
        }
        else if (emeliyyat == 3)
        {
            Console.WriteLine(" Borcunuz: " );
        }

    }
}