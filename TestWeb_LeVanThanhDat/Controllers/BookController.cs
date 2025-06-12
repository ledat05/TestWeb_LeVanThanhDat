using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb_LeVanThanhDat.Models;

namespace TestWeb_LeVanThanhDat.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _db;
        public BookController(AppDbContext db)
        {
            _db = db;
        }
        //Trả về giao diện
        public IActionResult Index()
        {
            var booklist = _db.Books.ToList();
            return View(booklist);
        }
        public IActionResult Add()
        {
            return View();
        }
        //Xu lý Add Book
        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }
        public IActionResult Update(int Id)
        {
            var book = _db.Books.Find(Id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Update (Book book)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                var existingBook = _db.Books.Find(book.Id);
                if (existingBook != null)
                {
                    // Cập nhật thông tin
                    existingBook.Id = book.Id;
                    existingBook.Title = book.Title;
                    existingBook.Author = book.Author;
                    existingBook.Price = book.Price;
                    existingBook.Quantity = book.Quantity;

                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }

                return NotFound();
            }

            return View(book);
        }
        public IActionResult Delete(int Id)
        {
            var book = _db.Books.Find(Id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Id)
        {
            var book = _db.Books.Find(Id);
            if (book == null)
            {
                return NotFound();
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            TempData["success"] = "Product deleted success";
            //chuyen den action index
            return RedirectToAction("Index");
        }
    }
}
