//Написати програму, що знаходить другий найбільший елемент масиву.

const int LENGTH = 10;
const int MIN = -50;
const int MAX = 151;

int[] arr = new int[LENGTH];
int maxNumber = int.MinValue;
int secondMaxNumber = int.MinValue;

var random = new Random();

for (int i = 0; i < LENGTH; i++)
{
	arr[i] = random.Next(MIN, MAX);
	Console.Write(arr[i] + "\t");

	if (arr[i] > maxNumber)
	{
		secondMaxNumber = maxNumber;
		maxNumber = arr[i];
	}
	else if (arr[i] > secondMaxNumber && arr[i] != maxNumber)
		secondMaxNumber = arr[i];
}

Console.WriteLine($"\n\nMax number: {maxNumber}\n\nSecond max number: {secondMaxNumber}");