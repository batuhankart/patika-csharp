using System;
using System.Collections.Generic;

namespace to_do
{
    class Program
    {
        public static List<CardData> cards;
        public static IDictionary<int, string> employeeList;
        static void Main(string[] args)
        {
            employeeList = new Dictionary<int, string>();
            employeeList.Add(0, "Mehmet Ayaz");
            employeeList.Add(1, "Oğuzhan Akbulut");
            employeeList.Add(2, "Hüseyin Aksakal");
            employeeList.Add(3, "Derya Deniz");
            employeeList.Add(4, "Ayşe Korkmaz");

            cards = new List<CardData>()
            {
                new CardData("Gemilerin Çizilmesi", "Oyunda kullanılacak gemilerin sprite'larının çizilmesi", 1, 3, "todo"),
                new CardData("Envanter Altyapısın Yazılması", "Oyunun envanter sisteminin altyapısının kodlanması", 3, 1, "todo"),
                new CardData("Wireframe'in Tasarlanması", "Oyunun ekran geçişlerini gösteren tasarımın yapılması", 4, 4, "todo")
            };

            MainMenu();
        }

        public static void MainMenu()
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BoardList();
                    break;
                case "2":
                    AddCard();
                    break;
                case "3":
                    RemoveCard();
                    break;
                case "4":
                    MoveCard();
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    MainMenu();
                    break;
            }
        }

        public static void BoardList()
        {
            Console.WriteLine("\nTODO Line");
            Console.WriteLine("************************");
            foreach (CardData card in cards)
            {
                if (card.Status == "todo")
                {
                    string employee = employeeList[card.Employee];
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Description);
                    Console.WriteLine("Atanan Kişi : " + employee);
                    Console.WriteLine("Büyüklük : " + (TeamSize)card.Size);
                    Console.WriteLine("-");
                }
            }

            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (CardData card in cards)
            {
                if (card.Status == "inProgress")
                {
                    string employee = employeeList[card.Employee];
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Description);
                    Console.WriteLine("Atanan Kişi : " + employee);
                    Console.WriteLine("Büyüklük : " + (TeamSize)card.Size);
                    Console.WriteLine("-");
                }
            }

            Console.WriteLine("\nDONE Line");
            Console.WriteLine("************************");
            foreach (CardData card in cards)
            {
                if (card.Status == "done")
                {
                    string employee = employeeList[card.Employee];
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Description);
                    Console.WriteLine("Atanan Kişi : " + employee);
                    Console.WriteLine("Büyüklük : " + (TeamSize)card.Size);
                    Console.WriteLine("-");
                }
            }

            MainMenu();
        }

        public static void AddCard()
        {
            Console.WriteLine("\nKart Ekleme");
            Console.WriteLine("****************************");

            Console.Write("Başlık Giriniz: ");
            string title = Console.ReadLine();

            Console.Write("İçerik Giriniz: ");
            string description = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
            int size = int.Parse(Console.ReadLine());
            if (size <= 0 || size > 5)
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                MainMenu();
            }

            Console.Write("Kişi Seçiniz: ");
            int ID = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<int, string> employee in employeeList)
            {
                if (employee.Key == ID)
                {
                    cards.Add(new CardData(title, description, ID, size, "todo"));
                    Console.WriteLine("Kart başarıyla eklendi!");
                    MainMenu();
                }
            }

            Console.WriteLine("Hatalı giriş yaptınız!");
            MainMenu();
        }

        public static void RemoveCard()
        {
            Console.WriteLine("\nÖncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();


            int resultCount = 0;
            for (int i = cards.Count - 1; i >= 0; i--)
            {
                if (cards[i].Title == input)
                {
                    cards.Remove(cards[i]);
                    resultCount++;
                }
            }

            if (resultCount > 0)
            {
                Console.WriteLine("Listeden {0} kart başarıyla silindi.", resultCount);
                MainMenu();
            }

            Console.WriteLine("Aradığınız kriterlere uygun bir kart bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            input = Console.ReadLine();

            if (input == "1")
            {
                MainMenu();
            }
            else if (input == "2")
            {
                RemoveCard();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                MainMenu();
            }
        }

        public static void MoveCard()
        {
            Console.WriteLine("\nÖncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            foreach (CardData card in cards)
            {
                if (input == card.Title)
                {
                    Console.WriteLine("\nBulunan Kart Bilgileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık : ");
                    Console.WriteLine("İçerik : ");
                    Console.WriteLine("Atanan Kişi : ");
                    Console.WriteLine("Büyüklük : ");
                    Console.WriteLine("Line : ");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            card.Status = "todo";
                            break;
                        case "2":
                            card.Status = "inProgress";
                            break;
                        case "3":
                            card.Status = "done";
                            break;
                        default:
                            break;
                    }

                    MainMenu();
                }
            }

            Console.WriteLine("Aradığınız kriterlere uygun bir kart bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            input = Console.ReadLine();

            if (input == "1")
            {
                MainMenu();
            }
            else if (input == "2")
            {
                RemoveCard();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                MainMenu();
            }
            
        }
    }
}
