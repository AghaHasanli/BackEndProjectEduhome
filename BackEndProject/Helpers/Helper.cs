using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Helpers
{
    public static class Helper
    {
        public static void DeletedFile(string root,string folder,string fileName)
        {
            string path = Path.Combine(root, folder, fileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
    }
    public enum Roles
    {
        Admin,
        Maneger,
        Member
    }
}
