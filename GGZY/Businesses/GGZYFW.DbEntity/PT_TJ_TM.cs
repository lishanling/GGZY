using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PT_TJ_TM。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_TJ_TM")]
    [Serializable]
    public partial class PT_TJ_TM : FwEntity
    {
        #region Model
		private DateTime? _TM;
		private decimal? _UPLOAD;

		/// <summary>
		/// 年月
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
		/// <summary>
		/// 开启上传
		/// </summary>
		public decimal? UPLOAD
		{
			get{ return _UPLOAD; }
			set
			{
				this.OnPropertyValueChange(_.UPLOAD, _UPLOAD, value);
				this._UPLOAD = value;
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
				_.TM,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.TM,
				_.UPLOAD,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._TM,
				this._UPLOAD,
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
			public readonly static Field All = new Field("*", "PT_TJ_TM");
            /// <summary>
			/// 年月
			/// </summary>
			public readonly static Field TM = new Field("TM", "PT_TJ_TM", "年月");
            /// <summary>
			/// 开启上传
			/// </summary>
			public readonly static Field UPLOAD = new Field("UPLOAD", "PT_TJ_TM", "开启上传");
        }
        #endregion
	}
}