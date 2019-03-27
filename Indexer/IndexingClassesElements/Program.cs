using System;

namespace IndexingClassesElements
{
    class MyFriendsNames 
    {
        private string[] friendsList = new string[10];


        // indexing 
        public string this[int index]
        {
            // give me data about specific person from list
            get 
            {
                if (index < 0 || index > 9) throw new IndexOutOfRangeException("Just 10 friends, no more");

                return friendsList[index];
            }
            // set value into array of friendslist
            set
            {
                if (index < 0 || index > 9) throw new IndexOutOfRangeException("Just 10 friends, no more");

                friendsList[index] = value;
            }
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            MyFriendsNames JimmysFriends = new MyFriendsNames();
            JimmysFriends[0] = "Tom";
            JimmysFriends[1] = "Kobe";

            Console.WriteLine(JimmysFriends[0]);
            Console.WriteLine(JimmysFriends[1]);
        }
    }
}
