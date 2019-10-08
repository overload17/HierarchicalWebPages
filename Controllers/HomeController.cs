using System.Linq;
using System.Web.Mvc;
using HierarchicalWebApplication.Data;

namespace HierarchicalWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly FolderDbContext _dbContext = new FolderDbContext();
        
        public ActionResult Folder(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return RedirectToAction("Folder", "Home", new {path = "Creating Digital Images" });
            }

            path = path.TrimEnd('/');

            int lastSlash = path.LastIndexOf('/');
            if (lastSlash >= 0)
            {
                path = path.Substring(lastSlash + 1);
            }

            var viewModel = _dbContext.Folders.FirstOrDefault(f => f.Name == path);
            return View(viewModel);
        }
    }
}