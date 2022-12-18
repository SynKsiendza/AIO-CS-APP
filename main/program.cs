using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mathfunc;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            void mainMenu()
            {
                Console.WriteLine("                     All in One App");
                Console.WriteLine("");
                Console.WriteLine("                     Apache License");
                Console.WriteLine("                Version 2.0, January 2004");
                Console.WriteLine("              http://www.apache.org/licenses/");
                Console.WriteLine("");
                Console.WriteLine(" GitLab link: https://gitlab.com/synksiendza/all-in-one-app");
                Console.WriteLine("");
                Console.WriteLine("Press ENTER to continue!");
                Console.ReadLine();
                mainMenuSwitch();
            }
            void mainMenuSwitch()
            {
                int mmChoice;
                Console.WriteLine("     Main Menu");
                Console.WriteLine(" 1. Calculator");
                Console.WriteLine(" 2. Converters");
                Console.WriteLine(" 3. Games Tips'n'Tricks");
                Console.WriteLine(" 4. OS Help");
                Console.WriteLine(" 5. Coding Help");
                Console.WriteLine(" 6. Other good things");
                Console.WriteLine(" 7. Changelog");
                Console.WriteLine(" 8. Info & Credits");
                Console.WriteLine(" 9. Quit");
                Console.WriteLine("Choose option: ");
                mmChoice = Convert.ToInt32(Console.ReadLine());
                switch(mmChoice)
                {
                    case 1:
                    {
                        calculatorMain();
                        break;
                    }
                    case 2:
                    {
                        convertersMain();
                        break;
                    }
                    case 3:
                    {
                        gamesMainMenu();   
                        break;
                    }
                    case 4:
                    {
                        osHelpMain();
                        break;
                    }
                    case 5:
                    {
                        codingHelpMain();
                        break;
                    }
                    case 6:
                    {
                        otherMain();
                        break;
                    }
                    case 7:
                    {
                        changelogMain();
                        break;
                    }
                    case 8:
                    {
                        infoCreditsMain();
                        break;
                    }
                    case 9:
                    {
                        quit();
                        break;
                    }
                }
            }
            mainMenu();
            void calculatorMain()
            {
                
            }
            void convertersMain()
            {
                
            }
            void gamesMainMenu()
            {
                int mmenuChoice = '1';

                Console.WriteLine("Menu: \n");
                Console.WriteLine("1. Forza Horizon 5\n");
                Console.WriteLine("2. Call of Duty: Modern Warfare II\n");
                Console.WriteLine("3. Euro Truck Simulator 2\n");
                Console.WriteLine("4. Cities: Skylines\n");
                Console.WriteLine("5. Path of Exhile\n");

                Console.WriteLine("Select Option:");
                mmenuChoice = Convert.ToInt32(Console.ReadLine());
                switch(mmenuChoice) 
                {
                    case 1:
                        FHMenu();
                        break;
                    case 2:
                        CODMWMenu();
                        break;
                    case 3:
                        ETSMenu();
                        break;
                    case 4:
                        CSMenu();
                        break;
                    case 5:
                        POEMenu();
                        break;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
            }
            void FHMenu()
            {
                FHMenu_CarList();
                // List of cars
                FHMenu_TFC();
                //Tunnings
            }
            void FHMenu_TFC()
            {

            }
            void FHMenu_CarList()
            {
                Console.WriteLine("Choose Brand:");
                Console.WriteLine("1. Acura");
                Console.WriteLine("2. Alpine");
                Console.WriteLine("3. Alumi");
                Console.WriteLine("4. AMC");
                Console.WriteLine("5. Apollo");
                Console.WriteLine("6. Ariel");
                Console.WriteLine("7. Ascari");
                Console.WriteLine("8. Aston Martin");
                Console.WriteLine("9. ATS");
                Console.WriteLine("10. Audi");
                Console.WriteLine("11. Austin-Healey");
                Console.WriteLine("13. Auto");
                Console.WriteLine("14. BAC");
                Console.WriteLine("15. Bentley");
                Console.WriteLine("16. BMW");
                Console.WriteLine("17. Brabham");
                Console.WriteLine("18. Bugatti");
                Console.WriteLine("19. Buick");
                Console.WriteLine("20. Cadillac");
                Console.WriteLine("21. Can-Am");
                Console.WriteLine("22. Caterham");
                Console.WriteLine("23. Chevrolet");
                Console.WriteLine("24. Cupra");
                Console.WriteLine("25. Datsun");
                Console.WriteLine("26. DeBerti");
                Console.WriteLine("27. DeLorean");
                Console.WriteLine("28. Dodge");
                Console.WriteLine("29. Donkervoort");
                Console.WriteLine("30. Eagle");
                Console.WriteLine("31. Exemotive");
                Console.WriteLine("32. Extreme");
                Console.WriteLine("33. Ferrari");
                Console.WriteLine("34. Ford");
                Console.WriteLine("35. Formula Drift");
                Console.WriteLine("36. Forsberg Racing");
                Console.WriteLine("36. Funco");
                Console.WriteLine("37. GMC");
                Console.WriteLine("38. HDT");
                Console.WriteLine("39. Hennessey");
                Console.WriteLine("40. Holden");
                Console.WriteLine("41. Honda");
                Console.WriteLine("42. Hoonigan");
                Console.WriteLine("43. Hot Wheels");
                Console.WriteLine("44. HSV");
                Console.WriteLine("45. Hummer");
                Console.WriteLine("46. Hyundai");
                Console.WriteLine("47. Infiniti");
                Console.WriteLine("48. International Scout");
                Console.WriteLine("49. Italdesign");
                Console.WriteLine("50. Jaguar");
                Console.WriteLine("51. JEEP");
                Console.WriteLine("52. Koenigsegg");
                Console.WriteLine("53. KTM");
                Console.WriteLine("54. Lamborghini");
                Console.WriteLine("55. Land Rover");
                Console.WriteLine("56. Lexus");
                Console.WriteLine("57. Local Motors");
                Console.WriteLine("58. Lola");
                Console.WriteLine("59. Lotus");
                Console.WriteLine("60. Lynk & Co");
                Console.WriteLine("61. Maserati");
                Console.WriteLine("62. Mazda");
                Console.WriteLine("63. McLaren");
                Console.WriteLine("64. Mercedes-AMG");
                Console.WriteLine("65. Mercedes-Benz");
                Console.WriteLine("66. Mercury");
                Console.WriteLine("67. Mayers");
                Console.WriteLine("68. MG");
                Console.WriteLine("69. Mini Cooper");
                Console.WriteLine("70. Mini John");
                Console.WriteLine("71. Mini X-Raid");
                Console.WriteLine("72. Mitsubishi");
                Console.WriteLine("73. Morgan");
                Console.WriteLine("74. Morris");
            }
            void CODMWMenu()
            {
                CODMWMenu_Loadouts();
                //Loadouty do COD
                CODMWMenu_Custom();
                //Custom for weapons
            }
            void CODMWMenu_Custom()
            {

            }
            void CODMWMenu_Loadouts()
            {

            }
            void ETSMenu()
            {
                ETSMenu_Trucks();
                //Best trucks for ETS2
                ETSMenu_Mods();
                //mods for ets2
            }
            void ETSMenu_Trucks()
            {

            }
            void ETSMenu_Mods()
            {

            }
            void CSMenu()
            {
                //Mods for cities skylines
            }
            void POEMenu()
            {
                POEMenu_Addons();
                //Best POE addons
                POEMenu_Tutorial();
                //Tuts for POE
            }
            void POEMenu_Addons()
            {

            }
            void POEMenu_Tutorial()
            {
                
            }
            void osHelpMain()
            {

            }
            void codingHelpMain()
            {

            }
            void otherMain()
            {

            }
            void changelogMain()
            {

            }
            void infoCreditsMain()
            {

            }
            void quit()
            {

            }
            //main Code
            mainMenu();
        }
    }
}