Console.WriteLine("enter your last name:");
string lastname = Console.ReadLine();

Console.WriteLine("enter your gender m/f/n");
char usergender = char.Parse(Console.ReadLine());

string greeting;

if (usergender == 'f')
{
    greeting = "Ms.";
}
else if (usergender== 'm')
 {
    greeting = "Mr.";
 }   

else
{ greeting = ""; }
Console.WriteLine($"hello, {greeting} {lastname}!");

Console.WriteLine("Enter your date of birth :");

int usersyb = Int32.Parse(Console.ReadLine());

int currentyear = DateTime.Now.Year;

int userage = currentyear - usersyb;

//Console.WriteLine($"You are {userage} years old. ");

    if (userage >= 13)
{
    Console.WriteLine($"You are {userage} - old enough to have an account");
}
    else
{
    Console.WriteLine($"You are {userage} too young to have an account");
}


//int userage = Int32 .Parse(Console.ReadLine());

//if (userage >= 13) 
//{
//    Console.WriteLine("You are old enough to have an account");
//}
//else 
//{
//    Console.WriteLine("You are too young to have an account");
//}