// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


bool IsPowerOfTwo(int N)
{
    if(N==1)
    {
        return true;
    } 

    return IsPowerOfTwo(N/2)&&(N%2==0);
    
    
} 

int a=Prompt("enter a: ");
bool result=IsPowerOfTwo(a);

System.Console.WriteLine($"number is power of 2={result}");