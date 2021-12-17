using Challenge_FriendsList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Challenge_FriendsList.Data;

namespace Challenge_FriendsList.Services
{
    public class ListOfFriends : IListOfFriends
    {
        //This is also gonna be delegated to the Data Context
        //public List<Friend> listOfFriends { get; set; }

        private FriendContext butler;

        public ListOfFriends(FriendContext db)
        {
            butler = db;
            //InitiliazeListOfFriends();
        }

        //This is being delegated to my data context

        //public void InitiliazeListOfFriends()
        //{
        //    listOfFriends = new List<Friend>()
        //    {
        //        new Friend(){id = 1, friendName = "John", place = "Boston", age = 23, occupation = "Engineer", sport = "Baseball"},
        //        new Friend(){id = 2, friendName = "Dan", place = "Honolulu", age = 30, occupation = "Lawyer", sport = "Football"},
        //        new Friend(){id = 3, friendName = "Sandy", place = "Bikini Bottom", age = 28, occupation = "Doctor", sport = "Soccer"},
        //    };
        //}
        public List<Friend> getFriends()
        {
            return butler.Friend.ToList();
        }

        public Friend getFriendById(int id)
        {
            //read action
            return this.butler.Friend.SingleOrDefault(friend => friend.id == id);            
        }

        public void insertNewFriend(Friend friend)
        {
            //create
            butler.Friend.Add(friend);
            butler.SaveChanges();
        }

        public void deleteFriend(int id)
        {
            Friend friend = butler.Friend.SingleOrDefault(friend => friend.id == id);
            butler.Friend.Remove(friend);
            butler.SaveChanges();
        }

        public void editFriend(Friend friend)
        {
            butler.Entry(friend).State = EntityState.Modified; //telling DB that this friend entry has been changed/updated
            butler.SaveChanges();
        }
    }
}
