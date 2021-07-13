using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类BASC_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BASC_RESULT")]
    [Serializable]
    public partial class BASC_RESULT : JdEntity
    {
        #region Model
		private decimal? _ID;
		private decimal? _REVIEW_ID;
		private string _IS_SUCCESS;
		private string _M_DATA_SOURCE;

		/// <summary>
		/// ID
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
		/// 推回表（T_RECORD_REVIEW）的ID
		/// </summary>
		public decimal? REVIEW_ID
		{
			get{ return _REVIEW_ID; }
			set
			{
				this.OnPropertyValueChange(_.REVIEW_ID, _REVIEW_ID, value);
				this._REVIEW_ID = value;
			}
		}
		/// <summary>
		/// 推送回交易平台是否成功
		/// </summary>
		public string IS_SUCCESS
		{
			get{ return _IS_SUCCESS; }
			set
			{
				this.OnPropertyValueChange(_.IS_SUCCESS, _IS_SUCCESS, value);
				this._IS_SUCCESS = value;
			}
		}
		/// <summary>
		/// 推送给某个用户的用户编码
		/// </summary>
		public string M_DATA_SOURCE
		{
			get{ return _M_DATA_SOURCE; }
			set
			{
				this.OnPropertyValueChange(_.M_DATA_SOURCE, _M_DATA_SOURCE, value);
				this._M_DATA_SOURCE = value;
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
				_.REVIEW_ID,
				_.IS_SUCCESS,
				_.M_DATA_SOURCE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._REVIEW_ID,
				this._IS_SUCCESS,
				this._M_DATA_SOURCE,
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
			public readonly static Field All = new Field("*", "BASC_RESULT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "BASC_RESULT", "ID");
            /// <summary>
			/// 推回表（T_RECORD_REVIEW）的ID
			/// </summary>
			public readonly static Field REVIEW_ID = new Field("REVIEW_ID", "BASC_RESULT", "推回表（T_RECORD_REVIEW）的ID");
            /// <summary>
			/// 推送回交易平台是否成功
			/// </summary>
			public readonly static Field IS_SUCCESS = new Field("IS_SUCCESS", "BASC_RESULT", "推送回交易平台是否成功");
            /// <summary>
			/// 推送给某个用户的用户编码
			/// </summary>
			public readonly static Field M_DATA_SOURCE = new Field("M_DATA_SOURCE", "BASC_RESULT", "推送给某个用户的用户编码");
        }
        #endregion
	}
}