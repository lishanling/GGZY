using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类JC_TRANS_RECORD。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("JC_TRANS_RECORD")]
	[Serializable]
	public partial class JC_TRANS_RECORD : JdEntity
	{
		#region Model
		private string _ID;
		private string _TRANS_CODE;
		private string _TITLE;
		private string _CONTENT;
		private string _RECEIVER;
		private string _RECEIVER_PHONE;
		private DateTime? _TRANS_TIME;
		private decimal? _TRANS_TYPE;
		private string _TRANS_USER;
		private string _ATTACHMENT_IDS;
		private decimal? _TRANS_USER_ID;
		private decimal? _RECEIVER_UNIT_ID;
		private decimal? _RECEIVER_ID;
		private DateTime? _DATA_TIMESTAMP;
		private string _TRANS_UNIT;
		private decimal? _TRANS_UNITID;
		private decimal? _HAS_RESULT;
		private decimal? _IS_NEW;
		private decimal? _IS_DELETE;
		private string _TRANS_USER_PHONE;
		private string _RECEIVER_UNIT_REGION;
		private string _TRANS_UNIT_REGION;
		private string _RECEIVER_UNIT_HY_TYPE;
		private string _TRANS_UNIT_HY_TYPE;

		/// <summary>
		/// ID
		/// </summary>
		public string ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 移送编号
		/// </summary>
		public string TRANS_CODE
		{
			get { return _TRANS_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_CODE, _TRANS_CODE, value);
				this._TRANS_CODE = value;
			}
		}
		/// <summary>
		/// 移送标题
		/// </summary>
		public string TITLE
		{
			get { return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 移送内容
		/// </summary>
		public string CONTENT
		{
			get { return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 移送对象
		/// </summary>
		public string RECEIVER
		{
			get { return _RECEIVER; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVER, _RECEIVER, value);
				this._RECEIVER = value;
			}
		}
		/// <summary>
		/// 移送对象联系电话
		/// </summary>
		public string RECEIVER_PHONE
		{
			get { return _RECEIVER_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVER_PHONE, _RECEIVER_PHONE, value);
				this._RECEIVER_PHONE = value;
			}
		}
		/// <summary>
		/// 移送时间
		/// </summary>
		public DateTime? TRANS_TIME
		{
			get { return _TRANS_TIME; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_TIME, _TRANS_TIME, value);
				this._TRANS_TIME = value;
			}
		}
		/// <summary>
		/// 移送类型(1:项目 2:主体 3:公职人员 9:其他)
		/// </summary>
		public decimal? TRANS_TYPE
		{
			get { return _TRANS_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_TYPE, _TRANS_TYPE, value);
				this._TRANS_TYPE = value;
			}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string TRANS_USER
		{
			get { return _TRANS_USER; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_USER, _TRANS_USER, value);
				this._TRANS_USER = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		public string ATTACHMENT_IDS
		{
			get { return _ATTACHMENT_IDS; }
			set
			{
				this.OnPropertyValueChange(_.ATTACHMENT_IDS, _ATTACHMENT_IDS, value);
				this._ATTACHMENT_IDS = value;
			}
		}
		/// <summary>
		/// 操作人ID
		/// </summary>
		public decimal? TRANS_USER_ID
		{
			get { return _TRANS_USER_ID; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_USER_ID, _TRANS_USER_ID, value);
				this._TRANS_USER_ID = value;
			}
		}
		/// <summary>
		/// 移送对象部门ID
		/// </summary>
		public decimal? RECEIVER_UNIT_ID
		{
			get { return _RECEIVER_UNIT_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVER_UNIT_ID, _RECEIVER_UNIT_ID, value);
				this._RECEIVER_UNIT_ID = value;
			}
		}
		/// <summary>
		/// 移送对象用户ID
		/// </summary>
		public decimal? RECEIVER_ID
		{
			get { return _RECEIVER_ID; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVER_ID, _RECEIVER_ID, value);
				this._RECEIVER_ID = value;
			}
		}
		/// <summary>
		/// 时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get { return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 操作人所在单位
		/// </summary>
		public string TRANS_UNIT
		{
			get { return _TRANS_UNIT; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_UNIT, _TRANS_UNIT, value);
				this._TRANS_UNIT = value;
			}
		}
		/// <summary>
		/// 操作人所在单位ID
		/// </summary>
		public decimal? TRANS_UNITID
		{
			get { return _TRANS_UNITID; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_UNITID, _TRANS_UNITID, value);
				this._TRANS_UNITID = value;
			}
		}
		/// <summary>
		/// 是否有处理结果
		/// </summary>
		public decimal? HAS_RESULT
		{
			get { return _HAS_RESULT; }
			set
			{
				this.OnPropertyValueChange(_.HAS_RESULT, _HAS_RESULT, value);
				this._HAS_RESULT = value;
			}
		}
		/// <summary>
		/// 是否新记录
		/// </summary>
		public decimal? IS_NEW
		{
			get { return _IS_NEW; }
			set
			{
				this.OnPropertyValueChange(_.IS_NEW, _IS_NEW, value);
				this._IS_NEW = value;
			}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public decimal? IS_DELETE
		{
			get { return _IS_DELETE; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
				this._IS_DELETE = value;
			}
		}
		/// <summary>
		/// 操作人联系电话
		/// </summary>
		public string TRANS_USER_PHONE
		{
			get { return _TRANS_USER_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_USER_PHONE, _TRANS_USER_PHONE, value);
				this._TRANS_USER_PHONE = value;
			}
		}
		/// <summary>
		/// 移送对象所在地区(部门表地区)
		/// </summary>
		public string RECEIVER_UNIT_REGION
		{
			get { return _RECEIVER_UNIT_REGION; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVER_UNIT_REGION, _RECEIVER_UNIT_REGION, value);
				this._RECEIVER_UNIT_REGION = value;
			}
		}
		/// <summary>
		/// 操作人所在读取（部门表地区）
		/// </summary>
		public string TRANS_UNIT_REGION
		{
			get { return _TRANS_UNIT_REGION; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_UNIT_REGION, _TRANS_UNIT_REGION, value);
				this._TRANS_UNIT_REGION = value;
			}
		}
		/// <summary>
		/// 移送对象所在单位行业部门
		/// </summary>
		public string RECEIVER_UNIT_HY_TYPE
		{
			get { return _RECEIVER_UNIT_HY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVER_UNIT_HY_TYPE, _RECEIVER_UNIT_HY_TYPE, value);
				this._RECEIVER_UNIT_HY_TYPE = value;
			}
		}
		/// <summary>
		/// 操作人所在单位所属行业
		/// </summary>
		public string TRANS_UNIT_HY_TYPE
		{
			get { return _TRANS_UNIT_HY_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TRANS_UNIT_HY_TYPE, _TRANS_UNIT_HY_TYPE, value);
				this._TRANS_UNIT_HY_TYPE = value;
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
				_.TRANS_CODE,
				_.TITLE,
				_.CONTENT,
				_.RECEIVER,
				_.RECEIVER_PHONE,
				_.TRANS_TIME,
				_.TRANS_TYPE,
				_.TRANS_USER,
				_.ATTACHMENT_IDS,
				_.TRANS_USER_ID,
				_.RECEIVER_UNIT_ID,
				_.RECEIVER_ID,
				_.DATA_TIMESTAMP,
				_.TRANS_UNIT,
				_.TRANS_UNITID,
				_.HAS_RESULT,
				_.IS_NEW,
				_.IS_DELETE,
				_.TRANS_USER_PHONE,
				_.RECEIVER_UNIT_REGION,
				_.TRANS_UNIT_REGION,
				_.RECEIVER_UNIT_HY_TYPE,
				_.TRANS_UNIT_HY_TYPE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._TRANS_CODE,
				this._TITLE,
				this._CONTENT,
				this._RECEIVER,
				this._RECEIVER_PHONE,
				this._TRANS_TIME,
				this._TRANS_TYPE,
				this._TRANS_USER,
				this._ATTACHMENT_IDS,
				this._TRANS_USER_ID,
				this._RECEIVER_UNIT_ID,
				this._RECEIVER_ID,
				this._DATA_TIMESTAMP,
				this._TRANS_UNIT,
				this._TRANS_UNITID,
				this._HAS_RESULT,
				this._IS_NEW,
				this._IS_DELETE,
				this._TRANS_USER_PHONE,
				this._RECEIVER_UNIT_REGION,
				this._TRANS_UNIT_REGION,
				this._RECEIVER_UNIT_HY_TYPE,
				this._TRANS_UNIT_HY_TYPE,
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
			public readonly static Field All = new Field("*", "JC_TRANS_RECORD");
			/// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "JC_TRANS_RECORD", "ID");
			/// <summary>
			/// 移送编号
			/// </summary>
			public readonly static Field TRANS_CODE = new Field("TRANS_CODE", "JC_TRANS_RECORD", "移送编号");
			/// <summary>
			/// 移送标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "JC_TRANS_RECORD", "移送标题");
			/// <summary>
			/// 移送内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "JC_TRANS_RECORD", DbType.AnsiString, null, "移送内容");
			/// <summary>
			/// 移送对象
			/// </summary>
			public readonly static Field RECEIVER = new Field("RECEIVER", "JC_TRANS_RECORD", "移送对象");
			/// <summary>
			/// 移送对象联系电话
			/// </summary>
			public readonly static Field RECEIVER_PHONE = new Field("RECEIVER_PHONE", "JC_TRANS_RECORD", "移送对象联系电话");
			/// <summary>
			/// 移送时间
			/// </summary>
			public readonly static Field TRANS_TIME = new Field("TRANS_TIME", "JC_TRANS_RECORD", "移送时间");
			/// <summary>
			/// 移送类型(1:项目 2:主体 3:公职人员 9:其他)
			/// </summary>
			public readonly static Field TRANS_TYPE = new Field("TRANS_TYPE", "JC_TRANS_RECORD", "移送类型(1:项目 2:主体 3:公职人员 9:其他)");
			/// <summary>
			/// 操作人
			/// </summary>
			public readonly static Field TRANS_USER = new Field("TRANS_USER", "JC_TRANS_RECORD", "操作人");
			/// <summary>
			/// 附件
			/// </summary>
			public readonly static Field ATTACHMENT_IDS = new Field("ATTACHMENT_IDS", "JC_TRANS_RECORD", "附件");
			/// <summary>
			/// 操作人ID
			/// </summary>
			public readonly static Field TRANS_USER_ID = new Field("TRANS_USER_ID", "JC_TRANS_RECORD", "操作人ID");
			/// <summary>
			/// 移送对象部门ID
			/// </summary>
			public readonly static Field RECEIVER_UNIT_ID = new Field("RECEIVER_UNIT_ID", "JC_TRANS_RECORD", "移送对象部门ID");
			/// <summary>
			/// 移送对象用户ID
			/// </summary>
			public readonly static Field RECEIVER_ID = new Field("RECEIVER_ID", "JC_TRANS_RECORD", "移送对象用户ID");
			/// <summary>
			/// 时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "JC_TRANS_RECORD", "时间戳");
			/// <summary>
			/// 操作人所在单位
			/// </summary>
			public readonly static Field TRANS_UNIT = new Field("TRANS_UNIT", "JC_TRANS_RECORD", "操作人所在单位");
			/// <summary>
			/// 操作人所在单位ID
			/// </summary>
			public readonly static Field TRANS_UNITID = new Field("TRANS_UNITID", "JC_TRANS_RECORD", "操作人所在单位ID");
			/// <summary>
			/// 是否有处理结果
			/// </summary>
			public readonly static Field HAS_RESULT = new Field("HAS_RESULT", "JC_TRANS_RECORD", "是否有处理结果");
			/// <summary>
			/// 是否新记录
			/// </summary>
			public readonly static Field IS_NEW = new Field("IS_NEW", "JC_TRANS_RECORD", "是否新记录");
			/// <summary>
			/// 是否删除
			/// </summary>
			public readonly static Field IS_DELETE = new Field("IS_DELETE", "JC_TRANS_RECORD", "是否删除");
			/// <summary>
			/// 操作人联系电话
			/// </summary>
			public readonly static Field TRANS_USER_PHONE = new Field("TRANS_USER_PHONE", "JC_TRANS_RECORD", "操作人联系电话");
			/// <summary>
			/// 移送对象所在地区(部门表地区)
			/// </summary>
			public readonly static Field RECEIVER_UNIT_REGION = new Field("RECEIVER_UNIT_REGION", "JC_TRANS_RECORD", "移送对象所在地区(部门表地区)");
			/// <summary>
			/// 操作人所在读取（部门表地区）
			/// </summary>
			public readonly static Field TRANS_UNIT_REGION = new Field("TRANS_UNIT_REGION", "JC_TRANS_RECORD", "操作人所在读取（部门表地区）");
			/// <summary>
			/// 移送对象所在单位行业部门
			/// </summary>
			public readonly static Field RECEIVER_UNIT_HY_TYPE = new Field("RECEIVER_UNIT_HY_TYPE", "JC_TRANS_RECORD", "移送对象所在单位行业部门");
			/// <summary>
			/// 操作人所在单位所属行业
			/// </summary>
			public readonly static Field TRANS_UNIT_HY_TYPE = new Field("TRANS_UNIT_HY_TYPE", "JC_TRANS_RECORD", "操作人所在单位所属行业");
		}
		#endregion
	}
}