using System;
using System.Collections.Generic;

namespace Generic_delegates
{
    public delegate void testdelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var result = User<string>.Test("ab", "ab");
            //Console.WriteLine(result);
            testdelegate objtestdelegate = new testdelegate(User.Printmsg);
         //   User.Printmsg("Hello");    //Without Delegates
            objtestdelegate("Dilip Sarvaiya");  //Using Delegates
            List<User> userList = new List<User>();
            userList.Add(new User() { ID = 1, name = "First", Experience = 5 });
            userList.Add(new User() { ID = 2, name = "Second", Experience = 6 });
            userList.Add(new User() { ID = 3, name = "Third", Experience = 8 });
            userList.Add(new User() { ID = 4, name = "Forth", Experience = 5 });

            IsUser objUser = new IsUser(userMethod);
            User.PrintUser(userList,objUser);

        }
        public static bool userMethod(User user)
        {
            if (user.Experience > 0)
            {
                return true;
            }
            else return false;
        }
    }
    public delegate bool IsUser(User user);
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int Experience { get; set; }

        public static void PrintUser(List<User> userList,IsUser objDelegate)
        {
            foreach (User user in userList)
            {
                if (objDelegate(user))
                {
                    Console.WriteLine("User name is {0} ", user.name);
                }
            }
        }
        public static void Printmsg(string msg)
        {
            Console.WriteLine(msg);
        }
        //public static bool Test(T a, T b)
        //{
        //    return a.Equals(b);
        //}
    }
}
