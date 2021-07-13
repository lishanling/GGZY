using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_SEQ。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_SEQ")]
    [Serializable]
    public partial class T_SEQ : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _TYPE;
		private DateTime? _TM;
		private decimal? _SEQ_NUM;
		private string _REMARK;

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
		/// 序列名称
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
		/// 序列类型
		/// </summary>
		public string TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 时间
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
		/// 序列数值
		/// </summary>
		public decimal? SEQ_NUM
		{
			get{ return _SEQ_NUM; }
			set
			{
				this.OnPropertyValueChange(_.SEQ_NUM, _SEQ_NUM, value);
				this._SEQ_NUM = value;
			}
		}
		/// <summary>
		/// 说明
		/// </summary>
		public string REMARK
		{
			get{ return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
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
				_.NAME,
				_.TYPE,
				_.TM,
				_.SEQ_NUM,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._NAME,
				this._TYPE,
				this._TM,
				this._SEQ_NUM,
				this._REMARK,
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
			public readonly static Field All = new Field("*", "T_SEQ");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_SEQ", "ID");
            /// <summary>
			/// 序列名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_SEQ", "序列名称");
            /// <summary>
			/// 序列类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "T_SEQ", "序列类型");
            /// <summary>
			/// 时间
			/// </summary>
			public readonly static Field TM = new Field("TM", "T_SEQ", "时间");
            /// <summary>
			/// 序列数值
			/// </summary>
			public readonly static Field SEQ_NUM = new Field("SEQ_NUM", "T_SEQ", "序列数值");
            /// <summary>
			/// 说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_SEQ", "说明");
        }
        #endregion
	}
}