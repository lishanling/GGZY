using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类ASSIST_CORRECT_INFO。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ASSIST_CORRECT_INFO")]
	[Serializable]
	public partial class ASSIST_CORRECT_INFO : FwEntity
	{
		#region Model
		private string _ID;
		private string _TENDER_PROJECT_CODE;
		private string _BID_SECTION_CODE;
		private decimal? _TENDER_PROJECT_MID;
		private decimal? _SECTION_MID;
		private decimal? _FILE_MID;
		private decimal? _WIN_MID;
		private decimal? _OLD_SECTION_AMOUNT;
		private decimal? _OLD_WIN_AMOUNT;
		private string _OLD_EVAL_METHOD;
		private decimal? _NEW_SECTION_AMOUNT;
		private decimal? _NEW_WIN_AMOUNT;
		private string _NEW_EVAL_METHOD;
		private DateTime? _CREATE_TIME;
		private decimal? _IS_RIGHT;
		private decimal? _OLD_CONTROL_AMOUNT;
		private decimal? _NEW_CONTROL_AMOUNT;

		/// <summary>
		/// id
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
		/// 标段编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get { return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目id
		/// </summary>
		public decimal? TENDER_PROJECT_MID
		{
			get { return _TENDER_PROJECT_MID; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_MID, _TENDER_PROJECT_MID, value);
				this._TENDER_PROJECT_MID = value;
			}
		}
		/// <summary>
		/// 标段id
		/// </summary>
		public decimal? SECTION_MID
		{
			get { return _SECTION_MID; }
			set
			{
				this.OnPropertyValueChange(_.SECTION_MID, _SECTION_MID, value);
				this._SECTION_MID = value;
			}
		}
		/// <summary>
		/// 招标文件id
		/// </summary>
		public decimal? FILE_MID
		{
			get { return _FILE_MID; }
			set
			{
				this.OnPropertyValueChange(_.FILE_MID, _FILE_MID, value);
				this._FILE_MID = value;
			}
		}
		/// <summary>
		/// 中标文件id
		/// </summary>
		public decimal? WIN_MID
		{
			get { return _WIN_MID; }
			set
			{
				this.OnPropertyValueChange(_.WIN_MID, _WIN_MID, value);
				this._WIN_MID = value;
			}
		}
		/// <summary>
		/// 旧的合同估算价
		/// </summary>
		public decimal? OLD_SECTION_AMOUNT
		{
			get { return _OLD_SECTION_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.OLD_SECTION_AMOUNT, _OLD_SECTION_AMOUNT, value);
				this._OLD_SECTION_AMOUNT = value;
			}
		}
		/// <summary>
		/// 旧的中标价
		/// </summary>
		public decimal? OLD_WIN_AMOUNT
		{
			get { return _OLD_WIN_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.OLD_WIN_AMOUNT, _OLD_WIN_AMOUNT, value);
				this._OLD_WIN_AMOUNT = value;
			}
		}
		/// <summary>
		/// 旧的评标办法
		/// </summary>
		public string OLD_EVAL_METHOD
		{
			get { return _OLD_EVAL_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.OLD_EVAL_METHOD, _OLD_EVAL_METHOD, value);
				this._OLD_EVAL_METHOD = value;
			}
		}
		/// <summary>
		/// 纠正的标段控制价
		/// </summary>
		public decimal? NEW_SECTION_AMOUNT
		{
			get { return _NEW_SECTION_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.NEW_SECTION_AMOUNT, _NEW_SECTION_AMOUNT, value);
				this._NEW_SECTION_AMOUNT = value;
			}
		}
		/// <summary>
		/// 纠正的中标价
		/// </summary>
		public decimal? NEW_WIN_AMOUNT
		{
			get { return _NEW_WIN_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.NEW_WIN_AMOUNT, _NEW_WIN_AMOUNT, value);
				this._NEW_WIN_AMOUNT = value;
			}
		}
		/// <summary>
		/// 纠正的评标办法
		/// </summary>
		public string NEW_EVAL_METHOD
		{
			get { return _NEW_EVAL_METHOD; }
			set
			{
				this.OnPropertyValueChange(_.NEW_EVAL_METHOD, _NEW_EVAL_METHOD, value);
				this._NEW_EVAL_METHOD = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 是否正确
		/// </summary>
		public decimal? IS_RIGHT
		{
			get { return _IS_RIGHT; }
			set
			{
				this.OnPropertyValueChange(_.IS_RIGHT, _IS_RIGHT, value);
				this._IS_RIGHT = value;
			}
		}
		/// <summary>
		/// 旧招标控制价
		/// </summary>
		public decimal? OLD_CONTROL_AMOUNT
		{
			get { return _OLD_CONTROL_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.OLD_CONTROL_AMOUNT, _OLD_CONTROL_AMOUNT, value);
				this._OLD_CONTROL_AMOUNT = value;
			}
		}
		/// <summary>
		/// 纠正的招标控制价
		/// </summary>
		public decimal? NEW_CONTROL_AMOUNT
		{
			get { return _NEW_CONTROL_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.NEW_CONTROL_AMOUNT, _NEW_CONTROL_AMOUNT, value);
				this._NEW_CONTROL_AMOUNT = value;
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
				_.BID_SECTION_CODE,
				_.TENDER_PROJECT_MID,
				_.SECTION_MID,
				_.FILE_MID,
				_.WIN_MID,
				_.OLD_SECTION_AMOUNT,
				_.OLD_WIN_AMOUNT,
				_.OLD_EVAL_METHOD,
				_.NEW_SECTION_AMOUNT,
				_.NEW_WIN_AMOUNT,
				_.NEW_EVAL_METHOD,
				_.CREATE_TIME,
				_.IS_RIGHT,
				_.OLD_CONTROL_AMOUNT,
				_.NEW_CONTROL_AMOUNT,
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
				this._BID_SECTION_CODE,
				this._TENDER_PROJECT_MID,
				this._SECTION_MID,
				this._FILE_MID,
				this._WIN_MID,
				this._OLD_SECTION_AMOUNT,
				this._OLD_WIN_AMOUNT,
				this._OLD_EVAL_METHOD,
				this._NEW_SECTION_AMOUNT,
				this._NEW_WIN_AMOUNT,
				this._NEW_EVAL_METHOD,
				this._CREATE_TIME,
				this._IS_RIGHT,
				this._OLD_CONTROL_AMOUNT,
				this._NEW_CONTROL_AMOUNT,
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
			public readonly static Field All = new Field("*", "ASSIST_CORRECT_INFO");
			/// <summary>
			/// id
			/// </summary>
			public readonly static Field ID = new Field("ID", "ASSIST_CORRECT_INFO", "id");
			/// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "ASSIST_CORRECT_INFO", "招标项目编号");
			/// <summary>
			/// 标段编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "ASSIST_CORRECT_INFO", "标段编号");
			/// <summary>
			/// 招标项目id
			/// </summary>
			public readonly static Field TENDER_PROJECT_MID = new Field("TENDER_PROJECT_MID", "ASSIST_CORRECT_INFO", "招标项目id");
			/// <summary>
			/// 标段id
			/// </summary>
			public readonly static Field SECTION_MID = new Field("SECTION_MID", "ASSIST_CORRECT_INFO", "标段id");
			/// <summary>
			/// 招标文件id
			/// </summary>
			public readonly static Field FILE_MID = new Field("FILE_MID", "ASSIST_CORRECT_INFO", "招标文件id");
			/// <summary>
			/// 中标文件id
			/// </summary>
			public readonly static Field WIN_MID = new Field("WIN_MID", "ASSIST_CORRECT_INFO", "中标文件id");
			/// <summary>
			/// 旧的合同估算价
			/// </summary>
			public readonly static Field OLD_SECTION_AMOUNT = new Field("OLD_SECTION_AMOUNT", "ASSIST_CORRECT_INFO", "旧的合同估算价");
			/// <summary>
			/// 旧的中标价
			/// </summary>
			public readonly static Field OLD_WIN_AMOUNT = new Field("OLD_WIN_AMOUNT", "ASSIST_CORRECT_INFO", "旧的中标价");
			/// <summary>
			/// 旧的评标办法
			/// </summary>
			public readonly static Field OLD_EVAL_METHOD = new Field("OLD_EVAL_METHOD", "ASSIST_CORRECT_INFO", "旧的评标办法");
			/// <summary>
			/// 纠正的标段控制价
			/// </summary>
			public readonly static Field NEW_SECTION_AMOUNT = new Field("NEW_SECTION_AMOUNT", "ASSIST_CORRECT_INFO", "纠正的标段控制价");
			/// <summary>
			/// 纠正的中标价
			/// </summary>
			public readonly static Field NEW_WIN_AMOUNT = new Field("NEW_WIN_AMOUNT", "ASSIST_CORRECT_INFO", "纠正的中标价");
			/// <summary>
			/// 纠正的评标办法
			/// </summary>
			public readonly static Field NEW_EVAL_METHOD = new Field("NEW_EVAL_METHOD", "ASSIST_CORRECT_INFO", "纠正的评标办法");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "ASSIST_CORRECT_INFO", "创建时间");
			/// <summary>
			/// 是否正确
			/// </summary>
			public readonly static Field IS_RIGHT = new Field("IS_RIGHT", "ASSIST_CORRECT_INFO", "是否正确");
			/// <summary>
			/// 旧招标控制价
			/// </summary>
			public readonly static Field OLD_CONTROL_AMOUNT = new Field("OLD_CONTROL_AMOUNT", "ASSIST_CORRECT_INFO", "旧招标控制价");
			/// <summary>
			/// 纠正的招标控制价
			/// </summary>
			public readonly static Field NEW_CONTROL_AMOUNT = new Field("NEW_CONTROL_AMOUNT", "ASSIST_CORRECT_INFO", "纠正的招标控制价");
		}
		#endregion
	}
}