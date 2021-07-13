using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类TENDER_PROJECT_GD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TENDER_PROJECT_GD")]
    [Serializable]
    public partial class TENDER_PROJECT_GD : FwEntity
    {
        #region Model
		private string _CODE;

		/// <summary>
		/// 
		/// </summary>
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
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
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._CODE,
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
			public readonly static Field All = new Field("*", "TENDER_PROJECT_GD");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "TENDER_PROJECT_GD", "");
        }
        #endregion
	}
}