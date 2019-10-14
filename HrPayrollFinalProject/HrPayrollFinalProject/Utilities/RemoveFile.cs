using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace HrPayrollFinalProject.Utilities
{
    public static class RemoveFile
    {
        public static bool RemoveImage(string root, string image)
        {
            string path = Path.Combine(root, image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
                return false;
        }
    }
}
