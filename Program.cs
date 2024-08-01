using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;


// variables in Pets characteristics
internal class Program
{
    private static void Main(string[] args)
    {
        string PetId;
        string PetSpecies;
        string age;
        string desc_ofPhysicalAppearance;
        string desc_ofPersonality;
        string petsNickname;

        // inputs from the user
        int MaxPet = 6;
        string readresult;
        string MenuResponse;
        string[,] OurAnimal = new string[MaxPet, 6];
        for (int i = 0; i < MaxPet; i++)
        {
            switch (i)
            {
                case 1:
                    PetId = "D1";
                    PetSpecies = "Dog";
                    age = "01";
                    desc_ofPersonality = "Playable and cute ";
                    desc_ofPhysicalAppearance = "Brown and cute with long hair";
                    petsNickname = "pluto";
                    break;
                case 2: PetId = "C2";
                    PetSpecies = "cat";
                    age = "2";
                    desc_ofPhysicalAppearance = "walks by catwalk";
                    desc_ofPersonality = "cute and little kitten with a cute smile";
                    petsNickname = "swifie";
                    break;
                case 3:
                    PetId = "C3";
                    PetSpecies = "cat";
                    age = "3";
                    desc_ofPhysicalAppearance = "white cat with black tip tail";
                    desc_ofPersonality = "jumps a lot when play with enjoy";
                    petsNickname = "darliee";
                    break;
                default:
                    PetId = "";
                    PetSpecies = "";
                    age = "";
                    desc_ofPersonality = "";
                    desc_ofPhysicalAppearance = "";
                    petsNickname = "";
                    break;
            }
            OurAnimal[i, 0] = "ID #: " + PetId;
            OurAnimal[i, 1] = "Species: " + PetSpecies;
            OurAnimal[i, 2] = "Age: " + age;
            OurAnimal[i, 3] = "Physical description: " + desc_ofPhysicalAppearance;
            OurAnimal[i, 4] = "Personality: " + desc_ofPersonality;
            OurAnimal[i, 5] = "Nickname: " + petsNickname;
        }
        do {
            Console.Clear();
            Console.WriteLine("1. List all of our current pet information.");
            Console.WriteLine("2. Assign values to the ourAnimals array fields.");
            Console.WriteLine("3. Ensure animal ages and physical descriptions are complete.");
            Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete.");
            Console.WriteLine("5. Edit an animal’s age.");
            Console.WriteLine("6. Edit an animal’s personality description.");
            Console.WriteLine("7. Display all cats with a specified characteristic.");
            Console.WriteLine("8. Display all dogs with a specified characteristic");


            Console.WriteLine("Enter the options to continue ");
            MenuResponse = Console.ReadLine().ToString().ToLower();


            switch (MenuResponse)
            {
                case "1":
                    for (int i = 0; i < MaxPet; i++)
                    {
                        if (OurAnimal[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(OurAnimal[i, j]);
                            }

                        }
                    }
                    Console.WriteLine("enter key to continue");
                    readresult = Console.ReadLine();
                    break;

                case "2":
                    int petCount = 0;
                 bool validEntry=false;
                    for (int i = 0; i < MaxPet; i++)
                    {
                        if (OurAnimal[i, 0] != "ID #: ")
                        {
                            petCount += 1;
                        }
                    }
                        do
                        {
                            do
                            {
                                Console.WriteLine("enter species of animal");
                                PetSpecies = Console.ReadLine().ToLower().Trim();
                                if (PetSpecies != "dog" && PetSpecies != "cat")
                                {
                                    validEntry = false;
                                Console.WriteLine("invalid!!!");
                                }
                                else
                                {
                                    validEntry = true;
                                }
                            } while (validEntry == false);

                            do
                            {
                                Console.WriteLine("Enter age for animal");
                                readresult = Console.ReadLine();
                            age = readresult;

                                if (age != "")
                               validEntry= true;

                                else
                                validEntry = false;
                            Console.WriteLine("invalid!!!");

                        }
                        while (validEntry == false);

                            PetId = PetSpecies.Substring(0, 1) + petCount;

                            do
                            {
                                Console.WriteLine("Enter description for animals physical appearance");
                                readresult = Console.ReadLine().ToLower().ToString();
                                if (readresult != "")
                                {
                                    desc_ofPhysicalAppearance = readresult;
                                }
                                else desc_ofPhysicalAppearance = "tbd";


                            } while (desc_ofPhysicalAppearance == "");

                            do
                            {
                                Console.WriteLine("Enter description for animal personality");
                                readresult = Console.ReadLine().ToString().ToLower();
                                if (readresult != " ")
                                    desc_ofPersonality = readresult;
                                else desc_ofPersonality = "tbd";

                            } while (desc_ofPersonality == "");
                            do
                            {
                                Console.WriteLine("enter animals petname or nickname");
                                readresult = Console.ReadLine().ToLower().ToString().Trim();
                                if (readresult != "")
                                    petsNickname = readresult;
                                else petsNickname = "tbd";

                            } while (petsNickname == "");
                           

                            Console.WriteLine("do you want to enter another pets information y/n");
                            readresult = Console.ReadLine().ToLower().ToLower().ToString().Trim();
                            if (readresult == "y")
                            {
                                validEntry = false;
                            }
                            else validEntry = true;

                     
                        OurAnimal[petCount, 0] = "ID #: " + PetId;
                        OurAnimal[petCount, 1] = "Species: " + PetSpecies;
                        OurAnimal[petCount, 2] = "Age: " + age;
                        OurAnimal[petCount, 3] = "Physical description: " + desc_ofPhysicalAppearance;
                        OurAnimal[petCount, 4] = "Personality: " + desc_ofPersonality;
                        OurAnimal[petCount, 5] = "Nickname: " + petsNickname;

                        petCount++ ;
                    }
                        while (petCount < MaxPet && validEntry == false) ;
                       

                    
                    break;

                case "3":
                    Console.WriteLine("Under construction");
                    break;
                case "4":
                    Console.WriteLine("Under construction");
                    break;
                case "5":
                    Console.WriteLine("Under construction");
                    break;
                case "6":
                    Console.WriteLine("Under construction");
                    break;
                case "7":
                    Console.WriteLine("undersite");
                    break;

            }
            } while (MenuResponse != "exit") ;
                } 
}