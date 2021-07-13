using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_OPER_ASK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_OPER_ASK")]
    [Serializable]
    public partial class T_OPER_ASK : FwEntity
    {
        #region Model
		private string _ID;
		private string _TITLE;
		private string _CONTENT;
		private string _Q_AREA;
		private DateTime? _TC_TM;
		private string _LX_TELPHONE;
		private decimal? _TCR;
		private decimal? _HFR;
		private string _HF_CONTENTS;
		private DateTime? _HF_TM;
		private string _CLJG;
		private string _CLYJ;
		private DateTime? _CL_TM;

		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID, _ID, value);
				this._ID = value;
			}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string TITLE
		{
			get{ return _TITLE; }
			set
			{
				this.OnPropertyValueChange(_.TITLE, _TITLE, value);
				this._TITLE = value;
			}
		}
		/// <summary>
		/// 问题内容
		/// </summary>
		public string CONTENT
		{
			get{ return _CONTENT; }
			set
			{
				this.OnPropertyValueChange(_.CONTENT, _CONTENT, value);
				this._CONTENT = value;
			}
		}
		/// <summary>
		/// 问题区域
		/// </summary>
		public string Q_AREA
		{
			get{ return _Q_AREA; }
			set
			{
				this.OnPropertyValueChange(_.Q_AREA, _Q_AREA, value);
				this._Q_AREA = value;
			}
		}
		/// <summary>
		/// 提出时间
		/// </summary>
		public DateTime? TC_TM
		{
			get{ return _TC_TM; }
			set
			{
				this.OnPropertyValueChange(_.TC_TM, _TC_TM, value);
				this._TC_TM = value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string LX_TELPHONE
		{
			get{ return _LX_TELPHONE; }
			set
			{
				this.OnPropertyValueChange(_.LX_TELPHONE, _LX_TELPHONE, value);
				this._LX_TELPHONE = value;
			}
		}
		/// <summary>
		/// 提出人
		/// </summary>
		public decimal? TCR
		{
			get{ return _TCR; }
			set
			{
				this.OnPropertyValueChange(_.TCR, _TCR, value);
				this._TCR = value;
			}
		}
		/// <summary>
		/// 回复人
		/// </summary>
		public decimal? HFR
		{
			get{ return _HFR; }
			set
			{
				this.OnPropertyValueChange(_.HFR, _HFR, value);
				this._HFR = value;
			}
		}
		/// <summary>
		/// 回复内容
		/// </summary>
		public string HF_CONTENTS
		{
			get{ return _HF_CONTENTS; }
			set
			{
				this.OnPropertyValueChange(_.HF_CONTENTS, _HF_CONTENTS, value);
				this._HF_CONTENTS = value;
			}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime? HF_TM
		{
			get{ return _HF_TM; }
			set
			{
				this.OnPropertyValueChange(_.HF_TM, _HF_TM, value);
				this._HF_TM = value;
			}
		}
		/// <summary>
		/// 处理结果
		/// </summary>
		public string CLJG
		{
			get{ return _CLJG; }
			set
			{
				this.OnPropertyValueChange(_.CLJG, _CLJG, value);
				this._CLJG = value;
			}
		}
		/// <summary>
		/// 处理意见
		/// </summary>
		public string CLYJ
		{
			get{ return _CLYJ; }
			set
			{
				this.OnPropertyValueChange(_.CLYJ, _CLYJ, value);
				this._CLYJ = value;
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
				_.TITLE,
				_.CONTENT,
				_.Q_AREA,
				_.TC_TM,
				_.LX_TELPHONE,
				_.TCR,
				_.HFR,
				_.HF_CONTENTS,
				_.HF_TM,
				_.CLJG,
				_.CLYJ,
				_.CL_TM,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._TITLE,
				this._CONTENT,
				this._Q_AREA,
				this._TC_TM,
				this._LX_TELPHONE,
				this._TCR,
				this._HFR,
				this._HF_CONTENTS,
				this._HF_TM,
				this._CLJG,
				this._CLYJ,
				this._CL_TM,
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
			public readonly static Field All = new Field("*", "T_OPER_ASK");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_OPER_ASK", "");
            /// <summary>
			/// 标题
			/// </summary>
			public readonly static Field TITLE = new Field("TITLE", "T_OPER_ASK", "标题");
            /// <summary>
			/// 问题内容
			/// </summary>
			public readonly static Field CONTENT = new Field("CONTENT", "T_OPER_ASK", "问题内容");
            /// <summary>
			/// 问题区域
			/// </summary>
			public readonly static Field Q_AREA = new Field("Q_AREA", "T_OPER_ASK", "问题区域");
            /// <summary>
			/// 提出时间
			/// </summary>
			public readonly static Field TC_TM = new Field("TC_TM", "T_OPER_ASK", "提出时间");
            /// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field LX_TELPHONE = new Field("LX_TELPHONE", "T_OPER_ASK", "联系电话");
            /// <summary>
			/// 提出人
			/// </summary>
			public readonly static Field TCR = new Field("TCR", "T_OPER_ASK", "提出人");
            /// <summary>
			/// 回复人
			/// </summary>
			public readonly static Field HFR = new Field("HFR", "T_OPER_ASK", "回复人");
            /// <summary>
			/// 回复内容
			/// </summary>
			public readonly static Field HF_CONTENTS = new Field("HF_CONTENTS", "T_OPER_ASK", "回复内容");
            /// <summary>
			/// 回复时间
			/// </summary>
			public readonly static Field HF_TM = new Field("HF_TM", "T_OPER_ASK", "回复时间");
            /// <summary>
			/// 处理结果
			/// </summary>
			public readonly static Field CLJG = new Field("CLJG", "T_OPER_ASK", "处理结果");
            /// <summary>
			/// 处理意见
			/// </summary>
			public readonly static Field CLYJ = new Field("CLYJ", "T_OPER_ASK", "处理意见");
            /// <summary>
			/// 处理时间
			/// </summary>
			public readonly static Field CL_TM = new Field("CL_TM", "T_OPER_ASK", "处理时间");
        }
        #endregion
	}
}