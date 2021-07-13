
using System;
using System.Linq;
using Dos.ORM;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.BigData
{
    public class ExpertInfoModel
    {

        [JsonIgnore]
        public string EXPERT_NAME { get; set; }

        [JsonIgnore]
        public string ID_CARD { get; set; }

        public string LEGAL_NAME
        {
            get
            {

                return Encode(EXPERT_NAME);
            }
        }

        public string LEGAL_CODE
        {
            get => Encode(ID_CARD);
        }

        public string AREANAME { get; set; }
        public Int64 LOST_COUNT { get; set; }
        public Int64 AGAIN_COUNT { get; set; }
        public Int64 WIN_COUNT { get; set; }
        public Int64 COUNT { get; set; }
        [JsonIgnore]
        public decimal? RATE { get; set; }

        public string RATE_TEXT => RATE?.ToString("P0");

        public string MIXCODE
        {
            get
            {
                var code = string.Empty;

                if (!string.IsNullOrWhiteSpace(EXPERT_NAME) && !string.IsNullOrWhiteSpace(ID_CARD) &&
                    ID_CARD.Length == 18)
                {
                    char[] c = ID_CARD.ToArray();
                    code = $"{c[1]}{c[5]}{c[9]}{c[17]}{c[10]}{c[12]}{c[0]}{c[2]}{c[7]}{c[14]}{c[13]}{c[16]}{c[3]}{c[6]}{c[11]}{c[15]}{c[4]}{c[8]}";
                }
                return code;
            }
        }

        private string Encode(string source)
        {
            if (!string.IsNullOrWhiteSpace(source))
            {
                var length = source.Length;
                switch (length)
                {
                    case 1:
                    case 2:
                        source = $"{source[0]}*";
                        break;
                    case 3:
                        source = $"{source[0]}*{source[2]}";
                        break;
                    case 18:
                        source = $"{source.Substring(0, 3)}*******{source.Substring(14, 4)}";
                        break;
                }
            }
            return source;
        }
    }

    public class V_EVALUATION_REPORT
    {
        /// <summary>
        /// 结果
        /// </summary>
        public readonly static Field EVALUATION_RESULT = new Field("EVALUATION_RESULT", "V_EVALUATION_REPORT", "结果");
        /// <summary>
        /// 结果数量
        /// </summary>
        public readonly static Field EVALUATION_RESULT_COUNT = new Field("EVALUATION_RESULT_COUNT", "V_EVALUATION_REPORT", "结果数量");
        /// <summary>
        /// 身份证
        /// </summary>
        public readonly static Field ID_CARD = new Field("ID_CARD", "V_EVALUATION_REPORT", "身份证");
        /// <summary>
        /// 招标失败
        /// </summary>
        public readonly static Field LOST_COUNT = new Field("SUM(DECODE(EVALUATION_RESULT,'1',EVALUATION_RESULT_COUNT,0))", "", "招标失败");
        /// <summary>
        /// 重新招标
        /// </summary>
        public readonly static Field AGAIN_COUNT = new Field("SUM(DECODE(EVALUATION_RESULT,'2',EVALUATION_RESULT_COUNT,0))", "", "重新招标");
        /// <summary>
        /// 招标失败
        /// </summary>
        public readonly static Field WIN_COUNT = new Field("SUM(DECODE(EVALUATION_RESULT,'3',EVALUATION_RESULT_COUNT,0))", "", "招标成功");

      

        /// <summary>
        /// 招标数量
        /// </summary>
        public readonly static Field RATE = new Field($"ROUND({WIN_COUNT.Name}/{EVALUATION_RESULT_COUNT.Sum().FieldName},3)");

    }
}