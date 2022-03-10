using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Program2
    {
        class Port
        {
            public int id { get; set; }
            public string location { get; set; }
            public int value { get; set; }
        }


        class Users
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string Mobile { get; set; }
            public string Username { get; set; }
            public string Question { get; set; }
        }
        static void Main(string[] args)
        {

            var user = new List<Users>() { };
            int userid = 0;


            Console.WriteLine("Are you a new user? (y/n)");
            char response = Convert.ToChar(Console.ReadLine());
            if (response.Equals('y'))
            {
                Console.WriteLine("Fill in the sign up details");
                Console.WriteLine("Name : ");
                string Name = Console.ReadLine();
                Console.WriteLine("Password : ");
                string Passowrd = genPass();
                Console.WriteLine(Passowrd);
                Console.WriteLine("Mobile : ");
                string Mobile = Console.ReadLine();
                string Username = Mobile;
                user.Add(new Users() { Name = Name, Password = Passowrd, Mobile = Mobile, Username = Mobile });
                Console.WriteLine($"Your Username is {Username}");
            }

            Console.WriteLine("Enter credentials to sign in : ");
            login();

            void login()
            {

                Console.WriteLine("Username : ");
                string loginusername = Console.ReadLine();
                Console.WriteLine("Password : ");
                string loginpassword = Console.ReadLine();

                for (int i = 0; i < user.Count; i++)
                {
                    if (loginpassword == user[i].Password && loginusername == user[i].Username)
                    {
                        Console.WriteLine("You are logged in!");
                        userid = i;
                        user[i].id = userid;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong credentials. Try Again");
                        login();
                    }
                }

            }

            Console.WriteLine("Security Question : \nChoose one question.");
            Console.WriteLine("1. Your favorite football player?");
            Console.WriteLine("2. Your favorite music band?");
            Console.WriteLine("3. Your dog's name?");

            int q = Convert.ToInt32(Console.ReadLine());
            string Ans;
            switch (q)
            {
                case 1:
                    Ans = Console.ReadLine();
                    user[userid].Question = Ans;
                    break;
                case 2:
                    Ans = Console.ReadLine();
                    break;
                case 3:
                    Ans = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
            Console.WriteLine("Do you want to reset your password?");
            char reset = Convert.ToChar(Console.ReadLine());
            if (reset.Equals('y'))
            {
                resetPassword();
            }

            void resetPassword()
            {
                Console.WriteLine("Enter old password : ");
                string oldpass = Console.ReadLine();
                Console.WriteLine("Enter new password : ");
                string newpass = Console.ReadLine();
                Console.WriteLine("Confirm new password : ");
                string confirmpass = Console.ReadLine();
                if (oldpass == user[userid].Password)
                {
                    if (newpass == confirmpass)
                    {
                        user[userid].Password = newpass;
                        Console.WriteLine("Your password was successfully updated.");
                        Console.WriteLine(user[userid].Password);
                    }
                    else
                    {
                        Console.WriteLine("Passwords does not match! Try again.");
                        resetPassword();
                    }
                }
                else
                {
                    Console.WriteLine("Old Password is wrong!");
                    resetPassword();
                }
            }













            string genPass()
            {
                StringBuilder Password = new StringBuilder();
                Random random = new Random(9);
                for (int i = 0; i < 8; i++)
                {
                    Password.Append(random.Next(0, 9));
                }

                return Password.ToString();
            }


            var ports = new List<Port>()
            {
                new Port() { id = 1, location = "Australia", value = 10 },
                new Port() { id = 2, location = "India", value = 140 },
                new Port() { id = 3, location = "USA", value = 50 },
                new Port() { id = 4, location = "UK", value = 90 },
                new Port() { id = 5, location = "Russia", value = 170 }
            };

            Console.WriteLine("Please select the service : Import / Export");
            Console.WriteLine("Press i for import or e for export : (i/e)");

            char res = Convert.ToChar(Console.ReadLine());

            if (res.Equals('i') || res.Equals('I'))
            {
                Console.WriteLine("IMPORT SERVICE :\nFROM :");

                for (int i = 0; i < ports.Count; i++)
                {
                    Console.WriteLine(i + 1 + " " + ports[i].location);
                }
                Console.WriteLine("Please select your Origin : ");
                int option = Convert.ToInt32(Console.ReadLine());


                var destinationports = new List<Port>();
                for (int i = 0; i < ports.Count; i++)
                {
                    if (i == option - 1)
                    {

                    }
                    else
                    {

                        destinationports.Add(new Port()
                        { id = ports[i].id, location = ports[i].location, value = ports[i].value }
                        );

                    }

                }
                Console.WriteLine("TO :");
                for (int i = 0; i < destinationports.Count; i++)
                {
                    Console.WriteLine(i + 1 + " " + destinationports[i].location);
                }

                Console.WriteLine("Please select your Destination : ");
                int destOpt = Convert.ToInt32(Console.ReadLine());
                int total = ports[option - 1].value * destinationports[destOpt - 1].value;
                Console.WriteLine($"Your total cost of shipping from {ports[option - 1].location} to {destinationports[destOpt - 1].location} is {total}.");

            }

            else if (res.Equals('e') || res.Equals('E'))
            {

            }
            else
            {
                Console.WriteLine("Invalid response!");
            }

        }



    }