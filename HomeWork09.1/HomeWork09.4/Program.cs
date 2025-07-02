//Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

const int MIN = -10;
const int MAX = 10;
const int ROW = 5;
const int COLUMN = 5;

int[,] matrix = new int[ROW, COLUMN];
int sum = 0;

var random = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		matrix[i, j] = random.Next(MIN, MAX);

		if (i == j)
			sum += matrix[i, j];

		Console.Write($"{matrix[i, j]} \t");
	}
	Console.WriteLine("\n");
}

Console.WriteLine($"Sum: {sum}");