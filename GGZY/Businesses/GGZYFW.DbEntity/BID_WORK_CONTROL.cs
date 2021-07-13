using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BID_WORK_CONTROL。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BID_WORK_CONTROL")]
    [Serializable]
    public partial class BID_WORK_CONTROL : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BID_PRO;
		private string _BID_CR;
		private DateTime? _BID_TIME;
		private string _EXPERT;
		private string _EXPERT_COST;
		private string _PM;
		private string _REMARK;

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
		/// 评标项目
		/// </summary>
		public string BID_PRO
		{
			get{ return _BID_PRO; }
			set
			{
				this.OnPropertyValueChange(_.BID_PRO, _BID_PRO, value);
				this._BID_PRO = value;
			}
		}
		/// <summary>
		/// 评标会场
		/// </summary>
		public string BID_CR
		{
			get{ return _BID_CR; }
			set
			{
				this.OnPropertyValueChange(_.BID_CR, _BID_CR, value);
				this._BID_CR = value;
			}
		}
		/// <summary>
		/// 评标时间
		/// </summary>
		public DateTime? BID_TIME
		{
			get{ return _BID_TIME; }
			set
			{
				this.OnPropertyValueChange(_.BID_TIME, _BID_TIME, value);
				this._BID_TIME = value;
			}
		}
		/// <summary>
		/// 专家
		/// </summary>
		public string EXPERT
		{
			get{ return _EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT, _EXPERT, value);
				this._EXPERT = value;
			}
		}
		/// <summary>
		/// 专家费用
		/// </summary>
		public string EXPERT_COST
		{
			get{ return _EXPERT_COST; }
			set
			{
				this.OnPropertyValueChange(_.EXPERT_COST, _EXPERT_COST, value);
				this._EXPERT_COST = value;
			}
		}
		/// <summary>
		/// 支付方式
		/// </summary>
		public string PM
		{
			get{ return _PM; }
			set
			{
				this.OnPropertyValueChange(_.PM, _PM, value);
				this._PM = value;
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
				_.BID_PRO,
				_.BID_CR,
				_.BID_TIME,
				_.EXPERT,
				_.EXPERT_COST,
				_.PM,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BID_PRO,
				this._BID_CR,
				this._BID_TIME,
				this._EXPERT,
				this._EXPERT_COST,
				this._PM,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "BID_WORK_CONTROL");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BID_WORK_CONTROL", "ID");
            /// <summary>
			/// 评标项目
			/// </summary>
			public readonly static Field BID_PRO = new Field("BID_PRO", "BID_WORK_CONTROL", "评标项目");
            /// <summary>
			/// 评标会场
			/// </summary>
			public readonly static Field BID_CR = new Field("BID_CR", "BID_WORK_CONTROL", "评标会场");
            /// <summary>
			/// 评标时间
			/// </summary>
			public readonly static Field BID_TIME = new Field("BID_TIME", "BID_WORK_CONTROL", "评标时间");
            /// <summary>
			/// 专家
			/// </summary>
			public readonly static Field EXPERT = new Field("EXPERT", "BID_WORK_CONTROL", "专家");
            /// <summary>
			/// 专家费用
			/// </summary>
			public readonly static Field EXPERT_COST = new Field("EXPERT_COST", "BID_WORK_CONTROL", "专家费用");
            /// <summary>
			/// 支付方式
			/// </summary>
			public readonly static Field PM = new Field("PM", "BID_WORK_CONTROL", "支付方式");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "BID_WORK_CONTROL", "备注");
        }
        #endregion
	}
}