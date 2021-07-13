using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_TENDER_LIST_COUNT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_TENDER_LIST_COUNT")]
    [Serializable]
    public partial class MV_TENDER_LIST_COUNT : FwEntity
    {
        #region Model
		private string _LEGAL_NAME;
		private decimal? _COUNT;
		private DateTime? _M_TM;

		/// <summary>
		/// 
		/// </summary>
		public string LEGAL_NAME
		{
			get{ return _LEGAL_NAME; }
			set
			{
				this.OnPropertyValueChange(_.LEGAL_NAME, _LEGAL_NAME, value);
				this._LEGAL_NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COUNT
		{
			get{ return _COUNT; }
			set
			{
				this.OnPropertyValueChange(_.COUNT, _COUNT, value);
				this._COUNT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM
		{
			get{ return _M_TM; }
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
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.LEGAL_NAME,
				_.COUNT,
				_.M_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._LEGAL_NAME,
				this._COUNT,
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
			public readonly static Field All = new Field("*", "MV_TENDER_LIST_COUNT");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LEGAL_NAME = new Field("LEGAL_NAME", "MV_TENDER_LIST_COUNT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COUNT = new Field("COUNT", "MV_TENDER_LIST_COUNT", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field M_TM = new Field("M_TM", "MV_TENDER_LIST_COUNT", "");
        }
        #endregion
	}
}