using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project1
{
    class Program
    {
        
        static void Main(string[] args)

        {
            //define variable
            string tempS;
            int temp;
            int tempR;
            int check;
            int computerpoint = 0;
            int userpoint = 0;
            int firstNumber;
            int secondNumber;
            int a, b, c, d;
            int userFirstNumber;
            int userSecondNumber;
            int userNumber;
            int feedBackPositive;
            int feedBackNegative;
            int userfeedBackPositive;
            int userfeedBackNegative;
            //define variable END



            //write info about game and rules
            Console.WriteLine(@"
  __  __ _       _   __  __           _              __  __ _           _  **
 |  \/  (_)     (_) |  \/  |         | |            |  \/  (_)         | | **
 | \  / |_ _ __  _  | \  / | __ _ ___| |_ ___ _ __  | \  / |_ _ __   __| | **
 | |\/| | | '_ \| | | |\/| |/ _` / __| __/ _ \ '__| | |\/| | | '_ \ / _` | **
 | |  | | | | | | | | |  | | (_| \__ \ ||  __/ |    | |  | | | | | | (_| | **
 |_|  |_|_|_| |_|_| |_|  |_|\__,_|___/\__\___|_|    |_|  |_|_|_| |_|\__,_| **
                                                                           **
___________________________________________________________________________**                                                                          
");
            Console.Write(@"
   ╦═╗┬ ┬┬  ┌─┐┌─┐   
(1)╠╦╝│ ││  ├┤ └─┐          
   ╩╚═└─┘┴─┘└─┘└─┘   
   ╔═╗┌─┐┌┬┐┌─┐┬  ┌─┐
(2)╚═╗├─┤│││├─┘│  ├┤        
   ╚═╝┴ ┴┴ ┴┴  ┴─┘└─┘
   ╔═╗┌┬┐┌─┐┬─┐┌┬┐   
(3)╚═╗ │ ├─┤├┬┘ │               
   ╚═╝ ┴ ┴ ┴┴└─ ┴    
                  
What do you want? : ");

            while (true)
            {
                tempS = Console.ReadLine();
                if (tempS.All(char.IsDigit) & tempS != "")
                {
                    break;
                }
                Console.Write("*You can not use string or punctuation. Please enter integer : ");

            }
            check = Convert.ToInt32(tempS);

            check = Convert.ToInt32(tempS);
            while (true)
            {


                if (check == 1)
                {
                    Console.WriteLine(@"
1. The game is played on 2-square rows.
2. Each square in a row can be 1, 2 or 3. 
3. The same number cannot be repeated.
4. One of feedbacks have to be 0.
5. Don't trick.
6. If you don't obey rules, game over.

");
                    Console.Write(@"

___________________________________________________________________________
   ╦═╗┬ ┬┬  ┌─┐┌─┐   
(1)╠╦╝│ ││  ├┤ └─┐          
   ╩╚═└─┘┴─┘└─┘└─┘   
   ╔═╗┌─┐┌┬┐┌─┐┬  ┌─┐
(2)╚═╗├─┤│││├─┘│  ├┤        
   ╚═╝┴ ┴┴ ┴┴  ┴─┘└─┘
   ╔═╗┌┬┐┌─┐┬─┐┌┬┐   
(3)╚═╗ │ ├─┤├┬┘ │               
   ╚═╝ ┴ ┴ ┴┴└─ ┴    
                  
What do you want? : ");


                    while (true)
                    {
                        tempS = Console.ReadLine();
                        if (tempS.All(char.IsDigit) & tempS != "")
                        {
                            break;
                        }
                        Console.Write("*You can not use string or punctuation. Please enter integer : ");

                    }
                    check = Convert.ToInt32(tempS);

                }
                else if (check == 2)
                {
                    Console.WriteLine(@"

 
Round: 1
Game:  1
Computer Score: 0
Player Score: 0
 
Your Guess (1): 21
My Feedback: +1, -0
 
Your Guess (2): 23
My Feedback: +2, -0
 
You win.
 
--------------------

Press enter for next step
");
                    Console.ReadLine();

                    Console.WriteLine(@"


Round: 1
Game:  2
Computer Score: 2
Player Score: 0
 
My Guess (1): 12
Your Feedback (+): 0
Your Feedback (-): 2
 
My Guess (2): 21
Your Feedback (+): 2
Your Feedback (-): 0
 
I win.
 
--------------------


Press enter for next step
");
                    Console.ReadLine();

                    Console.WriteLine(@"

 
Round: 2
Game:  1
Computer Score: 2
Player Score: 2
 
Your Guess (1): 32
My Feedback: +0, -1
 
Your Guess (2): 31
My Feedback: +1, -0
 
Your Guess (3): 21
My Feedback: +2, -0
 
You win.
 
--------------------

Press enter for next step
");
                    Console.ReadLine(); Console.WriteLine(@"

ound: 2
Game:  2
Computer Score: 5
Player Score: 2
 
My Guess (1): 23
Your Feedback (+): 
 
...



");

                    Console.Write(@"
___________________________________________________________________________
   ╦═╗┬ ┬┬  ┌─┐┌─┐   
(1)╠╦╝│ ││  ├┤ └─┐          
   ╩╚═└─┘┴─┘└─┘└─┘   
   ╔═╗┌─┐┌┬┐┌─┐┬  ┌─┐
(2)╚═╗├─┤│││├─┘│  ├┤        
   ╚═╝┴ ┴┴ ┴┴  ┴─┘└─┘
   ╔═╗┌┬┐┌─┐┬─┐┌┬┐   
(3)╚═╗ │ ├─┤├┬┘ │               
   ╚═╝ ┴ ┴ ┴┴└─ ┴    
                  
What do you want? : ");

                    while (true)
                    {
                        tempS = Console.ReadLine();
                        if (tempS.All(char.IsDigit) & tempS != "")
                        {
                            break;
                        }
                        Console.Write("*You can not use string or punctuation. Please enter integer : ");

                    }
                    check = Convert.ToInt32(tempS);

                }

                else if (check == 3)
                {
                    break;
                }

                else
                {
                    Console.Write("Wrong choose! Please enter 1 or 2 or 3  : ");
                    while (true)
                    {
                        tempS = Console.ReadLine();
                        if (tempS.All(char.IsDigit) & tempS != "")
                        {
                            break;
                        }
                        Console.Write("*You can not use string or punctuation. Please enter integer : ");
                        
                    }
                    check = Convert.ToInt32(tempS);
                }

            }


            


            for (int round = 1; round <= 10; round++)
            {

                //game 1**************************************************************

                //genrate random number------------------------------
                Random random = new Random();
                firstNumber = random.Next(1, 4);
                secondNumber = random.Next(1, 4);

                if (firstNumber == secondNumber)
                {
                    if (firstNumber == 1)
                    {
                        secondNumber = random.Next(2, 4);
                    }

                    else if (firstNumber == 3)
                    {
                        secondNumber = random.Next(1, 3);
                    }


                    else
                    {
                        temp = random.Next(1, 3);
                        if (temp == 1)
                        {
                            secondNumber = 1;
                        }
                        else
                        {
                            secondNumber = 3;
                        }
                    }
                }

                //generate random number END--------------------------


                //write game info
                Console.Write(@"
*******************************************************************************
 Round: {0}
 Game:  1
 My Score:   {1}          
 Your Score: {2}          
-------------------------------------------------------------------------------


 Your Guess (1) : ", round, computerpoint, userpoint);
                //write game info END


                //get user guess
                while (true)
                {
                    tempS = Console.ReadLine();
                    if (tempS.All(char.IsDigit) & tempS != "")
                    {
                        break;
                    }
                    Console.Write(" You can not use string or punctuation. Please enter integer : ");

                }
                userNumber = Convert.ToInt32(tempS);
                if (!(userNumber == 12 | userNumber == 13 | userNumber == 21 | userNumber == 23 | userNumber == 31 | userNumber == 32))
                {

                    Console.WriteLine(" Game over the fact that you do not obey rules. You only use 12,13,21,23,31,32 ");
                    Console.WriteLine("Press enter for Exit game");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                userSecondNumber = userNumber % 10;
                userFirstNumber = (userNumber - userSecondNumber) / 10;
                //get user guess END


                //genrate feedback
                feedBackPositive = 0;
                feedBackNegative = 0;

                if (userFirstNumber == firstNumber)
                {
                    feedBackPositive++;
                }

                if (userSecondNumber == secondNumber)
                {
                    feedBackPositive++;
                }
                if (userFirstNumber == secondNumber)
                {
                    feedBackNegative++;
                }
                if (userSecondNumber == firstNumber)
                {
                    feedBackNegative++;
                }

                //genrate feedback END

                if (!(feedBackPositive == 2))
                {
                    //Guess 2*******************
                    Console.WriteLine(" My feedback: +{0} , -{1}", feedBackPositive, feedBackNegative);
                    Console.Write(" Your Guess (2) : ");
                    //get user guess
                    while (true)
                    {
                        tempS = Console.ReadLine();
                        if (tempS.All(char.IsDigit) & tempS != "")
                        {
                            break;
                        }
                        Console.Write(" You can not use string or punctuation. Please enter integer : ");

                    }
                    userNumber = Convert.ToInt32(tempS);
                    if (!(userNumber == 12 | userNumber == 13 | userNumber == 21 | userNumber == 23 | userNumber == 31 | userNumber == 32))
                    {

                        Console.WriteLine(" Game over the fact that you do not obey rules. You only use 12,13,21,23,31,32 ");
                        Console.WriteLine("Press enter for Exit game");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    userSecondNumber = userNumber % 10;
                    userFirstNumber = (userNumber - userSecondNumber) / 10;
                    //get user guess END

                    //genrate feedback
                    feedBackPositive = 0;
                    feedBackNegative = 0;

                    if (userFirstNumber == firstNumber)
                    {
                        feedBackPositive++;
                    }

                    if (userSecondNumber == secondNumber)
                    {
                        feedBackPositive++;
                    }
                    if (userFirstNumber == secondNumber)
                    {
                        feedBackNegative++;
                    }
                    if (userSecondNumber == firstNumber)
                    {
                        feedBackNegative++;
                    }

                    //genrate feedback END

                    //Guess 2 END*************


                    if (!(feedBackPositive == 2))
                    {
                        //Guess 3
                        Console.WriteLine(" My feedback: +{0} , -{1}", feedBackPositive, feedBackNegative);
                        Console.Write(" Your Guess (2) : ");
                        //get user guess
                        while (true)
                        {
                            tempS = Console.ReadLine();
                            if (tempS.All(char.IsDigit) & tempS != "")
                            {
                                break;
                            }
                            Console.Write(" You can not use string or punctuation. Please enter integer : ");

                        }
                        userNumber = Convert.ToInt32(tempS);
                        if (!(userNumber == 12 | userNumber == 13 | userNumber == 21 | userNumber == 23 | userNumber == 31 | userNumber == 32))
                        {

                            Console.WriteLine(" Game over the fact that you do not obey rules. You only use 12,13,21,23,31,32 ");
                            Console.WriteLine("Press enter for Exit game");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }

                        userSecondNumber = userNumber % 10;
                        userFirstNumber = (userNumber - userSecondNumber) / 10;
                        //get user guess END

                        //genrate feedback
                        feedBackPositive = 0;
                        feedBackNegative = 0;

                        if (userFirstNumber == firstNumber)
                        {
                            feedBackPositive++;
                        }

                        if (userSecondNumber == secondNumber)
                        {
                            feedBackPositive++;
                        }
                        if (userFirstNumber == secondNumber)
                        {
                            feedBackNegative++;
                        }
                        if (userSecondNumber == firstNumber)
                        {
                            feedBackNegative++;
                        }

                        //genrate feedback END
                        //Guess 3 END ***********************
                        if (!(feedBackPositive == 2))
                        {
                            Console.WriteLine(" My feedback: +{0} , -{1}", feedBackPositive, feedBackNegative);
                            Console.WriteLine(@" You lost!
*******************************************************************************");
                            computerpoint += 3;
                        }
                        else
                        {
                            Console.WriteLine(" My feedback: +{0} , -{1}", feedBackPositive, feedBackNegative);
                            Console.WriteLine(@" You WIN!
*******************************************************************************");
                            computerpoint += 3;
                        }

                    }
                    else
                    {
                        //guess 2
                        computerpoint += 2;
                        Console.WriteLine(" My feedback: +{0} , -{1}", feedBackPositive, feedBackNegative);
                        Console.WriteLine(@" You WIN!
*******************************************************************************");

                    }





                }
                else
                {
                    //guess 1
                    computerpoint++;
                    Console.WriteLine(" My feedback: +{0} , -{1}", feedBackPositive, feedBackNegative);
                    Console.WriteLine(@" You WIN!
*******************************************************************************");
                }
                //game 1 END************************************************************** 
                Console.WriteLine(@"
First game done. Choose a number and then press enter and second game will start
");
                Console.ReadLine();
                //game 2 **************************************************************

                //genrate random number------------------------------
                firstNumber = random.Next(1, 4);
                secondNumber = random.Next(1, 4);

                if (firstNumber == secondNumber)
                {
                    if (firstNumber == 1)
                    {
                        secondNumber = random.Next(2, 4);
                    }

                    else if (firstNumber == 3)
                    {
                        secondNumber = random.Next(1, 3);
                    }


                    else
                    {


                        temp = random.Next(1, 3);
                        if (temp == 1)
                        {
                            secondNumber = 1;
                        }
                        else
                        {
                            secondNumber = 3;
                        }
                    }
                }

                //generate random number END--------------------------


                Console.WriteLine(@"

*******************************************************************************
 Round: {0}
 Game:  2
 My Score:   {1}          
 Your Score: {2}          
-------------------------------------------------------------------------------


 My Guess (1) : {3}{4}", round, computerpoint, userpoint, firstNumber, secondNumber);
                //check feedback
                Console.Write(" Your Feedback (+): ");
                while (true)
                {
                    tempS = Console.ReadLine();
                    if (tempS.All(char.IsDigit) & tempS != "")
                    {
                        break;
                    }
                    Console.Write(" You can not use string or punctuation. Please enter integer : ");

                }
                userfeedBackPositive = Convert.ToInt32(tempS);
                Console.Write(" Your Feedback (-): ");
                while (true)
                {
                    tempS = Console.ReadLine();
                    if (tempS.All(char.IsDigit) & tempS != "")
                    {
                        break;
                    }
                    Console.Write(" You can not use string or punctuation. Please enter integer : ");

                }
                userfeedBackNegative = Convert.ToInt32(tempS);

                if ((userfeedBackPositive == 1 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 1) | (userfeedBackPositive == 2 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 2))
                //check feedback END
                {
                    //guess 1------------------------------
                    if (!(userfeedBackPositive == 2))
                    {
                        if (userfeedBackNegative == 2)
                        {
                            //guess 2----------------user feedbacknegative 2
                            temp = firstNumber;
                            firstNumber = secondNumber;
                            secondNumber = temp;
                            Console.WriteLine(" My Guess (2) : {0}{1}", firstNumber, secondNumber);
                            //check feedback
                            Console.Write(" Your Feedback (+): ");
                            while (true)
                            {
                                tempS = Console.ReadLine();
                                if (tempS.All(char.IsDigit) & tempS != "")
                                {
                                    break;
                                }
                                Console.Write(" You can not use string or punctuation. Please enter integer : ");

                            }
                            userfeedBackPositive = Convert.ToInt32(tempS);
                            Console.Write(" Your Feedback (-): ");
                            while (true)
                            {
                                tempS = Console.ReadLine();
                                if (tempS.All(char.IsDigit) & tempS != "")
                                {
                                    break;
                                }
                                Console.Write(" You can not use string or punctuation. Please enter integer : ");

                            }
                            userfeedBackNegative = Convert.ToInt32(tempS);

                            if ((userfeedBackPositive == 1 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 1) | (userfeedBackPositive == 2 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 2))
                            //check feedback END
                            {
                                if (userfeedBackPositive == 2)
                                {
                                    userpoint += 2;
                                    Console.WriteLine(" I WIN!");
                                }
                                else
                                {
                                    Console.WriteLine(" You do not trick me. Your feedback have to be 2,0. Game over !");
                                    Console.WriteLine("Press enter for Exit game");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                }

                            }
                            else
                            {
                                //wrong feedback
                                Console.WriteLine(" Game over the fact that your feedback wrong. Your feed back have to be one of numbers that +1,0 0,-1 +2,0 and 0,-2.");
                                Console.WriteLine("Press enter for Exit game");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                            //guess 2----------------user feedbacknegative 2 END*
                        }

                        else if (userfeedBackPositive == 1)
                        {
                            //feedback positive 1 ***************-----------------****************
                            a = firstNumber;
                            b = secondNumber;

                            temp = random.Next(1, 3);
                            tempR = temp;
                            if (temp == 1)
                            {
                                //change first number
                                if (secondNumber == 1)
                                {
                                    if (firstNumber == 2)
                                    {
                                        firstNumber = 3;
                                    }
                                    else
                                    {
                                        firstNumber = 2;
                                    }
                                }
                                else if (secondNumber == 2)
                                {
                                    if (firstNumber == 1)
                                    {
                                        firstNumber = 3;
                                    }
                                    else
                                    {
                                        firstNumber = 1;
                                    }
                                }
                                else
                                {
                                    if (firstNumber == 1)
                                    {
                                        firstNumber = 2;
                                    }
                                    else
                                    {
                                        firstNumber = 1;
                                    }
                                }

                                //change first number END
                            }
                            else
                            {
                                //change second number
                                if (firstNumber == 1)
                                {
                                    if (secondNumber == 2)
                                    {
                                        secondNumber = 3;
                                    }
                                    else
                                    {
                                        secondNumber = 2;
                                    }
                                }
                                else if (firstNumber == 2)
                                {
                                    if (secondNumber == 1)
                                    {
                                        secondNumber = 3;
                                    }
                                    else
                                    {
                                        secondNumber = 1;
                                    }
                                }
                                else
                                {
                                    if (secondNumber == 1)
                                    {
                                        secondNumber = 2;
                                    }
                                    else
                                    {
                                        secondNumber = 1;
                                    }
                                }

                                //change second number END
                            }
                            c = firstNumber;
                            d = secondNumber;
                            Console.WriteLine(" My Guess (2) : {0}{1}", firstNumber, secondNumber);
                            //check feedback
                            Console.Write(" Your Feedback (+): ");
                            while (true)
                            {
                                tempS = Console.ReadLine();
                                if (tempS.All(char.IsDigit) & tempS != "")
                                {
                                    break;
                                }
                                Console.Write(" You can not use string or punctuation. Please enter integer : ");

                            }
                            userfeedBackPositive = Convert.ToInt32(tempS);
                            Console.Write(" Your Feedback (-): ");
                            while (true)
                            {
                                tempS = Console.ReadLine();
                                if (tempS.All(char.IsDigit) & tempS != "")
                                {
                                    break;
                                }
                                Console.Write(" You can not use string or punctuation. Please enter integer : ");

                            }
                            userfeedBackNegative = Convert.ToInt32(tempS);

                            if ((userfeedBackPositive == 1 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 1) | (userfeedBackPositive == 2 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 2))
                            //check feedback END
                            {
                                if (!(userfeedBackPositive == 2))
                                {
                                    if (userfeedBackNegative == 2)
                                    {
                                        Console.WriteLine(" You do not trick me. Your feedback have to be 2,0 or 0,-1. Game over !");
                                        Console.WriteLine("Press enter for Exit game");
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    else if (userfeedBackPositive == 1)
                                    {
                                        Console.WriteLine(" You do not trick me. Your feedback have to be 2,0 or 0,-1. Game over !");
                                        Console.WriteLine("Press enter for Exit game");
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        // guess 3 feedback negative 1******* 
                                        //change number. hangi basamak değitiyse diğer basamak değişen basamağın değerini alır ve değişen basamakta ilk değerini alır.
                                        if (tempR == 1)//değişen basamağı gösteriyor 348. satırda değeri atandı.
                                        {
                                            firstNumber = a;
                                            secondNumber = c;
                                        }
                                        else
                                        {
                                            firstNumber = d;
                                            secondNumber = b;
                                        }

                                        //change number END

                                        Console.WriteLine(" My Guess (3) : {0}{1}", firstNumber, secondNumber);
                                        //check feedback
                                        Console.Write(" Your Feedback (+): ");
                                        while (true)
                                        {
                                            tempS = Console.ReadLine();
                                            if (tempS.All(char.IsDigit) & tempS != "")
                                            {
                                                break;
                                            }
                                            Console.Write(" You can not use string or punctuation. Please enter integer : ");

                                        }
                                        userfeedBackPositive = Convert.ToInt32(tempS);
                                        Console.Write(" Your Feedback (-): ");
                                        while (true)
                                        {
                                            tempS = Console.ReadLine();
                                            if (tempS.All(char.IsDigit) & tempS != "")
                                            {
                                                break;
                                            }
                                            Console.Write(" You can not use string or punctuation. Please enter integer : ");

                                        }
                                        userfeedBackNegative = Convert.ToInt32(tempS);

                                        if ((userfeedBackPositive == 1 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 1) | (userfeedBackPositive == 2 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 2))
                                        //check feedback END
                                        {
                                            if (userfeedBackPositive == 2)
                                            {
                                                userpoint += 3;
                                                Console.WriteLine(" I WIN!");
                                            }
                                            else
                                            {
                                                Console.WriteLine(" You do not trick me. Your feedback have to be 2,0. Game over !"); // kesin doğru.
                                                Console.WriteLine("Press enter for Exit game");
                                                Console.ReadLine();
                                                Environment.Exit(0);
                                            }
                                        }
                                        else
                                        {
                                            //wrong feedback -guess 3 feedback negative 1
                                            Console.WriteLine(" Game over the fact that your feedback wrong. Your feed back have to be one of numbers that +1,0 0,-1 +2,0 and 0,-2.");
                                            Console.WriteLine("Press enter for Exit game");
                                            Console.ReadLine();
                                            Environment.Exit(0);
                                        }


                                        // guess 3 feedback negative 1 ******* END
                                    }

                                    //guess 2 end
                                }
                                else
                                {
                                    //guess 2
                                    userpoint += 2;
                                    Console.WriteLine(@" I WİN!
*******************************************************************************");

                                }

                                //guess 2 END
                            }
                            else
                            {
                                //wrong feedback - guess 2 feedback
                                Console.WriteLine(" Game over the fact that your feedback wrong. Your feed back have to be one of numbers that +1,0 0,-1 +2,0 and 0,-2.");
                                Console.WriteLine("Press enter for Exit game");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }

                            //feedback positive 1 END ----***********----------
                        }


                        else//user feedbacknegative 1 
                        {

                            //feedback negative 1 ***************-----------------****************

                            a = firstNumber;
                            b = secondNumber;
                            temp = firstNumber;
                            firstNumber = secondNumber;
                            secondNumber = temp;
                            temp = random.Next(1, 3);
                            tempR = temp;

                            if (temp == 1)
                            {
                                //change first number
                                if (secondNumber == 1)
                                {
                                    if (firstNumber == 2)
                                    {
                                        firstNumber = 3;
                                    }
                                    else
                                    {
                                        firstNumber = 2;
                                    }
                                }
                                else if (secondNumber == 2)
                                {
                                    if (firstNumber == 1)
                                    {
                                        firstNumber = 3;
                                    }
                                    else
                                    {
                                        firstNumber = 1;
                                    }
                                }
                                else
                                {
                                    if (firstNumber == 1)
                                    {
                                        firstNumber = 2;
                                    }
                                    else
                                    {
                                        firstNumber = 1;
                                    }
                                }

                                //change first number END
                            }
                            else
                            {
                                //change second number
                                if (firstNumber == 1)
                                {
                                    if (secondNumber == 2)
                                    {
                                        secondNumber = 3;
                                    }
                                    else
                                    {
                                        secondNumber = 2;
                                    }
                                }
                                else if (firstNumber == 2)
                                {
                                    if (secondNumber == 1)
                                    {
                                        secondNumber = 3;
                                    }
                                    else
                                    {
                                        secondNumber = 1;
                                    }
                                }
                                else
                                {
                                    if (secondNumber == 1)
                                    {
                                        secondNumber = 2;
                                    }
                                    else
                                    {
                                        secondNumber = 1;
                                    }
                                }

                                //change second number END
                            }
                            c = firstNumber;
                            d = secondNumber;
                            Console.WriteLine(" My Guess (2) : {0}{1}", firstNumber, secondNumber);
                            //check feedback
                            Console.Write(" Your Feedback (+): ");
                            while (true)
                            {
                                tempS = Console.ReadLine();
                                if (tempS.All(char.IsDigit) & tempS != "")
                                {
                                    break;
                                }
                                Console.Write(" You can not use string or punctuation. Please enter integer : ");

                            }
                            userfeedBackPositive = Convert.ToInt32(tempS);
                            Console.Write(" Your Feedback (-): ");
                            while (true)
                            {
                                tempS = Console.ReadLine();
                                if (tempS.All(char.IsDigit) & tempS != "")
                                {
                                    break;
                                }
                                Console.Write(" You can not use string or punctuation. Please enter integer : ");

                            }
                            userfeedBackNegative = Convert.ToInt32(tempS);

                            if ((userfeedBackPositive == 1 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 1) | (userfeedBackPositive == 2 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 2))
                            //check feedback END
                            {
                                if (!(userfeedBackPositive == 2))
                                {
                                    if (userfeedBackNegative == 2)
                                    {
                                        Console.WriteLine(" You do not trick me. Your feedback have to be 2,0 or 0,-1. Game over !");
                                        Console.WriteLine("Press enter for Exit game");
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    else if (userfeedBackPositive == 1)
                                    {
                                        Console.WriteLine(" You do not trick me. Your feedback have to be 2,0 or 0,-1. Game over !");
                                        Console.WriteLine("Press enter for Exit game");
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        // guess 3 feedback negative 1******* 
                                        if (tempR == 1)
                                        {
                                            firstNumber = b;
                                            secondNumber = c;
                                            
                                        }
                                        else
                                        {
                                            firstNumber = d;
                                            secondNumber = a;
                                        }


                                    }

                                    //change number END

                                    Console.WriteLine(" My Guess (3) : {0}{1}", firstNumber, secondNumber);
                                    //check feedback
                                    Console.Write(" Your Feedback (+): ");
                                    while (true)
                                    {
                                        tempS = Console.ReadLine();
                                        if (tempS.All(char.IsDigit) & tempS != "")
                                        {
                                            break;
                                        }
                                        Console.Write(" You can not use string or punctuation. Please enter integer : ");

                                    }
                                    userfeedBackPositive = Convert.ToInt32(tempS);
                                    Console.Write(" Your Feedback (-): ");
                                    while (true)
                                    {
                                        tempS = Console.ReadLine();
                                        if (tempS.All(char.IsDigit) & tempS != "")
                                        {
                                            break;
                                        }
                                        Console.Write(" You can not use string or punctuation. Please enter integer : ");

                                    }
                                    userfeedBackNegative = Convert.ToInt32(tempS);

                                    if ((userfeedBackPositive == 1 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 1) | (userfeedBackPositive == 2 & userfeedBackNegative == 0) | (userfeedBackPositive == 0 & userfeedBackNegative == 2))
                                    //check feedback END
                                    {
                                        if (userfeedBackPositive == 2)
                                        {
                                            userpoint += 3;
                                            Console.WriteLine(@" I WIN!
*******************************************************************************");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" You do not trick me. Your feedback have to be 2,0. Game over !"); // kesin doğru.
                                            Console.WriteLine("Press enter for Exit game");
                                            Console.ReadLine();
                                            Environment.Exit(0);
                                        }
                                    }
                                    else
                                    {
                                        //wrong feedback -guess 3 feedback negative 1
                                        Console.WriteLine(" Game over the fact that your feedback wrong. Your feed back have to be one of numbers that +1,0 0,-1 +2,0 and 0,-2.");
                                        Console.WriteLine("Press enter for Exit game");
                                        Console.ReadLine();
                                        Environment.Exit(0);
                                    }


                                    // guess 3 feedback negative 1 ******* END
                                }

                                    //guess 2 end

                                else
                                {
                                    //guess 2
                                    userpoint += 2;
                                    Console.WriteLine(@" I WIN!
*******************************************************************************");

                                }

                                //guess 2 END
                            }
                            else
                            {
                                //wrong feedback - guess 2 feedback
                                Console.WriteLine(" Game over the fact that your feedback wrong. Your feed back have to be one of numbers that +1,0 0,-1 +2,0 and 0,-2.");
                                Console.WriteLine("Press enter for Exit game");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }

                            //feedback negative 1 END ----***********----------


                        }






                    }
                    else
                    {
                        //guess 1
                        userpoint++;
                        Console.WriteLine(@" I WIN!
*******************************************************************************");
                    }
                }
                else
                {
                    //wrong feedback -first feedback
                    Console.WriteLine(" Game over the fact that your feedback wrong. Your feed back have to be one of numbers that +1,0 0,-1 +2,0 and 0,-2.");
                    Console.WriteLine("Press enter for Exit game");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                if (round != 10)
                {
                    Console.WriteLine(@"
 Second game done. Press enter and then {0}. round will start
", (round + 1));
                    Console.ReadLine();
                }

                //for loop END
            }



            if (userpoint > computerpoint)
            {
                Console.WriteLine(@"


     )                                                                 
  ( /(                                         )                       
  )\())     (       ) (     (     )  (      ( /(    (  (        (      
 ((_)\ (   ))\   ( /( )(   ))\   /(( )\  (  )\())(  )( )\  (   ))\ (   
__ ((_))\ /((_)  )(_)|()\ /((_) (_))((_) )\(_))/ )\(()((_) )\ /((_))\  
\ \ / ((_|_))(  ((_)_ ((_|_))   _)((_|_)((_) |_ ((_)((_|_)((_|_))(((_) 
 \ V / _ \ || | / _` | '_/ -_)  \ V /| / _||  _/ _ \ '_| / _ \ || (_-< 
  |_|\___/\_,_| \__,_|_| \___|   \_/ |_\__| \__\___/_| |_\___/\_,_/__/ 
                                                                       


YOUR POINT  {0}  
COMPUTER POINT {1}




###############################################################################
###############################################################################", userpoint, computerpoint);
            }
            else if (userpoint < computerpoint)
            {
                Console.WriteLine(@"


_____.___.              .__                  __   
\__  |   | ____  __ __  |  |   ____  _______/  |_ 
 /   |   |/  _ \|  |  \ |  |  /  _ \/  ___/\   __\
 \____   (  <_> )  |  / |  |_(  <_> )___ \  |  |  
 / ______|\____/|____/  |____/\____/____  > |__|  
 \/                                     \/        

YOUR POINT  {0}  
MY POİNT {1}




###############################################################################
###############################################################################", userpoint, computerpoint);
            }
            else
            {
                Console.WriteLine(@"

________                         
___  __ \____________ ___      __
__  / / /_  ___/  __ `/_ | /| / /
_  /_/ /_  /   / /_/ /__ |/ |/ / 
/_____/ /_/    \__,_/ ____/|__/  
                                     

YOUR POINT  {0}  
MY POINT {1}




###############################################################################
###############################################################################", userpoint, computerpoint);
            }

            //END
        }
    }
}
