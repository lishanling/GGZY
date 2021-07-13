using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类GOOD_TEMP_PARAM。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("GOOD_TEMP_PARAM")]
	[Serializable]
	public partial class GOOD_TEMP_PARAM : JdEntity
	{
		#region Model
		private decimal? _ID;
		private DateTime? _CREATE_TIME;
		private string _SWB_ITEMUNID;
		private string _SWB_ITEMCODE;
		private string _SWB_AREACODE;
		private string _SWB_DEPTCODE;
		private string _SWB_SRCCODE;

		/// <summary>
		/// id
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
		/// 创建时间
		/// </summary>
		public DateTime? CREATE_TIME
		{
			get { return _CREATE_TIME; }
			set
			{
				this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
				this._CREATE_TIME = value;
			}
		}
		/// <summary>
		/// 事项在省网办的唯一主键
		/// </summary>
		public string SWB_ITEMUNID
		{
			get { return _SWB_ITEMUNID; }
			set
			{
				this.OnPropertyValueChange(_.SWB_ITEMUNID, _SWB_ITEMUNID, value);
				this._SWB_ITEMUNID = value;
			}
		}
		/// <summary>
		/// 事项在省网办的事项编码
		/// </summary>
		public string SWB_ITEMCODE
		{
			get { return _SWB_ITEMCODE; }
			set
			{
				this.OnPropertyValueChange(_.SWB_ITEMCODE, _SWB_ITEMCODE, value);
				this._SWB_ITEMCODE = value;
			}
		}
		/// <summary>
		/// 事项所属区划代码
		/// </summary>
		public string SWB_AREACODE
		{
			get { return _SWB_AREACODE; }
			set
			{
				this.OnPropertyValueChange(_.SWB_AREACODE, _SWB_AREACODE, value);
				this._SWB_AREACODE = value;
			}
		}
		/// <summary>
		/// 事项所属部门统一社会信用代码
		/// </summary>
		public string SWB_DEPTCODE
		{
			get { return _SWB_DEPTCODE; }
			set
			{
				this.OnPropertyValueChange(_.SWB_DEPTCODE, _SWB_DEPTCODE, value);
				this._SWB_DEPTCODE = value;
			}
		}
		/// <summary>
		/// 事项原属地系统事项编码
		/// </summary>
		public string SWB_SRCCODE
		{
			get { return _SWB_SRCCODE; }
			set
			{
				this.OnPropertyValueChange(_.SWB_SRCCODE, _SWB_SRCCODE, value);
				this._SWB_SRCCODE = value;
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
				_.CREATE_TIME,
				_.SWB_ITEMUNID,
				_.SWB_ITEMCODE,
				_.SWB_AREACODE,
				_.SWB_DEPTCODE,
				_.SWB_SRCCODE,
			};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._CREATE_TIME,
				this._SWB_ITEMUNID,
				this._SWB_ITEMCODE,
				this._SWB_AREACODE,
				this._SWB_DEPTCODE,
				this._SWB_SRCCODE,
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
			public readonly static Field All = new Field("*", "GOOD_TEMP_PARAM");
			/// <summary>
			/// id
			/// </summary>
			public readonly static Field ID = new Field("ID", "GOOD_TEMP_PARAM", "id");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "GOOD_TEMP_PARAM", "创建时间");
			/// <summary>
			/// 事项在省网办的唯一主键
			/// </summary>
			public readonly static Field SWB_ITEMUNID = new Field("SWB_ITEMUNID", "GOOD_TEMP_PARAM", "事项在省网办的唯一主键");
			/// <summary>
			/// 事项在省网办的事项编码
			/// </summary>
			public readonly static Field SWB_ITEMCODE = new Field("SWB_ITEMCODE", "GOOD_TEMP_PARAM", "事项在省网办的事项编码");
			/// <summary>
			/// 事项所属区划代码
			/// </summary>
			public readonly static Field SWB_AREACODE = new Field("SWB_AREACODE", "GOOD_TEMP_PARAM", "事项所属区划代码");
			/// <summary>
			/// 事项所属部门统一社会信用代码
			/// </summary>
			public readonly static Field SWB_DEPTCODE = new Field("SWB_DEPTCODE", "GOOD_TEMP_PARAM", "事项所属部门统一社会信用代码");
			/// <summary>
			/// 事项原属地系统事项编码
			/// </summary>
			public readonly static Field SWB_SRCCODE = new Field("SWB_SRCCODE", "GOOD_TEMP_PARAM", "事项原属地系统事项编码");
		}
		#endregion
        public override string GetSequence()
        {
            return "SEQ_GOOD_TEMP_PARAM";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
	}
}