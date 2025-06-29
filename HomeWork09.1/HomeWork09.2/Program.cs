//Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.
const int ROW = 3;
const int COLUMN = 3;
const int MIN = -20;
const int MAX = 20;

int[,] arr = new int[ROW, COLUMN]
	{
		{45,2,33 },
		{5,-85,60 },
		{1234,35,-8}
	};

int[] row = new int[COLUMN];
int temp = 0;
for (int i = 0; i < ROW; i++)
{
	for (int j = 0; j < COLUMN; j++)
	{
		row[j] = arr[i, j];
	}

	for (int l = 0; l < COLUMN - 1; l++)
		for (int k = 0; k < COLUMN - 1 - l; k++)
		{
			if (row[k] > row[k + 1])
			{
				temp = row[k];
				row[k] = row[k + 1];
				row[k + 1] = temp;
			}
		}

	for (int j = 0; j < COLUMN; j++)
	{
		arr[i, j] = row[j];
	}
}


for (int i = 0; i < ROW; i++)
	for (int j = 0; j < COLUMN; j++)
		Console.WriteLine(arr[i, j] + "\t\n");