using System.Collections.Generic;
using System.Data.Entity;
using HierarchicalWebApplication.Models;

namespace HierarchicalWebApplication.Data
{
    public class FolderDbContext : DbContext
    {
        public FolderDbContext() : base("FolderDbContext")
        {
            Database.SetInitializer(new FolderDbInitializer());
        }

        public DbSet<Folder> Folders { get; set; }
    }

    public class FolderDbInitializer : DropCreateDatabaseAlways<FolderDbContext>
    {
        protected override void Seed(FolderDbContext context)
        {
            IList<Folder> defaultFolders = new List<Folder>();

            defaultFolders.Add(new Folder { Id = 1, Name = "Creating Digital Images" });
            defaultFolders.Add(new Folder { Id = 2, Name = "Resources", Parent = defaultFolders[0]});
            defaultFolders.Add(new Folder { Id = 3, Name = "Evidence", Parent = defaultFolders[0] });
            defaultFolders.Add(new Folder { Id = 4, Name = "Graphic Products", Parent = defaultFolders[0] });
            defaultFolders.Add(new Folder { Id = 5, Name = "Primary Sources", Parent = defaultFolders[1] });
            defaultFolders.Add(new Folder { Id = 5, Name = "Secondary Sources", Parent = defaultFolders[1] });
            defaultFolders.Add(new Folder { Id = 6, Name = "Process", Parent = defaultFolders[3] });
            defaultFolders.Add(new Folder { Id = 7, Name = "Final Product", Parent = defaultFolders[3] });
            
            context.Folders.AddRange(defaultFolders);

            base.Seed(context);
        }
    }
}