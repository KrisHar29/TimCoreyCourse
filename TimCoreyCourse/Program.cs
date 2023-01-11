//// Create a console App that has variables to hold a persons name, age
//// if they are alive, and phone number. Do not need to capture.

//string name = "Kristoffer";
//int age = 32;
//bool isAlive = true;
//long phoneNumber = 0123456789;


//// captur a users age, identify how old they will be =/- 25 yrs and print information

//Console.Write("What is your age?: ");
//string? userAge = Console.ReadLine();
//int userAgeInt = Convert.ToInt32(userAge);
//Console.WriteLine($"Your age in 25 years will be: {userAgeInt + 25}");
//Console.WriteLine($"Your age 25 years ago was: {userAgeInt - 25}");


//// capture users first name, welcome tim as professor and anybody else as student.

//Console.Write("What is your name?: ");
//string usersName = Console.ReadLine();

//if (usersName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello Professor");
//}
//else
//{
//    Console.WriteLine("Hello student");
//}


//// plan and build a console app that aska user their name and their age.
//// If there name is bob or sue, address them as professor.
//// If they are under 21 recomend they age x number of years to start this class.

//Console.Write("What is your first name?: ");
//string usersName = Console.ReadLine();
//Console.Write("What is your age?: ");
//string usersAge = Console.ReadLine();

//if (int.TryParse(usersAge, out int age))
//{
//    if (usersName.ToLower() == "bob" || usersName.ToLower() == "sue")
//    {
//        Console.WriteLine($"Hello Professor {usersName}"); 
//    }
//    else { Console.WriteLine($"Hello Student {usersName}"); }

//    if (age < 21) { Console.WriteLine($"I recomend you wait {21 - age} years, {usersName}"); }
//    else { Console.WriteLine($"Welcome to class {usersName}"); }
//}
//else { Console.WriteLine("Invalid Age"); }

//// create a console app that asks a user their name. welcome (tim) as professor and anybody else as student 
//// do this until user types exit.


//bool anotherName = true;
//do
//{
//    Console.Write("What is your name?: ");
//    string userName = Console.ReadLine();
//    if (userName.ToLower() == "tim") { Console.WriteLine("Hello Professor"); }
//    else { Console.WriteLine("Hello Student"); }
//    Console.Write("Enter another name?(y/n): ");
//    string anotherStudent = Console.ReadLine();
//    if (anotherStudent.ToLower() == "y") { anotherName = true; }
//    else if (anotherStudent.ToLower() == "n") { anotherName = false; }
//    else { Console.WriteLine("Invalid input. Breaking cycle."); break; }
//} while (anotherName == true);

//// create an array of 3 names ask user to select a number return that name
//// check for invalid numbers

//bool attempt = true;
//string[] names = new string[] { "Kris", "Anna", "Teddy", "Pixel" };
//do
//{
//    Console.Write("Type a number 1-4: ");
//    string input = Console.ReadLine();
//    if (int.TryParse(input, out int number))
//    {
//        if (number >= 1 && number <= 4)
//        {
//            Console.WriteLine($"Name picked is {names[number - 1]}");
//        }
//    }
//    else { Console.WriteLine("Invalid number, try again."); }
//    Console.WriteLine("Want to enter another number?(y/n)");
//    string anotherAttempt = Console.ReadLine();
//    if (anotherAttempt.ToLower() == "y") { attempt = true; }
//    else if (anotherAttempt.ToLower() == "n") { attempt = false; }
//    else { Console.WriteLine("Invalid input. Breaking cycle."); break; }

//} while (attempt == true);


//// add students to a class list until there are no more students,
//// then print out the count of students

//bool addAnother = true;
//List<string> students = new List<string>();
//bool isString;
//do
//{
//    Console.Write("Enter a student name: ");
//    string input = Console.ReadLine();
//    students.Add(input);
//    Console.Write("Enter another student name?(y/n): ");
//    string inputAnother = Console.ReadLine();
//    if (inputAnother.ToLower() == "y") { addAnother = true; }
//    else if (inputAnother.ToLower() == "n") { addAnother = false; }
//    else { Console.WriteLine("Invalid input. Breaking cycle"); break; }

//} while (addAnother == true);
//Console.WriteLine($"There are {students.Count} students.");

//// create a dictionary list of employee ids and name.
//// fill in a few records then ask user for their id and return their name

//Dictionary<int , string> employees = new Dictionary<int , string>();
//employees.Add(1, "Adam");
//employees.Add(2, "Bob");
//employees.Add(3, "Charlie");
//employees.Add(4, "Dylan");

