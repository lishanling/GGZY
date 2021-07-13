using System;
using System.Collections.Generic;
using System.Linq;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 标前列表页对象
    /// </summary>
    public class BeforeListModel
    {
        public string GUID { get; set; }
        public string TZ_CODE { get; set; }
        public string PROJECT_NAME { get; set; }
        public string APPLY_DATE { get; set; }
        public string TOTAL_MONEY { get; set; }
        public string PROJECT_TYPE { get; set; }
        public string AFC_TYPE { get; set; }

        public string PROJECT_TYPE_NAME
        {
            get
            {
                var txt = String.Empty;
                switch (PROJECT_TYPE)
                {
                    case "A00001":
                        txt = "审批";
                        break;
                    case "A00002":
                        txt = "核准";
                        break;
                    case "A00003":
                        txt = "备案";
                        break;
                    case "A00088":
                        txt = "非固定资产";
                        break;
                }
                return txt;
            }
        }

        public string RN { get; set; }
    }
    /// <summary>
    /// 联动监管-标前详情 
    /// </summary>
    public class BeforeDetailModel
    {
        /// <summary>
        /// 联动监管-标前详情 
        /// </summary>
        public BeforeDetailModel()
        {
            Approval=new List<BeforeApprovalDetail>();
            Project=new BeforeProjectDetail();
            Enterprise=new List<BeforeEnterpriseDetail>();
            Result=new List<BeforeApprovalResultDetail>();
        }
        /// <summary>
        /// 项目推介审核情况
        /// </summary>
        public List<BeforeApprovalDetail> Approval { get; set; }
        /// <summary>
        /// 申报项目基本信息
        /// </summary>
        public BeforeProjectDetail Project { get; set; }
        /// <summary>
        /// 法人基本信息
        /// </summary>
        public List<BeforeEnterpriseDetail> Enterprise { get; set; }
        /// <summary>
        /// 批准结果信息
        /// </summary>
        public List<BeforeApprovalResultDetail> Result { get; set; }

        public void SetProjectEnterprise()
        {
            if (Enterprise!=null&&Enterprise.Any() && Project != null)
            {
                Project.XMFRDW = Enterprise.FirstOrDefault()?.QYMC;
            }
        }
    }
    /// <summary>
    /// 批准结果信息
    /// </summary>
    public class BeforeApprovalResultDetail
    {
        /// <summary>
        /// 主管部门 德化县发展和改革局
        /// </summary>
        public string ZGBM { get; set; }
        /// <summary>
        /// 备案事项 县级权限内企业境内投资项目备案 
        /// </summary>
        public string BASX { get; set; }
        /// <summary>
        /// 备案号  闽发改备[2020]C110125
        /// </summary>
        public string BAH { get; set; }
        /// <summary>
        /// 结果 办结(通过)
        /// </summary>
        public string JG { get; set; }
        /// <summary>
        /// 通过时间 2020-05-18
        /// </summary>
        public string TGSJ { get; set; }

    }
    /// <summary>
    /// 项目推介审核情况
    /// </summary>
    public class BeforeApprovalDetail
    {
        /// <summary>
        /// 审核类型  拟推介审核 公开推介审核
        /// </summary>
        public string SHLX { get; set; }
        /// <summary>
        /// 审核状态 审核通过
        /// </summary>
        public string SHZT { get; set; }
        /// <summary>
        /// 发起人 长汀县发改局投资科
        /// </summary>
        public string FQR { get; set; }
        /// <summary>
        /// 发起时间 2019-01-03
        /// </summary>
        public string FQSJ { get; set; }
        /// <summary>
        /// 详情
        /// </summary>
        public string CONTENT { get; set; }
    }

    /// <summary>
    /// 法人基本信息
    /// </summary>
    public class BeforeEnterpriseDetail
    {
        /// <summary>
        /// 企业名称	长汀县腾飞城市建设投资有限公司
        /// </summary>
        public string QYMC { get; set; }
        /// <summary>
        /// 企业注册类型	
        /// </summary>
        public string QYZCLX { get; set; }
        /// <summary>
        /// 项目法人证照类型	企业营业执照(工商注册号)
        /// </summary>
        public string XMFRZZLX { get; set; }
        /// <summary>
        /// 项目法人证照号码	91******0Y
        /// </summary>
        public string XMFRZZHM { get; set; }
        /// <summary>
        /// 法定代表人姓名	
        /// </summary>
        public string FRXM { get; set; }
        /// <summary>
        /// 法定代表人身份证件类型	
        /// </summary>
        public string FRSFZJLX { get; set; }
        /// <summary>
        /// 法定代表人身份证件号码	
        /// </summary>
        public string FRSFZJHM { get; set; }
        /// <summary>
        /// 联系人姓名	张佳薇
        /// </summary>
        public string LXRXM { get; set; }
        /// <summary>
        /// 联系人身份证件类型	
        /// </summary>
        public string LXRSFZJLX { get; set; }
        /// <summary>
        /// 联系人身份证件号码	
        /// </summary>
        public string LXRSFZJHM { get; set; }
        /// <summary>
        /// 联系人固话	133****6033
        /// </summary>
        public string LXRGH { get; set; }
        /// <summary>
        /// 联系人邮箱	ct6****63.com
        /// </summary>
        public string LXRYX { get; set; }
        /// <summary>
        /// 联系人手机	
        /// </summary>
        public string LXRSJ { get; set; }
        /// <summary>
        /// 传真	
        /// </summary>
        public string CZ { get; set; }
    }
    /// <summary>
    /// 申报项目基本信息
    /// </summary>
    public class BeforeProjectDetail
    {
        /// <summary>
        /// 项目法人单位	
        /// </summary>
        public string XMFRDW { get; set; }
        /// <summary>
        /// 来源平台	
        /// </summary>
        public string LYPT { get; set; }
        /// <summary>
        /// 代理机构	
        /// </summary>
        public string DLJG { get; set; }
        /// <summary>
        /// 业主单位	
        /// </summary>
        public string YZDW { get; set; }
        /// <summary>
        /// 项目代码	2018-350821-78-01-053318
        /// </summary>
        public string XMDM { get; set; }
        /// <summary>
        /// 项目名称	卧龙-南屏山风景名胜区南屏山景区游步道工程
        /// </summary>
        public string XMMC { get; set; }
        /// <summary>
        /// 申报时间	2018-09-12
        /// </summary>

        public string SBSJ { get; set; }
        /// <summary>
        /// 投资项目	县级政府投资的社会事业项目审批
        /// </summary>
        public String TZXM { get; set; }
        /// <summary>
        /// 项目类型	审批类
        /// </summary>
        public string XMLX { get; set; }
        /// <summary>
        /// 项目所属行政区域	福建省龙岩市长汀县
        /// </summary>
        public String REGION { get; set; }
        /// <summary>
        /// 报建编号	
        /// </summary>
        public String BJBH { get; set; }
        /// <summary>
        /// 工程类别
        /// </summary>

        public string GCLB { get; set; }
        /// <summary>
        /// 工程投资性质	
        /// </summary>
        public String GCTZXZ { get; set; }
        /// <summary>
        /// 房屋和市政工程建设性质	
        /// </summary>

        public String GCJSXZ { get; set; }
        /// <summary>
        /// 是否重点项目	
        /// </summary>
        public String SFZDXM { get; set; }
        /// <summary>
        /// 工程用途	
        /// </summary>
        public string GCYT { get; set; }
        /// <summary>
        /// 国标行业	公共设施管理业
        /// </summary>
        public string GBHY { get; set; }
        /// <summary>
        /// 项目所属行业	旅游
        /// </summary>
        public string XMSSHY { get; set; }
        /// <summary>
        /// 建设性质	新建
        /// </summary>
        public string JSXZ { get; set; }
        /// <summary>
        /// 项目属性	国有控股项目
        /// </summary>
        public string XMSX { get; set; }
        /// <summary>
        /// 拟开工年份	2018
        /// </summary>
        public string KGNF { get; set; }
        /// <summary>
        /// 拟建成年份	2020
        /// </summary>
        public string JCNF { get; set; }
        /// <summary>
        /// 项目总投资(万元)	30016.8000
        /// </summary>
        public string XMZTZ { get; set; }
        /// <summary>
        /// 总投资额为“0”时说明	
        /// </summary>
        public string SM { get; set; }
        /// <summary>
        /// 产业结构调整指导类型	允许类
        /// </summary>
        public string ZDLX { get; set; }
        /// <summary>
        /// 产业结构调整指导目录	城市基础设施
        /// </summary>
        public string ZDML { get; set; }
        /// <summary>
        /// 建设详细地址	福建省龙岩市长汀县
        /// </summary>
        public string XXDZ { get; set; }
        /// <summary>
        /// 主要建设内容及规模	建设慢行系统、慢行系统游览设施、慢行系统服务设施、总体工程等
        /// </summary>
        public string NRGM { get; set; }
    }
}