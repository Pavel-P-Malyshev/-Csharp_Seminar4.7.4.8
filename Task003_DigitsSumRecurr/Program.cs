/*
Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


int DigitsSum(int N)
{
    
    if(N==0){
        return 0;
    } 
    //sum+=N%10;
    return DigitsSum(N/10)+N%10;
    
    //Console.WriteLine(sum);
} 
   


int n=Prompt("enter N: ");
int result=DigitsSum(n);
System.Console.WriteLine($"sum={result}");