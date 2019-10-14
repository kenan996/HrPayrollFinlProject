using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Extensions
{
    public static class IFormExtensions
    {

        public static bool IsImage(this IFormFile formFile)
        {
            return formFile.ContentType.Contains("image/");
        }
            
        public async static Task<string> Save (this IFormFile formFile, string root,string folder)
        {
            string path = Path.Combine(root, "img");

            string fileName = Path.Combine(folder, Guid.NewGuid().ToString() + formFile.FileName);

            string resultPath = Path.Combine(path, fileName);

            using (FileStream fileStream = new FileStream(resultPath, FileMode.OpenOrCreate))
            {
                await formFile.CopyToAsync(fileStream);
            }

            return fileName;
        }
    }
}
