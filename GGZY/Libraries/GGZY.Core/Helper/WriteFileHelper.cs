using GGZY.Core.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Core.Helper
{
    public abstract class WriteFileHelper
    {
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="parentFolder"></param>
        /// <param name="filename"></param>
        /// <param name="fileContent"></param>
        /// <returns></returns>
#pragma warning disable CS1573 // 参数“encode”在“WriteFileHelper.WriteFile(string, string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        public static bool WriteFile(string parentFolder,string filename,string fileContent,string encode="UTF-8")
#pragma warning restore CS1573 // 参数“encode”在“WriteFileHelper.WriteFile(string, string, string, string)”的 XML 注释中没有匹配的 param 标记(但其他参数有)
        {
            try
            {
                if (!Directory.Exists(parentFolder))
                {
                    Directory.CreateDirectory(parentFolder);
                }

                string filePath = parentFolder + "\\" + filename;
                if (File.Exists(filePath))
                    File.Delete(filePath);

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    //获得字节数组
                    byte[] data = System.Text.Encoding.GetEncoding(encode).GetBytes(fileContent);
                    //开始写入
                    fs.Write(data, 0, data.Length);
                    //清空缓冲区、关闭流
                    fs.Flush();
                    fs.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                Logger.Error("写入文件失败, FolderName:" + parentFolder + ",FileName:" + filename + ",异常信息:"+ex.Message, ex);
                return false;
            }
        }
    }
}
