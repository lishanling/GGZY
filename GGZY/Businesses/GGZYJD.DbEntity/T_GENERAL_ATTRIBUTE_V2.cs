using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_GENERAL_ATTRIBUTE_V2。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_GENERAL_ATTRIBUTE_V2")]
    [Serializable]
    public partial class T_GENERAL_ATTRIBUTE_V2 : JdEntity
    {
        #region Model
		private string _MGUID;
		private string _ENTITYID;
		private string _ENTITYNAME;
		private string _KEY;
		private string _VALUE;
		private string _OBJECTID;
		private string _REMARK;

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
		/// 实体主键
		/// </summary>
		public string ENTITYID
		{
			get{ return _ENTITYID; }
			set
			{
				this.OnPropertyValueChange(_.ENTITYID, _ENTITYID, value);
				this._ENTITYID = value;
			}
		}
		/// <summary>
		/// 实体名称
		/// </summary>
		public string ENTITYNAME
		{
			get{ return _ENTITYNAME; }
			set
			{
				this.OnPropertyValueChange(_.ENTITYNAME, _ENTITYNAME, value);
				this._ENTITYNAME = value;
			}
		}
		/// <summary>
		/// 实体扩展属性，对应字段名称
		/// </summary>
		public string KEY
		{
			get{ return _KEY; }
			set
			{
				this.OnPropertyValueChange(_.KEY, _KEY, value);
				this._KEY = value;
			}
		}
		/// <summary>
		/// 实体扩展属性值，对应字段名称
		/// </summary>
		public string VALUE
		{
			get{ return _VALUE; }
			set
			{
				this.OnPropertyValueChange(_.VALUE, _VALUE, value);
				this._VALUE = value;
			}
		}
		/// <summary>
		/// 通用属性归属对象 比如平台标识
		/// </summary>
		public string OBJECTID
		{
			get{ return _OBJECTID; }
			set
			{
				this.OnPropertyValueChange(_.OBJECTID, _OBJECTID, value);
				this._OBJECTID = value;
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
				_.ENTITYID,
				_.ENTITYNAME,
				_.KEY,
				_.VALUE,
				_.OBJECTID,
				_.REMARK,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._MGUID,
				this._ENTITYID,
				this._ENTITYNAME,
				this._KEY,
				this._VALUE,
				this._OBJECTID,
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
			public readonly static Field All = new Field("*", "T_GENERAL_ATTRIBUTE_V2");
            /// <summary>
			/// 主键
			/// </summary>
			public readonly static Field MGUID = new Field("MGUID", "T_GENERAL_ATTRIBUTE_V2", "主键");
            /// <summary>
			/// 实体主键
			/// </summary>
			public readonly static Field ENTITYID = new Field("ENTITYID", "T_GENERAL_ATTRIBUTE_V2", "实体主键");
            /// <summary>
			/// 实体名称
			/// </summary>
			public readonly static Field ENTITYNAME = new Field("ENTITYNAME", "T_GENERAL_ATTRIBUTE_V2", "实体名称");
            /// <summary>
			/// 实体扩展属性，对应字段名称
			/// </summary>
			public readonly static Field KEY = new Field("KEY", "T_GENERAL_ATTRIBUTE_V2", "实体扩展属性，对应字段名称");
            /// <summary>
			/// 实体扩展属性值，对应字段名称
			/// </summary>
			public readonly static Field VALUE = new Field("VALUE", "T_GENERAL_ATTRIBUTE_V2",DbType.AnsiString,null, "实体扩展属性值，对应字段名称");
            /// <summary>
			/// 通用属性归属对象 比如平台标识
			/// </summary>
			public readonly static Field OBJECTID = new Field("OBJECTID", "T_GENERAL_ATTRIBUTE_V2", "通用属性归属对象 比如平台标识");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_GENERAL_ATTRIBUTE_V2", "备注");
        }
        #endregion
	}
}