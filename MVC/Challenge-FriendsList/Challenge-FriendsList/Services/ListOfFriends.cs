using Challenge_FriendsList.Models;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_FriendsList.Services
{
    public class ListOfFriends : IListOfFriends
    {
        public List<Friend> listOfFriends { get; set; }

        public ListOfFriends()
        {
            InitiliazeListOfFriends();
        }

        public void InitiliazeListOfFriends()
        {
            listOfFriends = new List<Friend>()
            {
                new Friend(){id = 1, friendName = "John", place = "Boston", age = 23, occupation = "Engineer", sport = "Baseball"},
                new Friend(){id = 2, friendName = "Dan", place = "Honolulu", age = 30, occupation = "Lawyer", sport = "Football"},
                new Friend(){id = 3, friendName = "Sandy", place = "Bikini Bottom", age = 28, occupation = "Doctor", sport = "Soccer"},
            };
        }

        public Friend getFriendById(int id)
        {
            //LINQ or LAMBDA statement

            Friend friend = this.listOfFriends.SingleOrDefault(friend => friend.id == id);
            return friend;
        }

        public void deleteFriendById(int id)
        {
            Friend friend = getFriendById(id);
            this.listOfFriends.Remove(friend);
        }
    }
}
