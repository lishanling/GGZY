using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类THE_EEL_SET_AND_AUTH。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("THE_EEL_SET_AND_AUTH")]
    [Serializable]
    public partial class THE_EEL_SET_AND_AUTH : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _BID_PRO;
		private string _EMV_CR;
		private string _EBF_CR;
		private string _EMV_EXPERT;
		private string _EBF_EXPERT;
		private string _REMARK;
		private string _TENDER_PROJECT_CODE;
		private string _OPEN_TIME;
		private string _ZHC_EXPERTS;
		private string _FHC_EXPERTS;
		private string _LEAD_EXPERT;

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
		/// 评标主会场会议室
		/// </summary>
		public string EMV_CR
		{
			get{ return _EMV_CR; }
			set
			{
				this.OnPropertyValueChange(_.EMV_CR, _EMV_CR, value);
				this._EMV_CR = value;
			}
		}
		/// <summary>
		/// 评标分会场会议室
		/// </summary>
		public string EBF_CR
		{
			get{ return _EBF_CR; }
			set
			{
				this.OnPropertyValueChange(_.EBF_CR, _EBF_CR, value);
				this._EBF_CR = value;
			}
		}
		/// <summary>
		/// 评标主会场专家
		/// </summary>
		public string EMV_EXPERT
		{
			get{ return _EMV_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.EMV_EXPERT, _EMV_EXPERT, value);
				this._EMV_EXPERT = value;
			}
		}
		/// <summary>
		/// 评标分会场专家
		/// </summary>
		public string EBF_EXPERT
		{
			get{ return _EBF_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.EBF_EXPERT, _EBF_EXPERT, value);
				this._EBF_EXPERT = value;
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
		/// 
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
		/// <summary>
		/// 
		/// </summary>
		public string OPEN_TIME
		{
			get{ return _OPEN_TIME; }
			set
			{
				this.OnPropertyValueChange(_.OPEN_TIME, _OPEN_TIME, value);
				this._OPEN_TIME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZHC_EXPERTS
		{
			get{ return _ZHC_EXPERTS; }
			set
			{
				this.OnPropertyValueChange(_.ZHC_EXPERTS, _ZHC_EXPERTS, value);
				this._ZHC_EXPERTS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FHC_EXPERTS
		{
			get{ return _FHC_EXPERTS; }
			set
			{
				this.OnPropertyValueChange(_.FHC_EXPERTS, _FHC_EXPERTS, value);
				this._FHC_EXPERTS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LEAD_EXPERT
		{
			get{ return _LEAD_EXPERT; }
			set
			{
				this.OnPropertyValueChange(_.LEAD_EXPERT, _LEAD_EXPERT, value);
				this._LEAD_EXPERT = value;
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
				_.EMV_CR,
				_.EBF_CR,
				_.EMV_EXPERT,
				_.EBF_EXPERT,
				_.REMARK,
				_.TENDER_PROJECT_CODE,
				_.OPEN_TIME,
				_.ZHC_EXPERTS,
				_.FHC_EXPERTS,
				_.LEAD_EXPERT,
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
				this._EMV_CR,
				this._EBF_CR,
				this._EMV_EXPERT,
				this._EBF_EXPERT,
				this._REMARK,
				this._TENDER_PROJECT_CODE,
				this._OPEN_TIME,
				this._ZHC_EXPERTS,
				this._FHC_EXPERTS,
				this._LEAD_EXPERT,
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
			public readonly static Field All = new Field("*", "THE_EEL_SET_AND_AUTH");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "THE_EEL_SET_AND_AUTH", "ID");
            /// <summary>
			/// 评标项目
			/// </summary>
			public readonly static Field BID_PRO = new Field("BID_PRO", "THE_EEL_SET_AND_AUTH", "评标项目");
            /// <summary>
			/// 评标主会场会议室
			/// </summary>
			public readonly static Field EMV_CR = new Field("EMV_CR", "THE_EEL_SET_AND_AUTH", "评标主会场会议室");
            /// <summary>
			/// 评标分会场会议室
			/// </summary>
			public readonly static Field EBF_CR = new Field("EBF_CR", "THE_EEL_SET_AND_AUTH", "评标分会场会议室");
            /// <summary>
			/// 评标主会场专家
			/// </summary>
			public readonly static Field EMV_EXPERT = new Field("EMV_EXPERT", "THE_EEL_SET_AND_AUTH", "评标主会场专家");
            /// <summary>
			/// 评标分会场专家
			/// </summary>
			public readonly static Field EBF_EXPERT = new Field("EBF_EXPERT", "THE_EEL_SET_AND_AUTH", "评标分会场专家");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "THE_EEL_SET_AND_AUTH", "备注");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "THE_EEL_SET_AND_AUTH", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPEN_TIME = new Field("OPEN_TIME", "THE_EEL_SET_AND_AUTH", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZHC_EXPERTS = new Field("ZHC_EXPERTS", "THE_EEL_SET_AND_AUTH", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FHC_EXPERTS = new Field("FHC_EXPERTS", "THE_EEL_SET_AND_AUTH", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEAD_EXPERT = new Field("LEAD_EXPERT", "THE_EEL_SET_AND_AUTH", "");
        }
        #endregion
	}
}