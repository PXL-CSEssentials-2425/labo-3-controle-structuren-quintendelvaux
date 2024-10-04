/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */
using System.Security.Cryptography;
Random randomNumberGenerator = new Random();
Random healing = new Random();
Random attackDmg = new Random();
int knightHealth = 0;
int goblinHealth = 0;
int gCountholder = 0;
int kCountholder = 0;
int hCountholder = 0;
bool endGame = false;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"chose health: c \nrandomize health: r");
Console.ResetColor();
string healthChoiseControl = Console.ReadLine();


//healthControll
switch (healthChoiseControl)
{
    case "c":
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Health knight: ");
        Console.ResetColor();
        knightHealth = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Health goblin: ");
        Console.ResetColor();
        goblinHealth = int.Parse(Console.ReadLine());
        break;
    case "r":
        knightHealth = (randomNumberGenerator.Next(1, 101));
        goblinHealth = randomNumberGenerator.Next(1, 101);

        break;
    default:

        break;
}
while ((healthChoiseControl != "c") && (healthChoiseControl != "r"))
{

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"chose health: c \nrandomize health: r");
    Console.ResetColor();
    healthChoiseControl = Console.ReadLine();

    switch (healthChoiseControl)
    {
        case "c":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Health knight: ");
            Console.ResetColor();
            knightHealth = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Health goblin: ");
            Console.ResetColor();
            goblinHealth = int.Parse(Console.ReadLine());
            break;
        case "r":
            knightHealth = (randomNumberGenerator.Next(1, 101));
            goblinHealth = randomNumberGenerator.Next(1, 101);

            break;
        default:

            break;
    }
}
    //healthControll^^




    //start
    Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Game has started!");
Console.ResetColor();
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Knight health {knightHealth}");
Console.WriteLine($"Goblin health {goblinHealth}");
Console.ResetColor();
Console.WriteLine();

while (endGame == false)
{


    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Attack: a");
    Console.WriteLine("Heal: h");
    Console.Write("Please select an action: ");
    Console.ResetColor();
    string action = Console.ReadLine();


    switch (action)
    {
        case "a":
            kCountholder = attackDmg.Next(1, 10);
            goblinHealth -= kCountholder;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your attack did {kCountholder} damage.");
            Console.ResetColor();
            gCountholder = attackDmg.Next(1, 10);
            knightHealth -= gCountholder;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Enemy attack did {gCountholder} damage.");
            Console.ResetColor();
            break;
        case "h":
            hCountholder = healing.Next(1, 5);
            knightHealth += hCountholder;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"you have healed {hCountholder} health");
            Console.ResetColor();
            gCountholder = attackDmg.Next(1, 10);
            knightHealth -= gCountholder;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Enemy attack did {gCountholder} damage.");
            Console.ResetColor();
            break;
        default:

            break;
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Knight health {knightHealth}");
    Console.WriteLine($"Goblin health {goblinHealth}");
    Console.ResetColor();
    Console.WriteLine();


    if (knightHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("you have been slayed!");
        Console.ResetColor();
        endGame = true;
    }
    if (goblinHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("goblin has been slayed!");
        Console.ResetColor();
        endGame = true;
    }

}
/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
