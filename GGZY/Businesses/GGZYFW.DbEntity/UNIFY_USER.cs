using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类UNIFY_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("UNIFY_USER")]
    [Serializable]
    public partial class UNIFY_USER : FwEntity
    {
        #region Model
		private string _MGUID;
		private string _NAME;
		private string _PWD;
		private decimal? _TYPE;
		private decimal? _STATE;
		private string _CREATEDBY;
		private DateTime? _CREATEDTIME;
		private string _UPDATEDBY;
		private DateTime? _UPDATEDTIME;

		/// <summary>
		/// 主键
		/// </summary>
		public string MGUID
		{
			get{ return _MGUID; }
			set
			{
				this.OnPropertyValueChange(_.MGUID, _MGUID, value);
				this._MGUID = value;
			}
		}
		/// <summary>
		/// 登录名
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
		/// 登录密码
		/// </summary>
		public string PWD
		{
			get{ return _PWD; }
			set
			{
				this.OnPropertyValueChange(_.PWD, _PWD, value);
				this._PWD = value;
			}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public decimal? TYPE
		{
			get{ return _TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TYPE, _TYPE, value);
				this._TYPE = value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public decimal? STATE
		{
			get{ return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
			}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CREATEDBY
		{
			get{ return _CREATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDBY, _CREATEDBY, value);
				this._CREATEDBY = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATEDTIME
		{
			get{ return _CREATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATEDTIME, _CREATEDTIME, value);
				this._CREATEDTIME = value;
			}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string UPDATEDBY
		{
			get{ return _UPDATEDBY; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDBY, _UPDATEDBY, value);
				this._UPDATEDBY = value;
			}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UPDATEDTIME
		{
			get{ return _UPDATEDTIME; }
			set
			{
				this.OnPropertyValueChange(_.UPDATEDTIME, _UPDATEDTIME, value);
				this._UPDATEDTIME = value;
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
				_.MGUID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.MGUID,
				_.NAME,
				_.PWD,
				_.TYPE,
				_.STATE,
				_.CREATEDBY,
				_.CREATEDTIME,
				_.UPDATEDBY,
				_.UPDATEDTIME,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._MGUID,
				this._NAME,
				this._PWD,
				this._TYPE,
				this._STATE,
				this._CREATEDBY,
				this._CREATEDTIME,
				this._UPDATEDBY,
				this._UPDATEDTIME,
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
			public readonly static Field All = new Field("*", "UNIFY_USER");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field MGUID = new Field("MGUID", "UNIFY_USER", "主键");
            /// <summary>
			/// 登录名
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "UNIFY_USER", "登录名");
            /// <summary>
			/// 登录密码
			/// </summary>
			public readonly static Field PWD = new Field("PWD", "UNIFY_USER", "登录密码");
            /// <summary>
			/// 类型
			/// </summary>
			public readonly static Field TYPE = new Field("TYPE", "UNIFY_USER", "类型");
            /// <summary>
			/// 状态
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "UNIFY_USER", "状态");
            /// <summary>
			/// 创建人
			/// </summary>
			public readonly static Field CREATEDBY = new Field("CREATEDBY", "UNIFY_USER", "创建人");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATEDTIME = new Field("CREATEDTIME", "UNIFY_USER", "创建时间");
            /// <summary>
			/// 修改人
			/// </summary>
			public readonly static Field UPDATEDBY = new Field("UPDATEDBY", "UNIFY_USER", "修改人");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATEDTIME = new Field("UPDATEDTIME", "UNIFY_USER", "修改时间");
        }
        #endregion
	}
}