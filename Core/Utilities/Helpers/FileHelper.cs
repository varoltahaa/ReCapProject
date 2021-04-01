using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public static class FileHelper
    {
        public static string DefaultImagePath = Directory.GetCurrentDirectory() + @"\upload_images\no-image.jpg";
        public static string UploadImagePath = Directory.GetCurrentDirectory() + @"\upload_images";


        public static string CreatePath(IFormFile formFile)
        {
            FileInfo fileInfo = new FileInfo(formFile.FileName);

            string path = Path.Combine(UploadImagePath);
            string fileExtension = fileInfo.Extension;
            string uniqueFilename = Guid.NewGuid().ToString() + fileExtension;
            string result = $@"{path}\{uniqueFilename}";

            return result;
        }


        public static string AddFile(IFormFile formFile)
        {
            string result;

            try
            {

                if (formFile == null)
                {
                    result = DefaultImagePath;

                    return result;
                }

                else
                {
                    result = CreatePath(formFile);

                    var sourcePath = Path.GetTempFileName();

                    using (var fileStream = new FileStream(sourcePath, FileMode.Create))
                    {
                        formFile.CopyTo(fileStream);
                    }

                    File.Move(sourcePath, result);

                    return result;
                }

            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }


        public static string DeleteFile(string imagePath)
        {
            try
            {
                File.Delete(imagePath);

                return "Deleted";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public static string UpdateFile(IFormFile formFile, string imagePath)
        {
            string result;

            try
            {
                if (formFile == null)
                {
                    File.Delete(imagePath);

                    result = DefaultImagePath;

                    return result;
                }

                else
                {
                    result = CreatePath(formFile);

                    var sourcePath = Path.GetTempFileName();

                    using (var stream = new FileStream(sourcePath, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }

                    File.Move(sourcePath, result);

                    File.Delete(imagePath);

                    return result;
                }


            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }
    }
}
