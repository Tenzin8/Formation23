// Récupération du nombre
Console.WriteLine("saisie un nombre");
string saisie = Console.ReadLine();
//conversion de string vers decimal
decimal nombre = decimal.Parse(saisie);
// affichage conditional
if (nombre > 0)
{
    Console.WriteLine("le nombre est positive");
}
else if (nombre < 0)
{
    Console.WriteLine("le nombre est négative");
}
else
{
    Console.WriteLine ("le nombre est positif et négatif (c'est zéro)");
}