using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类M_CLOBTEST。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("M_CLOBTEST")]
    [Serializable]
    public partial class M_CLOBTEST : FwEntity
    {
        #region Model
		private string _NAME;
		private string _ATTACHMENT;

		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			get{ return _NAME; }
			set
			{
				this.OnPropertyValueChange(_.NAME, _NAME, value);
				this._NAME = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATTACHMENT
		{
			get{ return _ATTACHMENT; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT, _ATTACHMENT, value);
				this._ATTACHMENT = value;
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
				_.NAME,
				_.ATTACHMENT,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._NAME,
				this._ATTACHMENT,
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
			public readonly static Field All = new Field("*", "M_CLOBTEST");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "M_CLOBTEST", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ATTACHMENT = new Field("ATTACHMENT", "M_CLOBTEST", "");
        }
        #endregion
	}
}