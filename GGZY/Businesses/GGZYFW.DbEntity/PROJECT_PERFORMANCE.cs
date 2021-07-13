using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PROJECT_PERFORMANCE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PROJECT_PERFORMANCE")]
    [Serializable]
    public partial class PROJECT_PERFORMANCE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _IDENTIFICATION_NUM;
		private string _UNIT_NAME;
		private string _ENTRY_NAME;
		private DateTime? _OCCURRENCE_TIME;
		private string _BID_AMOUNT;
		private string _PROJECT_COMPLETION;
		private string _LETTER_ACCEPTANCE;
		private string _APPENDICES_CONTRACT;
		private string _ITEM_REPORT;

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
		/// 标识号
		/// </summary>
		public string IDENTIFICATION_NUM
		{
			get{ return _IDENTIFICATION_NUM; }
			set
			{
				this.OnPropertyValueChange(_.IDENTIFICATION_NUM, _IDENTIFICATION_NUM, value);
				this._IDENTIFICATION_NUM = value;
			}
		}
		/// <summary>
		/// 单位名称
		/// </summary>
		public string UNIT_NAME
		{
			get{ return _UNIT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.UNIT_NAME, _UNIT_NAME, value);
				this._UNIT_NAME = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string ENTRY_NAME
		{
			get{ return _ENTRY_NAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTRY_NAME, _ENTRY_NAME, value);
				this._ENTRY_NAME = value;
			}
		}
		/// <summary>
		/// 发生时间
		/// </summary>
		public DateTime? OCCURRENCE_TIME
		{
			get{ return _OCCURRENCE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OCCURRENCE_TIME, _OCCURRENCE_TIME, value);
				this._OCCURRENCE_TIME = value;
			}
		}
		/// <summary>
		/// 中标金额
		/// </summary>
		public string BID_AMOUNT
		{
			get{ return _BID_AMOUNT; }
			set
			{
				this.OnPropertyValueChange(_.BID_AMOUNT, _BID_AMOUNT, value);
				this._BID_AMOUNT = value;
			}
		}
		/// <summary>
		/// 项目完成情况
		/// </summary>
		public string PROJECT_COMPLETION
		{
			get{ return _PROJECT_COMPLETION; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_COMPLETION, _PROJECT_COMPLETION, value);
				this._PROJECT_COMPLETION = value;
			}
		}
		/// <summary>
		/// 中标通知书附件
		/// </summary>
		public string LETTER_ACCEPTANCE
		{
			get{ return _LETTER_ACCEPTANCE; }
			set
			{
				this.OnPropertyValueChange(_.LETTER_ACCEPTANCE, _LETTER_ACCEPTANCE, value);
				this._LETTER_ACCEPTANCE = value;
			}
		}
		/// <summary>
		/// 合同附件
		/// </summary>
		public string APPENDICES_CONTRACT
		{
			get{ return _APPENDICES_CONTRACT; }
			set
			{
				this.OnPropertyValueChange(_.APPENDICES_CONTRACT, _APPENDICES_CONTRACT, value);
				this._APPENDICES_CONTRACT = value;
			}
		}
		/// <summary>
		/// 项目结项报告附件
		/// </summary>
		public string ITEM_REPORT
		{
			get{ return _ITEM_REPORT; }
			set
			{
				this.OnPropertyValueChange(_.ITEM_REPORT, _ITEM_REPORT, value);
				this._ITEM_REPORT = value;
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
				_.IDENTIFICATION_NUM,
				_.UNIT_NAME,
				_.ENTRY_NAME,
				_.OCCURRENCE_TIME,
				_.BID_AMOUNT,
				_.PROJECT_COMPLETION,
				_.LETTER_ACCEPTANCE,
				_.APPENDICES_CONTRACT,
				_.ITEM_REPORT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._IDENTIFICATION_NUM,
				this._UNIT_NAME,
				this._ENTRY_NAME,
				this._OCCURRENCE_TIME,
				this._BID_AMOUNT,
				this._PROJECT_COMPLETION,
				this._LETTER_ACCEPTANCE,
				this._APPENDICES_CONTRACT,
				this._ITEM_REPORT,
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
			public readonly static Field All = new Field("*", "PROJECT_PERFORMANCE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PROJECT_PERFORMANCE", "ID");
            /// <summary>
			/// 标识号
			/// </summary>
			public readonly static Field IDENTIFICATION_NUM = new Field("IDENTIFICATION_NUM", "PROJECT_PERFORMANCE", "标识号");
            /// <summary>
			/// 单位名称
			/// </summary>
			public readonly static Field UNIT_NAME = new Field("UNIT_NAME", "PROJECT_PERFORMANCE", "单位名称");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field ENTRY_NAME = new Field("ENTRY_NAME", "PROJECT_PERFORMANCE", "项目名称");
            /// <summary>
			/// 发生时间
			/// </summary>
			public readonly static Field OCCURRENCE_TIME = new Field("OCCURRENCE_TIME", "PROJECT_PERFORMANCE", "发生时间");
            /// <summary>
			/// 中标金额
			/// </summary>
			public readonly static Field BID_AMOUNT = new Field("BID_AMOUNT", "PROJECT_PERFORMANCE", "中标金额");
            /// <summary>
			/// 项目完成情况
			/// </summary>
			public readonly static Field PROJECT_COMPLETION = new Field("PROJECT_COMPLETION", "PROJECT_PERFORMANCE", "项目完成情况");
            /// <summary>
			/// 中标通知书附件
			/// </summary>
			public readonly static Field LETTER_ACCEPTANCE = new Field("LETTER_ACCEPTANCE", "PROJECT_PERFORMANCE", "中标通知书附件");
            /// <summary>
			/// 合同附件
			/// </summary>
			public readonly static Field APPENDICES_CONTRACT = new Field("APPENDICES_CONTRACT", "PROJECT_PERFORMANCE", "合同附件");
            /// <summary>
			/// 项目结项报告附件
			/// </summary>
			public readonly static Field ITEM_REPORT = new Field("ITEM_REPORT", "PROJECT_PERFORMANCE", "项目结项报告附件");
        }
        #endregion
	}
}