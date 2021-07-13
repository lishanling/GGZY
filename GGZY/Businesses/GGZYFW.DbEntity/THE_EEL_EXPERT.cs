using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类THE_EEL_EXPERT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("THE_EEL_EXPERT")]
    [Serializable]
    public partial class THE_EEL_EXPERT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _REAL_NAME;
		private string _ID_CARD;
		private decimal? _SEX;
		private string _SUBJECT;
		private decimal? _IS_LEAD_EXPERT;
		private string _SEAT;
		private decimal? _EXPERT_TYPE;
		private decimal? _FID;
		private decimal? _IS_DELETE;

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
		/// 姓名
		/// </summary>
		public string REAL_NAME
		{
			get{ return _REAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.REAL_NAME, _REAL_NAME, value);
				this._REAL_NAME = value;
			}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string ID_CARD
		{
			get{ return _ID_CARD; }
			set
			{
				this.OnPropertyValueChange(_.ID_CARD, _ID_CARD, value);
				this._ID_CARD = value;
			}
		}
		/// <summary>
		/// 性别 0:女 1：男
		/// </summary>
		public decimal? SEX
		{
			get{ return _SEX; }
			set
			{
				this.OnPropertyValueChange(_.SEX, _SEX, value);
				this._SEX = value;
			}
		}
		/// <summary>
		/// 专业
		/// </summary>
		public string SUBJECT
		{
			get{ return _SUBJECT; }
			set
			{
				this.OnPropertyValueChange(_.SUBJECT, _SUBJECT, value);
				this._SUBJECT = value;
			}
		}
		/// <summary>
		/// 是否评标组长
		/// </summary>
		public decimal? IS_LEAD_EXPERT
		{
			get{ return _IS_LEAD_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.IS_LEAD_EXPERT, _IS_LEAD_EXPERT, value);
				this._IS_LEAD_EXPERT = value;
			}
		}
		/// <summary>
		/// 评标席位
		/// </summary>
		public string SEAT
		{
			get{ return _SEAT; }
			set
			{
				this.OnPropertyValueChange(_.SEAT, _SEAT, value);
				this._SEAT = value;
			}
		}
		/// <summary>
		/// 类型：0 主会场专家  1分会场专家
		/// </summary>
		public decimal? EXPERT_TYPE
		{
			get{ return _EXPERT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_TYPE, _EXPERT_TYPE, value);
				this._EXPERT_TYPE = value;
			}
		}
		/// <summary>
		/// 专家设置表关联ID
		/// </summary>
		public decimal? FID
		{
			get{ return _FID; }
			set
			{
				this.OnPropertyValueChange(_.FID, _FID, value);
				this._FID = value;
			}
		}
		/// <summary>
		/// 是否删除 0:否 1：删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
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
				_.REAL_NAME,
				_.ID_CARD,
				_.SEX,
				_.SUBJECT,
				_.IS_LEAD_EXPERT,
				_.SEAT,
				_.EXPERT_TYPE,
				_.FID,
				_.IS_DELETE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REAL_NAME,
				this._ID_CARD,
				this._SEX,
				this._SUBJECT,
				this._IS_LEAD_EXPERT,
				this._SEAT,
				this._EXPERT_TYPE,
				this._FID,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "THE_EEL_EXPERT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "THE_EEL_EXPERT", "ID");
            /// <summary>
			/// 姓名
			/// </summary>
			public readonly static Field REAL_NAME = new Field("REAL_NAME", "THE_EEL_EXPERT", "姓名");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "THE_EEL_EXPERT", "身份证号码");
            /// <summary>
			/// 性别 0:女 1：男
			/// </summary>
			public readonly static Field SEX = new Field("SEX", "THE_EEL_EXPERT", "性别 0:女 1：男");
            /// <summary>
			/// 专业
			/// </summary>
			public readonly static Field SUBJECT = new Field("SUBJECT", "THE_EEL_EXPERT", "专业");
            /// <summary>
			/// 是否评标组长
			/// </summary>
			public readonly static Field IS_LEAD_EXPERT = new Field("IS_LEAD_EXPERT", "THE_EEL_EXPERT", "是否评标组长");
            /// <summary>
			/// 评标席位
			/// </summary>
			public readonly static Field SEAT = new Field("SEAT", "THE_EEL_EXPERT", "评标席位");
            /// <summary>
			/// 类型：0 主会场专家  1分会场专家
			/// </summary>
			public readonly static Field EXPERT_TYPE = new Field("EXPERT_TYPE", "THE_EEL_EXPERT", "类型：0 主会场专家  1分会场专家");
            /// <summary>
			/// 专家设置表关联ID
			/// </summary>
			public readonly static Field FID = new Field("FID", "THE_EEL_EXPERT", "专家设置表关联ID");
            /// <summary>
			/// 是否删除 0:否 1：删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "THE_EEL_EXPERT", "是否删除 0:否 1：删除");
        }
        #endregion
	}
}