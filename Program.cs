
Console.Write("Enter the first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Choose an operation (+,-,*,/): ");
string operation = Console.ReadLine();

double result = 0;
if (operation =="+")
result = num1+num2;
else if (operation =="-")
result = num1-num2;
else if (operation =="*")
result = num1*num2;
else if (operation =="/")
result = num1/num2;
else{
    Console.WriteLine("Invalid operation. ");
    return;
}

Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
