using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS_OLD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ZXTS_OLD")]
    [Serializable]
    public partial class PT_ZXTS_OLD : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _TS_DW;
		private string _TS_TYPE;
		private string _TS_LXR;
		private string _TS_SFZ;
		private string _TS_PHONE;
		private string _BTS_DW;
		private string _OCODE;
		private string _TS_NAME;
		private string _TS_CONTENT;
		private DateTime? _TS_TM;
		private string _AIDS;
		private string _ISOPEN;
		private string _STATUS;
		private string _SL_DW;
		private DateTime? _SL_TM;
		private string _SL_CL;
		private string _CL_DW;
		private DateTime? _CL_TM;
		private string _CL_CLYJ;
		private string _JG_CLYJ;
		private string _JG_CLQK;
		private string _JYPT;
		private string _CODE;
		private string _TSR_TYPE;
		private decimal? _U_ID;
		private string _SL_STAFF;
		private string _CL_STAFF;
		private string _SS_DEPID;

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
		/// 投诉单位
		/// </summary>
		public string TS_DW
		{
			get{ return _TS_DW; }
			set
			{
				this.OnPropertyValueChange(_.TS_DW, _TS_DW, value);
				this._TS_DW = value;
			}
		}
		/// <summary>
		/// 投诉类型
		/// </summary>
		public string TS_TYPE
		{
			get{ return _TS_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TS_TYPE, _TS_TYPE, value);
				this._TS_TYPE = value;
			}
		}
		/// <summary>
		/// 投诉联系人
		/// </summary>
		public string TS_LXR
		{
			get{ return _TS_LXR; }
			set
			{
				this.OnPropertyValueChange(_.TS_LXR, _TS_LXR, value);
				this._TS_LXR = value;
			}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string TS_SFZ
		{
			get{ return _TS_SFZ; }
			set
			{
				this.OnPropertyValueChange(_.TS_SFZ, _TS_SFZ, value);
				this._TS_SFZ = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string TS_PHONE
		{
			get{ return _TS_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.TS_PHONE, _TS_PHONE, value);
				this._TS_PHONE = value;
			}
		}
		/// <summary>
		/// 被投诉单位
		/// </summary>
		public string BTS_DW
		{
			get{ return _BTS_DW; }
			set
			{
				this.OnPropertyValueChange(_.BTS_DW, _BTS_DW, value);
				this._BTS_DW = value;
			}
		}
		/// <summary>
		/// 组织结构代码
		/// </summary>
		public string OCODE
		{
			get{ return _OCODE; }
			set
			{
				this.OnPropertyValueChange(_.OCODE, _OCODE, value);
				this._OCODE = value;
			}
		}
		/// <summary>
		/// 投诉名称
		/// </summary>
		public string TS_NAME
		{
			get{ return _TS_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TS_NAME, _TS_NAME, value);
				this._TS_NAME = value;
			}
		}
		/// <summary>
		/// 投诉内容
		/// </summary>
		public string TS_CONTENT
		{
			get{ return _TS_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.TS_CONTENT, _TS_CONTENT, value);
				this._TS_CONTENT = value;
			}
		}
		/// <summary>
		/// 投诉时间
		/// </summary>
		public DateTime? TS_TM
		{
			get{ return _TS_TM; }
			set
			{
				this.OnPropertyValueChange(_.TS_TM, _TS_TM, value);
				this._TS_TM = value;
			}
		}
		/// <summary>
		/// 上传附件
		/// </summary>
		public string AIDS
		{
			get{ return _AIDS; }
			set
			{
				this.OnPropertyValueChange(_.AIDS, _AIDS, value);
				this._AIDS = value;
			}
		}
		/// <summary>
		/// 是否公开
		/// </summary>
		public string ISOPEN
		{
			get{ return _ISOPEN; }
			set
			{
				this.OnPropertyValueChange(_.ISOPEN, _ISOPEN, value);
				this._ISOPEN = value;
			}
		}
		/// <summary>
		/// 当前状态
		/// </summary>
		public string STATUS
		{
			get{ return _STATUS; }
			set
			{
				this.OnPropertyValueChange(_.STATUS, _STATUS, value);
				this._STATUS = value;
			}
		}
		/// <summary>
		/// 受理单位
		/// </summary>
		public string SL_DW
		{
			get{ return _SL_DW; }
			set
			{
				this.OnPropertyValueChange(_.SL_DW, _SL_DW, value);
				this._SL_DW = value;
			}
		}
		/// <summary>
		/// 受理时间
		/// </summary>
		public DateTime? SL_TM
		{
			get{ return _SL_TM; }
			set
			{
				this.OnPropertyValueChange(_.SL_TM, _SL_TM, value);
				this._SL_TM = value;
			}
		}
		/// <summary>
		/// 受理-处理
		/// </summary>
		public string SL_CL
		{
			get{ return _SL_CL; }
			set
			{
				this.OnPropertyValueChange(_.SL_CL, _SL_CL, value);
				this._SL_CL = value;
			}
		}
		/// <summary>
		/// 处理单位
		/// </summary>
		public string CL_DW
		{
			get{ return _CL_DW; }
			set
			{
				this.OnPropertyValueChange(_.CL_DW, _CL_DW, value);
				this._CL_DW = value;
			}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? CL_TM
		{
			get{ return _CL_TM; }
			set
			{
				this.OnPropertyValueChange(_.CL_TM, _CL_TM, value);
				this._CL_TM = value;
			}
		}
		/// <summary>
		/// 处理-处理意见
		/// </summary>
		public string CL_CLYJ
		{
			get{ return _CL_CLYJ; }
			set
			{
				this.OnPropertyValueChange(_.CL_CLYJ, _CL_CLYJ, value);
				this._CL_CLYJ = value;
			}
		}
		/// <summary>
		/// 结果-处理依据
		/// </summary>
		public string JG_CLYJ
		{
			get{ return _JG_CLYJ; }
			set
			{
				this.OnPropertyValueChange(_.JG_CLYJ, _JG_CLYJ, value);
				this._JG_CLYJ = value;
			}
		}
		/// <summary>
		/// 结果-处理情况
		/// </summary>
		public string JG_CLQK
		{
			get{ return _JG_CLQK; }
			set
			{
				this.OnPropertyValueChange(_.JG_CLQK, _JG_CLQK, value);
				this._JG_CLQK = value;
			}
		}
		/// <summary>
		/// 交易平台
		/// </summary>
		public string JYPT
		{
			get{ return _JYPT; }
			set
			{
				this.OnPropertyValueChange(_.JYPT, _JYPT, value);
				this._JYPT = value;
			}
		}
		/// <summary>
		/// 编号
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
		/// 投诉人类型
		/// </summary>
		public string TSR_TYPE
		{
			get{ return _TSR_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.TSR_TYPE, _TSR_TYPE, value);
				this._TSR_TYPE = value;
			}
		}
		/// <summary>
		/// 投诉用户
		/// </summary>
		public decimal? U_ID
		{
			get{ return _U_ID; }
			set
			{
				this.OnPropertyValueChange(_.U_ID, _U_ID, value);
				this._U_ID = value;
			}
		}
		/// <summary>
		/// 受理人
		/// </summary>
		public string SL_STAFF
		{
			get{ return _SL_STAFF; }
			set
			{
				this.OnPropertyValueChange(_.SL_STAFF, _SL_STAFF, value);
				this._SL_STAFF = value;
			}
		}
		/// <summary>
		/// 处理人
		/// </summary>
		public string CL_STAFF
		{
			get{ return _CL_STAFF; }
			set
			{
				this.OnPropertyValueChange(_.CL_STAFF, _CL_STAFF, value);
				this._CL_STAFF = value;
			}
		}
		/// <summary>
		/// 送审单位
		/// </summary>
		public string SS_DEPID
		{
			get{ return _SS_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.SS_DEPID, _SS_DEPID, value);
				this._SS_DEPID = value;
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
				_.TS_DW,
				_.TS_TYPE,
				_.TS_LXR,
				_.TS_SFZ,
				_.TS_PHONE,
				_.BTS_DW,
				_.OCODE,
				_.TS_NAME,
				_.TS_CONTENT,
				_.TS_TM,
				_.AIDS,
				_.ISOPEN,
				_.STATUS,
				_.SL_DW,
				_.SL_TM,
				_.SL_CL,
				_.CL_DW,
				_.CL_TM,
				_.CL_CLYJ,
				_.JG_CLYJ,
				_.JG_CLQK,
				_.JYPT,
				_.CODE,
				_.TSR_TYPE,
				_.U_ID,
				_.SL_STAFF,
				_.CL_STAFF,
				_.SS_DEPID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TS_DW,
				this._TS_TYPE,
				this._TS_LXR,
				this._TS_SFZ,
				this._TS_PHONE,
				this._BTS_DW,
				this._OCODE,
				this._TS_NAME,
				this._TS_CONTENT,
				this._TS_TM,
				this._AIDS,
				this._ISOPEN,
				this._STATUS,
				this._SL_DW,
				this._SL_TM,
				this._SL_CL,
				this._CL_DW,
				this._CL_TM,
				this._CL_CLYJ,
				this._JG_CLYJ,
				this._JG_CLQK,
				this._JYPT,
				this._CODE,
				this._TSR_TYPE,
				this._U_ID,
				this._SL_STAFF,
				this._CL_STAFF,
				this._SS_DEPID,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_OLD");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_OLD", "ID");
            /// <summary>
			/// 投诉单位
			/// </summary>
			public readonly static Field TS_DW = new Field("TS_DW", "PT_ZXTS_OLD", "投诉单位");
            /// <summary>
			/// 投诉类型
			/// </summary>
			public readonly static Field TS_TYPE = new Field("TS_TYPE", "PT_ZXTS_OLD", "投诉类型");
            /// <summary>
			/// 投诉联系人
			/// </summary>
			public readonly static Field TS_LXR = new Field("TS_LXR", "PT_ZXTS_OLD", "投诉联系人");
            /// <summary>
			/// 身份证号码
			/// </summary>
			public readonly static Field TS_SFZ = new Field("TS_SFZ", "PT_ZXTS_OLD", "身份证号码");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field TS_PHONE = new Field("TS_PHONE", "PT_ZXTS_OLD", "联系电话");
            /// <summary>
			/// 被投诉单位
			/// </summary>
			public readonly static Field BTS_DW = new Field("BTS_DW", "PT_ZXTS_OLD", "被投诉单位");
            /// <summary>
			/// 组织结构代码
			/// </summary>
			public readonly static Field OCODE = new Field("OCODE", "PT_ZXTS_OLD", "组织结构代码");
            /// <summary>
			/// 投诉名称
			/// </summary>
			public readonly static Field TS_NAME = new Field("TS_NAME", "PT_ZXTS_OLD", "投诉名称");
            /// <summary>
			/// 投诉内容
			/// </summary>
			public readonly static Field TS_CONTENT = new Field("TS_CONTENT", "PT_ZXTS_OLD", "投诉内容");
            /// <summary>
			/// 投诉时间
			/// </summary>
			public readonly static Field TS_TM = new Field("TS_TM", "PT_ZXTS_OLD", "投诉时间");
            /// <summary>
			/// 上传附件
			/// </summary>
			public readonly static Field AIDS = new Field("AIDS", "PT_ZXTS_OLD", "上传附件");
            /// <summary>
			/// 是否公开
			/// </summary>
			public readonly static Field ISOPEN = new Field("ISOPEN", "PT_ZXTS_OLD", "是否公开");
            /// <summary>
			/// 当前状态
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "PT_ZXTS_OLD", "当前状态");
            /// <summary>
			/// 受理单位
			/// </summary>
			public readonly static Field SL_DW = new Field("SL_DW", "PT_ZXTS_OLD", "受理单位");
            /// <summary>
			/// 受理时间
			/// </summary>
			public readonly static Field SL_TM = new Field("SL_TM", "PT_ZXTS_OLD", "受理时间");
            /// <summary>
			/// 受理-处理
			/// </summary>
			public readonly static Field SL_CL = new Field("SL_CL", "PT_ZXTS_OLD", "受理-处理");
            /// <summary>
			/// 处理单位
			/// </summary>
			public readonly static Field CL_DW = new Field("CL_DW", "PT_ZXTS_OLD", "处理单位");
            /// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field CL_TM = new Field("CL_TM", "PT_ZXTS_OLD", "处理时间");
            /// <summary>
			/// 处理-处理意见
			/// </summary>
			public readonly static Field CL_CLYJ = new Field("CL_CLYJ", "PT_ZXTS_OLD", "处理-处理意见");
            /// <summary>
			/// 结果-处理依据
			/// </summary>
			public readonly static Field JG_CLYJ = new Field("JG_CLYJ", "PT_ZXTS_OLD", "结果-处理依据");
            /// <summary>
			/// 结果-处理情况
			/// </summary>
			public readonly static Field JG_CLQK = new Field("JG_CLQK", "PT_ZXTS_OLD", "结果-处理情况");
            /// <summary>
			/// 交易平台
			/// </summary>
			public readonly static Field JYPT = new Field("JYPT", "PT_ZXTS_OLD", "交易平台");
            /// <summary>
			/// 编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "PT_ZXTS_OLD", "编号");
            /// <summary>
			/// 投诉人类型
			/// </summary>
			public readonly static Field TSR_TYPE = new Field("TSR_TYPE", "PT_ZXTS_OLD", "投诉人类型");
            /// <summary>
			/// 投诉用户
			/// </summary>
			public readonly static Field U_ID = new Field("U_ID", "PT_ZXTS_OLD", "投诉用户");
            /// <summary>
			/// 受理人
			/// </summary>
			public readonly static Field SL_STAFF = new Field("SL_STAFF", "PT_ZXTS_OLD", "受理人");
            /// <summary>
			/// 处理人
			/// </summary>
			public readonly static Field CL_STAFF = new Field("CL_STAFF", "PT_ZXTS_OLD", "处理人");
            /// <summary>
			/// 送审单位
			/// </summary>
			public readonly static Field SS_DEPID = new Field("SS_DEPID", "PT_ZXTS_OLD", "送审单位");
        }
        #endregion
	}
}