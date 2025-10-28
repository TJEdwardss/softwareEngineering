using Microsoft.AspNetCore.Mvc;
using softwareEngineering.View;

namespace softwareEngineering.Controllers;

public class BooksController : Controller
{
//the show form
    [HttpGet]
    public IActionResult AddBook()
    {
        return View();
    }

//add a book to the database
    [HttpPost]
    public async Task<IActionResult> AddBook(Book book)
    {
        //appDBcontext.Add(book);
        //await appDBcontext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}