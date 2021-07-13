using System;
using System.IO;
using System.Linq;
using System.Text;
using GGZY.Core.Log;
using GGZY.Core.Utils;

namespace GGZY.Core.Extensions
{
    public static class FileInfoExtensions
    {
        /// <summary>
        /// 获取不带扩展名称的文件名
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        public static string NameWithoutExt(this FileInfo fileInfo)
        {
            var name = fileInfo.Name;
            
            var ex = fileInfo.Extension;
            var fileName = name.Replace(ex, "");
            return fileName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string SetExtension(this FileInfo fileInfo, string extension)
        {
            if (!extension.StartsWith("."))
            {
                extension = "." + extension;
            }
            var name = fileInfo.Name;
            var ex = fileInfo.Extension;
            var fileName = name.Replace(ex, extension);
            return fileName;
        }
        /// <summary>
        /// 返回不具有扩展名称的指定路径字符串的文件名
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string FileNameWithoutExtension(this string filePath)
        {
            var r = string.Empty;
            try
            {

                r = Path.GetFileNameWithoutExtension(filePath);
            }
            catch (Exception e)
            {
                Logger.Error($"获取文件名失败:{e.Message}", e);
            }

            return r;
        }
        /// <summary>
        /// 文件MD5
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string Md5HashFromFile(this string fileName)
        {
            var r = string.Empty;
            try
            {
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    r = CommonUtils.Md5Stream(file);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"获取{fileName}MD5错误:{ex.Message}", ex);
            }

            return r;
        }

        /// <summary>
        /// 返回指定路径字符串的扩展名
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string Extension(this string fileName)
        {
            var r = string.Empty;
            try
            {
               
                r = Path.GetExtension(fileName);
            }
            catch (Exception e)
            {
                Logger.Error($"获取{fileName}扩展名称失败:{e.Message}", e);
            }

            return r;
        }

        /// <summary>
        /// 返回指定路径字符串的文件名和扩展名
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FileName(this string fileName)
        {
            var r = string.Empty;
            try
            {
                r = Path.GetFileName(fileName);
            }
            catch (Exception e)
            {
                r = fileName.Split('.').FirstOrDefault();
                Logger.Error($"返回{fileName}的文件名和扩展名失败:{e.Message}", e);
            }

            return r;
        }
        /// <summary>
        /// 返回指定路径字符串的目录信息
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string DirectoryName(this string fileName)
        {
            var r = string.Empty;
            try
            {
                r = Path.GetDirectoryName(fileName);
            }
            catch (Exception e)
            {
                Logger.Error($"返回{fileName}的目录信息失败:{e.Message}", e);
            }

            return r;
        }
        /// <summary>
        /// 通过文件路径创建文件夹
        /// 如果文件夹不存在，则创建
        /// </summary>
        /// <param name="path">文件保存路径</param>
        public static void CreateDirectoryIfNotExist(this string path)
        {
           var directoryName= Path.GetDirectoryName(path);
           if (!string.IsNullOrWhiteSpace(directoryName)&&!Directory.Exists(directoryName))
           {
               Directory.CreateDirectory(directoryName);
           }
        }
        /// <summary>
        /// 返回指定的文件名的MIME映射
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string ContentType(this string fileName)
        {
            var r = string.Empty;
            try
            {
                r = System.Web.MimeMapping.GetMimeMapping(fileName);
            }
            catch (Exception e)
            {
                Logger.Error($"返回{fileName}的MIME映射失败:{e.Message}", e);
            }
            return r;
        }

    }
}