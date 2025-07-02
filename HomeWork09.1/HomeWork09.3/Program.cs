//Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

const int LENGTH = 10;
const int MIN = -50;
const int MAX = 200;

bool isInt = false;
int indexOfArray = 0;

int[] originalArr = new int[LENGTH];
int[] newArr = new int[LENGTH - 1];

while (!isInt)
{
	Console.Write("Enter index of array you want to delete: ");
	isInt = int.TryParse(Console.ReadLine(), out indexOfArray);

	if(indexOfArray >= LENGTH || indexOfArray < 0)
		isInt = false;
}

var random = new Random();

for (int i = 0; i < originalArr.Length; i++)
{
	originalArr[i] = random.Next(MIN, MAX);
	Console.WriteLine(originalArr[i]);
}

int resultIndex = 0;

for (int i = 0; i < originalArr.Length; i++)
{
	if (i != indexOfArray)
	{
		newArr[resultIndex] = originalArr[i];
		resultIndex++;
	}
}

Console.WriteLine("\nArray after deleted element");

for (resultIndex = 0; resultIndex < newArr.Length; resultIndex++)
	Console.WriteLine(newArr[resultIndex]);