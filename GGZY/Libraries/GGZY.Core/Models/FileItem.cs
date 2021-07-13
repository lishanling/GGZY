using System;
using System.IO;
using GGZY.Core.Extensions;

namespace GGZY.Core.Models
{
    /// <summary>
    /// 文件元数据。
    /// 可以使用以下几种构造方法：
    /// 本地路径：new FileItem("C:/temp.jpg");
    /// 本地文件：new FileItem(new FileInfo("C:/temp.jpg"));
    /// 字节流：new FileItem("abc.jpg", bytes);
    /// </summary>
    public class FileItem
    {
        private string fileName;
        private string mimeType;
        private byte[] content;
        private FileInfo fileInfo;

        /// <summary>
        /// 基于本地文件的构造器。
        /// </summary>
        /// <param name="fileInfo">本地文件</param>
        public FileItem(FileInfo fileInfo)
        {
            if (fileInfo == null || !fileInfo.Exists)
            {
                throw new ArgumentException("fileInfo is null or not exists!");
            }
            this.fileInfo = fileInfo;
        }

        /// <summary>
        /// 基于本地文件全路径的构造器。
        /// </summary>
        /// <param name="filePath">本地文件全路径</param>
        public FileItem(string filePath)
            : this(new FileInfo(filePath))
        {
            this.fileName = filePath.FileName();
        }

        /// <summary>
        /// 基于文件名和字节流的构造器。
        /// </summary>
        /// <param name="fileName">文件名称（服务端持久化字节流到磁盘时的文件名）</param>
        /// <param name="content">文件字节流</param>
        public FileItem(string fileName, byte[] content)
        {
            if (string.IsNullOrEmpty(fileName)) throw new ArgumentNullException("fileName");
            if (content == null || content.Length == 0) throw new ArgumentNullException("content");

            this.fileName = fileName;
            this.content = content;
        }

        /// <summary>
        /// 基于文件名、字节流和媒体类型的构造器。
        /// </summary>
        /// <param name="fileName">文件名（服务端持久化字节流到磁盘时的文件名）</param>
        /// <param name="content">文件字节流</param>
        /// <param name="mimeType">媒体类型</param>
        public FileItem(String fileName, byte[] content, String mimeType)
            : this(fileName, content)
        {
            if (string.IsNullOrEmpty(mimeType)) throw new ArgumentNullException("mimeType");
            this.mimeType = mimeType;
        }

        public FileItem(string fileName, Stream contentStream)
        {
            if (string.IsNullOrEmpty(fileName)) throw new ArgumentNullException("fileName");
            if (contentStream == null || contentStream.Length == 0) throw new ArgumentNullException("content");
            var contentBytes = new byte[contentStream.Length];
            contentStream.Read(contentBytes, 0, contentBytes.Length);
            contentStream.Seek(0, SeekOrigin.Begin);
            this.fileName = fileName;
            this.content = contentBytes;
        }
        public string GetFileName()
        {
            if (this.fileName == null && this.fileInfo != null && this.fileInfo.Exists)
            {
                this.fileName = this.fileInfo.FullName;
            }

            #region 扩展名缺失 通过文件头计算文件类型

            if (!string.IsNullOrWhiteSpace(this.fileName) && this.fileName.IndexOf(".",StringComparison.CurrentCulture) == -1)
            {
                var content = GetContent();
                if (content != null && content.Length > 2)
                {
                    var ex = String.Empty;
                    var suffix = $"{content[0]}{content[1]}";
                    switch (suffix)
                    {
                        case "3780":
                            ex = "pdf";
                            break;
                        case "255216":
                            ex = "jpg";
                            break;
                        case "13780":
                            ex = "png";
                            break;
                        case "5150":
                        case "4946":
                        case "104116":
                            ex = "txt";
                            break;
                        case "7790":
                            ex = "exe";
                            break;
                        case "8297":
                            ex = "rar";
                            break;
                        case "7173":
                            ex = "gif";
                            break;
                        case "6677":
                            ex = "bmp";
                            break;
                        case "255254":
                            ex = "ini";
                            break;

                    }

                    if (!string.IsNullOrWhiteSpace(ex))
                    {
                        this.fileName = $"{this.fileName}.{ex}";
                    }
                    
                }
            }

            #endregion
            return this.fileName;
        }

        public string GetMimeType()
        {
            if (this.mimeType == null)
            {
                this.mimeType = fileName.ContentType();
            }
            return this.mimeType;
        }

        public byte[] GetContent()
        {
            if (this.content == null && this.fileInfo != null && this.fileInfo.Exists)
            {
                using (Stream fileStream = this.fileInfo.OpenRead())
                {
                    this.content = new byte[fileStream.Length];
                    fileStream.Read(content, 0, content.Length);
                }
            }

            return this.content;
        }
    }
}