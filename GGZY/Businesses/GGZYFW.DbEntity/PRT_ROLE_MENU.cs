using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类PRT_ROLE_MENU。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PRT_ROLE_MENU")]
    [Serializable]
    public partial class PRT_ROLE_MENU : FwEntity
    {
        #region Model
		private string _ROLEID;
		private string _MENUID;
		private string _CREATE_BY;
		private DateTime? _CREATE_DATE;
		private decimal? _DELFLAG;
		private string _ID;

		/// <summary>
		/// 角色ID
		/// </summary>
		public string ROLEID
		{
			get{ return _ROLEID; }
			set
			{
				this.OnPropertyValueChange(_.ROLEID, _ROLEID, value);
				this._ROLEID = value;
			}
		}
		/// <summary>
		/// 菜单ID
		/// </summary>
		public string MENUID
		{
			get{ return _MENUID; }
			set
			{
				this.OnPropertyValueChange(_.MENUID, _MENUID, value);
				this._MENUID = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATE_BY
		{
			get{ return _CREATE_BY; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
				this._CREATE_BY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_DATE
		{
			get{ return _CREATE_DATE; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_DATE, _CREATE_DATE, value);
				this._CREATE_DATE = value;
			}
		}
		
#pragma warning disable CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? DELFLAG
#pragma warning restore CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
		{
			get{ return _DELFLAG; }
			set
			{
				this.OnPropertyValueChange(_.DELFLAG, _DELFLAG, value);
				this._DELFLAG = value;
			}
		}
		/// <summary>
		/// 主键
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
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
				_.ROLEID,
				_.MENUID,
				_.CREATE_BY,
				_.CREATE_DATE,
				_.DELFLAG,
				_.ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ROLEID,
				this._MENUID,
				this._CREATE_BY,
				this._CREATE_DATE,
				this._DELFLAG,
				this._ID,
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
			public readonly static Field All = new Field("*", "PRT_ROLE_MENU");
            /// <summary>
			/// 角色ID
			/// </summary>
			public readonly static Field ROLEID = new Field("ROLEID", "PRT_ROLE_MENU", "角色ID");
            /// <summary>
			/// 菜单ID
			/// </summary>
			public readonly static Field MENUID = new Field("MENUID", "PRT_ROLE_MENU", "菜单ID");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATE_BY = new Field("CREATE_BY", "PRT_ROLE_MENU", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_DATE = new Field("CREATE_DATE", "PRT_ROLE_MENU", "创建时间");
            
#pragma warning disable CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field DELFLAG = new Field("DELFLAG", "PRT_ROLE_MENU", "是否删除");
#pragma warning restore CS1570 // XML 注释出现 XML 格式错误 --““”(十六进制值 0x13)是无效的字符。”
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field ID = new Field("ID", "PRT_ROLE_MENU", "主键");
        }
        #endregion
	}
}