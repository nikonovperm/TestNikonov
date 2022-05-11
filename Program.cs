/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. */ 

string[] GetArrayOutput(string[] arrayInput)
{
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arrayOutput = new string[count];
    return arrayOutput;
}

string[] FillArrayOutput(string[] arrayInput, string[] arrayOutput)
{
    int indexOutput = 0;
    for (int indexInput = 0; indexInput < arrayInput.Length; indexInput++)
    {
        if (arrayInput[indexInput].Length <= 3)
        {
            arrayOutput[indexOutput] = arrayInput[indexInput];
            indexOutput ++;
        }
    }
    return arrayOutput;
}

void PrintArray(string[] arrayOutput)
{
    for (int i = 0; i < arrayOutput.Length; i++)
    {
        Console.Write($"{arrayOutput[i]}\t");
    }
}

string[] arrayInput = {"hello", "2", "world", ":-)", "hi", "git"};
string[] arrayOutput = GetArrayOutput(arrayInput);
arrayOutput = FillArrayOutput(arrayInput, arrayOutput);
PrintArray(arrayOutput);
