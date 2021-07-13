using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Core.Utils
{
    public class Mod32Utils
    {
        static DataTable dtDic = new DataTable();
        static int mod = 37;
        static int[] w = null;

        static Mod32Utils()
        {
            #region 生成 纯系统的权数
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add((int)Math.Pow(2, i) % mod);
                //textBox1.Text += Math.Pow(2, i) % 37 + ",";
            }
            w = list.ToArray();
            #endregion

            #region mod 37-2 字典表 生成 字符对应的值
            //生成 字符对应的值
            dtDic.Columns.Add("char", typeof(string));      //字符
            dtDic.Columns.Add("num_char", typeof(string));  //系统中字母数字串的值
            for (int i = 0; i < 10; i++)
            {
                DataRow dr = dtDic.NewRow();
                dr["char"] = i;
                dr["num_char"] = i;
                dtDic.Rows.Add(dr);
            }

            int A = 65;
            for (int i = 0; i < 26; i++)
            {
                DataRow dr = dtDic.NewRow();
                dr["char"] = (char)(A + i);
                dr["num_char"] = 10 + i;
                dtDic.Rows.Add(dr);
            }
            DataRow dr36 = dtDic.NewRow();
            dr36["char"] = "*";
            dr36["num_char"] = 36;
            dtDic.Rows.Add(dr36);
            #endregion
        }
        /// <summary>
        /// 统一交易标识码1位校验码
        /// </summary>
        public static string Mod(string value)
        {
            //权数与字符值的 乘积的和
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                //从右向左 取乘积和
                string lastChar = value[value.Length - 1 - i].ToString();
                int num = Convert.ToInt32(dtDic.Select("char='" + lastChar + "'")[0]["num_char"]);
                sum += num * w[i + 1];
            }

            // sum + juaoyan===1(mod 37)  总和sum加上检验码必须与1(模 37)同余
            // (sum + juaoyan - 1) % 37 = 0
            //  int yusu = sum % mod;  先将sum中的值变成 37以内
            // (yusu + juaoyan -1 )%37=0
            // yusu + juaoyan -1 = 37  //左侧为37的倍数
            // juaoyan = 37 + 1 - yusu;  
            //  int juaoyan = (mod + 1 - yusu) % mod; //取个模让值小于37
            int yusu = sum % mod;       //余数
            int juaoyan = (mod + 1 - yusu) % mod; //效验码

            string jiaoyanChar = dtDic.Select("num_char='" + juaoyan + "'")[0]["char"].ToString();

            return jiaoyanChar;
        }

    }
}
