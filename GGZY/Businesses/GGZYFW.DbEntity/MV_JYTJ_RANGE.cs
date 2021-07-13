using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类MV_JYTJ_RANGE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("MV_JYTJ_RANGE")]
    [Serializable]
    public partial class MV_JYTJ_RANGE : FwEntity
    {
        #region Model
		private decimal? _ZBGG;
		private string _AREACODE;
		private DateTime? _TM;

		/// <summary>
		/// 
		/// </summary>
		public decimal? ZBGG
		{
			get{ return _ZBGG; }
			set
			{
				this.OnPropertyValueChange(_.ZBGG, _ZBGG, value);
				this._ZBGG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREACODE
		{
			get{ return _AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.AREACODE, _AREACODE, value);
				this._AREACODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM
		{
			get{ return _TM; }
			set
			{
				this.OnPropertyValueChange(_.TM, _TM, value);
				this._TM = value;
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
				_.ZBGG,
				_.AREACODE,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ZBGG,
				this._AREACODE,
				this._TM,
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
			public readonly static Field All = new Field("*", "MV_JYTJ_RANGE");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBGG = new Field("ZBGG", "MV_JYTJ_RANGE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AREACODE = new Field("AREACODE", "MV_JYTJ_RANGE", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "MV_JYTJ_RANGE", "");
        }
        #endregion
	}
}