/*
Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N при помощи рекурсии.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/




int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


void ShowNaturalNum(int N)
{
    if(N<=0){
        return;
    } 
    
    ShowNaturalNum(N-1);
    Console.WriteLine(N);
} 
   


int n=Prompt("enter N: ");
ShowNaturalNum(n);







