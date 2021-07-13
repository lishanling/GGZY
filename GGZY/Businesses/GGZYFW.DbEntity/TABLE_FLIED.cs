using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TABLE_FLIED。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TABLE_FLIED")]
    [Serializable]
    public partial class TABLE_FLIED : FwEntity
    {
        #region Model
		private decimal? _CODE;
		private string _EN;
		private string _CHS;

		/// <summary>
		/// 编码
		/// </summary>
		public decimal? CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 英文
		/// </summary>
		public string EN
		{
			get{ return _EN; }
			set
			{
				this.OnPropertyValueChange(_.EN, _EN, value);
				this._EN = value;
			}
		}
		/// <summary>
		/// 中文
		/// </summary>
		public string CHS
		{
			get{ return _CHS; }
			set
			{
				this.OnPropertyValueChange(_.CHS, _CHS, value);
				this._CHS = value;
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
				_.CODE,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.CODE,
				_.EN,
				_.CHS,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._CODE,
				this._EN,
				this._CHS,
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
			public readonly static Field All = new Field("*", "TABLE_FLIED");
            /// <summary>
			/// 编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "TABLE_FLIED", "编码");
            /// <summary>
			/// 英文
			/// </summary>
			public readonly static Field EN = new Field("EN", "TABLE_FLIED", "英文");
            /// <summary>
			/// 中文
			/// </summary>
			public readonly static Field CHS = new Field("CHS", "TABLE_FLIED", "中文");
        }
        #endregion
	}
}