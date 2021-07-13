using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_TP_NODE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TP_NODE")]
    [Serializable]
    public partial class T_TP_NODE : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _NAME;
		private string _CODE;
		private string _TACHE_CODE;
		private string _REMARK;
		private decimal? _ORDER_ID;
		private DateTime? _CREATE_TM;
		private string _MUTEX_NODE;
		private string _CPN_CODE;

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
		/// 节点名称
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
		/// 节点编码
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
		/// 归属环节编码
		/// </summary>
		public string TACHE_CODE
		{
			get{ return _TACHE_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TACHE_CODE, _TACHE_CODE, value);
				this._TACHE_CODE = value;
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
		/// <summary>
		/// 排序id
		/// </summary>
		public decimal? ORDER_ID
		{
			get{ return _ORDER_ID; }
			set
			{
				this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
				this._ORDER_ID = value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TM
		{
			get{ return _CREATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TM, _CREATE_TM, value);
				this._CREATE_TM = value;
			}
		}
		/// <summary>
		/// 互斥节点：【互斥节点】状态为无时且【当前节点】状态不为无，互斥节点不可用;多个节点用‘,’分割。
		/// </summary>
		public string MUTEX_NODE
		{
			get{ return _MUTEX_NODE; }
			set
			{
				this.OnPropertyValueChange(_.MUTEX_NODE, _MUTEX_NODE, value);
				this._MUTEX_NODE = value;
			}
		}
		/// <summary>
		/// 流程图对应节点编码
		/// </summary>
		public string CPN_CODE
		{
			get{ return _CPN_CODE; }
			set
			{
				this.OnPropertyValueChange(_.CPN_CODE, _CPN_CODE, value);
				this._CPN_CODE = value;
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
				_.CODE,
				_.TACHE_CODE,
				_.REMARK,
				_.ORDER_ID,
				_.CREATE_TM,
				_.MUTEX_NODE,
				_.CPN_CODE,
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
				this._CODE,
				this._TACHE_CODE,
				this._REMARK,
				this._ORDER_ID,
				this._CREATE_TM,
				this._MUTEX_NODE,
				this._CPN_CODE,
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
			public readonly static Field All = new Field("*", "T_TP_NODE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TP_NODE", "ID");
            /// <summary>
			/// 节点名称
			/// </summary>
			public readonly static Field NAME = new Field("NAME", "T_TP_NODE", "节点名称");
            /// <summary>
			/// 节点编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_TP_NODE", "节点编码");
            /// <summary>
			/// 归属环节编码
			/// </summary>
			public readonly static Field TACHE_CODE = new Field("TACHE_CODE", "T_TP_NODE", "归属环节编码");
            /// <summary>
			/// 说明
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "T_TP_NODE", "说明");
            /// <summary>
			/// 排序id
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "T_TP_NODE", "排序id");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_TP_NODE", "创建时间");
            /// <summary>
			/// 互斥节点：【互斥节点】状态为无时且【当前节点】状态不为无，互斥节点不可用;多个节点用‘,’分割。
			/// </summary>
			public readonly static Field MUTEX_NODE = new Field("MUTEX_NODE", "T_TP_NODE", "互斥节点：【互斥节点】状态为无时且【当前节点】状态不为无，互斥节点不可用;多个节点用‘,’分割。");
            /// <summary>
			/// 流程图对应节点编码
			/// </summary>
			public readonly static Field CPN_CODE = new Field("CPN_CODE", "T_TP_NODE", "流程图对应节点编码");
        }
        #endregion
	}
}