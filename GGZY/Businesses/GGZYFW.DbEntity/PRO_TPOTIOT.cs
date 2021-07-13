using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRO_TPOTIOT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRO_TPOTIOT")]
    [Serializable]
    public partial class PRO_TPOTIOT : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _PRO_CODE;
		private string _PRO_NAME;
		private string _PRO_TPIC;
		private string _MONEY;
		private string _PRO_SITUATION;
		private string _PRO_DOCPT;
		private string _CRT_PROGRESS;
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
		/// 项目编号
		/// </summary>
		public string PRO_CODE
		{
			get{ return _PRO_CODE; }
			set
			{
				this.OnPropertyValueChange(_.PRO_CODE, _PRO_CODE, value);
				this._PRO_CODE = value;
			}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string PRO_NAME
		{
			get{ return _PRO_NAME; }
			set
			{
				this.OnPropertyValueChange(_.PRO_NAME, _PRO_NAME, value);
				this._PRO_NAME = value;
			}
		}
		/// <summary>
		/// 项目负责人
		/// </summary>
		public string PRO_TPIC
		{
			get{ return _PRO_TPIC; }
			set
			{
				this.OnPropertyValueChange(_.PRO_TPIC, _PRO_TPIC, value);
				this._PRO_TPIC = value;
			}
		}
		/// <summary>
		/// 金额(万元)
		/// </summary>
		public string MONEY
		{
			get{ return _MONEY; }
			set
			{
				this.OnPropertyValueChange(_.MONEY, _MONEY, value);
				this._MONEY = value;
			}
		}
		/// <summary>
		/// 项目情况
		/// </summary>
		public string PRO_SITUATION
		{
			get{ return _PRO_SITUATION; }
			set
			{
				this.OnPropertyValueChange(_.PRO_SITUATION, _PRO_SITUATION, value);
				this._PRO_SITUATION = value;
			}
		}
		/// <summary>
		/// 项目完成度
		/// </summary>
		public string PRO_DOCPT
		{
			get{ return _PRO_DOCPT; }
			set
			{
				this.OnPropertyValueChange(_.PRO_DOCPT, _PRO_DOCPT, value);
				this._PRO_DOCPT = value;
			}
		}
		/// <summary>
		/// 当前进度
		/// </summary>
		public string CRT_PROGRESS
		{
			get{ return _CRT_PROGRESS; }
			set
			{
				this.OnPropertyValueChange(_.CRT_PROGRESS, _CRT_PROGRESS, value);
				this._CRT_PROGRESS = value;
			}
		}
		/// <summary>
		/// 备注
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
				_.PRO_CODE,
				_.PRO_NAME,
				_.PRO_TPIC,
				_.MONEY,
				_.PRO_SITUATION,
				_.PRO_DOCPT,
				_.CRT_PROGRESS,
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
				this._PRO_CODE,
				this._PRO_NAME,
				this._PRO_TPIC,
				this._MONEY,
				this._PRO_SITUATION,
				this._PRO_DOCPT,
				this._CRT_PROGRESS,
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
			public readonly static Field All = new Field("*", "PRO_TPOTIOT");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRO_TPOTIOT", "ID");
            /// <summary>
			/// 项目编号
			/// </summary>
			public readonly static Field PRO_CODE = new Field("PRO_CODE", "PRO_TPOTIOT", "项目编号");
            /// <summary>
			/// 项目名称
			/// </summary>
			public readonly static Field PRO_NAME = new Field("PRO_NAME", "PRO_TPOTIOT", "项目名称");
            /// <summary>
			/// 项目负责人
			/// </summary>
			public readonly static Field PRO_TPIC = new Field("PRO_TPIC", "PRO_TPOTIOT", "项目负责人");
            /// <summary>
			/// 金额(万元)
			/// </summary>
			public readonly static Field MONEY = new Field("MONEY", "PRO_TPOTIOT", "金额(万元)");
            /// <summary>
			/// 项目情况
			/// </summary>
			public readonly static Field PRO_SITUATION = new Field("PRO_SITUATION", "PRO_TPOTIOT", "项目情况");
            /// <summary>
			/// 项目完成度
			/// </summary>
			public readonly static Field PRO_DOCPT = new Field("PRO_DOCPT", "PRO_TPOTIOT", "项目完成度");
            /// <summary>
			/// 当前进度
			/// </summary>
			public readonly static Field CRT_PROGRESS = new Field("CRT_PROGRESS", "PRO_TPOTIOT", "当前进度");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "PRO_TPOTIOT", "备注");
        }
        #endregion
	}
}