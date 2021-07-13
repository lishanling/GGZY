using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类AHWH_GZLY。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("AHWH_GZLY")]
    [Serializable]
    public partial class AHWH_GZLY : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private string _CONTENTS;
		private string _EMAIL;
		private string _NAME;
		private DateTime? _TM;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTENTS
		{
			get{ return _CONTENTS; }
			set
			{
				this.OnPropertyValueChange(_.CONTENTS, _CONTENTS, value);
				this._CONTENTS = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMAIL
		{
			get{ return _EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.EMAIL, _EMAIL, value);
				this._EMAIL = value;
			}
		}
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
				_.TITLE,
				_.CONTENTS,
				_.EMAIL,
				_.NAME,
				_.TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TITLE,
				this._CONTENTS,
				this._EMAIL,
				this._NAME,
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
			public readonly static Field All = new Field("*", "AHWH_GZLY");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "AHWH_GZLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "AHWH_GZLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTENTS = new Field("CONTENTS", "AHWH_GZLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EMAIL = new Field("EMAIL", "AHWH_GZLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "AHWH_GZLY", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "AHWH_GZLY", "");
        }
        #endregion
	}
}