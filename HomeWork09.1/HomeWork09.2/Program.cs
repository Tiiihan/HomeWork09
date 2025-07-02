//Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.
const int ROW = 3;
const int COLUMN = 3;
const int MIN = -101;
const int MAX = 101;

int[,] arr = new int[ROW, COLUMN];
int[] arrForSorting = new int[ROW * COLUMN];

var random = new Random();

Console.WriteLine("Before sorting");

int indexOfSortArr = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
	for (int j = 0; j < arr.GetLength(1); j++)
	{
		arr[i, j] = random.Next(MIN, MAX);

		arrForSorting[indexOfSortArr] = arr[i, j];
		indexOfSortArr++;

		Console.Write(arr[i, j] + "\t");
	}
	Console.WriteLine();
}

for (int i = 0; i < arrForSorting.Length - 1; i++)
	for (int j = 0; j < arrForSorting.Length - 1 - i; j++)
		if (arrForSorting[j] > arrForSorting[j + 1])
		{
			arrForSorting[j] += arrForSorting[j + 1];
			arrForSorting[j + 1] = arrForSorting[j] - arrForSorting[j + 1];
			arrForSorting[j] -= arrForSorting[j + 1];
		}

Console.WriteLine("\nAfter sorting");

indexOfSortArr = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
	for (int j = 0; j < arr.GetLength(1); j++)
	{
		arr[i, j] = arrForSorting[indexOfSortArr];
		indexOfSortArr++;

		Console.Write(arr[i,j] + "\t");
	}
	Console.WriteLine();
}