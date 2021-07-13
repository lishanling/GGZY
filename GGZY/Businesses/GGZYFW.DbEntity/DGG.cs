using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类DGG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("DGG")]
    [Serializable]
    public partial class DGG : FwEntity
    {
        #region Model
		private string _SS;
		private string _ASD;

		/// <summary>
		/// 
		/// </summary>
		public string SS
		{
			get{ return _SS; }
			set
			{
				this.OnPropertyValueChange(_.SS, _SS, value);
				this._SS = value;
			}
		}
		/// <summary>
		/// 发过火
		/// </summary>
		public string ASD
		{
			get{ return _ASD; }
			set
			{
				this.OnPropertyValueChange(_.ASD, _ASD, value);
				this._ASD = value;
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
				_.SS,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.SS,
				_.ASD,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._SS,
				this._ASD,
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
			public readonly static Field All = new Field("*", "DGG");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SS = new Field("SS", "DGG", "");
            /// <summary>
			/// 发过火
			/// </summary>
			public readonly static Field ASD = new Field("ASD", "DGG", "发过火");
        }
        #endregion
	}
}