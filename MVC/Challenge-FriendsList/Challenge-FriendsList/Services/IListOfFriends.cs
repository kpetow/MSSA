using Challenge_FriendsList.Models;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_FriendsList.Services
{
    public interface IListOfFriends
    {
        public IList<Friend> getFriends();
        //List<Friend> listOfFriends { get; set; }
        public Friend getFriendById(int? id);
        public void insertNewFriend(Friend friend);
        public void deleteFriend(int id);
        public void editFriend(Friend friend);


    }

}