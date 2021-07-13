using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_UPLOAD_ERROR。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_UPLOAD_ERROR")]
    [Serializable]
    public partial class T_UPLOAD_ERROR : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _SYS_CODE;
		private string _DATA_KEY;
		private string _TB_NAME;
		private string _CHECK_ONE;
		private string _CHECK_TWO;
		private string _CHECK_ALL;
		private DateTime? _SAVE_TIME;
		private string _REMARK;
		private DateTime? _CREATE_TIME;
		private decimal? _IS_HISTORY;
		private DateTime? _START_TIME;
		private DateTime? _END_TIME;

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
		/// 交易平台编码
		/// </summary>
		public string SYS_CODE
		{
			get{ return _SYS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.SYS_CODE, _SYS_CODE, value);
				this._SYS_CODE = value;
			}
		}
		/// <summary>
		/// DATA_KEY
		/// </summary>
		public string DATA_KEY
		{
			get{ return _DATA_KEY; }
			set
			{
				this.OnPropertyValueChange(_.DATA_KEY, _DATA_KEY, value);
				this._DATA_KEY = value;
			}
		}
		/// <summary>
		/// 表名
		/// </summary>
		public string TB_NAME
		{
			get{ return _TB_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TB_NAME, _TB_NAME, value);
				this._TB_NAME = value;
			}
		}
		/// <summary>
		/// 一次校验状态
		/// </summary>
		public string CHECK_ONE
		{
			get{ return _CHECK_ONE; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_ONE, _CHECK_ONE, value);
				this._CHECK_ONE = value;
			}
		}
		/// <summary>
		/// 二次校验状态
		/// </summary>
		public string CHECK_TWO
		{
			get{ return _CHECK_TWO; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_TWO, _CHECK_TWO, value);
				this._CHECK_TWO = value;
			}
		}
		/// <summary>
		/// 省与国家检验
		/// </summary>
		public string CHECK_ALL
		{
			get{ return _CHECK_ALL; }
			set
			{
				this.OnPropertyValueChange(_.CHECK_ALL, _CHECK_ALL, value);
				this._CHECK_ALL = value;
			}
		}
		/// <summary>
		/// 上传时间
		/// </summary>
		public DateTime? SAVE_TIME
		{
			get{ return _SAVE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SAVE_TIME, _SAVE_TIME, value);
				this._SAVE_TIME = value;
			}
		}
		/// <summary>
		/// 备注
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
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get{ return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 是否为历史数据
		/// </summary>
		public decimal? IS_HISTORY
		{
			get{ return _IS_HISTORY; }
			set
			{
				this.OnPropertyValueChange(_.IS_HISTORY, _IS_HISTORY, value);
				this._IS_HISTORY = value;
			}
		}
		/// <summary>
		/// 搜索开始时间
		/// </summary>
		public DateTime? START_TIME
		{
			get{ return _START_TIME; }
			set
			{
				this.OnPropertyValueChange(_.START_TIME, _START_TIME, value);
				this._START_TIME = value;
			}
		}
		/// <summary>
		/// 搜索结束时间
		/// </summary>
		public DateTime? END_TIME
		{
			get{ return _END_TIME; }
			set
			{
				this.OnPropertyValueChange(_.END_TIME, _END_TIME, value);
				this._END_TIME = value;
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
				_.SYS_CODE,
				_.DATA_KEY,
				_.TB_NAME,
				_.CHECK_ONE,
				_.CHECK_TWO,
				_.CHECK_ALL,
				_.SAVE_TIME,
				_.REMARK,
				_.CREATE_TIME,
				_.IS_HISTORY,
				_.START_TIME,
				_.END_TIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._SYS_CODE,
				this._DATA_KEY,
				this._TB_NAME,
				this._CHECK_ONE,
				this._CHECK_TWO,
				this._CHECK_ALL,
				this._SAVE_TIME,
				this._REMARK,
				this._CREATE_TIME,
				this._IS_HISTORY,
				this._START_TIME,
				this._END_TIME,
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
			public readonly static Field All = new Field("*", "T_UPLOAD_ERROR");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_UPLOAD_ERROR", "ID");
            /// <summary>
			/// 交易平台编码
			/// </summary>
			public readonly static Field SYS_CODE = new Field("SYS_CODE", "T_UPLOAD_ERROR", "交易平台编码");
            /// <summary>
			/// DATA_KEY
			/// </summary>
			public readonly static Field DATA_KEY = new Field("DATA_KEY", "T_UPLOAD_ERROR", "DATA_KEY");
            /// <summary>
			/// 表名
			/// </summary>
			public readonly static Field TB_NAME = new Field("TB_NAME", "T_UPLOAD_ERROR", "表名");
            /// <summary>
			/// 一次校验状态
			/// </summary>
			public readonly static Field CHECK_ONE = new Field("CHECK_ONE", "T_UPLOAD_ERROR", "一次校验状态");
            /// <summary>
			/// 二次校验状态
			/// </summary>
			public readonly static Field CHECK_TWO = new Field("CHECK_TWO", "T_UPLOAD_ERROR", "二次校验状态");
            /// <summary>
			/// 省与国家检验
			/// </summary>
			public readonly static Field CHECK_ALL = new Field("CHECK_ALL", "T_UPLOAD_ERROR", "省与国家检验");
            /// <summary>
			/// 上传时间
			/// </summary>
			public readonly static Field SAVE_TIME = new Field("SAVE_TIME", "T_UPLOAD_ERROR", "上传时间");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_UPLOAD_ERROR", "备注");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "T_UPLOAD_ERROR", "创建时间");
            /// <summary>
			/// 是否为历史数据
			/// </summary>
			public readonly static Field IS_HISTORY = new Field("IS_HISTORY", "T_UPLOAD_ERROR", "是否为历史数据");
            /// <summary>
			/// 搜索开始时间
			/// </summary>
			public readonly static Field START_TIME = new Field("START_TIME", "T_UPLOAD_ERROR", "搜索开始时间");
            /// <summary>
			/// 搜索结束时间
			/// </summary>
			public readonly static Field END_TIME = new Field("END_TIME", "T_UPLOAD_ERROR", "搜索结束时间");
        }
        #endregion
	}
}