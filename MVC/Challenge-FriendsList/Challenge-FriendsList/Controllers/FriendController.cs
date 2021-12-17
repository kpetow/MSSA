using Challenge_FriendsList.Models;
using Challenge_FriendsList.Services;
using Microsoft.AspNetCore.Mvc;


namespace Challenge_FriendsList.Controllers
{
    public class FriendController : Controller
    {
        IListOfFriends _listofFriends;

        //Inject service into controller
        public FriendController(IListOfFriends listOfFriends) //catches the service arguments
        {
            //Dependency Injection
            _listofFriends = listOfFriends;
        }

        //Read Friend
          public IActionResult Index()
        {                 
            return View(_listofFriends);
        }

        [HttpGet]
        public IActionResult InsertNewFriend()
        {
            return View();
        }

        //Create Friend
        [HttpPost]
        public IActionResult InsertNewFriend(Friend friend)
        {
            if (ModelState.IsValid)
            {
                _listofFriends.listOfFriends.Add(friend);
                return RedirectToAction("Index");
            }
            
            return View();
        }

        //Update Friend
        public IActionResult editFriend(int id)
        {
            Friend friend = _listofFriends.getFriendById(id);
            return View(friend);
        }

        [HttpPost]
        public IActionResult editFriend(Friend friend)
        {
            _listofFriends.editFriend(friend);
            return View(friend);
        }

        public IActionResult Details(int id)
        {
            Friend friend = _listofFriends.getFriendById(id);            
            return View(friend);
        }

        //Delete Friend

        public IActionResult Delete(int id)
        {
            _listofFriends.deleteFriend(id);
            return RedirectToAction("Index");
        }


    }
}
