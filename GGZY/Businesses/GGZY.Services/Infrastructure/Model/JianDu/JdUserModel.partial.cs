using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 监督平台用户信息
    /// </summary>
    public partial class JdUserModel
    {
        private string _DEPARTIDS;
        private List<string> _DEPARTIDS_ARRAY;

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
        /// <summary>
        /// 是否有所有行业权限
        /// </summary>
        public decimal? ISALLKIND => UserDepartment?.ISALLKIND;
        [JsonIgnore]
        public string DEPARTIDS
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_DEPARTIDS)&& _DEPARTIDS_ARRAY != null&& _DEPARTIDS_ARRAY.Any())
                {
                    _DEPARTIDS = string.Join(",", _DEPARTIDS_ARRAY);
                }
                return _DEPARTIDS;
            }
            set => _DEPARTIDS = value;
        }

        public List<string> DEPARTIDS_ARRAY
        {
            get
            {
                if ((_DEPARTIDS_ARRAY == null || !_DEPARTIDS_ARRAY.Any()) && !string.IsNullOrWhiteSpace(_DEPARTIDS))
                {
                    _DEPARTIDS_ARRAY = _DEPARTIDS.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                return _DEPARTIDS_ARRAY;
            }
            set => _DEPARTIDS_ARRAY = value;
        }

        #region T_USER_EXTEND

        public TUserExtend UserExtend { get; set; }
        /// <summary>
        /// 组织机构信息
        /// </summary>
        public TUserDepartment UserDepartment { get; set; }
        public JdMainUserModel MainUser { get; set; }
        #endregion

        public string DEPARTID_TEXT { get; set; }
        public string TYPE_TEXT { get; set; }
        /// <summary>
        /// 是否是行业主管
        /// </summary>
        public bool IsZhuGuan => UserExtend == null && TYPE == (int) JdTUserType.GongZuoTaiYongHu;
        /// <summary>
        /// 是否是公安
        /// </summary>
        public bool IsGongAn => TYPE == (int) JdTUserType.GongAn;
        /// <summary>
        /// 是否是纪委
        /// </summary>
        public bool IsJiWei => TYPE == (int) JdTUserType.JiWeiJianWei;
        /// <summary>
        /// 是否是注册用户(通过门户注册)
        /// </summary>
        public bool IsZhuCeYongHu => UserExtend != null && TYPE == (int) JdTUserType.BaoJianBeiAnYongHu;

    }
}