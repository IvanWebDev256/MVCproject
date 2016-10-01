using OdeToFood.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ReviewController : Controller
    {

        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index([Bind(Prefix = "restaurantId")] int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View(new RestaurantReview { RestaurantId = restaurantId });
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var _x = _db.Reviews.Find(id);
            var model = MvcApplication.Mapper.Map<ReviewEditModel>(_x);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ReviewEditModel review)
        {
            if (ModelState.IsValid)
            {
                var x = _db.Reviews.Find(review.Id);
                MvcApplication.Mapper.Map(review, x);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}

