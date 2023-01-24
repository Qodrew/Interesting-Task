Console.Clear();

int[,] arrayI = new int[10, 10] ;


void FillArrayConst(int[,] inputArray) {
    int countCol = 1;
    int countStr = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            inputArray[i,j] = 1 * countStr;
            countStr++;
        }
    }
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            inputArray[i,j] = 1 * countCol;
            countCol++;
        }
    }
}

void FillArrayTable (int[,] inputArray) {
    for (int i = 1; i < 10; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            inputArray[i,j] = (i + 1) * (j + 1);
        }
    }
}

FillArrayConst(arrayI);
FillArrayTable(arrayI);


PrintArray(arrayI);
