using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrPayrollFinalProject.Extensions
{
    public static class IFormExtensions
    {
        public static bool IsImage(this IFormFile formFile)
        {
            return formFile.ContentType == "jpeg/jpg";
        }

        public async static void Save(this IFormFile formFile, string root,string folder)
        {

        }
    }
}
