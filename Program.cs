//Defense of Consolas

Console.Write("What is the target row: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("What is the column: ");
int column = int.Parse(Console.ReadLine());
string leftPosition = $"({row}, {column - 1})";
string rightPosition = $"({row}, {column + 1})";
string topPosition = $"({row + 1}, {column})";
string bottomPosition = $"({row - 1}, {column})";
Console.WriteLine($"Deploy to: \n{topPosition} \n{rightPosition} \n{bottomPosition} \n{leftPosition} ");