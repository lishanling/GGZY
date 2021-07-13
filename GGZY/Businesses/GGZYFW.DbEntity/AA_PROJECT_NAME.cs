using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类AA_PROJECT_NAME。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("AA_PROJECT_NAME")]
    [Serializable]
    public partial class AA_PROJECT_NAME : FwEntity
    {
        #region Model
		private string _PROJECT_NAME;

		/// <summary>
		/// 
		/// </summary>
		public string PROJECT_NAME
		{
			get{ return _PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_NAME, _PROJECT_NAME, value);
				this._PROJECT_NAME = value;
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
				_.PROJECT_NAME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._PROJECT_NAME,
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
			public readonly static Field All = new Field("*", "AA_PROJECT_NAME");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_NAME = new Field("PROJECT_NAME", "AA_PROJECT_NAME", "");
        }
        #endregion
	}
}