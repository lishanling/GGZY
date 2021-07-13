using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
	/// <summary>
	/// 实体类BH_OFD_SEND_LOG。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("BH_OFD_SEND_LOG")]
	[Serializable]
	public partial class BH_OFD_SEND_LOG : FwEntity
	{
		#region Model
		private int _ID;
		private DateTime _SEND_DATE;
		private int _SERIAL;
		private string _TRANSID;
		private string _SEND_JSON;
		private string _RECEIVE_JSON;
		private DateTime _CREATE_TIME;

		/// <summary>
		/// 唯一标识
		/// </summary>
		public int ID
		{
			get { return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 发送日期，用于计算流水号
		/// </summary>
		public DateTime SEND_DATE
		{
			get { return _SEND_DATE; }
			set
			{
				this.OnPropertyValueChange(_.SEND_DATE, _SEND_DATE, value);
				this._SEND_DATE = value;
			}
		}
		/// <summary>
		/// 序列号
		/// </summary>
		public int SERIAL
		{
			get { return _SERIAL; }
			set
			{
				this.OnPropertyValueChange(_.SERIAL, _SERIAL, value);
				this._SERIAL = value;
			}
		}
		/// <summary>
		/// 流水号
		/// </summary>
		public string TRANSID
		{
			get { return _TRANSID; }
			set
			{
				this.OnPropertyValueChange(_.TRANSID, _TRANSID, value);
				this._TRANSID = value;
			}
		}
		/// <summary>
		/// 发送文本
		/// </summary>
		public string SEND_JSON
		{
			get { return _SEND_JSON; }
			set
			{
				this.OnPropertyValueChange(_.SEND_JSON, _SEND_JSON, value);
				this._SEND_JSON = value;
			}
		}
		/// <summary>
		/// 接收文本
		/// </summary>
		public string RECEIVE_JSON
		{
			get { return _RECEIVE_JSON; }
			set
			{
				this.OnPropertyValueChange(_.RECEIVE_JSON, _RECEIVE_JSON, value);
				this._RECEIVE_JSON = value;
			}
		}
		/// <summary>
		/// 发送时间
		/// </summary>
		public DateTime CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
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
				_.SEND_DATE,
				_.SERIAL,
				_.TRANSID,
				_.SEND_JSON,
				_.RECEIVE_JSON,
				_.CREATE_TIME,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._SEND_DATE,
				this._SERIAL,
				this._TRANSID,
				this._SEND_JSON,
				this._RECEIVE_JSON,
				this._CREATE_TIME,
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
			public readonly static Field All = new Field("*", "BH_OFD_SEND_LOG");
			/// <summary>
			/// 唯一标识
			/// </summary>
			public readonly static Field ID = new Field("ID", "BH_OFD_SEND_LOG", "唯一标识");
			/// <summary>
			/// 发送日期，用于计算流水号
			/// </summary>
			public readonly static Field SEND_DATE = new Field("SEND_DATE", "BH_OFD_SEND_LOG", "发送日期，用于计算流水号");
			/// <summary>
			/// 序列号
			/// </summary>
			public readonly static Field SERIAL = new Field("SERIAL", "BH_OFD_SEND_LOG", "序列号");
			/// <summary>
			/// 流水号
			/// </summary>
			public readonly static Field TRANSID = new Field("TRANSID", "BH_OFD_SEND_LOG", "流水号");
			/// <summary>
			/// 发送文本
			/// </summary>
			public readonly static Field SEND_JSON = new Field("SEND_JSON", "BH_OFD_SEND_LOG", DbType.AnsiString, null, "发送文本");
			/// <summary>
			/// 接收文本
			/// </summary>
			public readonly static Field RECEIVE_JSON = new Field("RECEIVE_JSON", "BH_OFD_SEND_LOG", DbType.AnsiString, null, "接收文本");
			/// <summary>
			/// 发送时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_OFD_SEND_LOG", "发送时间");
		}
		#endregion
        public override string GetSequence()
        {
            return "SEQ_BH_OFD_SEND_LOG";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
	}
}