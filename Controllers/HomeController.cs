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
            path = path.TrimEnd('/');

            int lastSlash = path.LastIndexOf('/');
            if (lastSlash >= 0)
            {
                path = path.Substring(lastSlash + 1);
            }

            var viewModel = string.IsNullOrEmpty(path) ? _dbContext.Folders.First() : _dbContext.Folders.FirstOrDefault(f => f.Name == path);
            return View(viewModel);
        }
    }
}