using System.IO;
using System.Text;

namespace GGZY.Core.Extensions
{
    public static class StreamExtensions
    {
        public static string StreamToStringDispose(this Stream stream, Encoding encode)
        {
            using (StreamReader streamReader = new StreamReader(stream, encode))
            {
                return streamReader.ReadToEnd();
            }
        }

        public static string StreamToString(this Stream stream, Encoding encode)
        {
            stream.Seek(0, SeekOrigin.Begin);
            byte[] byts = new byte[stream.Length];
            stream.Read(byts, 0, byts.Length);
            var end = encode.GetString(byts);
            stream.Seek(0, SeekOrigin.Begin);
            return end;
        }
        public static string StreamToString(this Stream stream, bool dispose = true)
        {
            var s = dispose ? stream.StreamToStringDispose(Encoding.UTF8) : stream.StreamToString(Encoding.UTF8);
            return s;
        }


    }
}