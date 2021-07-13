using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Models;

namespace PullData.Model
{

    public class PoorCreditResult
    {
        public string Code { get; set; }
        public string Message { get; set; }
        /// <summary>
        /// 名单列表内容
        /// </summary>
        public string NameList { get; set; }
        /// <summary>
        /// 备忘录内容
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 限制的行为内容
        /// </summary>
        public string Content { get; set; }
        public string Ticket { get; set; }
        public List<Blacklist> Balcklists { get; set; }

        public List<LabelValueModel> Result
        {
            get
            {
                var r = new List<LabelValueModel>();
                if (Code == "00")
                {
                    var m = new LabelValueModel();
                    foreach (Blacklist balcklist in Balcklists)
                    {
                        m.Id = balcklist.Name;
                        var memo = string.Empty;
                        foreach (var po in balcklist.Policies)
                        {
                            memo += $"{po.Name};"; 
                            var contents = string.Empty;
                            foreach (var poCategory in po.Categorys)
                            {
                               
                                foreach (var poCategoryMeasure in poCategory.Measures)
                                {
                                    contents += $"({poCategoryMeasure.Type}){poCategoryMeasure.Description};";
                                }

                            }
                            m.Label = contents;
                        }
                        m.Value = memo;
                    }
                    r.Add(m);
                }

                return r;
            }
        }
    }
    public class Blacklist
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Policy> Policies { get; set; }
    }

    public class Policy
    {
        public string Name { get; set; }
        public List<Category> Categorys { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
        public List<Measure> Measures { get; set; }
    }

    public class Measure
    {
        public string Type { get; set; }
        public string Description { get; set; }
    }

}
