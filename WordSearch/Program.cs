namespace WordSearch
{
    using System.IO;
    using System.Net.Sockets;
    using System.Text.RegularExpressions;
    using System.Threading;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = 15;

            string CategoriesAndWordsFilePath = "Words.txt";
            string[] CatergoriesAndWordsString =
                {
                    "Guild Wars 2", "Abbadon", "Melandru", "Balthazar", "Dwayna", "Grenth", "Kormir", "Lyssa", "Dhuum", "Aurene", "Jormag", "Mordremoth", "Glint", "Zhaitan", "Kralkatorrik", "Primordius",
                    "Rimworld", "Thrumbo", "Boomalope", "Alphabeaver", "Boomrat", "Mechanoid", "Megascarab", "MegaSloth", "WarQueen", "Spelopede", "Toxalope", "Animatree", "Termite", "Militor", "Tesseron", "Diabolus",
                    "Sly Cooper", "Sly", "Carmelita", "Bentley", "Murray", "Muggshot", "Pandaking", "Penelope", "Neyla", "Dimitri", "Clockwerk", "Contessa", "Guru", "Rajan", "Octavio", "JeanBison",
                    "Ratchet And Clank", "Ratchet", "Clank", "Nefarious", "Qwark", "Plumber", "Talwyn", "Skidd", "Starlene", "Protopet", "Sasha", "Rivet", "Azimuth", "Courtney", "Angela", "Skrunch",
                    "Dynasty Warriors", "CaoCao", "XunYu", "ZhugeLiang", "XiahouDun", "LuBu", "LiuBei", "GuanYinping", "GuanYu", "ZhangFei", "TaishiCi", "SunCe", "SunJian", "Diaochan", "PangTong", "ZhangLiao",
                    "World Of Warcraft", "Arthas", "Thrall", "Jaina", "Khadgar", "Sylvanas", "Medivh", "Alexstraza", "GulDan", "Sargeras", "Illidan", "Anduin", "Varian", "Ragnaros", "Elune", "Alleria",
                    "League Of Legends", "Ziggs", "Pantheon", "ChoGath", "Aatrox", "Anivia", "Briar", "Braum", "Draven", "Ekko", "Hecarim", "Nautilus", "Illaoi", "Jax", "Kallista", "Sona",
                    "Soulsborne", "Gwynn", "Ornstein", "Smough", "Manus", "Kalameet", "Sif", "Artorias", "Gyndolin", "Gwynevere", "Nito", "Gael", "Priscilla", "Seath", "Patches", "Radahn",
                    "Remnant From The Ashes", "Abomination", "Amalgam", "Annihilation", "Harvester", "Bane", "Bastion", "Bloat", "Cancer", "Cinderclad", "Corruptor", "Custodian", "Defiler", "Dran", "Pan", "Fae",
                    "Marvel", "Hulk", "Wolverine", "Nightcrawler", "Magneto", "Ironman", "Starlord", "Groot", "Rocket", "Collector", "Jeff", "Deadpool", "Darwin", "Cyclops", "Blackpanther", "fingfangfoom",
                };
            File.WriteAllLines(CategoriesAndWordsFilePath, CatergoriesAndWordsString);


            string[] allCategoriesAndWords = File.ReadAllLines(CategoriesAndWordsFilePath);

            Console.WriteLine("Select your category." + "\n" + "Guild Wars 2" + "\n" + "Rimworld" + "\n" + "Sly Cooper" + "\n" + "Ratchet And Clank" + "\n" + "Dynasty Warriors" + "\n" + "World Of Warcraft" + "\n" + "League Of Legends" + "\n" + "Soulsborne" + "\n" + "Remnant From The Ashes" + "\n" + "Marvel");
            string? userInput = Console.ReadLine()?.Trim().ToLower();

            if (!Array.Exists(CatergoriesAndWordsString, choice => choice.Equals(userInput, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Invalid choice!." + "\n");
            }

            string[][] categoriesAndWords = new string[10][];
            for (int i = 0; i < categoriesAndWords.Length; i++)
            {
                categoriesAndWords[i] = new string[numberOfWords + 1];
                for (int j = 0; j < categoriesAndWords[i].Length; j++)
                {
                    categoriesAndWords[i][j] = allCategoriesAndWords[i * (numberOfWords + 1) + j];
                }
            }

            string[] eightChosenWords = new string[8];
            Random rnd = new Random();
            for (int i = 0; i < categoriesAndWords.Length; i++)
            {
                if (categoriesAndWords[i][0].ToLower() == userInput)
                {
                    for (int j = 0; j < eightChosenWords.Length; j++)
                    {
                        int randomIndex = rnd.Next(1, categoriesAndWords[i].Length);
                        string potentialWord = categoriesAndWords[i][randomIndex];
                        if (eightChosenWords.Contains(potentialWord))
                        {
                            j--;
                            continue;
                        }
                        eightChosenWords[j] = potentialWord;
                    }
                    break;
                }
            }
            



            Console.WriteLine("00" + "01" + "02" + "03" + "04" + "05" + "06" + "07" + "08" + "09" + "10" + "11" + "12" + "13" + "14" + "15" + "16" + "17" + "18" + "19" + "20");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
