using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            //double number = 10.5;
            //Console.WriteLine(number); // Output 10,5 - in output we have comma, but in code we have dot

            //double applePrice, orangePrice,strawberryPrice, tomatoPrice, potatoPrice;

            //applePrice = 1.5;
            //orangePrice = 2.5;
            //strawberryPrice = 3.5;
            //tomatoPrice = 4.5;
            //potatoPrice = 0.5;

            //Console.WriteLine("---- Price List ----\n");
            //Console.WriteLine("Apple price : " + applePrice);
            //Console.WriteLine("Orange price : " + orangePrice);
            //Console.WriteLine("Strawberry price : " + strawberryPrice);
            //Console.WriteLine("Tomato price : " + tomatoPrice);
            //Console.WriteLine("Potato price : " + potatoPrice);

            //double appleGram, orangeGram, strawberryGram, tomatoGram, potatoGram;

            //appleGram = 1.250;
            //orangeGram = 1.500;
            //strawberryGram = 0.785;
            //tomatoGram = 1.640;
            //potatoGram = 2.759;

            //Console.WriteLine("\n---- Total Price List ----\n");
            //Console.WriteLine("Apple total price: " + applePrice*appleGram);
            //Console.WriteLine("Orange total price: " + orangePrice*orangeGram);
            //Console.WriteLine("Strawberry total price: " + strawberryPrice*strawberryGram);
            //Console.WriteLine("Potato total price: " + potatoPrice*potatoGram);
            //Console.WriteLine("Tomato total price: " + tomatoPrice*tomatoGram);

            //double shoppingTotalPrice = appleGram * applePrice + orangeGram * orangePrice + strawberryGram * strawberryPrice + tomatoGram * tomatoPrice + potatoGram * potatoPrice;

            //Console.WriteLine("\nShopping Total Price : \n" + shoppingTotalPrice);

            #endregion

            #region Char Variables

            //char symbol = 'A'; // char variables declare with single quotes

            //Console.WriteLine(symbol);

            #endregion

            #region String Inputs from Keyboard

            //Console.WriteLine("CSharp Airlines Passenger Information");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Passenger Name : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Surname : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Passenger Age : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passenger Identity Number : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Passenger District : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Passenger City : ");
            //passengerCity = Console.ReadLine();



            //Console.WriteLine("\n-------------------\n");
            //Console.WriteLine("Passenger : " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Passenger Details");
            //Console.WriteLine("Identity Number : " + passengerIdentityNumber + " Age : " + passengerAge);
            //Console.WriteLine("District : " + passengerDistrict + " City : " + passengerCity);


            #endregion

            #region Integer Inputs from Keyboard and Casting

            //Console.WriteLine("---- WTOS Store Price List ----\n");
            //int shoePrice, tshirtPrice, pantPrice, hatPrice, jacketPrice;
            //shoePrice = 60;
            //tshirtPrice = 20;
            //pantPrice = 40;
            //hatPrice = 10;
            //jacketPrice = 80;

            //Console.WriteLine("Shoe : " + shoePrice);
            //Console.WriteLine("Tshirt : " + tshirtPrice);
            //Console.WriteLine("Pant : " + pantPrice);
            //Console.WriteLine("Hat : " + hatPrice);
            //Console.WriteLine("Jacket : " + jacketPrice);

            //Console.WriteLine("\n-------------------------------------\n");
            //Console.WriteLine("How many pieces for each item you want to buy?");

            //int shoePiece, tshirtPiece, pantPiece, hatPiece, jacketPiece;

            //Console.Write("Shoe : ");
            //shoePiece = Convert.ToInt32(Console.ReadLine()); // Casting to integer

            //Console.Write("Tshirt : ");
            //tshirtPiece = int.Parse(Console.ReadLine()); // Casting to integer (another way)

            //Console.Write("Pant : ");
            //pantPiece = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Hat : ");
            //hatPiece = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Jacket : ");
            //jacketPiece = Convert.ToInt32(Console.ReadLine());

            //int totalPrice = shoePrice * shoePiece + tshirtPrice * tshirtPiece + pantPrice * pantPiece + hatPrice * hatPiece + jacketPrice * jacketPiece;
            //Console.WriteLine("Total Price : " + totalPrice);

            #endregion

            #region Double Inputs from Keyboard and Casting

            //Console.WriteLine("-------- Grade Calculator --------\n");

            //Console.Write("Midterm Grade : ");
            //double midtermGrade = Convert.ToDouble(Console.ReadLine()); // Casting to double

            //Console.Write("Project Grade : ");
            //double projectGrade = double.Parse(Console.ReadLine()); // Casting to double (another way)

            //Console.Write("Homework Grade : ");
            //double homeworkGrade = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Final Grade : ");
            //double finalGrade = Convert.ToDouble(Console.ReadLine());

            //double totalGrade = midtermGrade * 0.3 + projectGrade * 0.2 + homeworkGrade * 0.1 + finalGrade * 0.4;

            //Console.WriteLine("Total Grade : " + totalGrade);

            #endregion

            #region Char Inputs from Keyboard

            //Console.WriteLine("Let me guess first charachter of your name :)");

            //char myChoice = char.Parse(Console.ReadLine()); // Casting to char
            ////char myChoice = Convert.ToChar(Console.ReadLine()); // Casting to char (another way)
            //// cannot parse the string which has more than one charachter - throws an exception in this case

            //Console.WriteLine("My choice is " + myChoice);

            #endregion
        }
    }
}
