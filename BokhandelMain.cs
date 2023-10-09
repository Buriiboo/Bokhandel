using system;

namespace bokhandel
{
    class BokhandelMain
    {
        public static void BookMain()
        {
             while(true)
            {
                Console.WriteLine("+++++++++++++++++++++++++++++");
                Console.WriteLine("#############################");
                Console.WriteLine("Välkommen till vår Bokhandel!");
                Console.WriteLine("#############################");
                Console.WriteLine("+++++++++++++++++++++++++++++");
                Console.WriteLine("Vad vill du göra?:");
                Console.WriteLine("1. Lägg till personal");
                Console.WriteLine("2. Ny utrikting");
                Console.WriteLine("3. Arkiv");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                switch(choice)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "5":
                    return;
            }    
        }
    }
}

/* Uppgift: 
skapa ett program som hanterar en bokhandel:
"Vi har böcker som vi vill sälja på nätet. Vi vill kunna välja författare
i en lista när vi lägger in nya böcker.
Vi vill kunna markera om dom är skickade till KUND
*/

