using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

//Casino is a library file. TwentyOne is a Console Application
namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            //Guid: Global Unique Identifier - 128 bit integer used as a unique identifier.
            Guid identifier = Guid.NewGuid();
            //value type : non-nullable struct, 12 constructors to datetime
                      
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if(playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                Console.WriteLine("the length of the list is : " + Exceptions.Count);
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");            //Write keeps writing in the same line
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + "|");
                    Console.WriteLine();                            //WriteLine goes to the next line after writing
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }
            
            //int bank = Convert.ToInt32(Console.ReadLine());   //The above code takes care of the ugly error this throws.
            Console.WriteLine("Hello {0}, Would you like to join a game of TwentyOne right now? ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\sanjeev\source\repos\The-Tech-Academy-C-Sharp-Projects\TwentyOne\TwentyOne\log.txt"))
                {
                    file.WriteLine("ID: "+player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;        //caution against while loops as they can run infinitely by your mistake
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

        //static because we are not going to make an instance of 'program.cs'
        private static void UpdateDbWithException(Exception ex)
        {
            //string with username, pass info to connect to the database
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; 
                                       Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                       TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                       MultiSubnetFailover = False";
            //sql query that we are writing
            //parameterize queries by putting placeholder @ExceptionType, etc. to prevent sql injection attacks. 
            //e.g. instead of name user could enter 'DROP TABLE' -- there could be irrepairable damage to DB.
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            //This using is different than on top of file. This is for managing and controllig memory when dealing with external resources
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.VarChar);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery(); //nonquery is like an INSERT, query is like SELECT

            }   //this curly brace automatically shuts of the connection so we don't have memory leaks.
        }


        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TwentyOneGame; 
                                       Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                       TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                       MultiSubnetFailover = False";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";       //Mine name is Table. I couldn't change it to Exceptions like instructor
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }

                connection.Close();
            }   //no parameterizing here. We are pulling all rows, parameterized could be: where number >0 (etc. in the query)

            return Exceptions;
        }
    }
}
