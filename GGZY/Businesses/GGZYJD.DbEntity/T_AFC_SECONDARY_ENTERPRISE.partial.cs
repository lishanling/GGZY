﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// T_AFC_SECONDARY_ENTERPRISE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_AFC_SECONDARY_ENTERPRISE
    {
        public string Type => "SECONDARY";

        /// <summary>
        /// 8.9 法人证照类型
        /// </summary>
        public string LEREP_CERTTYPE_NAME
        {
            get { return GetCertTypeName(LEREP_CERTTYPE); }
        }

        /// <summary>
        /// 8.9 法人证照类型
        /// </summary>
        public string LEREP_REPRESENTATIVE_CERTTYPE_NAME
        {
            get { return GetCertTypeName(LEREP_REPRESENTATIVE_CERTTYPE); }
        }
        ///// <summary>
        ///// 	8.14 项目单位类型
        ///// </summary>

        public string CONTACT_TYPE_NAME
        {
            get
            {
                var name = CONTACT_CERTTYPE;
                switch (CONTACT_CERTTYPE)
                {
                    case "SF":
                        name = "身份证";
                        break;
                    case "YYZZ":
                        //name = "项目法人单位";
                        break;
                    case "GATX":
                        //name = "项目法人单位";
                        break;
                }
                return name;
            }
        }

        protected string GetCertTypeName(string type)
        {
            var name = string.Empty;
            switch (type)
            {
                case "A05100":
                    name = "企业营业执照(工商注册号)";
                    break;
                case "A05201":
                    name = "组织机构代码证（企业法人）";
                    break;
                case "A05202":
                    name = "组织机构代码证（国家机关法人）";
                    break;
                case "A05203":
                    name = " 组织机构代码证（事业单位法人）";
                    break;
                case "A05204":
                    name = "组织机构代码证（社会团体法人）";
                    break;
                case "A05300":
                    name = "统一社会信用代码";
                    break;
                case "A05900":
                    name = "其他";
                    break;
            }
            return name;
        }
    }
}