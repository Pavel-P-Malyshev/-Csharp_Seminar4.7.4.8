/*
Задача 4: Напишите программу, которая на вход принимает два числа A и B, и 
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


int Power(int a, int b)
{
    
    if(b==0){
        return 1;
    } 
    
    return Power(a,b-1)*a;
    
    
} 
   


int a=Prompt("enter a: ");
int b=Prompt("enter b: ");
int result=Power(a,b);
System.Console.WriteLine($"B power of A is={result}");