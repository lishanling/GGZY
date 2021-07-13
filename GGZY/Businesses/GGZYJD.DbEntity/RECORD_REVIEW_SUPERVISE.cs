using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类RECORD_REVIEW_SUPERVISE。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("RECORD_REVIEW_SUPERVISE")]
	[Serializable]
	public partial class RECORD_REVIEW_SUPERVISE : JdEntity
	{
		#region Model
		private string _ID;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;
		private decimal? _RECORD_ID;
		private string _REVIEW_CODE;
		private decimal? _STATUS;
		private DateTime? _SUPERVISE_TIME;
		private string _SUPERVISE_TYPE;
		private string _SUPERVISE_WAY;
		private DateTime? _M_TM;

		/// <summary>
		/// 主键ID
		/// </summary>
		public string ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get { return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get { return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 备案记录ID
		/// </summary>
		public decimal? RECORD_ID
		{
			get { return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 备案记录编号
		/// </summary>
		public string REVIEW_CODE
		{
			get { return _REVIEW_CODE; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_CODE, _REVIEW_CODE, value);
				this._REVIEW_CODE = value;
			}
		}
		/// <summary>
		/// 督查状态（0：绿灯 1：红灯）
		/// </summary>
		public decimal? STATUS
		{
			get { return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 监察时间
		/// </summary>
		public DateTime? SUPERVISE_TIME
		{
			get { return _SUPERVISE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_TIME, _SUPERVISE_TIME, value);
				this._SUPERVISE_TIME = value;
			}
		}
		/// <summary>
		/// 督查类型
		/// </summary>
		public string SUPERVISE_TYPE
		{
			get { return _SUPERVISE_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_TYPE, _SUPERVISE_TYPE, value);
				this._SUPERVISE_TYPE = value;
			}
		}
		/// <summary>
		/// 督查方式
		/// </summary>
		public string SUPERVISE_WAY
		{
			get { return _SUPERVISE_WAY; }
			set
			{
				this.OnPropertyValueChange(_.SUPERVISE_WAY, _SUPERVISE_WAY, value);
				this._SUPERVISE_WAY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? M_TM
		{
			get { return _M_TM; }
			set
			{
				this.OnPropertyValueChange(_.M_TM, _M_TM, value);
				this._M_TM = value;
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
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
				_.RECORD_ID,
				_.REVIEW_CODE,
				_.STATUS,
				_.SUPERVISE_TIME,
				_.SUPERVISE_TYPE,
				_.SUPERVISE_WAY,
				_.M_TM,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
				this._RECORD_ID,
				this._REVIEW_CODE,
				this._STATUS,
				this._SUPERVISE_TIME,
				this._SUPERVISE_TYPE,
				this._SUPERVISE_WAY,
				this._M_TM,
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
			public readonly static Field All = new Field("*", "RECORD_REVIEW_SUPERVISE");
			/// <summary>
			/// 主键ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_REVIEW_SUPERVISE", "主键ID");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "RECORD_REVIEW_SUPERVISE", "招标项目编号");
			/// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "RECORD_REVIEW_SUPERVISE", "招标项目名称");
			/// <summary>
			/// 备案记录ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_REVIEW_SUPERVISE", "备案记录ID");
			/// <summary>
			/// 备案记录编号
			/// </summary>
			public readonly static Field REVIEW_CODE = new Field("REVIEW_CODE", "RECORD_REVIEW_SUPERVISE", "备案记录编号");
			/// <summary>
			/// 督查状态（0：绿灯 1：红灯）
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "RECORD_REVIEW_SUPERVISE", "督查状态（0：绿灯 1：红灯）");
			/// <summary>
			/// 监察时间
			/// </summary>
			public readonly static Field SUPERVISE_TIME = new Field("SUPERVISE_TIME", "RECORD_REVIEW_SUPERVISE", "监察时间");
			/// <summary>
			/// 督查类型
			/// </summary>
			public readonly static Field SUPERVISE_TYPE = new Field("SUPERVISE_TYPE", "RECORD_REVIEW_SUPERVISE", "督查类型");
			/// <summary>
			/// 督查方式
			/// </summary>
			public readonly static Field SUPERVISE_WAY = new Field("SUPERVISE_WAY", "RECORD_REVIEW_SUPERVISE", "督查方式");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "RECORD_REVIEW_SUPERVISE", "创建时间");
		}
		#endregion
	}
}