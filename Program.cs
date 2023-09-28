namespace Textspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abschnitt Titelbild
            Console.WriteLine("**********************************************************************************************");

            Console.WriteLine("**********************************************************************************************");

            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("                       Iced Cappuccino mit Hafermilch!                            ");
            Console.WriteLine("       Mach dich auf die Suche nach einem Iced Cappuccino in der Zukunft!         ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**********************************************************************************************");

            Console.WriteLine("**********************************************************************************************");

            Console.WriteLine("**********************************************************************************************");

            Console.WriteLine("Drücke die a-Taste und bestätige mit der Enter-Taste um das Spiel zu starten!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Eingabe, dass Text kommt            
            string start = Console.ReadLine();
            if (start == "a")
            {
                System.Console.Clear();
                Console.WriteLine("Du wachst auf an einem ganz gewöhnlichen Tag, merkst aber schnell, dass deine Umgebung anders ist – viel fortschrittlicher. Ein Blick auf dem Kalender verrät dir, dass du dich 50 Jahre in der Zukunft befindest. Das einzige, was du jetzt an diesem Morgen brauchst um mit diesem Schock klar zu kommen ist ein: Iced Cold Brew Cappuccino mit Hafermilch. Auf geht die Reise!");
                //Option 1a
                Console.WriteLine("A: Du gehst auf den Vorhof und möchtest dich auf dein Fahrrad setzte, findest aber nur ein Hooverboard.");
                //Option 1b
                Console.WriteLine("B: Du schlenderst in die Garage setzt dich in dein Auto aber es hat eine Selbststeuerung.");
                Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste");
                string eingabe = Console.ReadLine();
                //Wenn man a eingegeben hat ...
                if (eingabe.ToLower() == "a")
                {
                    //Szene 2
                    Console.WriteLine("Du schwebst durch die Stadt. Du balancierst dich durch die Strassen und eine Kreuzung kommt auf dich zu. Du weisst nicht mehr genau wo dein Starbucks des Vertrauens ist und bist im Zwiespalt:");
                    //Option 1
                    Console.WriteLine("A: Entweder durch ein schwarzes Loch");
                    //Option 2
                    Console.WriteLine("B: Oder über die Brücke, die schwebt");
                    Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste");
                    string eingabe2 = Console.ReadLine();
                    if (eingabe2.ToLower() == "a")
                    {

                        //Szene 3
                        Console.WriteLine("Das schwarze Loch entpuppt sich als eine Super Mario Autorennbahn. Wähle Dein Fahrzeug, indem du eine Zahl von 1-4 wählst");
                        int fahrzeug = Convert.ToInt32(Console.ReadLine());
                        switch (fahrzeug)
                        {
                            case 1:
                                Console.WriteLine("Motorrad");
                                break;
                            case 2:
                                Console.WriteLine("Fahrrad");
                                break;
                            case 3:
                                Console.WriteLine("E-Bike");
                                break;
                            case 4:
                                Console.WriteLine("Trotinett");
                                break;
                            default:
                                Console.WriteLine("Ungültiger Wert!");
                                break;
                        }
                        //Szene 4
                        Console.WriteLine("Du befindest dich plötzlich in der Startlinie neben dir Gegner:innen mit den ausgefallensten Fahrzeugen. Der Startschuss fällt und du lässt dich auf das Abenteuer ein. Wie im Game gibt es auch auf der Rennbahn kleine Features zum sammeln.");
                        //Option A
                        Console.WriteLine("A:Rakete");
                        //Option B
                        Console.WriteLine("B:Regenbogen");
                        Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste");
                        string eingabe3 = Console.ReadLine();
                        if (eingabe3.ToLower() == "a")
                        {
                            Console.WriteLine("Mit voller Wucht schleuderst du nach vorne, verlierst das Gleichgewicht und fällst in den Abgrund. Direkt in eine Starbucks, wo du endlich deinen Iced Cappucciono trinken kannst.");
                        }
                        else if (eingabe.ToLower() == "b")
                        {
                            Console.WriteLine("Game Over: Der Regenbogen entpuppt sich als giftiges Elixier.");
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet");
                        }
                    }
                    //Falls nicht ...
                    else if (eingabe.ToLower() == "b")
                    {
                        Console.WriteLine("Brücke stürzt ab: Game Over");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet");
                    }

                }
                //Falls nicht ...
                else if (eingabe.ToLower() == "b")
                {
                    Console.WriteLine("Die Selbststeuerung funktioniert nicht einwandfrei und es geschieht ein Unfall: Game Over");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet");
                }


            }
            else
            {
                Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet");
            }
            Console.ReadKey();
            }
        }   
    }
    //Zusätzliche Klasse mit einer erweiterten Console.ReadLine Funktion mit einer TimeOut Funktion die wir nicht programmiert haben, da dies zu kompliziert ist.
    class Reader
    {
        private static Thread inputThread;
        private static Thread AutoResetEvent getInput, gotInput;
        private static string input;

        static Reader()
        {
            getInput = new AutoResetEvent(false);
            gotInput = new AutoResetEvent(false);
            inputThread = new Thread(reader);
            inputThread.IsBackground = true;
            inputThread.Start();
        }

        private static void reader()
        { 
            while (true)
            {
                getInput.WaitOne();
                input = Console.ReadLine();
                gotInput.Set();
            }
        }
    //Die neue ReadLine Methode die wir nicht selbst programmier haben, aber verwenden werden.
    public static string ReadLine(int timeOutMillisecs = Timeout.Infinite)
    {
        getInput.Set();
        bool success = gotInput.WaitOne(timeOutMillisecs);
        if (success)
        {
            return input;
        }
        else
        {
            throw new TimeoutException("User did not provide input within the timelimit.");
        }

    }     


        
    
    

