Console.WriteLine("");
Console.WriteLine("                                      '' Mountains of infinity  ''               ");
Console.WriteLine(" ");
Console.WriteLine(" ");

Console.Write(" нажмите F что бы начать игру - ");

var vord = Console.ReadLine();
if (vord == "f" || vord == "F")
{
    Console.WriteLine("");
    Console.WriteLine(" Начать (1)");
    Console.WriteLine(" Выйти (9)");

    while (true)
    {
        string vord1 = Console.ReadLine();
        int.TryParse(vord1, out int gg);
        if (gg == 1)
        {
            Console.WriteLine("Выберите персонажа:");
            Console.WriteLine("Деад инсайд (1)");
            Console.WriteLine("Асс (2)");
            Console.WriteLine("Даркхолм (3)");
            Console.WriteLine("Выйти (9)");
            Console.WriteLine("");



            string g1 = Console.ReadLine();
            int.TryParse(vord1, out int hero);
            if (hero == 1)
            {
                Console.WriteLine("Информация о персонаже:");
                Console.WriteLine("Деад инсайд - был вором и мастерски владел луком он выслеживал своих врагов ,находил их слабые места и без шумно убивал .");
                Console.WriteLine("Он услышол о зогадочной горе , шли слухи что где то там есть много багатство. и он собравлся В путь"); Console.WriteLine("");
                Console.WriteLine("выход в меню персонажей (3)");

                string s4 = Console.ReadLine();
                int.TryParse(s4, out int minu);
                if (minu == 3)
                {
                    break;
                }
            }
            while (hero != 1)
            {
                if (hero == 2)
                {
                    Console.WriteLine("Информация о персонаже:");
                    Console.WriteLine("Асс Храбрый рыцарь да показать свою преданность и отвагу дочери кораля он отправился в поход на загадачные горы о котором шли легенды что никто не возращялся от туда\r\n");
                    Console.WriteLine("");
                    Console.WriteLine("выход в меню персонажей (3)");
                    string s3 = Console.ReadLine();
                    int.TryParse(s3, out int minui);
                    if (minui == 3)
                    {
                        break;
                    }
                }
                if (hero == 3)
                {
                    Console.WriteLine("Информация о персонаже:");
                    Console.WriteLine("");
                    Console.WriteLine("Даркхолм - чёрный маг,.... Один из сильнейших ныне живущих Тёмных Черный алхимик очень любит природу и все живое.особенно питатся им он услышал о загодочной горе и заинтересовалсяи его аномалей, и решил отправиться туда");
                    Console.WriteLine("");
                    Console.WriteLine("выход в меню персонажей (3)");
                    string s1 = Console.ReadLine();
                    int.TryParse(s1, out int minuy);
                    if (minuy == 3)
                    {
                        break;
                    }
                }
                if (hero == 9)
                {
                    Console.WriteLine("Вы вышли ");
                    Environment.Exit(0);
                }
                if (gg == 9)
                {
                    Console.WriteLine("Вы вышли ");
                    Environment.Exit(0);
                }
            }
        }
    }

    
}



//ConsoleKeyInfo choice;
//do
//{
//    choice = Console.ReadKey(true);
//} while (choice.Key != ConsoleKey.F);

//switch (choice.Key)
//{
//    case ConsoleKey.F:
//        Console.WriteLine("");
//        Console.WriteLine(" Начать (1)");
//        Console.WriteLine(" Выйти (9)");

//        var user_vord = Console.ReadLine();

//        while (true)
//        {
//            if (user_vord == "1")
//            {
//                Console.WriteLine("Выберите персонажа:");
//                Console.WriteLine("Деад инсайд (1)");
//                Console.WriteLine("Асс (2)");
//                Console.WriteLine("Даркхолм (3)");
//                Console.WriteLine("");
//            }
//            string user_hero = Console.ReadLine();
//            int.TryParse(user_hero, out int resalt);
//            while (user_vord != "2")
//            {
                    
//                    switch (resalt)
//                    {
//                        case 1:
//                            Console.WriteLine("Информация о персонаже:");
//                            Console.WriteLine("Деад инсайд - был вором и мастерски владел луком он выслеживал своих врагов ,находил их слабые места и без шумно убивал .");
//                            Console.WriteLine("Он услышол о зогадочной горе , шли слухи что где то там есть много багатство. и он собравлся В путь"); Console.WriteLine("");
//                            Console.WriteLine("выход в меню персонажей (3)");
//                            string s4 = Console.ReadLine();
//                            int.TryParse(s4, out int minu);
//                            if (minu == 3)
//                            {
//                                break;
//                            }
//                            break;

//                        case 2:
//                            Console.WriteLine("Информация о персонаже:");
//                            Console.WriteLine("Асс Храбрый рыцарь да показать свою преданность и отвагу дочери кораля он отправился в поход на загадачные горы о котором шли легенды что никто не возращялся от туда\r\n");
//                            Console.WriteLine("");
//                            Console.WriteLine("выход в меню персонажей (3)");
//                            string s3 = Console.ReadLine();
//                            int.TryParse(s3, out int minui);
//                            if (minui == 3)
//                            {
//                                break;
//                            }
//                            break;
//                        case 3:
//                            Console.WriteLine("Информация о персонаже:");
//                            Console.WriteLine("");
//                            Console.WriteLine("Даркхолм - чёрный маг,.... Один из сильнейших ныне живущих Тёмных Черный алхимик очень любит природу и все живое.особенно питатся им он услышал о загодочной горе и заинтересовалсяи его аномалей, и решил отправиться туда");
//                            Console.WriteLine("");
//                            Console.WriteLine("выход в меню персонажей (3)");
//                            string s1 = Console.ReadLine();
//                            int.TryParse(s1, out int minuy);
//                            if (minuy == 3)
//                            {
//                                break;
//                            }
//                            break;
//                        case 9:
//                            Console.WriteLine("Вы вышли ");
//                            Environment.Exit(0);
//                            break;

//                    }
//            }
            
//        }
//break;   
//}


        

           
                

    



























////jet brains

////static void FirstWay() //методы
////{
////    Console.WriteLine("Вы бросили деревню на произвол судьбы....." +
////        "\n вы идете по тропинке и видите плачушего мужчину" +
////        "\n ваши действия " +
////        "\n пройти мимо (1)" +
////        "\n спросить что у него случилось (2)" +
////        "\n попробовать ограбить(3)");
////}

////static void ThirdWay()
////{

////}
////static void LineBeginning()
//{
//    Console.WriteLine("Вы бежите к деревне и видите что питорасы убивают мирное население вы хватаете мечь сниете доспех с мёртвого солдата и видите что на вас направилось два питораса ");
//}