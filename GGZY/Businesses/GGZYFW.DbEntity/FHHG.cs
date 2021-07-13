using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类FHHG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("FHHG")]
    [Serializable]
    public partial class FHHG : FwEntity
    {
        #region Model
		private string _DD;
		private string _KKJ;

		/// <summary>
		/// DD
		/// </summary>
		public string DD
		{
			get{ return _DD; }
			set
			{
				this.OnPropertyValueChange(_.DD, _DD, value);
				this._DD = value;
			}
		}
		/// <summary>
		/// 看看
		/// </summary>
		public string KKJ
		{
			get{ return _KKJ; }
			set
			{
				this.OnPropertyValueChange(_.KKJ, _KKJ, value);
				this._KKJ = value;
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
				_.DD,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.DD,
				_.KKJ,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._DD,
				this._KKJ,
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
			public readonly static Field All = new Field("*", "FHHG");
            /// <summary>
			/// DD
			/// </summary>
			public readonly static Field DD = new Field("DD", "FHHG", "DD");
            /// <summary>
			/// 看看
			/// </summary>
			public readonly static Field KKJ = new Field("KKJ", "FHHG", "看看");
        }
        #endregion
	}
}