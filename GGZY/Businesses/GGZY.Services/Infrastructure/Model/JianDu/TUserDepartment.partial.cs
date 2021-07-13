using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TUserDepartment
    {
        private string _REGION;
        private List<string> _REGION_ARRAY;
        private string _PARENTIDS;
        private List<string> _PARENTIDS_ARRAY;
        private string _OTHERDEPIDS;
        private List<List<string>> _OTHERDEPIDS_ARRAY;
        public string HY_TYPE_TEXT { get; set; }
        /// <summary>
        /// 行业类型(报建类型)  1 2 3 4 5 6 7 
        /// </summary>
        public List<string> HY_TYPE_LIST => HY_TYPE?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList() ?? new List<string>();
        /// <summary>
        /// 63
        /// 行业项目分类(TENDER_PROJECT_TYPE)
        /// VALUE  01 02 
        /// VALUE2 报建类型 1 2 3 4 5 6 7
        /// VALUE3 A01 A02
        /// </summary>
        public List<SYS_DIC> SYS_DIC_63 { get; set; }
        /// <summary>
        /// A01 A02
        /// </summary>
        public List<string> TENDER_PROJECT_TYPES => SYS_DIC_63?.Select(c => c.VALUE3).ToList();

        private List<string> _FW_TENDER_PROJECT_TYPES;

        /// <summary>
        /// 监督平台行业类型转服务平台行业类型 A01 G01
        /// </summary>
        public List<string> FW_TENDER_PROJECT_TYPES
        {
            get
            {
                if (_FW_TENDER_PROJECT_TYPES == null || !_FW_TENDER_PROJECT_TYPES.Any())
                {

                    var types = new List<String>();
                    var aType = TENDER_PROJECT_TYPES;
                    var gType = TENDER_PROJECT_TYPES?.Select(c => c?.Replace("A", "G")).ToList();
                    if (aType != null && aType.Any())
                    {
                        types.AddRange(aType);
                    }

                    if (gType != null && gType.Any())
                    {
                        types.AddRange(gType);
                    }

                    if (types.Any(c => c.Contains("99-1")))
                    {
                        types.Add("A99");
                        types.Add("G99");
                    }
                    if (types.Any(c => c.Contains("03-")))
                    {
                        types.Add("A03");
                        types.Add("G03");
                    }

                    _FW_TENDER_PROJECT_TYPES = types;
                }
                return _FW_TENDER_PROJECT_TYPES;
            }
        }
        /// <summary>
        /// 归属地名称
        /// </summary>
        public string AREACODE_TEXT { get; set; }

        // public List<Dictionary<string,string>>
        [JsonIgnore]
        public string REGIONS
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_REGION) && _REGION_ARRAY != null && _REGION_ARRAY.Any())
                {
                    _REGION = string.Join(",", _REGION_ARRAY);
                }
                return _REGION;
            }
            set => _REGION = value;
        }

        public List<string> REGIONS_ARRAY
        {
            get
            {
                if ((_REGION_ARRAY == null || !_REGION_ARRAY.Any()) && !string.IsNullOrWhiteSpace(_REGION))
                {
                    _REGION_ARRAY = _REGION.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                return _REGION_ARRAY;
            }
            set => _REGION_ARRAY = value;
        }
        [JsonIgnore]
        public string PARENTIDS
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_PARENTIDS) && PARENTIDS_ARRAY != null && PARENTIDS_ARRAY.Any())
                {
                    _PARENTIDS = string.Join(",", PARENTIDS_ARRAY);
                }
                return _PARENTIDS;
            }
            set => _PARENTIDS = value;
        }

        public List<string> PARENTIDS_ARRAY
        {
            get
            {
                if ((_PARENTIDS_ARRAY == null || !_PARENTIDS_ARRAY.Any()) && !string.IsNullOrWhiteSpace(_PARENTIDS))
                {
                    _PARENTIDS_ARRAY = _PARENTIDS.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                return _PARENTIDS_ARRAY;
            }
            set => _PARENTIDS_ARRAY = value;
        }
        /// <summary>
        /// depid1,depid2;depid3,depid4
        /// </summary>
        [JsonIgnore]
        public string OTHERDEPIDS
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_OTHERDEPIDS) && (OTHERDEPIDS_ARRAY != null && OTHERDEPIDS_ARRAY.Any()))
                {
                    var arr = OTHERDEPIDS_ARRAY.Select(c => string.Join(",", c)).ToList();
                    _OTHERDEPIDS = string.Join(";", arr);
                }
                return _OTHERDEPIDS;
            }
            set => _OTHERDEPIDS = value;
        }

        public List<List<string>> OTHERDEPIDS_ARRAY
        {
            get
            {
                if ((_OTHERDEPIDS_ARRAY == null || !_OTHERDEPIDS_ARRAY.Any()) && !string.IsNullOrWhiteSpace(_OTHERDEPIDS))
                {
                    _OTHERDEPIDS_ARRAY = _OTHERDEPIDS.Split(';').Select(c => c.Split(',').ToList()).ToList();
                }
                return _OTHERDEPIDS_ARRAY;
            }
            set => _OTHERDEPIDS_ARRAY = value;
        }

        public string RootAreaCode
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(AREACODE))
                {

                    var rootAreaCode = AREACODE.TrimEnd('0');
                    var rightLen = 0;
                    if (rootAreaCode.Length <= 6)
                    {
                        if (rootAreaCode.Length % 2 > 0) rightLen = 2 - rootAreaCode.Length % 2;
                    }
                    else
                    {
                        if (rootAreaCode.Length % 3 > 0) rightLen = 3 - rootAreaCode.Length % 3;
                    }
                    rootAreaCode = rootAreaCode.PadRight(rootAreaCode.Length + rightLen, '0');

                    return rootAreaCode;
                }
                return AREACODE;
            }
        }
    }
}