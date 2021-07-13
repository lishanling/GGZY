using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类AHWH_BSZX。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("AHWH_BSZX")]
    [Serializable]
    public partial class AHWH_BSZX : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _TITLE;
		private DateTime? _TM;
		private string _ISPUBLIC;
		private string _CONTENTS;
		private string _NAME;
		private string _REPLY;
		private string _SOURCES;

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
		/// 
		/// </summary>
		public string ISPUBLIC
		{
			get{ return _ISPUBLIC; }
			set
			{
				this.OnPropertyValueChange(_.ISPUBLIC, _ISPUBLIC, value);
				this._ISPUBLIC = value;
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
		public string REPLY
		{
			get{ return _REPLY; }
			set
			{
				this.OnPropertyValueChange(_.REPLY, _REPLY, value);
				this._REPLY = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SOURCES
		{
			get{ return _SOURCES; }
			set
			{
				this.OnPropertyValueChange(_.SOURCES, _SOURCES, value);
				this._SOURCES = value;
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
				_.TM,
				_.ISPUBLIC,
				_.CONTENTS,
				_.NAME,
				_.REPLY,
				_.SOURCES,
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
				this._TM,
				this._ISPUBLIC,
				this._CONTENTS,
				this._NAME,
				this._REPLY,
				this._SOURCES,
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
			public readonly static Field All = new Field("*", "AHWH_BSZX");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "AHWH_BSZX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "AHWH_BSZX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "AHWH_BSZX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISPUBLIC = new Field("ISPUBLIC", "AHWH_BSZX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTENTS = new Field("CONTENTS", "AHWH_BSZX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "AHWH_BSZX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REPLY = new Field("REPLY", "AHWH_BSZX", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SOURCES = new Field("SOURCES", "AHWH_BSZX", "");
        }
        #endregion
	}
}