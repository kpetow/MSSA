using Challenge_FriendsList.Models;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_FriendsList.Services
{
    public interface IListOfFriends
    {
        List<Friend> listOfFriends { get; set; }
        public Friend getFriendById(int id);
        public void deleteFriendById(int id);
    }

}