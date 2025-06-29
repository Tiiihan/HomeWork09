//Написати програму, що знаходить другий найбільший елемент масиву.
const int LENGTH = 10;
const int MIN = -50;
const int MAX = 151;

int[] arr = new int[LENGTH];
int maxNumber = int.MinValue;
int secondMxNumber = int.MinValue;

var random = new Random();

for (int i = 0; i < LENGTH; i++)
{
	arr[i] = random.Next(MIN, MAX);
	Console.Write(arr[i] + "\t");
}

for (int i = 0; i < LENGTH; i++)
	if (arr[i] > maxNumber)
	{
		secondMxNumber = maxNumber;
		maxNumber = arr[i];
	}
	else if (arr[i] > secondMxNumber && arr[i] != maxNumber)
		secondMxNumber = arr[i];

Console.WriteLine($"\n\nMax number: {maxNumber}\n\nSecond max number: {secondMxNumber}");