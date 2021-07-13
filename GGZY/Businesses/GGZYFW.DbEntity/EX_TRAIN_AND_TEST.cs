using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类EX_TRAIN_AND_TEST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("EX_TRAIN_AND_TEST")]
    [Serializable]
    public partial class EX_TRAIN_AND_TEST : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _EX_CODE;
		private string _EX_NAME;
		private string _TAT_OBJECT;
		private string _TAT_CONTENT;
		private DateTime? _TAT_DATE;
		private string _TAT_ADDRESS;
		private string _TAT_SIGN_UP;
		private string _TAT_COST;
		private string _OTHER_MATTER;
		private string _ID_CARD;

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
		/// 专家编号
		/// </summary>
		public string EX_CODE
		{
			get{ return _EX_CODE; }
			set
			{
				this.OnPropertyValueChange(_.EX_CODE, _EX_CODE, value);
				this._EX_CODE = value;
			}
		}
		/// <summary>
		/// 专家姓名
		/// </summary>
		public string EX_NAME
		{
			get{ return _EX_NAME; }
			set
			{
				this.OnPropertyValueChange(_.EX_NAME, _EX_NAME, value);
				this._EX_NAME = value;
			}
		}
		/// <summary>
		/// 培训考核对象
		/// </summary>
		public string TAT_OBJECT
		{
			get{ return _TAT_OBJECT; }
			set
			{
				this.OnPropertyValueChange(_.TAT_OBJECT, _TAT_OBJECT, value);
				this._TAT_OBJECT = value;
			}
		}
		/// <summary>
		/// 培训考核内容
		/// </summary>
		public string TAT_CONTENT
		{
			get{ return _TAT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TAT_CONTENT, _TAT_CONTENT, value);
				this._TAT_CONTENT = value;
			}
		}
		/// <summary>
		/// 培训考核时间
		/// </summary>
		public DateTime? TAT_DATE
		{
			get{ return _TAT_DATE; }
			set
			{
				this.OnPropertyValueChange(_.TAT_DATE, _TAT_DATE, value);
				this._TAT_DATE = value;
			}
		}
		/// <summary>
		/// 培训考核地点
		/// </summary>
		public string TAT_ADDRESS
		{
			get{ return _TAT_ADDRESS; }
			set
			{
				this.OnPropertyValueChange(_.TAT_ADDRESS, _TAT_ADDRESS, value);
				this._TAT_ADDRESS = value;
			}
		}
		/// <summary>
		/// 培训考核报名
		/// </summary>
		public string TAT_SIGN_UP
		{
			get{ return _TAT_SIGN_UP; }
			set
			{
				this.OnPropertyValueChange(_.TAT_SIGN_UP, _TAT_SIGN_UP, value);
				this._TAT_SIGN_UP = value;
			}
		}
		/// <summary>
		/// 培训考核费用说明
		/// </summary>
		public string TAT_COST
		{
			get{ return _TAT_COST; }
			set
			{
				this.OnPropertyValueChange(_.TAT_COST, _TAT_COST, value);
				this._TAT_COST = value;
			}
		}
		/// <summary>
		/// 其他事项
		/// </summary>
		public string OTHER_MATTER
		{
			get{ return _OTHER_MATTER; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_MATTER, _OTHER_MATTER, value);
				this._OTHER_MATTER = value;
			}
		}
		/// <summary>
		/// 专家身份证件号码
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
				_.EX_CODE,
				_.EX_NAME,
				_.TAT_OBJECT,
				_.TAT_CONTENT,
				_.TAT_DATE,
				_.TAT_ADDRESS,
				_.TAT_SIGN_UP,
				_.TAT_COST,
				_.OTHER_MATTER,
				_.ID_CARD,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._EX_CODE,
				this._EX_NAME,
				this._TAT_OBJECT,
				this._TAT_CONTENT,
				this._TAT_DATE,
				this._TAT_ADDRESS,
				this._TAT_SIGN_UP,
				this._TAT_COST,
				this._OTHER_MATTER,
				this._ID_CARD,
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
			public readonly static Field All = new Field("*", "EX_TRAIN_AND_TEST");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "EX_TRAIN_AND_TEST", "ID");
            /// <summary>
			/// 专家编号
			/// </summary>
			public readonly static Field EX_CODE = new Field("EX_CODE", "EX_TRAIN_AND_TEST", "专家编号");
            /// <summary>
			/// 专家姓名
			/// </summary>
			public readonly static Field EX_NAME = new Field("EX_NAME", "EX_TRAIN_AND_TEST", "专家姓名");
            /// <summary>
			/// 培训考核对象
			/// </summary>
			public readonly static Field TAT_OBJECT = new Field("TAT_OBJECT", "EX_TRAIN_AND_TEST", "培训考核对象");
            /// <summary>
			/// 培训考核内容
			/// </summary>
			public readonly static Field TAT_CONTENT = new Field("TAT_CONTENT", "EX_TRAIN_AND_TEST", "培训考核内容");
            /// <summary>
			/// 培训考核时间
			/// </summary>
			public readonly static Field TAT_DATE = new Field("TAT_DATE", "EX_TRAIN_AND_TEST", "培训考核时间");
            /// <summary>
			/// 培训考核地点
			/// </summary>
			public readonly static Field TAT_ADDRESS = new Field("TAT_ADDRESS", "EX_TRAIN_AND_TEST", "培训考核地点");
            /// <summary>
			/// 培训考核报名
			/// </summary>
			public readonly static Field TAT_SIGN_UP = new Field("TAT_SIGN_UP", "EX_TRAIN_AND_TEST", "培训考核报名");
            /// <summary>
			/// 培训考核费用说明
			/// </summary>
			public readonly static Field TAT_COST = new Field("TAT_COST", "EX_TRAIN_AND_TEST", "培训考核费用说明");
            /// <summary>
			/// 其他事项
			/// </summary>
			public readonly static Field OTHER_MATTER = new Field("OTHER_MATTER", "EX_TRAIN_AND_TEST", "其他事项");
            /// <summary>
			/// 专家身份证件号码
			/// </summary>
			public readonly static Field ID_CARD = new Field("ID_CARD", "EX_TRAIN_AND_TEST", "专家身份证件号码");
        }
        #endregion
	}
}