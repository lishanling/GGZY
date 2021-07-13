using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类SLT_SCORE_BAK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("SLT_SCORE_BAK")]
    [Serializable]
    public partial class SLT_SCORE_BAK : FwEntity
    {
        #region Model
		private string _NAME;
		private string _CODE;
		private decimal? _SCORE;
		private string _DATATIMESTAMP;
		private string _SYNCDATA;
		private string _SYNCTIME;
		private decimal? _IS_DELETE;

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
		public string CODE
		{
			get{ return _CODE; }
			set
			{
				this.OnPropertyValueChange(_.CODE, _CODE, value);
				this._CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SCORE
		{
			get{ return _SCORE; }
			set
			{
				this.OnPropertyValueChange(_.SCORE, _SCORE, value);
				this._SCORE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DATATIMESTAMP
		{
			get{ return _DATATIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATATIMESTAMP, _DATATIMESTAMP, value);
				this._DATATIMESTAMP = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYNCDATA
		{
			get{ return _SYNCDATA; }
			set
			{
				this.OnPropertyValueChange(_.SYNCDATA, _SYNCDATA, value);
				this._SYNCDATA = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYNCTIME
		{
			get{ return _SYNCTIME; }
			set
			{
				this.OnPropertyValueChange(_.SYNCTIME, _SYNCTIME, value);
				this._SYNCTIME = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get{ return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
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
				_.CODE,
				_.SCORE,
				_.DATATIMESTAMP,
				_.SYNCDATA,
				_.SYNCTIME,
				_.IS_DELETE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._NAME,
				this._CODE,
				this._SCORE,
				this._DATATIMESTAMP,
				this._SYNCDATA,
				this._SYNCTIME,
				this._IS_DELETE,
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
			public readonly static Field All = new Field("*", "SLT_SCORE_BAK");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "SLT_SCORE_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "SLT_SCORE_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCORE = new Field("SCORE", "SLT_SCORE_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DATATIMESTAMP = new Field("DATATIMESTAMP", "SLT_SCORE_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYNCDATA = new Field("SYNCDATA", "SLT_SCORE_BAK", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "SLT_SCORE_BAK", "");
            /// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "SLT_SCORE_BAK", "是否删除");
        }
        #endregion
	}
}