using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

FirstNamespace LTTSTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FirstName = new string[100];
            string LastName = null, lFirstName = null;
            string[] dob = new string[100];
            string[] regNo = new string[100];
            string[] course = new string[100];
            float[] adFee = new float[100];
            int[] Phno = new int[1000];
            int[] adId = new int[100];
            int admFee, adNum = 1000;
            float tFee = 0.0F;
            string Course = null;
            string UserFirstName = null;
            string password = null;
            string reg = null;
            bool stats = true;
            int status = 1, choice, i;
            do
            {
                Console.Write("\nEnter user FirstName: ");
                UserFirstName = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                if (UserFirstName != "FirstName" || password != "password")
                {
                    Console.WriteLine("Validating.......");
                    Thread.Sleep(500);
                    Console.WriteLine("Invalid userFirstName and password");
                    status++;
                }
            } while (status <= 3 && password != "password");
            if (UserFirstName == "FirstName" && password == "password")
            {
                Console.WriteLine("\n\t----------> Enter Student details <----------");
                Console.Write("\n\tEnter no of Students: ");
                int n = int.Parse(Console.ReadLine());
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n\t\t\t\tStudent.{i + 1} details: ");
                    Console.Write("\n\tEnter First FirstName: ");
                    LastName = Console.ReadLine();
                    Console.Write("\tEnter Last FirstName: ");
                    lFirstName = Console.ReadLine();
                    FirstName[i] = LastName + " " + lFirstName;
                    Console.Write("\tEnter Date of birth(DD/MM/YYYY): ");
                    dob[i] = Console.ReadLine();
                    if (i == 0)
                    {
                        Console.Write("\tEnter Register Number: ");
                        reg = Console.ReadLine();
                        regNo[i] = reg;
                    }
                    else
                    {
                        do
                        {
                            Console.Write("\tEnter Register Number: ");
                            reg = Console.ReadLine();
                            for (int j = 0; j < i; j++)
                            {
                                if (reg != regNo[j])
                                    { regNo[i] = reg; stats = true; break;}
                                else
                                    Console.WriteLine("\tRegister num already exist...!!"); stats = false;
                            }
                        } while (!stats);
                    }
                    Console.Write("\tEnter Course: ");
                    course[i] = Console.ReadLine();
                    Console.Write("\tEnter Admission Fee: ");
                    admFee = int.Parse(Console.ReadLine());
                    adFee[i] = admFee + (admFee * 0.18F);
                    Console.Write("\tEnter Mobile Number: ");
                    Phno[i] = int.Parse(Console.ReadLine());
                    adId[i] = adNum + 1;

                }
                do
                {
                    Console.WriteLine("\n\t\t************ Student Details ************");
                    Console.WriteLine("\n\t1.Display all Students");
                    Console.WriteLine("\t2.Show total admission fee");
                    Console.WriteLine("\t3.Search student by course");
                    Console.WriteLine("\t4.EXIT");
                    Console.Write("\nEnter choice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\n  StudentFirstName | DateOfBirth | RegisterNumber | Course | AdmissionFees | MobileNumber | AdmissionID\n");
                            for (i = 0; i < n; i++)
                            {
                                Console.WriteLine($"  {FirstName[i]}\t| {dob[i]} |\t {regNo[i]}\t|\t {course[i]}\t|\t {adFee[i]} \t| {Phno[i]} \t|\t {adId[i]}");
                            }
                            break;
                        case 2:
                            for (i = 0; i < n; i++)
                            {
                                tFee = tFee + adFee[i];
                            }
                            Console.WriteLine($"\n------------- Total admission fee: {tFee}");
                            break;
                        case 3:
                            Console.Write("\n\tEnter course: ");
                            Course = Console.ReadLine();
                            for (i = 0; i < n; i++)
                            {
                                if (course[i] == Course)
                                {
                                    Console.WriteLine($"\t\t{i + 1}. {FirstName[i]}");
                                }
                            }
                            break;
                        case 4: Console.WriteLine("\n\t\t\t.............Exiting Application............."); break;
                        default: Console.WriteLine("\n\t...........Sorry Invalid Input, Please Try Again. Returning to main menu............."); Thread.Sleep(500); break;
                    }

                } while (choice != 4);
            }
            else
                Console.WriteLine("\n\t------------->>> Try after sometime <<<-------------");
        }
    }
}


