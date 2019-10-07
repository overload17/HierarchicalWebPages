using System.Collections.Generic;

namespace HierarchicalWebApplication.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Folder Parent { get; set; }
        public virtual ICollection<Folder> Children { get; set; }
    }
}