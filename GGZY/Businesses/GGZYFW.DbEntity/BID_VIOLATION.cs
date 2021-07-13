using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BID_VIOLATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BID_VIOLATION")]
    [Serializable]
    public partial class BID_VIOLATION : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _VIOM_NAME;
		private string _INFO_FROM;
		private DateTime? _REL_DATE;
		private string _VIO_TYPE;
		private string _VIO_OBJECT;
		private DateTime? _VIO_DATE;
		private string _VIO_DESC;
		private string _NOTI_DEPART;
		private string _PLT_BASIS;
		private string _PLT_RESULT;

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
		/// 违规事项名称
		/// </summary>
		public string VIOM_NAME
		{
			get{ return _VIOM_NAME; }
			set
			{
				this.OnPropertyValueChange(_.VIOM_NAME, _VIOM_NAME, value);
				this._VIOM_NAME = value;
			}
		}
		/// <summary>
		/// 信息来源
		/// </summary>
		public string INFO_FROM
		{
			get{ return _INFO_FROM; }
			set
			{
				this.OnPropertyValueChange(_.INFO_FROM, _INFO_FROM, value);
				this._INFO_FROM = value;
			}
		}
		/// <summary>
		/// 违规事项名称
		/// </summary>
		public DateTime? REL_DATE
		{
			get{ return _REL_DATE; }
			set
			{
				this.OnPropertyValueChange(_.REL_DATE, _REL_DATE, value);
				this._REL_DATE = value;
			}
		}
		/// <summary>
		/// 违规类型
		/// </summary>
		public string VIO_TYPE
		{
			get{ return _VIO_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.VIO_TYPE, _VIO_TYPE, value);
				this._VIO_TYPE = value;
			}
		}
		/// <summary>
		/// 违规对象
		/// </summary>
		public string VIO_OBJECT
		{
			get{ return _VIO_OBJECT; }
			set
			{
				this.OnPropertyValueChange(_.VIO_OBJECT, _VIO_OBJECT, value);
				this._VIO_OBJECT = value;
			}
		}
		/// <summary>
		/// 违规日期
		/// </summary>
		public DateTime? VIO_DATE
		{
			get{ return _VIO_DATE; }
			set
			{
				this.OnPropertyValueChange(_.VIO_DATE, _VIO_DATE, value);
				this._VIO_DATE = value;
			}
		}
		/// <summary>
		/// 违规说明
		/// </summary>
		public string VIO_DESC
		{
			get{ return _VIO_DESC; }
			set
			{
				this.OnPropertyValueChange(_.VIO_DESC, _VIO_DESC, value);
				this._VIO_DESC = value;
			}
		}
		/// <summary>
		/// 通报部门
		/// </summary>
		public string NOTI_DEPART
		{
			get{ return _NOTI_DEPART; }
			set
			{
				this.OnPropertyValueChange(_.NOTI_DEPART, _NOTI_DEPART, value);
				this._NOTI_DEPART = value;
			}
		}
		/// <summary>
		/// 处罚依据
		/// </summary>
		public string PLT_BASIS
		{
			get{ return _PLT_BASIS; }
			set
			{
				this.OnPropertyValueChange(_.PLT_BASIS, _PLT_BASIS, value);
				this._PLT_BASIS = value;
			}
		}
		/// <summary>
		/// 处罚结果
		/// </summary>
		public string PLT_RESULT
		{
			get{ return _PLT_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.PLT_RESULT, _PLT_RESULT, value);
				this._PLT_RESULT = value;
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
				_.VIOM_NAME,
				_.INFO_FROM,
				_.REL_DATE,
				_.VIO_TYPE,
				_.VIO_OBJECT,
				_.VIO_DATE,
				_.VIO_DESC,
				_.NOTI_DEPART,
				_.PLT_BASIS,
				_.PLT_RESULT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._VIOM_NAME,
				this._INFO_FROM,
				this._REL_DATE,
				this._VIO_TYPE,
				this._VIO_OBJECT,
				this._VIO_DATE,
				this._VIO_DESC,
				this._NOTI_DEPART,
				this._PLT_BASIS,
				this._PLT_RESULT,
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
			public readonly static Field All = new Field("*", "BID_VIOLATION");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "BID_VIOLATION", "");
            /// <summary>
			/// 违规事项名称
			/// </summary>
			public readonly static Field VIOM_NAME = new Field("VIOM_NAME", "BID_VIOLATION", "违规事项名称");
            /// <summary>
			/// 信息来源
			/// </summary>
			public readonly static Field INFO_FROM = new Field("INFO_FROM", "BID_VIOLATION", "信息来源");
            /// <summary>
			/// 违规事项名称
			/// </summary>
			public readonly static Field REL_DATE = new Field("REL_DATE", "BID_VIOLATION", "违规事项名称");
            /// <summary>
			/// 违规类型
			/// </summary>
			public readonly static Field VIO_TYPE = new Field("VIO_TYPE", "BID_VIOLATION", "违规类型");
            /// <summary>
			/// 违规对象
			/// </summary>
			public readonly static Field VIO_OBJECT = new Field("VIO_OBJECT", "BID_VIOLATION", "违规对象");
            /// <summary>
			/// 违规日期
			/// </summary>
			public readonly static Field VIO_DATE = new Field("VIO_DATE", "BID_VIOLATION", "违规日期");
            /// <summary>
			/// 违规说明
			/// </summary>
			public readonly static Field VIO_DESC = new Field("VIO_DESC", "BID_VIOLATION", "违规说明");
            /// <summary>
			/// 通报部门
			/// </summary>
			public readonly static Field NOTI_DEPART = new Field("NOTI_DEPART", "BID_VIOLATION", "通报部门");
            /// <summary>
			/// 处罚依据
			/// </summary>
			public readonly static Field PLT_BASIS = new Field("PLT_BASIS", "BID_VIOLATION", "处罚依据");
            /// <summary>
			/// 处罚结果
			/// </summary>
			public readonly static Field PLT_RESULT = new Field("PLT_RESULT", "BID_VIOLATION", "处罚结果");
        }
        #endregion
	}
}