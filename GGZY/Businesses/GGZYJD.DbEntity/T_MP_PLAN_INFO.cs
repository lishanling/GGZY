using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_MP_PLAN_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_MP_PLAN_INFO")]
    [Serializable]
    public partial class T_MP_PLAN_INFO : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private decimal? _ASC_ID;
		private string _STAGE_TYPE;
		private decimal? _ISUSER;
		private string _SUNIT;
		private string _OPEN_RANGE;
		private string _REMARK;
		private string _KIND;
		private string _TYPE;
		private string _CODE;
		private DateTime? _CREATE_TM;
		private string _CONTENT_URL;
		private string _LEVEL_TYPE;
		private string _SU_AREACODE;
		private string _NODE_CODE;
		private string _JUDGE_DESC;
		private string _JUDGE_DESC2;
		private string _MUTEX_MP;
		private string _IS_HIDE;

		/// <summary>
		/// ID
		/// </summary>
		public decimal? ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 监督点名称
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 归属方案ID
		/// </summary>
		public decimal? ASC_ID
		{
			get{ return _ASC_ID; }
			set
			{
				this.OnPropertyValueChange(_.ASC_ID, _ASC_ID, value);
				this._ASC_ID = value;
			}
		}
		/// <summary>
		/// 项目阶段
		/// </summary>
		public string STAGE_TYPE
		{
			get{ return _STAGE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.STAGE_TYPE, _STAGE_TYPE, value);
				this._STAGE_TYPE = value;
			}
		}
		/// <summary>
		/// 是否人工监督
		/// </summary>
		public decimal? ISUSER
		{
			get{ return _ISUSER; }
			set
			{
				this.OnPropertyValueChange(_.ISUSER, _ISUSER, value);
				this._ISUSER = value;
			}
		}
		/// <summary>
		/// 监督单位
		/// </summary>
		public string SUNIT
		{
			get{ return _SUNIT; }
			set
			{
				this.OnPropertyValueChange(_.SUNIT, _SUNIT, value);
				this._SUNIT = value;
			}
		}
		/// <summary>
		/// 公开范围
		/// </summary>
		public string OPEN_RANGE
		{
			get{ return _OPEN_RANGE; }
			set
			{
				this.OnPropertyValueChange(_.OPEN_RANGE, _OPEN_RANGE, value);
				this._OPEN_RANGE = value;
			}
		}
		/// <summary>
		/// 监督点描述
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 监督点分类
		/// </summary>
		public string KIND
		{
			get{ return _KIND; }
			set
			{
				this.OnPropertyValueChange(_.KIND, _KIND, value);
				this._KIND = value;
			}
		}
		/// <summary>
		/// 监督点类型
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 监督执行编码
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		
#pragma warning disable CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
/// <summary>
		/// 内容URL
		/// </summary>
		public string CONTENT_URL
