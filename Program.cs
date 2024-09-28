//lets get to know the user/player

Console.WriteLine();
Console.WriteLine("Hello, Friend");
Console.WriteLine("I'm a ProjectA. Can you tell me your first name?");
string firstname = Console.ReadLine();
Console.WriteLine($"Hi {firstname}");

//lets see if the user is old enough to drive using boolean
Console.WriteLine("How old are you :)");
int userAge = int.Parse(Console.ReadLine());
Console.WriteLine( "OMG!");

if (userAge < 30)
{
    Console.WriteLine("Wow, you're young.");
}
else
{
    Console.WriteLine("Did it all, seen it all huh?");

}


bool isOldToDrive = userAge > 16;
Console.ReadLine();
Console.WriteLine($"Are you old enough to drive? ");
Console.ReadLine();
if (isOldToDrive)
    Console.WriteLine(value: "That is Awesome!");
if (!isOldToDrive)
    Console.WriteLine($"Aww, that sucks we only have to wait {16 - userAge} more years.");
Console.WriteLine();

//now let's see if user is old enough to drink or not
bool isOldEnoughToDrink = userAge >= 19;
Console.WriteLine($"You are old to enogh to drink?  ");
Console.ReadLine();
if (isOldEnoughToDrink) {
    Console.WriteLine($"Cheers! DONT DRINK AND DRIVE!");
} else {
 
    Console.WriteLine($"Don't worry, Drinking is bad for the health anyways");
}
Console.ReadLine();

//now let's see if user can drive a car
Console.WriteLine("Can you drive a car?");
Console.ReadLine();
bool canDriveCar = isOldToDrive || isOldEnoughToDrink;
if (canDriveCar)
    Console.WriteLine($"I bet you can");
else
    Console.WriteLine($"hmmmmm...");
Console.ReadLine();

//lets's see how much user has
float Savingsmoney = 0;
Console.WriteLine($"you currently have ${Savingsmoney}");
Console.ReadLine();

//now lets send user $10.000_00 as gift
Savingsmoney += 10000.00f;
Console.WriteLine($"Oh look, I just sent you a little surprise, use that to get a new car.");
 Console.ReadLine();
Console.WriteLine($"You have ${Savingsmoney}");
Console.WriteLine("Now lets see which car you prefer...");

//lets create variables for our car options and assign prices to them
float carBMW = 9500.50f;
float carHonda = 5000.00f;
float carFerrarri = 999999.99f;
Console.WriteLine($"You can buy a BMW: {carBMW}, Honda: {carHonda} or a Ferrarri: {carFerrarri}");


//lets allow the user to pick an option
string input = Console.ReadLine();

if (input.ToUpper() == "BMW")
{
    Savingsmoney -= carBMW;

}

else if (input.ToUpper() == "HONDA")
{
    Savingsmoney -= carHonda;

}
else if (input.ToUpper() == "FERRARRI")
{
 Savingsmoney -= carFerrarri;
}

else Console.WriteLine("invalid car choice");


//lets see how much user has after their purchase
Console.WriteLine( $"You now have ${Savingsmoney}" );
Console.ReadLine();
if (Savingsmoney > 0)
{
    Console.WriteLine($"You can use the remaining amount for gas.");
}
else
{
        Console.WriteLine($"You are now in generational debt of {Savingsmoney}.");

}



Console.WriteLine("Congrats on your new car :)");
﻿
