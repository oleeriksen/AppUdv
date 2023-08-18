using System;
namespace Module01
{
    public class Hello
    {
        public static void Run() {
            Console.Write("Skriv dit navn: ");
            var name = Console.ReadLine();
            var hilsen = "Hello " + name + "! Have a nice day!";

            name = name[0].ToString().ToUpper() + name.Substring(1);
            var time = DateTime.Now.Hour;
            if (time <= 10) // morgen
                hilsen = "God morgen " + name + "! Håber du får en god dag!";
            else if (time <= 13)
                hilsen = "God formiddag " + name + "! Håber resten af dagen bliver god!";
            else if (time <= 17)
                hilsen = "God dag " + name + "!";
            else if (time <= 22)
                hilsen = "God aften " + name + "! Håber du har haft en god dag";
            else hilsen = "God nat " + name + "! Sov godt!";

            Console.WriteLine(hilsen);
        }
    }
}

