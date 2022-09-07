/*
Задача 6: Проверка на простое число: 
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


bool IsSimple(int N, int denominator)
{
    if(denominator==1)
    {
        return true;
    } 

    return IsSimple(N,denominator-1)&&(N%denominator!=0);
    
    
} 

int a=Prompt("enter a: ");
bool result=IsSimple(a,a-1);

System.Console.WriteLine($"if a is simple number={result}");