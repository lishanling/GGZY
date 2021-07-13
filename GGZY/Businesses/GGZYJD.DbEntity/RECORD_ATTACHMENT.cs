using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类RECORD_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("RECORD_ATTACHMENT")]
	[Serializable]
	public partial class RECORD_ATTACHMENT : JdEntity
	{
		#region Model
		private decimal? _ID;
		private decimal? _RECORD_ID;
		private string _ATTFILE_TYPECODE;
		private string _GUIDS;
		private string _DESCRIPTION;
		private string _IS_INTACT;
		private string _MATERIAL_OPINION;
		private string _REMARK;
		private decimal? _IS_READ_ONLY;
		private string _ATTFILE_TYPENAME;
		private string _BID_SECTION_CODE;
		private decimal? _CATEGORY;

		/// <summary>
		/// 附件ID
		/// </summary>
		public decimal? ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 备案审查主表ID
		/// </summary>
		public decimal? RECORD_ID
		{
			get { return _RECORD_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECORD_ID, _RECORD_ID, value);
				this._RECORD_ID = value;
			}
		}
		/// <summary>
		/// 资料编码
		/// </summary>
		public string ATTFILE_TYPECODE
		{
			get { return _ATTFILE_TYPECODE; }
			set
			{
				this.OnPropertyValueChange(_.ATTFILE_TYPECODE, _ATTFILE_TYPECODE, value);
				this._ATTFILE_TYPECODE = value;
			}
		}
		/// <summary>
		/// sys_attachment表对应的GUID
		/// </summary>
		public string GUIDS
		{
			get { return _GUIDS; }
			set
			{
				this.OnPropertyValueChange(_.GUIDS, _GUIDS, value);
				this._GUIDS = value;
			}
		}
		/// <summary>
		/// 材料说明
		/// </summary>
		public string DESCRIPTION
		{
			get { return _DESCRIPTION; }
			set
			{
				this.OnPropertyValueChange(_.DESCRIPTION, _DESCRIPTION, value);
				this._DESCRIPTION = value;
			}
		}
		/// <summary>
		/// 材料是否完整
		/// </summary>
		public string IS_INTACT
		{
			get { return _IS_INTACT; }
			set
			{
				this.OnPropertyValueChange(_.IS_INTACT, _IS_INTACT, value);
				this._IS_INTACT = value;
			}
		}
		/// <summary>
		/// 材料审查意见
		/// </summary>
		public string MATERIAL_OPINION
		{
			get { return _MATERIAL_OPINION; }
			set
			{
				this.OnPropertyValueChange(_.MATERIAL_OPINION, _MATERIAL_OPINION, value);
				this._MATERIAL_OPINION = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string REMARK
		{
			get { return _REMARK; }
			set
			{
				this.OnPropertyValueChange(_.REMARK, _REMARK, value);
				this._REMARK = value;
			}
		}
		/// <summary>
		/// 是否只读
		/// </summary>
		public decimal? IS_READ_ONLY
		{
			get { return _IS_READ_ONLY; }
			set
			{
				this.OnPropertyValueChange(_.IS_READ_ONLY, _IS_READ_ONLY, value);
				this._IS_READ_ONLY = value;
			}
		}
		/// <summary>
		/// 资料名称
		/// </summary>
		public string ATTFILE_TYPENAME
		{
			get { return _ATTFILE_TYPENAME; }
			set
			{
				this.OnPropertyValueChange(_.ATTFILE_TYPENAME, _ATTFILE_TYPENAME, value);
				this._ATTFILE_TYPENAME = value;
			}
		}
		/// <summary>
		/// 标段包编号
		/// </summary>
		public string BID_SECTION_CODE
		{
			get { return _BID_SECTION_CODE; }
			set
			{
				this.OnPropertyValueChange(_.BID_SECTION_CODE, _BID_SECTION_CODE, value);
				this._BID_SECTION_CODE = value;
			}
		}
		/// <summary>
		/// 附件类别，1：招标条件备案附件  2：招标文件备案附件
		/// </summary>
		public decimal? CATEGORY
		{
			get { return _CATEGORY; }
			set
			{
				this.OnPropertyValueChange(_.CATEGORY, _CATEGORY, value);
				this._CATEGORY = value;
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
				_.RECORD_ID,
				_.ATTFILE_TYPECODE,
				_.GUIDS,
				_.DESCRIPTION,
				_.IS_INTACT,
				_.MATERIAL_OPINION,
				_.REMARK,
				_.IS_READ_ONLY,
				_.ATTFILE_TYPENAME,
				_.BID_SECTION_CODE,
				_.CATEGORY,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._RECORD_ID,
				this._ATTFILE_TYPECODE,
				this._GUIDS,
				this._DESCRIPTION,
				this._IS_INTACT,
				this._MATERIAL_OPINION,
				this._REMARK,
				this._IS_READ_ONLY,
				this._ATTFILE_TYPENAME,
				this._BID_SECTION_CODE,
				this._CATEGORY,
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
			public readonly static Field All = new Field("*", "RECORD_ATTACHMENT");
			/// <summary>
			/// 附件ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "RECORD_ATTACHMENT", "附件ID");
			/// <summary>
			/// 备案审查主表ID
			/// </summary>
			public readonly static Field RECORD_ID = new Field("RECORD_ID", "RECORD_ATTACHMENT", "备案审查主表ID");
			/// <summary>
			/// 资料编码
			/// </summary>
			public readonly static Field ATTFILE_TYPECODE = new Field("ATTFILE_TYPECODE", "RECORD_ATTACHMENT", "资料编码");
			/// <summary>
			/// sys_attachment表对应的GUID
			/// </summary>
			public readonly static Field GUIDS = new Field("GUIDS", "RECORD_ATTACHMENT", "sys_attachment表对应的GUID");
			/// <summary>
			/// 材料说明
			/// </summary>
			public readonly static Field DESCRIPTION = new Field("DESCRIPTION", "RECORD_ATTACHMENT", DbType.AnsiString, null, "材料说明");
			/// <summary>
			/// 材料是否完整
			/// </summary>
			public readonly static Field IS_INTACT = new Field("IS_INTACT", "RECORD_ATTACHMENT", "材料是否完整");
			/// <summary>
			/// 材料审查意见
			/// </summary>
			public readonly static Field MATERIAL_OPINION = new Field("MATERIAL_OPINION", "RECORD_ATTACHMENT", DbType.AnsiString, null, "材料审查意见");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field REMARK = new Field("REMARK", "RECORD_ATTACHMENT", "备注");
			/// <summary>
			/// 是否只读
			/// </summary>
			public readonly static Field IS_READ_ONLY = new Field("IS_READ_ONLY", "RECORD_ATTACHMENT", "是否只读");
			/// <summary>
			/// 资料名称
			/// </summary>
			public readonly static Field ATTFILE_TYPENAME = new Field("ATTFILE_TYPENAME", "RECORD_ATTACHMENT", "资料名称");
			/// <summary>
			/// 标段包编号
			/// </summary>
			public readonly static Field BID_SECTION_CODE = new Field("BID_SECTION_CODE", "RECORD_ATTACHMENT", "标段包编号");
			/// <summary>
			/// 附件类别，1：招标条件备案附件  2：招标文件备案附件
			/// </summary>
			public readonly static Field CATEGORY = new Field("CATEGORY", "RECORD_ATTACHMENT", "附件类别，1：招标条件备案附件  2：招标文件备案附件");
		}
		#endregion
	}
}