using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_ZXTS_OLD2。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("PT_ZXTS_OLD2")]
    [Serializable]
    public partial class PT_ZXTS_OLD2 : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _CODE;
		private string _STATE;
		private string _COMPLAINT_NAME;
		private string _COMPLAINT_TYPE;
		private string _COMPLAINT_CODE;
		private string _COMPLAINT_ADRESS;
		private string _COMPLAINT_EMAIL;
		private string _COMPLAINT_CONTACT;
		private string _COMPLAINT_CONTACT_PHONE;
		private string _COMPLAINTED_NAME;
		private string _COMPLAINTED_TYPE;
		private string _COMPLAINTED_CODE;
		private string _COMPLAINTED_ADRESS;
		private string _COMPLAINTED_CONTACT;
		private string _COMPLAINTED_CONTACT_PHONE;
		private string _TENDER_PROJECT_CODE;
		private string _TENDER_PROJECT_NAME;
		private string _COMPLAINT_CONTENT;
		private string _COMPLAINT_CLAIM;
		private string _TSS_AIDS;
		private string _SFZ_AIDS;
		private string _YYZM_AIDS;
		private string _ZMCL_AIDS;
		private string _OTHER_AIDS;
		private DateTime? _CREATE_TM;
		private string _ACCEPT_DEPID;
		private string _ACCEPT_STATE;
		private decimal? _ACCEPT_UID;
		private DateTime? _ACCEPT_TM;
		private string _ACCEPT_REMARK;
		private string _ACCEPT_AIDS;
		private string _HANDLE_STATE;
		private decimal? _HANDLE_UID;
		private DateTime? _HANDLE_TM;
		private string _HANDLE_REMARK;
		private string _HANDLE_AIDS;
		private string _IS_DELAY;
		private DateTime? _DELAY_TM;
		private DateTime? _DATA_TIMESTAMP;
		private string _DELAY_REMARK;
		private decimal? _DELAY_UID;
		private string _DELAY_AIDS;
		private DateTime? _OVER_TM;

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
		/// 投诉编号
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
		/// 状态（1待受理2撤销3不予受理4待处理5申请撤诉6不予撤诉7同意撤诉8不予处理9已处理type=72）
		/// </summary>
		public string STATE
		{
			get{ return _STATE; }
			set
			{
				this.OnPropertyValueChange(_.STATE, _STATE, value);
				this._STATE = value;
			}
		}
		/// <summary>
		/// 投诉人
		/// </summary>
		public string COMPLAINT_NAME
		{
			get{ return _COMPLAINT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_NAME, _COMPLAINT_NAME, value);
				this._COMPLAINT_NAME = value;
			}
		}
		/// <summary>
		/// 投诉人
		/// </summary>
		public string COMPLAINT_TYPE
		{
			get{ return _COMPLAINT_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_TYPE, _COMPLAINT_TYPE, value);
				this._COMPLAINT_TYPE = value;
			}
		}
		/// <summary>
		/// 投诉人代码
		/// </summary>
		public string COMPLAINT_CODE
		{
			get{ return _COMPLAINT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CODE, _COMPLAINT_CODE, value);
				this._COMPLAINT_CODE = value;
			}
		}
		/// <summary>
		/// 投诉人_联系地址
		/// </summary>
		public string COMPLAINT_ADRESS
		{
			get{ return _COMPLAINT_ADRESS; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_ADRESS, _COMPLAINT_ADRESS, value);
				this._COMPLAINT_ADRESS = value;
			}
		}
		/// <summary>
		/// 投诉人_邮箱
		/// </summary>
		public string COMPLAINT_EMAIL
		{
			get{ return _COMPLAINT_EMAIL; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_EMAIL, _COMPLAINT_EMAIL, value);
				this._COMPLAINT_EMAIL = value;
			}
		}
		/// <summary>
		/// 投诉人_联系人
		/// </summary>
		public string COMPLAINT_CONTACT
		{
			get{ return _COMPLAINT_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTACT, _COMPLAINT_CONTACT, value);
				this._COMPLAINT_CONTACT = value;
			}
		}
		/// <summary>
		/// 投诉人_联系电话
		/// </summary>
		public string COMPLAINT_CONTACT_PHONE
		{
			get{ return _COMPLAINT_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTACT_PHONE, _COMPLAINT_CONTACT_PHONE, value);
				this._COMPLAINT_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 被投诉人名称
		/// </summary>
		public string COMPLAINTED_NAME
		{
			get{ return _COMPLAINTED_NAME; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_NAME, _COMPLAINTED_NAME, value);
				this._COMPLAINTED_NAME = value;
			}
		}
		/// <summary>
		/// 被投诉人_类型（1法人，2自然人，3组织 type=71）
		/// </summary>
		public string COMPLAINTED_TYPE
		{
			get{ return _COMPLAINTED_TYPE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_TYPE, _COMPLAINTED_TYPE, value);
				this._COMPLAINTED_TYPE = value;
			}
		}
		/// <summary>
		/// 被投诉人代码
		/// </summary>
		public string COMPLAINTED_CODE
		{
			get{ return _COMPLAINTED_CODE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_CODE, _COMPLAINTED_CODE, value);
				this._COMPLAINTED_CODE = value;
			}
		}
		/// <summary>
		/// 被投诉人_联系地址
		/// </summary>
		public string COMPLAINTED_ADRESS
		{
			get{ return _COMPLAINTED_ADRESS; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_ADRESS, _COMPLAINTED_ADRESS, value);
				this._COMPLAINTED_ADRESS = value;
			}
		}
		/// <summary>
		/// 被投诉人_联系人
		/// </summary>
		public string COMPLAINTED_CONTACT
		{
			get{ return _COMPLAINTED_CONTACT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_CONTACT, _COMPLAINTED_CONTACT, value);
				this._COMPLAINTED_CONTACT = value;
			}
		}
		/// <summary>
		/// 被投诉人_联系电话
		/// </summary>
		public string COMPLAINTED_CONTACT_PHONE
		{
			get{ return _COMPLAINTED_CONTACT_PHONE; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINTED_CONTACT_PHONE, _COMPLAINTED_CONTACT_PHONE, value);
				this._COMPLAINTED_CONTACT_PHONE = value;
			}
		}
		/// <summary>
		/// 招标项目编号
		/// </summary>
		public string TENDER_PROJECT_CODE
		{
			get{ return _TENDER_PROJECT_CODE; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
				this._TENDER_PROJECT_CODE = value;
			}
		}
		/// <summary>
		/// 招标项目名称
		/// </summary>
		public string TENDER_PROJECT_NAME
		{
			get{ return _TENDER_PROJECT_NAME; }
			set
			{
				this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
				this._TENDER_PROJECT_NAME = value;
			}
		}
		/// <summary>
		/// 投诉事项基本事实
		/// </summary>
		public string COMPLAINT_CONTENT
		{
			get{ return _COMPLAINT_CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CONTENT, _COMPLAINT_CONTENT, value);
				this._COMPLAINT_CONTENT = value;
			}
		}
		/// <summary>
		/// 请求与主张
		/// </summary>
		public string COMPLAINT_CLAIM
		{
			get{ return _COMPLAINT_CLAIM; }
			set
			{
				this.OnPropertyValueChange(_.COMPLAINT_CLAIM, _COMPLAINT_CLAIM, value);
				this._COMPLAINT_CLAIM = value;
			}
		}
		/// <summary>
		/// 附件_投诉书扫描件
		/// </summary>
		public string TSS_AIDS
		{
			get{ return _TSS_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.TSS_AIDS, _TSS_AIDS, value);
				this._TSS_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_身份证复印件
		/// </summary>
		public string SFZ_AIDS
		{
			get{ return _SFZ_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.SFZ_AIDS, _SFZ_AIDS, value);
				this._SFZ_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_异议证明文件
		/// </summary>
		public string YYZM_AIDS
		{
			get{ return _YYZM_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.YYZM_AIDS, _YYZM_AIDS, value);
				this._YYZM_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_有效线索和相关证明材料
		/// </summary>
		public string ZMCL_AIDS
		{
			get{ return _ZMCL_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.ZMCL_AIDS, _ZMCL_AIDS, value);
				this._ZMCL_AIDS = value;
			}
		}
		/// <summary>
		/// 附件_其他材料
		/// </summary>
		public string OTHER_AIDS
		{
			get{ return _OTHER_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.OTHER_AIDS, _OTHER_AIDS, value);
				this._OTHER_AIDS = value;
			}
		}
		/// <summary>
		/// 填报日期
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
		/// 受理部门
		/// </summary>
		public string ACCEPT_DEPID
		{
			get{ return _ACCEPT_DEPID; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_DEPID, _ACCEPT_DEPID, value);
				this._ACCEPT_DEPID = value;
			}
		}
		/// <summary>
		/// 受理状态（1未受理2已受理3不予受理type=73）
		/// </summary>
		public string ACCEPT_STATE
		{
			get{ return _ACCEPT_STATE; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_STATE, _ACCEPT_STATE, value);
				this._ACCEPT_STATE = value;
			}
		}
		/// <summary>
		/// 受理人员
		/// </summary>
		public decimal? ACCEPT_UID
		{
			get{ return _ACCEPT_UID; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_UID, _ACCEPT_UID, value);
				this._ACCEPT_UID = value;
			}
		}
		/// <summary>
		/// 受理时间
		/// </summary>
		public DateTime? ACCEPT_TM
		{
			get{ return _ACCEPT_TM; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_TM, _ACCEPT_TM, value);
				this._ACCEPT_TM = value;
			}
		}
		/// <summary>
		/// 受理意见
		/// </summary>
		public string ACCEPT_REMARK
		{
			get{ return _ACCEPT_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_REMARK, _ACCEPT_REMARK, value);
				this._ACCEPT_REMARK = value;
			}
		}
		/// <summary>
		/// 受理相关附件
		/// </summary>
		public string ACCEPT_AIDS
		{
			get{ return _ACCEPT_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.ACCEPT_AIDS, _ACCEPT_AIDS, value);
				this._ACCEPT_AIDS = value;
			}
		}
		/// <summary>
		/// 处理状态(1未处理2已处理3不予处理type=74)
		/// </summary>
		public string HANDLE_STATE
		{
			get{ return _HANDLE_STATE; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_STATE, _HANDLE_STATE, value);
				this._HANDLE_STATE = value;
			}
		}
		/// <summary>
		/// 处理人员
		/// </summary>
		public decimal? HANDLE_UID
		{
			get{ return _HANDLE_UID; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_UID, _HANDLE_UID, value);
				this._HANDLE_UID = value;
			}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? HANDLE_TM
		{
			get{ return _HANDLE_TM; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_TM, _HANDLE_TM, value);
				this._HANDLE_TM = value;
			}
		}
		/// <summary>
		/// 处理意见
		/// </summary>
		public string HANDLE_REMARK
		{
			get{ return _HANDLE_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_REMARK, _HANDLE_REMARK, value);
				this._HANDLE_REMARK = value;
			}
		}
		/// <summary>
		/// 处理相关附件
		/// </summary>
		public string HANDLE_AIDS
		{
			get{ return _HANDLE_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.HANDLE_AIDS, _HANDLE_AIDS, value);
				this._HANDLE_AIDS = value;
			}
		}
		/// <summary>
		/// 是否延期
		/// </summary>
		public string IS_DELAY
		{
			get{ return _IS_DELAY; }
			set
			{
				this.OnPropertyValueChange(_.IS_DELAY, _IS_DELAY, value);
				this._IS_DELAY = value;
			}
		}
		/// <summary>
		/// 延期时间
		/// </summary>
		public DateTime? DELAY_TM
		{
			get{ return _DELAY_TM; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_TM, _DELAY_TM, value);
				this._DELAY_TM = value;
			}
		}
		/// <summary>
		/// 数据时间戳
		/// </summary>
		public DateTime? DATA_TIMESTAMP
		{
			get{ return _DATA_TIMESTAMP; }
			set
			{
				this.OnPropertyValueChange(_.DATA_TIMESTAMP, _DATA_TIMESTAMP, value);
				this._DATA_TIMESTAMP = value;
			}
		}
		/// <summary>
		/// 延期说明
		/// </summary>
		public string DELAY_REMARK
		{
			get{ return _DELAY_REMARK; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_REMARK, _DELAY_REMARK, value);
				this._DELAY_REMARK = value;
			}
		}
		/// <summary>
		/// 延期人员
		/// </summary>
		public decimal? DELAY_UID
		{
			get{ return _DELAY_UID; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_UID, _DELAY_UID, value);
				this._DELAY_UID = value;
			}
		}
		/// <summary>
		/// 延期-相关附件
		/// </summary>
		public string DELAY_AIDS
		{
			get{ return _DELAY_AIDS; }
			set
			{
				this.OnPropertyValueChange(_.DELAY_AIDS, _DELAY_AIDS, value);
				this._DELAY_AIDS = value;
			}
		}
		/// <summary>
		/// 超时时间(最后处理时间)
		/// </summary>
		public DateTime? OVER_TM
		{
			get{ return _OVER_TM; }
			set
			{
				this.OnPropertyValueChange(_.OVER_TM, _OVER_TM, value);
				this._OVER_TM = value;
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
				_.CODE,
				_.STATE,
				_.COMPLAINT_NAME,
				_.COMPLAINT_TYPE,
				_.COMPLAINT_CODE,
				_.COMPLAINT_ADRESS,
				_.COMPLAINT_EMAIL,
				_.COMPLAINT_CONTACT,
				_.COMPLAINT_CONTACT_PHONE,
				_.COMPLAINTED_NAME,
				_.COMPLAINTED_TYPE,
				_.COMPLAINTED_CODE,
				_.COMPLAINTED_ADRESS,
				_.COMPLAINTED_CONTACT,
				_.COMPLAINTED_CONTACT_PHONE,
				_.TENDER_PROJECT_CODE,
				_.TENDER_PROJECT_NAME,
				_.COMPLAINT_CONTENT,
				_.COMPLAINT_CLAIM,
				_.TSS_AIDS,
				_.SFZ_AIDS,
				_.YYZM_AIDS,
				_.ZMCL_AIDS,
				_.OTHER_AIDS,
				_.CREATE_TM,
				_.ACCEPT_DEPID,
				_.ACCEPT_STATE,
				_.ACCEPT_UID,
				_.ACCEPT_TM,
				_.ACCEPT_REMARK,
				_.ACCEPT_AIDS,
				_.HANDLE_STATE,
				_.HANDLE_UID,
				_.HANDLE_TM,
				_.HANDLE_REMARK,
				_.HANDLE_AIDS,
				_.IS_DELAY,
				_.DELAY_TM,
				_.DATA_TIMESTAMP,
				_.DELAY_REMARK,
				_.DELAY_UID,
				_.DELAY_AIDS,
				_.OVER_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CODE,
				this._STATE,
				this._COMPLAINT_NAME,
				this._COMPLAINT_TYPE,
				this._COMPLAINT_CODE,
				this._COMPLAINT_ADRESS,
				this._COMPLAINT_EMAIL,
				this._COMPLAINT_CONTACT,
				this._COMPLAINT_CONTACT_PHONE,
				this._COMPLAINTED_NAME,
				this._COMPLAINTED_TYPE,
				this._COMPLAINTED_CODE,
				this._COMPLAINTED_ADRESS,
				this._COMPLAINTED_CONTACT,
				this._COMPLAINTED_CONTACT_PHONE,
				this._TENDER_PROJECT_CODE,
				this._TENDER_PROJECT_NAME,
				this._COMPLAINT_CONTENT,
				this._COMPLAINT_CLAIM,
				this._TSS_AIDS,
				this._SFZ_AIDS,
				this._YYZM_AIDS,
				this._ZMCL_AIDS,
				this._OTHER_AIDS,
				this._CREATE_TM,
				this._ACCEPT_DEPID,
				this._ACCEPT_STATE,
				this._ACCEPT_UID,
				this._ACCEPT_TM,
				this._ACCEPT_REMARK,
				this._ACCEPT_AIDS,
				this._HANDLE_STATE,
				this._HANDLE_UID,
				this._HANDLE_TM,
				this._HANDLE_REMARK,
				this._HANDLE_AIDS,
				this._IS_DELAY,
				this._DELAY_TM,
				this._DATA_TIMESTAMP,
				this._DELAY_REMARK,
				this._DELAY_UID,
				this._DELAY_AIDS,
				this._OVER_TM,
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
			public readonly static Field All = new Field("*", "PT_ZXTS_OLD2");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "PT_ZXTS_OLD2", "ID");
            /// <summary>
			/// 投诉编号
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "PT_ZXTS_OLD2", "投诉编号");
            /// <summary>
			/// 状态（1待受理2撤销3不予受理4待处理5申请撤诉6不予撤诉7同意撤诉8不予处理9已处理type=72）
			/// </summary>
			public readonly static Field STATE = new Field("STATE", "PT_ZXTS_OLD2", "状态（1待受理2撤销3不予受理4待处理5申请撤诉6不予撤诉7同意撤诉8不予处理9已处理type=72）");
            /// <summary>
			/// 投诉人
			/// </summary>
			public readonly static Field COMPLAINT_NAME = new Field("COMPLAINT_NAME", "PT_ZXTS_OLD2", "投诉人");
            /// <summary>
			/// 投诉人
			/// </summary>
			public readonly static Field COMPLAINT_TYPE = new Field("COMPLAINT_TYPE", "PT_ZXTS_OLD2", "投诉人");
            /// <summary>
			/// 投诉人代码
			/// </summary>
			public readonly static Field COMPLAINT_CODE = new Field("COMPLAINT_CODE", "PT_ZXTS_OLD2", "投诉人代码");
            /// <summary>
			/// 投诉人_联系地址
			/// </summary>
			public readonly static Field COMPLAINT_ADRESS = new Field("COMPLAINT_ADRESS", "PT_ZXTS_OLD2", "投诉人_联系地址");
            /// <summary>
			/// 投诉人_邮箱
			/// </summary>
			public readonly static Field COMPLAINT_EMAIL = new Field("COMPLAINT_EMAIL", "PT_ZXTS_OLD2", "投诉人_邮箱");
            /// <summary>
			/// 投诉人_联系人
			/// </summary>
			public readonly static Field COMPLAINT_CONTACT = new Field("COMPLAINT_CONTACT", "PT_ZXTS_OLD2", "投诉人_联系人");
            /// <summary>
			/// 投诉人_联系电话
			/// </summary>
			public readonly static Field COMPLAINT_CONTACT_PHONE = new Field("COMPLAINT_CONTACT_PHONE", "PT_ZXTS_OLD2", "投诉人_联系电话");
            /// <summary>
			/// 被投诉人名称
			/// </summary>
			public readonly static Field COMPLAINTED_NAME = new Field("COMPLAINTED_NAME", "PT_ZXTS_OLD2", "被投诉人名称");
            /// <summary>
			/// 被投诉人_类型（1法人，2自然人，3组织 type=71）
			/// </summary>
			public readonly static Field COMPLAINTED_TYPE = new Field("COMPLAINTED_TYPE", "PT_ZXTS_OLD2", "被投诉人_类型（1法人，2自然人，3组织 type=71）");
            /// <summary>
			/// 被投诉人代码
			/// </summary>
			public readonly static Field COMPLAINTED_CODE = new Field("COMPLAINTED_CODE", "PT_ZXTS_OLD2", "被投诉人代码");
            /// <summary>
			/// 被投诉人_联系地址
			/// </summary>
			public readonly static Field COMPLAINTED_ADRESS = new Field("COMPLAINTED_ADRESS", "PT_ZXTS_OLD2", "被投诉人_联系地址");
            /// <summary>
			/// 被投诉人_联系人
			/// </summary>
			public readonly static Field COMPLAINTED_CONTACT = new Field("COMPLAINTED_CONTACT", "PT_ZXTS_OLD2", "被投诉人_联系人");
            /// <summary>
			/// 被投诉人_联系电话
			/// </summary>
			public readonly static Field COMPLAINTED_CONTACT_PHONE = new Field("COMPLAINTED_CONTACT_PHONE", "PT_ZXTS_OLD2", "被投诉人_联系电话");
            /// <summary>
			/// 招标项目编号
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "PT_ZXTS_OLD2", "招标项目编号");
            /// <summary>
			/// 招标项目名称
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "PT_ZXTS_OLD2", "招标项目名称");
            /// <summary>
			/// 投诉事项基本事实
			/// </summary>
			public readonly static Field COMPLAINT_CONTENT = new Field("COMPLAINT_CONTENT", "PT_ZXTS_OLD2", "投诉事项基本事实");
            /// <summary>
			/// 请求与主张
			/// </summary>
			public readonly static Field COMPLAINT_CLAIM = new Field("COMPLAINT_CLAIM", "PT_ZXTS_OLD2", "请求与主张");
            /// <summary>
			/// 附件_投诉书扫描件
			/// </summary>
			public readonly static Field TSS_AIDS = new Field("TSS_AIDS", "PT_ZXTS_OLD2", "附件_投诉书扫描件");
            /// <summary>
			/// 附件_身份证复印件
			/// </summary>
			public readonly static Field SFZ_AIDS = new Field("SFZ_AIDS", "PT_ZXTS_OLD2", "附件_身份证复印件");
            /// <summary>
			/// 附件_异议证明文件
			/// </summary>
			public readonly static Field YYZM_AIDS = new Field("YYZM_AIDS", "PT_ZXTS_OLD2", "附件_异议证明文件");
            /// <summary>
			/// 附件_有效线索和相关证明材料
			/// </summary>
			public readonly static Field ZMCL_AIDS = new Field("ZMCL_AIDS", "PT_ZXTS_OLD2", "附件_有效线索和相关证明材料");
            /// <summary>
			/// 附件_其他材料
			/// </summary>
			public readonly static Field OTHER_AIDS = new Field("OTHER_AIDS", "PT_ZXTS_OLD2", "附件_其他材料");
            /// <summary>
			/// 填报日期
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "PT_ZXTS_OLD2", "填报日期");
            /// <summary>
			/// 受理部门
			/// </summary>
			public readonly static Field ACCEPT_DEPID = new Field("ACCEPT_DEPID", "PT_ZXTS_OLD2", "受理部门");
            /// <summary>
			/// 受理状态（1未受理2已受理3不予受理type=73）
			/// </summary>
			public readonly static Field ACCEPT_STATE = new Field("ACCEPT_STATE", "PT_ZXTS_OLD2", "受理状态（1未受理2已受理3不予受理type=73）");
            /// <summary>
			/// 受理人员
			/// </summary>
			public readonly static Field ACCEPT_UID = new Field("ACCEPT_UID", "PT_ZXTS_OLD2", "受理人员");
            /// <summary>
			/// 受理时间
			/// </summary>
			public readonly static Field ACCEPT_TM = new Field("ACCEPT_TM", "PT_ZXTS_OLD2", "受理时间");
            /// <summary>
			/// 受理意见
			/// </summary>
			public readonly static Field ACCEPT_REMARK = new Field("ACCEPT_REMARK", "PT_ZXTS_OLD2", "受理意见");
            /// <summary>
			/// 受理相关附件
			/// </summary>
			public readonly static Field ACCEPT_AIDS = new Field("ACCEPT_AIDS", "PT_ZXTS_OLD2", "受理相关附件");
            /// <summary>
			/// 处理状态(1未处理2已处理3不予处理type=74)
			/// </summary>
			public readonly static Field HANDLE_STATE = new Field("HANDLE_STATE", "PT_ZXTS_OLD2", "处理状态(1未处理2已处理3不予处理type=74)");
            /// <summary>
			/// 处理人员
			/// </summary>
			public readonly static Field HANDLE_UID = new Field("HANDLE_UID", "PT_ZXTS_OLD2", "处理人员");
            /// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field HANDLE_TM = new Field("HANDLE_TM", "PT_ZXTS_OLD2", "处理时间");
            /// <summary>
			/// 处理意见
			/// </summary>
			public readonly static Field HANDLE_REMARK = new Field("HANDLE_REMARK", "PT_ZXTS_OLD2", "处理意见");
            /// <summary>
			/// 处理相关附件
			/// </summary>
			public readonly static Field HANDLE_AIDS = new Field("HANDLE_AIDS", "PT_ZXTS_OLD2", "处理相关附件");
            /// <summary>
			/// 是否延期
			/// </summary>
			public readonly static Field IS_DELAY = new Field("IS_DELAY", "PT_ZXTS_OLD2", "是否延期");
            /// <summary>
			/// 延期时间
			/// </summary>
			public readonly static Field DELAY_TM = new Field("DELAY_TM", "PT_ZXTS_OLD2", "延期时间");
            /// <summary>
			/// 数据时间戳
			/// </summary>
			public readonly static Field DATA_TIMESTAMP = new Field("DATA_TIMESTAMP", "PT_ZXTS_OLD2", "数据时间戳");
            /// <summary>
			/// 延期说明
			/// </summary>
			public readonly static Field DELAY_REMARK = new Field("DELAY_REMARK", "PT_ZXTS_OLD2", "延期说明");
            /// <summary>
			/// 延期人员
			/// </summary>
			public readonly static Field DELAY_UID = new Field("DELAY_UID", "PT_ZXTS_OLD2", "延期人员");
            /// <summary>
			/// 延期-相关附件
			/// </summary>
			public readonly static Field DELAY_AIDS = new Field("DELAY_AIDS", "PT_ZXTS_OLD2", "延期-相关附件");
            /// <summary>
			/// 超时时间(最后处理时间)
			/// </summary>
			public readonly static Field OVER_TM = new Field("OVER_TM", "PT_ZXTS_OLD2", "超时时间(最后处理时间)");
        }
        #endregion
	}
}