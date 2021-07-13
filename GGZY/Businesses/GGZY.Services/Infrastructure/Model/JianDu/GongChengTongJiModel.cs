using System.Collections.Generic;
using System.Text;
using GGZY.Core.Extensions;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class GongChengTongJiModel
    {
        public GongChengTongJiModel()
        {
            List = new List<V_GONGCHENG_TONGJI>();
            ZBXMZS = List.Count;

        }
        /// <summary>
        /// 招标项目总数
        /// </summary>
        public int ZBXMZS { get; set; }
        /// <summary>
        /// 招标人数量
        /// </summary>
        public int ZBRSL { get; set; }
        /// <summary>
        /// 招标代理数量
        /// </summary>
        public int ZBDLSL { get; set; }
        /// <summary>
        /// 招标控制价总额
        /// </summary>
        public int ZBKZJZE { get; set; }
        /// <summary>
        /// 中标价总额
        /// </summary>
        public int ZBJZE { get; set; }
        /// <summary>
        /// 平均下浮率
        /// </summary>
        public int PJXFL { get; set; }
        /// <summary>
        /// 中标单位总数
        /// </summary>
        public int ZBDWZS { get; set; }

        public List<V_GONGCHENG_TONGJI> List { get; set; }

        public string Name { get; set; } = "建设工程统计月报表";
        /// <summary>
        /// 标段（包）分类
        /// </summary>
        public string ClissifyCode { get; set; }
        /// <summary>
        /// {"A08", "建设工程施工招标统计月报表".CsvValue()}，
        /// {"A05", "建设工程监理招标统计月报表".CsvValue()}，
        /// {"A03,A04", "建设工程勘察、设计招标统计月报表".CsvValue()}，
        /// {"A10", "EPC总承包的月报表的统计".CsvValue()}，
        /// </summary>
        /// <returns></returns>
        public string ToCsv()
        {
            var data = new StringBuilder();
            data.AppendLine(Header[ClissifyCode]);
            switch (ClissifyCode)
            {
                case "A08":
                    for (int i = 0; i < List.Count; i++)
                    {
                        var m = List[i];
                        data.AppendLine($@"{(i + 1)},{m.GCMC.CsvValue()},{m.HYFL.CsvValue()},{m.BABM.CsvValue()},{m.ZJLY.CsvValue()},{m.ZBR.CsvValue()},{m.ZBDLDW.CsvValue()},{m.ZBFS.CsvValue()},{m.PBBF.CsvValue()},{m.GCGM.CsvValue()},{m.YSJ.CsvValue()},{m.ZBKZJ.CsvValue()},{m.ZBJ.CsvValue()},{m.YYSJBJ.CsvValue()},{m.YKZJBJ.CsvValue()},{m.DEGQ.CsvValue()},{m.JSGQ.CsvValue()},{m.GQSD.CsvValue()},{m.KBRQ.CsvValue()},{m.TBDWGS.CsvValue()},{m.ZBDW.CsvValue()},{m.ZBDWYJ.CsvValue()},{m.ZBDWXYF.CsvValue()},{m.XMFZR.CsvValue()},{m.XMFZRYJ.CsvValue()},{m.XMJSFZR.CsvValue()},{m.PBWYHCY.CsvValue()},{m.BEIZHU.CsvValue()}");
                    }
                    break;
                case "A05":
                    for (int i = 0; i < List.Count; i++)
                    {
                        var m = List[i];
                        data.AppendLine($@"{(i + 1)},{m.GCMC.CsvValue()},{m.HYFL.CsvValue()},{m.BABM.CsvValue()},{m.ZJLY.CsvValue()},{m.ZBR.CsvValue()},{m.ZBDLDW.CsvValue()},{m.ZBFS.CsvValue()},{m.PBBF.CsvValue()},{m.GCGM.CsvValue()},{m.YSJ.CsvValue()},{m.ZBKZJ.CsvValue()},{m.ZBJ.CsvValue()},{m.YYSJBJ.CsvValue()},{m.YKZJBJ.CsvValue()},{m.JLFWQ.CsvValue()},{m.KBRQ.CsvValue()},{m.TBDWGS.CsvValue()},{m.ZBDW.CsvValue()},{m.ZBDWYJ.CsvValue()},{m.ZBDWXYF.CsvValue()},{m.ZJLGCS.CsvValue()},{m.ZJLGCSYJ.CsvValue()},{m.PBWYHCY.CsvValue()},{m.BEIZHU.CsvValue()}");
                    }
                    break;
                case "A03_A04":
                    for (int i = 0; i < List.Count; i++)
                    {
                        var m = List[i];
                        data.AppendLine($@"{(i + 1)},{m.GCMC.CsvValue()},{m.HYFL.CsvValue()},{m.BABM.CsvValue()},{m.ZJLY.CsvValue()},{m.ZBR.CsvValue()},{m.ZBDLDW.CsvValue()},{m.ZBFS.CsvValue()},{m.PBBF.CsvValue()},{m.GCGM.CsvValue()},{m.YSJ.CsvValue()},{m.ZBKZJ.CsvValue()},{m.ZBJ.CsvValue()},{m.YYSJBJ.CsvValue()},{m.YKZJBJ.CsvValue()},{m.KCSJZQ.CsvValue()},{m.KBRQ.CsvValue()},{m.TBDWGS.CsvValue()},{m.ZBDW.CsvValue()},{m.ZBDWYJ.CsvValue()},{m.ZBDWXYF.CsvValue()},{m.XMFZR.CsvValue()},{m.XMFZRYJ.CsvValue()},{m.PBWYHCY.CsvValue()},{m.BEIZHU.CsvValue()}");
                    }
                    break;
                case "A10":
                    for (int i = 0; i < List.Count; i++)
                    {
                        var m = List[i];
                        data.AppendLine($@"{(i + 1)},{m.GCMC.CsvValue()},{m.HYFL.CsvValue()},{m.BABM.CsvValue()},{m.ZJLY.CsvValue()},{m.ZBR.CsvValue()},{m.ZBDLDW.CsvValue()},{m.ZBFS.CsvValue()},{m.PBBF.CsvValue()},{m.GCGM.CsvValue()},{m.YSJ.CsvValue()},{m.ZBKZJ.CsvValue()},{m.ZBJ.CsvValue()},{m.YYSJBJ.CsvValue()},{m.YKZJBJ.CsvValue()},{m.DEGQ.CsvValue()},{m.JSGQ.CsvValue()},{m.GQSD.CsvValue()},{m.KBRQ.CsvValue()},{m.TBDWGS.CsvValue()},{m.ZBDW.CsvValue()},{m.ZBDWYJ.CsvValue()},{m.ZBDWXYF.CsvValue()},{m.XMFZR.CsvValue()},{m.XMFZRYJ.CsvValue()},{m.PBWYHCY.CsvValue()},{m.BEIZHU.CsvValue()}");
                    }
                    break;
            }


            return data.ToString();
        }

      
        public static Dictionary<string, string> Header => new Dictionary<string, string>()
        {
            { "A08", "序号,工程名称,行业类别,备案部门,资金来源,招标人,招标代理单位,招标方式,评标办法,工程规模,预算价(万元),招标控制价(万元),与预算价比较,与控制价比较,定额工期,建设工期,建设工期比定额工期缩短(%),开标日期,投标单位个数,中标单位,中标单位业绩,中标单位信用分,项目负责人,项目负责人业绩,项目技术负责人,评标委员会成员,备注"},
            { "A05", "序号,工程名称,行业类别,备案部门,资金来源,招标人,招标代理单位,招标方式,评标办法,工程规模,预算价(万元),招标控制价(万元),与预算价比较,与控制价比较,监理服务期,开标日期,投标单位个数,中标单位,中标单位业绩,中标单位信用分,总监理工程师,总监理工程师业绩,评标委员会成员,备注"},
            { "A03_A04", "序号,工程名称,行业类别,备案部门,资金来源,招标人,招标代理单位,招标方式,评标办法,工程规模,预算价(万元),招标控制价(万元),与预算价比较,与控制价比较,勘察/设计周期,开标日期,投标单位个数,中标单位,中标单位业绩,中标单位信用分,项目负责人,项目负责人业绩,评标委员会成员,备注"},
            { "A10", "序号,工程名称,行业类别,备案部门,资金来源,招标人,招标代理单位,招标方式,评标办法,工程规模,预算价(万元),招标控制价(万元),与预算价比较,与控制价比较,交货期,开标日期,投标单位个数,中标单位,中标单位业绩,评标委员会成员,备注"},
            { "A10_", "序号,工程名称,行业类别,备案部门,资金来源,招标人,招标代理单位,招标方式,评标办法,工程规模,预算价(万元),招标控制价(万元),与预算价比较,与控制价比较,定额工期,建设工期,建设工期比定额工期缩短(%),开标日期,投标单位个数,中标单位,中标单位业绩,项目负责人,项目负责人业绩,评标委员会成员,备注"},
        };
    }
}