//Console.Write("Enter your ID: ");
//string input = Console.ReadLine();
//if (int.TryParse(input, out int id))
//{
//    if (employees.ContainsKey(id)) { Console.WriteLine($"Hello, {employees[id]}."); }
//    else { Console.WriteLine("Invalid ID."); }
//}
//else { Console.WriteLine("Invalid input."); }


//// ask the user for a comma seperated list of first names(no spaces)
//// split the string into a string array.
//// loop through the array and print hello name for each person

//Console.Write("Enter a list of names seperated by a ',' (dont use spaces): ");
//string? input = Console.ReadLine();
//if (input.Length >0)
//{
//    List<string> namesList = input.Split(',').ToList();
//    for (int i = 0; i < namesList.Count; i++)
//    {
//        Console.WriteLine($"Hello, {namesList[i]}.");
//    }
//}
//else { Console.WriteLine("Invalid input."); }

//// ask  user for first name.
//// continue asking for first names until there are no more(you to decide)
//// then loop through each name using a foreach

//List<string> names = new List<string>();
//bool addName = true;
//do
//{
//    Console.Write("Please enter a name: ");
//    string input = Console.ReadLine();
//    if (input.Length > 0)
//    {
//        names.Add(input);
//    }
//    else { Console.WriteLine("invalid input, stopping."); }
//    Console.Write("Would you like to add another name? (y/n): ");
//    string inputAdd = Console.ReadLine();
//    if (inputAdd.ToLower() == "y") { continue; }
//    else if (inputAdd.ToLower() == "n") { break; }
//    else { Console.WriteLine("invalid input stopping.");  }
//} while (addName == true);


//foreach (string name in names)
//{
//    Console.WriteLine($"Hello {name}.");
//}

////create a welcome method,
////a method to ask for users name and
////another to tell that user hello name.
////call the methods from program.cs

//using TCHW1;

//Method.Welcome();

//string name = Method.AskName();

//Method.SayHello(name);


//// build a console guest book. ask the user for their name
//// and how many are in their party/ keep track of how may
//// people are at the party. at end print out guest list
//// and total number of guests.
//using GuestBookMethod;

//Dictionary<string, int> guests = new Dictionary<string, int>();
//bool moreGuests = true;
//do
//{
//    GBMeth.Welcome();
//    var nameAndParty = GBMeth.AskNameAndParty();
//    guests.Add(nameAndParty.Item1, nameAndParty.Item2);
//    moreGuests = GBMeth.MoreGuests();

//} while (moreGuests == true);

//GBMeth.GuestsAndTotalGuests(guests);

// create a console app with a for loop that throws an
// exception after 5 iterations catch the exception

//int[] array = new int[] { 1, 2, 3, 4, 5 };

//for (int i = 0; i <= (array.Length+1); i++)
//{
//    try
//    {
//        Console.WriteLine($"Printing {array[i]}");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.ToString());
//        Console.WriteLine(ex);
//        Console.WriteLine(ex.Message);
//        Console.WriteLine(ex.StackTrace);
//        Console.WriteLine(ex.InnerException);
//    }
//}

//// create a console app that loops from 1 to 100,
//// throw an exception on 73.
//// use a breakpoint to break before the breaking situation

//int i = 0;
//int count = 0;

//for (i = 1; i < 100; i++ )
//{
//    int total;
//    if ( i == 73)
//    {
//        throw new Exception();
//    }
//    else 
//    {
//        total =+ i; 
//    }
//    count += total;
//}

//Console.WriteLine(count);


//// create a console app with a static class
//// that handles calculations


//using TCHW1;
//using static TCHW1.Calc;

//double x = RequestData.GetADouble("Enter your first number: ");
//double y = RequestData.GetADouble("Enter your first number: ");

//double result = Calc.Add(x, y);

//Console.WriteLine(result);

//double a = RequestData.GetADouble("Enter your first number: ");
//double b = RequestData.GetADouble("Enter your first number: ");

//double result2 = Calc.Subtract(a, b);

//Console.WriteLine(result2);

//double g = RequestData.GetADouble("Enter your first number: ");
//double h = RequestData.GetADouble("Enter your first number: ");

//double result3 = Calc.Multiply(g, h);

//Console.WriteLine(result3);

//double t = RequestData.GetADouble("Enter your first number: ");
//double q = RequestData.GetADouble("Enter your first number: ");

//double result4 = Calc.Divide(t, q);

//Console.WriteLine(result4);