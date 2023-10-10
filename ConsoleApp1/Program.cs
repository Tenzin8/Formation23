Console.WriteLine("insert a number");
string saisaieNum = Console.ReadLine();
int num = int.Parse(saisaieNum);
if  (num < 0)
{
    Console.WriteLine("the number is negatif");
}
else if (num > 0)
{
    Console.WriteLine("the number is positif"); 
}
else 
{
    Console.WriteLine("the number is 0");
}