using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using GGZY.Core.Log;


namespace GGZY.Core.Utils
{
    public class CompressUtils
    {
        #region ZipFile

        /// <summary>
        /// 压缩字符串到zip文件
        /// </summary>
        /// <param name="destFileName">压缩文件全路径，如D:\Zip\Compress.zip</param>
        /// <param name="txt">要压缩的字符串</param>
        public static void Compress(string destFileName, string txt)
        {
            if (File.Exists(destFileName))
            {
                File.Delete(destFileName);
            }
            using (ZipArchive archive = ZipFile.Open(destFileName, ZipArchiveMode.Create, Encoding.GetEncoding("gb2312")))
            {

                var fileInfo = new FileInfo(destFileName);
                var fileName = fileInfo.Name;
                var ex = fileInfo.Extension;
                var txtFileName = fileName.Replace(ex, ".txt");
                var readmeEntry = archive.CreateEntry(txtFileName, CompressionLevel.Fastest);
                using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                {
                    writer.WriteLine(txt);
                }
            }
        }

        /// <summary>
        /// 压缩文件（夹）到zip文件
        /// </summary>
        /// <param name="sourceFileName">
        /// 要压缩文件（夹）全路径，如 D:\Zip\UnCompress 或者 D:\Zip\UnCompress.txt
        /// </param>
        /// <param name="zipFileName">
        /// 压缩文件全路径，如D:\Zip\Compress.Zip
        /// </param>
        /// <param name="useSameName">是否生成同名压缩包</param>
        public static string CompressFile(string sourceFileName, string zipFileName = "", bool useSameName = false)
        {
            try
            {
                Logger.Debug($"CompressFile:{sourceFileName}");
                if (File.GetAttributes(sourceFileName).CompareTo(FileAttributes.Directory) == 0)
                {
                    Logger.Debug($"CompressFile:{sourceFileName} is Directory");
                    var dir = new DirectoryInfo(sourceFileName);
                    if (string.IsNullOrWhiteSpace(zipFileName))
                    {
                        zipFileName = dir.FullName.Replace(dir.Name, $"{Guid.NewGuid().ToString()}.zip");
                    }

                    if (useSameName)
                    {
                        zipFileName = $"{dir.FullName}.zip";
                    }

                    if (File.Exists(zipFileName))
                    {
                        File.Delete(zipFileName);
                    }
                    Logger.Debug($"zipFileName:{zipFileName}");
                    using (var archive = ZipFile.Open(zipFileName, ZipArchiveMode.Create, Encoding.GetEncoding("gb2312")))
                    {
                        foreach (var fileInfo in dir.GetFiles())
                        {
                            archive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name, CompressionLevel.Optimal);
                        }
                    }
                }
                else
                {
                    Logger.Debug($"CompressFile:{sourceFileName} is not Directory");
                    var fileInfo = new FileInfo(sourceFileName);
                    if (string.IsNullOrWhiteSpace(zipFileName))
                    {
                        zipFileName = fileInfo.FullName.Replace(fileInfo.Name, $"{Guid.NewGuid().ToString()}.zip");
                    }
                    if (useSameName)
                    {
                        zipFileName = fileInfo.FullName.Replace(fileInfo.Extension, ".zip");
                    }

                    if (File.Exists(zipFileName))
                    {
                        File.Delete(zipFileName);
                    }
                    Logger.Debug($"zipFileName:{zipFileName}");
                    using (var archive = ZipFile.Open(zipFileName, ZipArchiveMode.Create, Encoding.GetEncoding("gb2312")))
                    {
                        archive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name, CompressionLevel.Optimal);
                    }
                }
                return zipFileName;
            }
            catch (Exception e)
            {
                Logger.Error($"CompressUtils.CompressFile Error:{e.Message}", e);
            }
            //if (useSameName)
            //{
            //    var destFileName = "";
            //}
            return String.Empty;
        }
        /// <summary>
        /// 文件解压缩
        /// </summary>
        /// <param name="zipFileName">要解压的压缩文件</param>
        /// <param name="destDirectoryName">解压路径</param>
        public static void Decompress(string zipFileName, string destDirectoryName)
        {
            if (Directory.Exists(destDirectoryName))
            {
                Directory.Delete(destDirectoryName, true);
            }
            using (var archive = ZipFile.OpenRead(zipFileName))
            {
                archive.ExtractToDirectory(destDirectoryName);
            }
            
        }

        #endregion

        #region GZipStream

        /// <summary>
        /// 压缩字节数组
        /// </summary>
        /// <param name="inputBytes"></param>
        public static byte[] Compress(byte[] inputBytes)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                using (GZipStream zipStream = new GZipStream(outStream, CompressionMode.Compress, true))
                {
                    zipStream.Write(inputBytes, 0, inputBytes.Length);
                    zipStream.Close(); //很重要，必须关闭，否则无法正确解压
                    return outStream.ToArray();
                }
            }
        }

        /// <summary>
        /// 解压缩字节数组
        /// </summary>
        /// <param name="inputBytes"></param>
        public static byte[] Decompress(byte[] inputBytes)
        {

            using (MemoryStream inputStream = new MemoryStream(inputBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    using (GZipStream zipStream = new GZipStream(inputStream, CompressionMode.Decompress))
                    {
                        zipStream.CopyTo(outStream);
                        zipStream.Close();
                        return outStream.ToArray();
                    }
                }

            }
        }
        /// <summary>
        /// 压缩字符串
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Compress(string input)
        {
            byte[] inputBytes = Encoding.Default.GetBytes(input);
            byte[] result = Compress(inputBytes);
            return Convert.ToBase64String(result);
        }
        /// <summary>
        /// 解压缩字符串
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Decompress(string input)
        {
            byte[] inputBytes = Convert.FromBase64String(input);
            byte[] depressBytes = Decompress(inputBytes);
            return Encoding.Default.GetString(depressBytes);
        }
        /// <summary>
        /// 压缩目录
        /// </summary>
        /// <param name="dir"></param>
        public static void Compress(DirectoryInfo dir)
        {
            foreach (FileInfo fileToCompress in dir.GetFiles())
            {
                Compress(fileToCompress);
            }
        }
        /// <summary>
        /// 解压缩目录
        /// </summary>
        /// <param name="dir"></param>
        public static void Decompress(DirectoryInfo dir)
        {
            foreach (FileInfo fileToCompress in dir.GetFiles())
            {
                Decompress(fileToCompress);
            }
        }
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="fileToCompress"></param>
        public static void Compress(FileInfo fileToCompress)
        {
            using (FileStream originalFileStream = fileToCompress.OpenRead())
            {
                if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                {
                    var fileName = fileToCompress.FullName;
                    var path =
                        $"{fileName.Replace(fileToCompress.Extension, ".gz")}";
                    using (FileStream compressedFileStream = File.Create(path))
                    {
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                        {
                            originalFileStream.CopyTo(compressionStream);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 解压缩文件
        /// </summary>
        /// <param name="fileToDecompress"></param>
        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        #endregion
    }
}