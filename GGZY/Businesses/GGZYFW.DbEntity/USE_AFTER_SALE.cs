using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类USE_AFTER_SALE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("USE_AFTER_SALE")]
    [Serializable]
    public partial class USE_AFTER_SALE : FwEntity
    {
        #region Model
		private decimal? _ID;
		private string _USE;
		private string _DEBUG;
		private string _DESIGN_CONTECT;
		private string _INSTALLATION_SUPERVESOR;
		private string _TRAIN;
		private string _PROJECT_MANAGE;
		private DateTime? _GUARANTEE_SERVICE;
		private string _PORDUCT_PERFONMANCE;
		private string _PACKAGE;
		private string _DESIGN_INSTALL;
		private string _AFTER_SALE_SERVICE;
		private string _AFTER_SALE_CONTECT;
		private string _PHONE;

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
		/// 用途
		/// </summary>
		public string USE
		{
			get{ return _USE; }
			set
			{
				this.OnPropertyValueChange(_.USE, _USE, value);
				this._USE = value;
			}
		}
		/// <summary>
		/// 调试
		/// </summary>
		public string DEBUG
		{
			get{ return _DEBUG; }
			set
			{
				this.OnPropertyValueChange(_.DEBUG, _DEBUG, value);
				this._DEBUG = value;
			}
		}
		/// <summary>
		/// 设计联络
		/// </summary>
		public string DESIGN_CONTECT
		{
			get{ return _DESIGN_CONTECT; }
			set
			{
				this.OnPropertyValueChange(_.DESIGN_CONTECT, _DESIGN_CONTECT, value);
				this._DESIGN_CONTECT = value;
			}
		}
		/// <summary>
		/// 安装督导
		/// </summary>
		public string INSTALLATION_SUPERVESOR
		{
			get{ return _INSTALLATION_SUPERVESOR; }
			set
			{
				this.OnPropertyValueChange(_.INSTALLATION_SUPERVESOR, _INSTALLATION_SUPERVESOR, value);
				this._INSTALLATION_SUPERVESOR = value;
			}
		}
		/// <summary>
		/// 培训
		/// </summary>
		public string TRAIN
		{
			get{ return _TRAIN; }
			set
			{
				this.OnPropertyValueChange(_.TRAIN, _TRAIN, value);
				this._TRAIN = value;
			}
		}
		/// <summary>
		/// 项目管理
		/// </summary>
		public string PROJECT_MANAGE
		{
			get{ return _PROJECT_MANAGE; }
			set
			{
				this.OnPropertyValueChange(_.PROJECT_MANAGE, _PROJECT_MANAGE, value);
				this._PROJECT_MANAGE = value;
			}
		}
		/// <summary>
		/// 质保期服务
		/// </summary>
		public DateTime? GUARANTEE_SERVICE
		{
			get{ return _GUARANTEE_SERVICE; }
			set
			{
				this.OnPropertyValueChange(_.GUARANTEE_SERVICE, _GUARANTEE_SERVICE, value);
				this._GUARANTEE_SERVICE = value;
			}
		}
		/// <summary>
		/// 产品性能
		/// </summary>
		public string PORDUCT_PERFONMANCE
		{
			get{ return _PORDUCT_PERFONMANCE; }
			set
			{
				this.OnPropertyValueChange(_.PORDUCT_PERFONMANCE, _PORDUCT_PERFONMANCE, value);
				this._PORDUCT_PERFONMANCE = value;
			}
		}
		/// <summary>
		/// 包装
		/// </summary>
		public string PACKAGE
		{
			get{ return _PACKAGE; }
			set
			{
				this.OnPropertyValueChange(_.PACKAGE, _PACKAGE, value);
				this._PACKAGE = value;
			}
		}
		/// <summary>
		/// 设计及安装
		/// </summary>
		public string DESIGN_INSTALL
		{
			get{ return _DESIGN_INSTALL; }
			set
			{
				this.OnPropertyValueChange(_.DESIGN_INSTALL, _DESIGN_INSTALL, value);
				this._DESIGN_INSTALL = value;
			}
		}
		/// <summary>
		/// 售后服务
		/// </summary>
		public string AFTER_SALE_SERVICE
		{
			get{ return _AFTER_SALE_SERVICE; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_SALE_SERVICE, _AFTER_SALE_SERVICE, value);
				this._AFTER_SALE_SERVICE = value;
			}
		}
		/// <summary>
		/// 售后联系人
		/// </summary>
		public string AFTER_SALE_CONTECT
		{
			get{ return _AFTER_SALE_CONTECT; }
			set
			{
				this.OnPropertyValueChange(_.AFTER_SALE_CONTECT, _AFTER_SALE_CONTECT, value);
				this._AFTER_SALE_CONTECT = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string PHONE
		{
			get{ return _PHONE; }
			set
			{
				this.OnPropertyValueChange(_.PHONE, _PHONE, value);
				this._PHONE = value;
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
				_.USE,
				_.DEBUG,
				_.DESIGN_CONTECT,
				_.INSTALLATION_SUPERVESOR,
				_.TRAIN,
				_.PROJECT_MANAGE,
				_.GUARANTEE_SERVICE,
				_.PORDUCT_PERFONMANCE,
				_.PACKAGE,
				_.DESIGN_INSTALL,
				_.AFTER_SALE_SERVICE,
				_.AFTER_SALE_CONTECT,
				_.PHONE,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._USE,
				this._DEBUG,
				this._DESIGN_CONTECT,
				this._INSTALLATION_SUPERVESOR,
				this._TRAIN,
				this._PROJECT_MANAGE,
				this._GUARANTEE_SERVICE,
				this._PORDUCT_PERFONMANCE,
				this._PACKAGE,
				this._DESIGN_INSTALL,
				this._AFTER_SALE_SERVICE,
				this._AFTER_SALE_CONTECT,
				this._PHONE,
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
			public readonly static Field All = new Field("*", "USE_AFTER_SALE");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "USE_AFTER_SALE", "ID");
            /// <summary>
			/// 用途
			/// </summary>
			public readonly static Field USE = new Field("USE", "USE_AFTER_SALE", "用途");
            /// <summary>
			/// 调试
			/// </summary>
			public readonly static Field DEBUG = new Field("DEBUG", "USE_AFTER_SALE", "调试");
            /// <summary>
			/// 设计联络
			/// </summary>
			public readonly static Field DESIGN_CONTECT = new Field("DESIGN_CONTECT", "USE_AFTER_SALE", "设计联络");
            /// <summary>
			/// 安装督导
			/// </summary>
			public readonly static Field INSTALLATION_SUPERVESOR = new Field("INSTALLATION_SUPERVESOR", "USE_AFTER_SALE", "安装督导");
            /// <summary>
			/// 培训
			/// </summary>
			public readonly static Field TRAIN = new Field("TRAIN", "USE_AFTER_SALE", "培训");
            /// <summary>
			/// 项目管理
			/// </summary>
			public readonly static Field PROJECT_MANAGE = new Field("PROJECT_MANAGE", "USE_AFTER_SALE", "项目管理");
            /// <summary>
			/// 质保期服务
			/// </summary>
			public readonly static Field GUARANTEE_SERVICE = new Field("GUARANTEE_SERVICE", "USE_AFTER_SALE", "质保期服务");
            /// <summary>
			/// 产品性能
			/// </summary>
			public readonly static Field PORDUCT_PERFONMANCE = new Field("PORDUCT_PERFONMANCE", "USE_AFTER_SALE", "产品性能");
            /// <summary>
			/// 包装
			/// </summary>
			public readonly static Field PACKAGE = new Field("PACKAGE", "USE_AFTER_SALE", "包装");
            /// <summary>
			/// 设计及安装
			/// </summary>
			public readonly static Field DESIGN_INSTALL = new Field("DESIGN_INSTALL", "USE_AFTER_SALE", "设计及安装");
            /// <summary>
			/// 售后服务
			/// </summary>
			public readonly static Field AFTER_SALE_SERVICE = new Field("AFTER_SALE_SERVICE", "USE_AFTER_SALE", "售后服务");
            /// <summary>
			/// 售后联系人
			/// </summary>
			public readonly static Field AFTER_SALE_CONTECT = new Field("AFTER_SALE_CONTECT", "USE_AFTER_SALE", "售后联系人");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field PHONE = new Field("PHONE", "USE_AFTER_SALE", "联系电话");
        }
        #endregion
	}
}