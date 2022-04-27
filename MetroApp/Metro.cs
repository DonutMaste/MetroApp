using MetroApp;
using System;

Console.ForegroundColor = ConsoleColor.Red;
Cas example = new Cas();
example.Main();
Console.WriteLine("Linky Pražského metra");
Console.ResetColor();
List<string> linkaA = new List<string>
{ "Nemocnice Motol", "Petřiny", "Nádraží Veleslavín", "Bořislavka", "Dejvická", "Hradčanská",
    "Malostranská", "Staroměstská", "Muzeum", "Můstek", "Náměstí Míru", "Jiřího z Poděbrad",
    "Flora", "Želivského", "STRAŠNICKÁ", "Skalka", "Depo Hostivař"
};
List<string> linkaD = new List<string>
{ "Náměstí Míru", "Náměstí Bratří Synků","Pankrác","Olbrachtova",
  "Nádraží Krč","Nemocnice Krč","Nové Dvory","Libuš","Písnice","Depo Písnice"
};
List<string> linkaC = new List<string>
{
    "Háje", "Opatov", "Chodov", "Roztyly", "Budějovická", "Pankrác",
    "Vyšehrad","I.P.Pavlova","Muzeum","Hlavní Nádraží","Florenc",
    "Vltavská","Nádraží Holešovice","Kobylisy","Ládví","Střížkov","Prosek","Letňany"
};

Console.WriteLine("Chcete Linku D nebo A nebo C ?");
string linky = Console.ReadLine();
Console.Clear();

if (linky == "A")
{
    LinkaMetraA linkaMetroA = new LinkaMetraA(linkaA);
    linkaMetroA.VypisPrvni();
    linkaMetroA.VypisPosledni();
    Console.WriteLine("---------------------------");

    linkaMetroA.VypisStanice();
    Console.WriteLine("---------------------------");

    Console.WriteLine("Zadej název stanice odejzdu a poté název cíle stanice");
    string prvniStanice = Console.ReadLine();
    string druhaStanice = Console.ReadLine();
    int cas = linkaMetroA.ZjistiCas(prvniStanice, druhaStanice);
    Console.Clear();
    if (cas == 0)
    {
        Console.WriteLine("Chybně zadána stanice");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Cesta z {prvniStanice} do {druhaStanice}, bude trvat okolo {cas} minut.");
        Console.ResetColor();
    }
    Console.WriteLine("Chcete znát i cenu vstupenky?");
    string nigga2 = Console.ReadLine();
    Console.Clear();
    if (nigga2 == "Ano")
    {
        Console.WriteLine("Cena vstupenky pro:");
        Console.WriteLine("Dítě: 16Kč");
        Console.WriteLine("Junior a Dospělý a Student: 32Kč");
    }
    else
    {
        Console.WriteLine("Děkuji za použití Tvojí Mámy");
    }
}
else if (linky == "D")
{
    LinkaMetraD linkaMetraD = new LinkaMetraD(linkaD);
    linkaMetraD.VypisPrvniD();
    linkaMetraD.VypisPosledni();
    Console.WriteLine("---------------------------");

    linkaMetraD.VypisStaniceD();
    Console.WriteLine("---------------------------");

    Console.WriteLine("Zadej název stanice odejzdu a poté název cíle stanice");
    string prvniStaniceD = Console.ReadLine();
    string druhaStaniceD = Console.ReadLine();
    int cas2 = linkaMetraD.ZjistiCas1(prvniStaniceD, druhaStaniceD);
    Console.Clear();
    if (cas2 == 0)
    {
        Console.WriteLine("Chybně zadána stanice");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Cesta z {prvniStaniceD} do {druhaStaniceD}, bude trvat okolo {cas2} minut.");
        Console.ResetColor();
    }
    Console.WriteLine("Chcete znát i cenu vstupenky?");
    string nigga1 = Console.ReadLine();
    Console.Clear();
    if (nigga1 == "Ano")
    {
        Console.WriteLine("Cena vstupenky pro:");
        Console.WriteLine("Dítě: 16Kč");
        Console.WriteLine("Junior a Dospělý a Student: 32Kč");
    }
    else
    {
        Console.WriteLine("Děkuji za použití Tvojí Mámy");
    }
}
else if (linky == "C")
{
    LinkaMetraC linkaMetraD = new LinkaMetraC(linkaC);
    linkaMetraD.VypisPrvniC();
    linkaMetraD.VypisPosledniC();
    Console.WriteLine("---------------------------");

    linkaMetraD.VypisStaniceC();
    Console.WriteLine("---------------------------");

    Console.WriteLine("Zadej název stanice odejzdu a poté název cíle stanice");
    string prvniStaniceD = Console.ReadLine();
    string druhaStaniceD = Console.ReadLine();
    int cas2 = linkaMetraD.ZjistiCas1(prvniStaniceD, druhaStaniceD);
    Console.Clear();
    if (cas2 == 0)
    {
        Console.WriteLine("Chybně zadána stanice");
        return;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Cesta z {prvniStaniceD} do {druhaStaniceD}, bude trvat okolo {cas2} minut.");
        Console.ResetColor();
        
    }
    Console.WriteLine("Chcete znát i cenu vstupenky?");
    string nigga = Console.ReadLine();
    Console.Clear();
    if (nigga == "Ano")
    {
        Console.WriteLine("Cena vstupenky pro:");
        Console.WriteLine("Dítě: 16Kč");
        Console.WriteLine("Junior a Dospělý a Student: 32Kč");
    }
    else
    {
        Console.WriteLine("Děkuji za použití Tvojí Mámy");
    }
}

    else if (linky != "D" && linky != "A" && linky != "C")
    {
        Console.WriteLine("Taková stanice není, zkuste to znovu ;)");
    }


