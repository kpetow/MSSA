using Challenge_FriendsList.Models;
using Challenge_FriendsList.Services;
using Microsoft.AspNetCore.Mvc;


namespace Challenge_FriendsList.Controllers
{
    public class FriendController : Controller
    {
        IListOfFriends _listofFriends;

        //Inject service into controller
        public FriendController(IListOfFriends listOfFriends)
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
        public IActionResult EditFriend(int id)
        {
            return View();
        }
        
        public IActionResult Details(int id)
        {
            Friend friend = _listofFriends.getFriendById(id);
            return View(friend);
        }



        //Delete Friend

        public IActionResult Delete(int id)
        {
            _listofFriends.deleteFriendById(id);
            return RedirectToAction("Index");
        }

        public IActionResult editFriend()
        {
            return View();
        }
    }
}
