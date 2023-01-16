using Proiect_Relevance.Articole_Inventar;

string nrMax, gMax, vMax;

//Introducerea limitelor ghiozdanului
Console.WriteLine("Introduceti limitele maxime suportate de ghiozdan:\nNumar maxim de articole:");
nrMax = Console.ReadLine();
Console.WriteLine("Greutate maxima:");
gMax = Console.ReadLine();
Console.WriteLine("Volum maxim:");
vMax = Console.ReadLine();

Ghiozdan ghiozdan = new Ghiozdan(Convert.ToInt32(nrMax), float.Parse(gMax), float.Parse(vMax));

while(true)
{
    //Afisarea meniului cu articolele
    Console.WriteLine("TIPURILE DE OBIECTE CARE POT FI INTRODUSE IN GHIOZDAN:\n\n\t1.Sageata\n\t\tGreutate: 0.1\n\t\tVolum: 0.05\n\t2.Arc\n\t\tGreutate: 1\n\t\tVolum: 4\n\t3.Franghie\n\t\tGreutate: 1\n\t\tVolum: 1.5\n\t4.Apa\n\t\tGreutate: 2\n\t\tVolum: 3\n\t5.Portie de mancare\n\t\tGreutate: 1\n\t\tVolum: 0.5\n\t6.Sabie\n\t\tGreutate: 5\n\t\tVolum: 3\n\nIntroduceti numarul corespunzator obiectului pe care doriti sa-l introduceti in ghiozdan:");

    //Citirea numarului articolului ce urmeaza a fi introdus in ghiozdan
    string userInput = "";
    userInput = Console.ReadLine();

    //Folosim un switch cu cazuri pentru fiecare articol si adaugam articolul daca se respecta limitele ghiozdanului
    switch (userInput)
    {
        case "1":
            Sageata sageata = new Sageata();
            Console.WriteLine($"\nStatus adaugare: {ghiozdan.Adauga(sageata)}");
            break;

        case "2":
            Arc arc = new Arc();
            Console.WriteLine($"\nStatus adaugare: {ghiozdan.Adauga(arc)}");
            break;

        case "3":
            Franghie franghie = new Franghie();
            Console.WriteLine($"\nStatus adaugare: {ghiozdan.Adauga(franghie)}");
            break;

        case "4":
            Apa apa = new Apa();
            Console.WriteLine($"\nStatus adaugare: {ghiozdan.Adauga(apa)}");
            break;

        case "5":
            PortieDeMancare portie = new PortieDeMancare();
            Console.WriteLine($"\nStatus adaugare: {ghiozdan.Adauga(portie)}");
            break;

        case "6":
            Sabie sabie = new Sabie();
            Console.WriteLine($"\nStatus adaugare: {ghiozdan.Adauga(sabie)}");
            break;

        default:
            Console.WriteLine($"\nStatus adaugare: False");
            break;
    }

    //Afisam dupa fiecare adaugare sau incercare de adaugare parametrii articolului
    ghiozdan.StatusGhiozdan();
}

