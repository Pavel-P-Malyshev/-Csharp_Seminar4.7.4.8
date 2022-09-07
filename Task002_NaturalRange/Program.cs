/*
Задача 2: Задайте значения M и N. Напишите программу, которая 
рекурсивно выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


void ShowNaturalRange(int min, int max)
{
    if(min>max){
        return;
    } 
    
    ShowNaturalRange(min, max-1);
    Console.WriteLine(max);
} 
   


int n=Prompt("enter N: ");
int m=Prompt("enter m;");
ShowNaturalRange(n,m);