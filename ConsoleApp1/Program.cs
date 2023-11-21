Console.WriteLine("Saisie votre Age : ");
String saisieAge = Console.ReadLine();
int Age = int.Parse(saisieAge);
Console.WriteLine("Etes vous une fille ou un garçon?");
Console.WriteLine("1 fille");
Console.WriteLine("2 garçon");
Console.WriteLine();
Console.WriteLine("Selectionnez 1 ou 2 :");
String saisieSexe = Console.ReadLine();
int ChoixGenre = int.Parse(saisieSexe);
string messageFinal = "Tu es ";

if (ChoixGenre == 1 && Age < 18) 
{
    messageFinal = messageFinal + "mineure.";
}
else if (ChoixGenre == 1 && Age >= 18)
{
    messageFinal += "majeure.";
}
else if (ChoixGenre == 2 && Age < 18)
{
    messageFinal += "mineur.";
}
else if (ChoixGenre == 2 && Age >= 18)
{
    messageFinal += "majeur.";
}
else
{
    messageFinal = "problème !";
}
Console.WriteLine(messageFinal);
















