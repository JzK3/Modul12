namespace Task1215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
                  {
                      new User("JzK", "Azu Lamus", true),
                      new User("Hokinhim","Nekit Krosavchec",true),
                      new User("Fbi","Paulo Hohlensy",true),
                      new User("Svou","Sergey Vitalievich",false),
                      new User("Ecsobarus","Paulus Escobarenko",false),
                      new User("Kok","Shrek Osel",false),
                      new User("Kfc","Kentukky Chicken",false),
                      new User("Serj","Serjo Marricone",false),
                      new User("Kek","Kent Ketuh",false),
                      new User("Bb","take it away Walter",false),
                  };
            Greetings(users);
        }

        public static void Greetings(List<User> users)
        {
            while (true)
            {
                Console.Write("Введите ваш логин - ");
                string log = Console.ReadLine();
                for (int i = 0; i < users.Count; i++)
                {
                    if (log==users[i].Login)
                    {
                        Console.WriteLine($"Мой дорогой {users[i].Name}, рад тебя видеть!");
                        if (!users[i].IsPremium)
                        {
                            User.ShowAds();
                        }
                    }
                }
            }

            //foreach (var user in users) 
            //{
            //    {
            //        Console.WriteLine($"Мой дорогой {user.Name}, рад тебя видеть!");
            //        if (!user.IsPremium)
            //        {
            //            User.ShowAds();
            //        }
            //    }
            //}
        }
    }
}
