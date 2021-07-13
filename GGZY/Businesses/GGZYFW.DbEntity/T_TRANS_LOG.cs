using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_TRANS_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TRANS_LOG")]
    [Serializable]
    public partial class T_TRANS_LOG : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _M_KEY;
		private string _M_DATA_SOURCE;
		private string _TBNAME;
		private DateTime? _CREATETIME;
		private DateTime? _ADDTIME;
		private DateTime? _UPDATETIME;
		private DateTime? _DELETETIME;
		private decimal? _PREPAREDELETE;
		private decimal? _TYPE;
		private string _TENDER_PROJECT_CODE;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string M_KEY
		{
			get{ return _M_KEY; }
			set
			{
				this.OnPropertyValueChange(_.M_KEY, _M_KEY, value);
				this._M_KEY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TBNAME
		{
			get{ return _TBNAME; }
			set
			{
				this.OnPropertyValueChange(_.TBNAME, _TBNAME, value);
				this._TBNAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATETIME
		{
			get{ return _CREATETIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATETIME, _CREATETIME, value);
				this._CREATETIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ADDTIME
		{
			get{ return _ADDTIME; }
			set
			{
				this.OnPropertyValueChange(_.ADDTIME, _ADDTIME, value);
				this._ADDTIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATETIME
		{
			get{ return _UPDATETIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATETIME, _UPDATETIME, value);
				this._UPDATETIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DELETETIME
		{
			get{ return _DELETETIME; }
			set
			{
				this.OnPropertyValueChange(_.DELETETIME, _DELETETIME, value);
				this._DELETETIME = value;
			}
		}
		/// <summary>
		/// 默认为0，当1.0接口的数据被删除时，更新为1，进行删除2.0中的数据，已被删除过的状态为2
		/// </summary>
		public decimal? PREPAREDELETE
		{
			get{ return _PREPAREDELETE; }
			set
			{
				this.OnPropertyValueChange(_.PREPAREDELETE, _PREPAREDELETE, value);
				this._PREPAREDELETE = value;
			}
		}
		/// <summary>
		/// _1表示从通用数据集转到专用接口的数据，2表示专用接口新增数据时转到通用数据集中
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
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
				_.M_KEY,
				_.M_DATA_SOURCE,
				_.TBNAME,
				_.CREATETIME,
				_.ADDTIME,
				_.UPDATETIME,
				_.DELETETIME,
				_.PREPAREDELETE,
				_.TYPE,
				_.TENDER_PROJECT_CODE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._M_KEY,
				this._M_DATA_SOURCE,
				this._TBNAME,
				this._CREATETIME,
				this._ADDTIME,
				this._UPDATETIME,
				this._DELETETIME,
				this._PREPAREDELETE,
				this._TYPE,
				this._TENDER_PROJECT_CODE,
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
			public readonly static Field All = new Field("*", "T_TRANS_LOG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TRANS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_KEY = new Field("M_KEY", "T_TRANS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "T_TRANS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TBNAME = new Field("TBNAME", "T_TRANS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATETIME = new Field("CREATETIME", "T_TRANS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ADDTIME = new Field("ADDTIME", "T_TRANS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPDATETIME = new Field("UPDATETIME", "T_TRANS_LOG", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DELETETIME = new Field("DELETETIME", "T_TRANS_LOG", "");
            /// <summary>
			/// 默认为0，当1.0接口的数据被删除时，更新为1，进行删除2.0中的数据，已被删除过的状态为2
			/// </summary>
			public readonly static Field PREPAREDELETE = new Field("PREPAREDELETE", "T_TRANS_LOG", "默认为0，当1.0接口的数据被删除时，更新为1，进行删除2.0中的数据，已被删除过的状态为2");
            /// <summary>
			/// _1表示从通用数据集转到专用接口的数据，2表示专用接口新增数据时转到通用数据集中
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_TRANS_LOG", "_1表示从通用数据集转到专用接口的数据，2表示专用接口新增数据时转到通用数据集中");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "T_TRANS_LOG", "招标项目编号");
        }
        #endregion
	}
}