#pragma warning restore CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
		{
			get{ return _CONTENT_URL; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT_URL, _CONTENT_URL, value);
				this._CONTENT_URL = value;
			}
		}
		/// <summary>
		/// 异常预警
		/// </summary>
		public string LEVEL_TYPE
		{
			get{ return _LEVEL_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.LEVEL_TYPE, _LEVEL_TYPE, value);
				this._LEVEL_TYPE = value;
			}
		}
		/// <summary>
		/// 监督单位所属地区
		/// </summary>
		public string SU_AREACODE
		{
			get{ return _SU_AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.SU_AREACODE, _SU_AREACODE, value);
				this._SU_AREACODE = value;
			}
		}
		/// <summary>
		/// 归属环节节点编码
		/// </summary>
		public string NODE_CODE
		{
			get{ return _NODE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.NODE_CODE, _NODE_CODE, value);
				this._NODE_CODE = value;
			}
		}
		/// <summary>
		/// 规则表达式
		/// </summary>
		public string JUDGE_DESC
		{
			get{ return _JUDGE_DESC; }
			set
			{
				this.OnPropertyValueChange(_.JUDGE_DESC, _JUDGE_DESC, value);
				this._JUDGE_DESC = value;
			}
		}
		/// <summary>
		/// 规则表达式(特殊)
		/// </summary>
		public string JUDGE_DESC2
		{
			get{ return _JUDGE_DESC2; }
			set
			{
				this.OnPropertyValueChange(_.JUDGE_DESC2, _JUDGE_DESC2, value);
				this._JUDGE_DESC2 = value;
			}
		}
		/// <summary>
		/// 互斥监督点：【互斥监督点】状态为无时且【当前监督点】状态不为无，【互斥监督点】不可用;多个节点用‘,’分割。
		/// </summary>
		public string MUTEX_MP
		{
			get{ return _MUTEX_MP; }
			set
			{
				this.OnPropertyValueChange(_.MUTEX_MP, _MUTEX_MP, value);
				this._MUTEX_MP = value;
			}
		}
		/// <summary>
		/// 是否隐藏：当监督点未启动时是否隐藏展示
		/// </summary>
		public string IS_HIDE
		{
			get{ return _IS_HIDE; }
			set
			{
				this.OnPropertyValueChange(_.IS_HIDE, _IS_HIDE, value);
				this._IS_HIDE = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.NAME,
				_.ASC_ID,
				_.STAGE_TYPE,
				_.ISUSER,
				_.SUNIT,
				_.OPEN_RANGE,
				_.REMARK,
				_.KIND,
				_.TYPE,
				_.CODE,
				_.CREATE_TM,
				_.CONTENT_URL,
				_.LEVEL_TYPE,
				_.SU_AREACODE,
				_.NODE_CODE,
				_.JUDGE_DESC,
				_.JUDGE_DESC2,
				_.MUTEX_MP,
				_.IS_HIDE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._ASC_ID,
				this._STAGE_TYPE,
				this._ISUSER,
				this._SUNIT,
				this._OPEN_RANGE,
				this._REMARK,
				this._KIND,
				this._TYPE,
				this._CODE,
				this._CREATE_TM,
				this._CONTENT_URL,
				this._LEVEL_TYPE,
				this._SU_AREACODE,
				this._NODE_CODE,
				this._JUDGE_DESC,
				this._JUDGE_DESC2,
				this._MUTEX_MP,
				this._IS_HIDE,
			};
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "T_MP_PLAN_INFO");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_MP_PLAN_INFO", "ID");
            /// <summary>
			/// 监督点名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_MP_PLAN_INFO", "监督点名称");
            /// <summary>
			/// 归属方案ID
			/// </summary>
			public readonly static Field ASC_ID = new Field("ASC_ID", "T_MP_PLAN_INFO", "归属方案ID");
            /// <summary>
			/// 项目阶段
			/// </summary>
			public readonly static Field STAGE_TYPE = new Field("STAGE_TYPE", "T_MP_PLAN_INFO", "项目阶段");
            /// <summary>
			/// 是否人工监督
			/// </summary>
			public readonly static Field ISUSER = new Field("ISUSER", "T_MP_PLAN_INFO", "是否人工监督");
            /// <summary>
			/// 监督单位
			/// </summary>
			public readonly static Field SUNIT = new Field("SUNIT", "T_MP_PLAN_INFO", "监督单位");
            /// <summary>
			/// 公开范围
			/// </summary>
			public readonly static Field OPEN_RANGE = new Field("OPEN_RANGE", "T_MP_PLAN_INFO", "公开范围");
            /// <summary>
			/// 监督点描述
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_MP_PLAN_INFO", "监督点描述");
            /// <summary>
			/// 监督点分类
			/// </summary>
			public readonly static Field KIND = new Field("KIND", "T_MP_PLAN_INFO", "监督点分类");
            /// <summary>
			/// 监督点类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_MP_PLAN_INFO", "监督点类型");
            /// <summary>
			/// 监督执行编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_MP_PLAN_INFO", "监督执行编码");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_MP_PLAN_INFO", "创建时间");
            
#pragma warning disable CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
/// <summary>
			/// 内容URL
			/// </summary>
			public readonly static Field CONTENT_URL = new Field("CONTENT_URL", "T_MP_PLAN_INFO", "内容URL");
#pragma warning restore CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
            /// <summary>
			/// 异常预警
			/// </summary>
			public readonly static Field LEVEL_TYPE = new Field("LEVEL_TYPE", "T_MP_PLAN_INFO", "异常预警");
            /// <summary>
			/// 监督单位所属地区
			/// </summary>
			public readonly static Field SU_AREACODE = new Field("SU_AREACODE", "T_MP_PLAN_INFO", "监督单位所属地区");
            /// <summary>
			/// 归属环节节点编码
			/// </summary>
			public readonly static Field NODE_CODE = new Field("NODE_CODE", "T_MP_PLAN_INFO", "归属环节节点编码");
            /// <summary>
			/// 规则表达式
			/// </summary>
			public readonly static Field JUDGE_DESC = new Field("JUDGE_DESC", "T_MP_PLAN_INFO", "规则表达式");
            /// <summary>
			/// 规则表达式(特殊)
			/// </summary>
			public readonly static Field JUDGE_DESC2 = new Field("JUDGE_DESC2", "T_MP_PLAN_INFO", "规则表达式(特殊)");
            /// <summary>
			/// 互斥监督点：【互斥监督点】状态为无时且【当前监督点】状态不为无，【互斥监督点】不可用;多个节点用‘,’分割。
			/// </summary>
			public readonly static Field MUTEX_MP = new Field("MUTEX_MP", "T_MP_PLAN_INFO", "互斥监督点：【互斥监督点】状态为无时且【当前监督点】状态不为无，【互斥监督点】不可用;多个节点用‘,’分割。");
            /// <summary>
			/// 是否隐藏：当监督点未启动时是否隐藏展示
			/// </summary>
			public readonly static Field IS_HIDE = new Field("IS_HIDE", "T_MP_PLAN_INFO", "是否隐藏：当监督点未启动时是否隐藏展示");
        }
        #endregion
	}
}