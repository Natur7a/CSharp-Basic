// See https://aka.ms/new-console-template for more information



#region Operation


using Sesi1;

int x = 10;
int y = 20;
int sum = x + y;
int minus = x - y;
int multiply = x * y;
int divide = x / y;
int modulo = x % y;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Minus: {minus}");
Console.WriteLine($"Multiply: {multiply}");
Console.WriteLine($"Divide: {divide}");
Console.WriteLine($"Modulo: {modulo}");


#endregion

#region COmparisonatauperbandingan
int a = 2;
int b = 3;

bool isEqual = a == b;
bool isNotEqual = a != b;
bool isGreaterThan = a > b;
bool isLessThan = a < b;
bool isGreaterThanOrEqual = a >= b;
bool isLessThanOrEqual = a <= b;

Console.WriteLine($"Is Equal: {isEqual}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Greater Than or Equal: {isGreaterThanOrEqual}");
Console.WriteLine($"Is Less Than or Equal: {isLessThanOrEqual}");


bool isTrue = true;
bool isFalse = false;

bool andResult = isTrue && isFalse;
bool orResult = isTrue || isFalse;
bool notResult = !isEqual;

Console.WriteLine($"AND Result: {andResult}");
Console.WriteLine($"OR Result: {orResult}");
Console.WriteLine($"NOT Result: {notResult}");

#endregion

#region Collection 
int[] numbers = new int[3] { 1, 2, 3 };


Console.WriteLine(numbers[0]); // Output: 1
Console.WriteLine(numbers[1]); // Output: 2
Console.WriteLine(numbers[2]); // Output: 3


List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };

List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };

fruits.Add("Watermelon");

Console.WriteLine(fruits[0]); // Output: Apple
Console.WriteLine(fruits[1]); // Output: Banana
Console.WriteLine(fruits[2]); // Output: Orange
Console.WriteLine(fruits[3]); // Output: Watermelon

fruits.Remove("Banana");

Console.WriteLine(fruits[0]); // Output: Apple
Console.WriteLine(fruits[1]); // Output: Banana
Console.WriteLine(fruits[2]); // Output: Orange



Dictionary<string, int> ages = new Dictionary<string, int>
{
    { "Alice", 25 },
    { "Bob", 30 },
    { "Charlie", 35 }
};

ages.Add("David", 40);
ages.Remove("Bob");

Console.WriteLine(ages["Alice"]); // Output: 25

HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 5 };

uniqueNumbers.Add(3);

Console.WriteLine(string.Join(", ", uniqueNumbers)); // Output: 1, 2, 3, 4, 5

#endregion

#region Control Flow

int number = 100;
if(number < 50)
{
    Console.WriteLine("Number is less than 50");
} else if(number >= 50 && number < 100)
{
    Console.WriteLine("Number is between 50 and 100");
} else
{
    Console.WriteLine("Number is greater than or equal to 100");
}


foreach (int num in numbersList)
{
    Console.WriteLine($"Foreach Loop Number: {num}");
}

int i = 0;
while(i < 5)
{
    Console.WriteLine($"Iteration: {i}");
    i++;
}

#endregion

#region OOP
Car SportsCar = new Car();
SportsCar.Name = "Ferrari";
SportsCar.Color = "Red";
SportsCar.Sound();

Cat cat = new Cat();
cat.Name = "Kitty";
cat.MakeSound();

Dog dog = new Dog();
dog.MakeSound();

Savings savings = new Savings();
Console.WriteLine(savings.GetBalance());

savings.Deposit(1000);
Console.WriteLine(savings.GetBalance());

savings.Withdraw(500);
Console.WriteLine(savings.GetBalance());

#endregion
