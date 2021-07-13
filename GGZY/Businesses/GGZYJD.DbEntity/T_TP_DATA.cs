using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_TP_DATA。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_TP_DATA")]
    [Serializable]
    public partial class T_TP_DATA : JdEntity
    {
        #region Model
		private decimal? _ID;
		private string _CODE;
		private DateTime? _CREATE_TM;
		private DateTime? _UPDATE_TM;
		private string _FIELD_1;
		private string _FIELD_2;
		private string _FIELD_3;
		private string _FIELD_4;
		private string _FIELD_5;
		private string _FIELD_6;
		private string _FIELD_7;
		private string _FIELD_8;
		private string _FIELD_9;
		private string _FIELD_10;
		private string _FIELD_11;
		private string _FIELD_12;
		private string _FIELD_13;
		private string _FIELD_14;
		private string _FIELD_15;
		private string _FIELD_16;
		private string _FIELD_17;
		private string _FIELD_18;
		private string _FIELD_19;
		private string _FIELD_20;
		private string _FIELD_21;
		private string _FIELD_22;
		private string _FIELD_23;
		private string _FIELD_24;
		private string _FIELD_25;
		private string _FIELD_26;
		private string _FIELD_27;
		private string _FIELD_28;
		private string _FIELD_29;
		private string _FIELD_30;
		private string _FIELD_31;
		private string _FIELD_32;
		private string _FIELD_33;
		private string _FIELD_34;
		private string _FIELD_35;
		private string _FIELD_36;
		private string _FIELD_37;
		private string _FIELD_38;
		private string _FIELD_39;
		private string _FIELD_40;
		private string _BFIELD_1;
		private string _BFIELD_2;
		private string _BFIELD_3;
		private string _BFIELD_4;
		private string _BFIELD_5;
		private string _BFIELD_6;
		private string _FIELD_41;
		private string _FIELD_42;
		private string _FIELD_43;
		private string _FIELD_44;
		private string _FIELD_45;
		private string _BUSINESSID;

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
		/// 归属编码
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
		/// 修改时间
		/// </summary>
		public DateTime? UPDATE_TM
		{
			get{ return _UPDATE_TM; }
			set
			{
				this.OnPropertyValueChange(_.UPDATE_TM, _UPDATE_TM, value);
				this._UPDATE_TM = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_1
		{
			get{ return _FIELD_1; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_1, _FIELD_1, value);
				this._FIELD_1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_2
		{
			get{ return _FIELD_2; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_2, _FIELD_2, value);
				this._FIELD_2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_3
		{
			get{ return _FIELD_3; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_3, _FIELD_3, value);
				this._FIELD_3 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_4
		{
			get{ return _FIELD_4; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_4, _FIELD_4, value);
				this._FIELD_4 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_5
		{
			get{ return _FIELD_5; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_5, _FIELD_5, value);
				this._FIELD_5 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_6
		{
			get{ return _FIELD_6; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_6, _FIELD_6, value);
				this._FIELD_6 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_7
		{
			get{ return _FIELD_7; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_7, _FIELD_7, value);
				this._FIELD_7 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_8
		{
			get{ return _FIELD_8; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_8, _FIELD_8, value);
				this._FIELD_8 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_9
		{
			get{ return _FIELD_9; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_9, _FIELD_9, value);
				this._FIELD_9 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_10
		{
			get{ return _FIELD_10; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_10, _FIELD_10, value);
				this._FIELD_10 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_11
		{
			get{ return _FIELD_11; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_11, _FIELD_11, value);
				this._FIELD_11 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_12
		{
			get{ return _FIELD_12; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_12, _FIELD_12, value);
				this._FIELD_12 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_13
		{
			get{ return _FIELD_13; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_13, _FIELD_13, value);
				this._FIELD_13 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_14
		{
			get{ return _FIELD_14; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_14, _FIELD_14, value);
				this._FIELD_14 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_15
		{
			get{ return _FIELD_15; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_15, _FIELD_15, value);
				this._FIELD_15 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_16
		{
			get{ return _FIELD_16; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_16, _FIELD_16, value);
				this._FIELD_16 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_17
		{
			get{ return _FIELD_17; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_17, _FIELD_17, value);
				this._FIELD_17 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_18
		{
			get{ return _FIELD_18; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_18, _FIELD_18, value);
				this._FIELD_18 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_19
		{
			get{ return _FIELD_19; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_19, _FIELD_19, value);
				this._FIELD_19 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_20
		{
			get{ return _FIELD_20; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_20, _FIELD_20, value);
				this._FIELD_20 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_21
		{
			get{ return _FIELD_21; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_21, _FIELD_21, value);
				this._FIELD_21 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_22
		{
			get{ return _FIELD_22; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_22, _FIELD_22, value);
				this._FIELD_22 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_23
		{
			get{ return _FIELD_23; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_23, _FIELD_23, value);
				this._FIELD_23 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_24
		{
			get{ return _FIELD_24; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_24, _FIELD_24, value);
				this._FIELD_24 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_25
		{
			get{ return _FIELD_25; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_25, _FIELD_25, value);
				this._FIELD_25 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_26
		{
			get{ return _FIELD_26; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_26, _FIELD_26, value);
				this._FIELD_26 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_27
		{
			get{ return _FIELD_27; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_27, _FIELD_27, value);
				this._FIELD_27 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_28
		{
			get{ return _FIELD_28; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_28, _FIELD_28, value);
				this._FIELD_28 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_29
		{
			get{ return _FIELD_29; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_29, _FIELD_29, value);
				this._FIELD_29 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_30
		{
			get{ return _FIELD_30; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_30, _FIELD_30, value);
				this._FIELD_30 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_31
		{
			get{ return _FIELD_31; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_31, _FIELD_31, value);
				this._FIELD_31 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_32
		{
			get{ return _FIELD_32; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_32, _FIELD_32, value);
				this._FIELD_32 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_33
		{
			get{ return _FIELD_33; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_33, _FIELD_33, value);
				this._FIELD_33 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_34
		{
			get{ return _FIELD_34; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_34, _FIELD_34, value);
				this._FIELD_34 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_35
		{
			get{ return _FIELD_35; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_35, _FIELD_35, value);
				this._FIELD_35 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_36
		{
			get{ return _FIELD_36; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_36, _FIELD_36, value);
				this._FIELD_36 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_37
		{
			get{ return _FIELD_37; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_37, _FIELD_37, value);
				this._FIELD_37 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_38
		{
			get{ return _FIELD_38; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_38, _FIELD_38, value);
				this._FIELD_38 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_39
		{
			get{ return _FIELD_39; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_39, _FIELD_39, value);
				this._FIELD_39 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_40
		{
			get{ return _FIELD_40; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_40, _FIELD_40, value);
				this._FIELD_40 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BFIELD_1
		{
			get{ return _BFIELD_1; }
			set
			{
				this.OnPropertyValueChange(_.BFIELD_1, _BFIELD_1, value);
				this._BFIELD_1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BFIELD_2
		{
			get{ return _BFIELD_2; }
			set
			{
				this.OnPropertyValueChange(_.BFIELD_2, _BFIELD_2, value);
				this._BFIELD_2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BFIELD_3
		{
			get{ return _BFIELD_3; }
			set
			{
				this.OnPropertyValueChange(_.BFIELD_3, _BFIELD_3, value);
				this._BFIELD_3 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BFIELD_4
		{
			get{ return _BFIELD_4; }
			set
			{
				this.OnPropertyValueChange(_.BFIELD_4, _BFIELD_4, value);
				this._BFIELD_4 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BFIELD_5
		{
			get{ return _BFIELD_5; }
			set
			{
				this.OnPropertyValueChange(_.BFIELD_5, _BFIELD_5, value);
				this._BFIELD_5 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BFIELD_6
		{
			get{ return _BFIELD_6; }
			set
			{
				this.OnPropertyValueChange(_.BFIELD_6, _BFIELD_6, value);
				this._BFIELD_6 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_41
		{
			get{ return _FIELD_41; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_41, _FIELD_41, value);
				this._FIELD_41 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_42
		{
			get{ return _FIELD_42; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_42, _FIELD_42, value);
				this._FIELD_42 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_43
		{
			get{ return _FIELD_43; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_43, _FIELD_43, value);
				this._FIELD_43 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_44
		{
			get{ return _FIELD_44; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_44, _FIELD_44, value);
				this._FIELD_44 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIELD_45
		{
			get{ return _FIELD_45; }
			set
			{
				this.OnPropertyValueChange(_.FIELD_45, _FIELD_45, value);
				this._FIELD_45 = value;
			}
		}
		/// <summary>
		/// 业务流水号
		/// </summary>
		public string BUSINESSID
		{
			get{ return _BUSINESSID; }
			set
			{
				this.OnPropertyValueChange(_.BUSINESSID, _BUSINESSID, value);
				this._BUSINESSID = value;
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
				_.CREATE_TM,
				_.UPDATE_TM,
				_.FIELD_1,
				_.FIELD_2,
				_.FIELD_3,
				_.FIELD_4,
				_.FIELD_5,
				_.FIELD_6,
				_.FIELD_7,
				_.FIELD_8,
				_.FIELD_9,
				_.FIELD_10,
				_.FIELD_11,
				_.FIELD_12,
				_.FIELD_13,
				_.FIELD_14,
				_.FIELD_15,
				_.FIELD_16,
				_.FIELD_17,
				_.FIELD_18,
				_.FIELD_19,
				_.FIELD_20,
				_.FIELD_21,
				_.FIELD_22,
				_.FIELD_23,
				_.FIELD_24,
				_.FIELD_25,
				_.FIELD_26,
				_.FIELD_27,
				_.FIELD_28,
				_.FIELD_29,
				_.FIELD_30,
				_.FIELD_31,
				_.FIELD_32,
				_.FIELD_33,
				_.FIELD_34,
				_.FIELD_35,
				_.FIELD_36,
				_.FIELD_37,
				_.FIELD_38,
				_.FIELD_39,
				_.FIELD_40,
				_.BFIELD_1,
				_.BFIELD_2,
				_.BFIELD_3,
				_.BFIELD_4,
				_.BFIELD_5,
				_.BFIELD_6,
				_.FIELD_41,
				_.FIELD_42,
				_.FIELD_43,
				_.FIELD_44,
				_.FIELD_45,
				_.BUSINESSID,
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
				this._CREATE_TM,
				this._UPDATE_TM,
				this._FIELD_1,
				this._FIELD_2,
				this._FIELD_3,
				this._FIELD_4,
				this._FIELD_5,
				this._FIELD_6,
				this._FIELD_7,
				this._FIELD_8,
				this._FIELD_9,
				this._FIELD_10,
				this._FIELD_11,
				this._FIELD_12,
				this._FIELD_13,
				this._FIELD_14,
				this._FIELD_15,
				this._FIELD_16,
				this._FIELD_17,
				this._FIELD_18,
				this._FIELD_19,
				this._FIELD_20,
				this._FIELD_21,
				this._FIELD_22,
				this._FIELD_23,
				this._FIELD_24,
				this._FIELD_25,
				this._FIELD_26,
				this._FIELD_27,
				this._FIELD_28,
				this._FIELD_29,
				this._FIELD_30,
				this._FIELD_31,
				this._FIELD_32,
				this._FIELD_33,
				this._FIELD_34,
				this._FIELD_35,
				this._FIELD_36,
				this._FIELD_37,
				this._FIELD_38,
				this._FIELD_39,
				this._FIELD_40,
				this._BFIELD_1,
				this._BFIELD_2,
				this._BFIELD_3,
				this._BFIELD_4,
				this._BFIELD_5,
				this._BFIELD_6,
				this._FIELD_41,
				this._FIELD_42,
				this._FIELD_43,
				this._FIELD_44,
				this._FIELD_45,
				this._BUSINESSID,
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
			public readonly static Field All = new Field("*", "T_TP_DATA");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "T_TP_DATA", "ID");
            /// <summary>
			/// 归属编码
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "T_TP_DATA", "归属编码");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CREATE_TM = new Field("CREATE_TM", "T_TP_DATA", "创建时间");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UPDATE_TM = new Field("UPDATE_TM", "T_TP_DATA", "修改时间");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_1 = new Field("FIELD_1", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_2 = new Field("FIELD_2", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_3 = new Field("FIELD_3", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_4 = new Field("FIELD_4", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_5 = new Field("FIELD_5", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_6 = new Field("FIELD_6", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_7 = new Field("FIELD_7", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_8 = new Field("FIELD_8", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_9 = new Field("FIELD_9", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_10 = new Field("FIELD_10", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_11 = new Field("FIELD_11", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_12 = new Field("FIELD_12", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_13 = new Field("FIELD_13", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_14 = new Field("FIELD_14", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_15 = new Field("FIELD_15", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_16 = new Field("FIELD_16", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_17 = new Field("FIELD_17", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_18 = new Field("FIELD_18", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_19 = new Field("FIELD_19", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_20 = new Field("FIELD_20", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_21 = new Field("FIELD_21", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_22 = new Field("FIELD_22", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_23 = new Field("FIELD_23", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_24 = new Field("FIELD_24", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_25 = new Field("FIELD_25", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_26 = new Field("FIELD_26", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_27 = new Field("FIELD_27", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_28 = new Field("FIELD_28", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_29 = new Field("FIELD_29", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_30 = new Field("FIELD_30", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_31 = new Field("FIELD_31", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_32 = new Field("FIELD_32", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_33 = new Field("FIELD_33", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_34 = new Field("FIELD_34", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_35 = new Field("FIELD_35", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_36 = new Field("FIELD_36", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_37 = new Field("FIELD_37", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_38 = new Field("FIELD_38", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_39 = new Field("FIELD_39", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_40 = new Field("FIELD_40", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BFIELD_1 = new Field("BFIELD_1", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BFIELD_2 = new Field("BFIELD_2", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BFIELD_3 = new Field("BFIELD_3", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BFIELD_4 = new Field("BFIELD_4", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BFIELD_5 = new Field("BFIELD_5", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BFIELD_6 = new Field("BFIELD_6", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_41 = new Field("FIELD_41", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_42 = new Field("FIELD_42", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_43 = new Field("FIELD_43", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_44 = new Field("FIELD_44", "T_TP_DATA", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FIELD_45 = new Field("FIELD_45", "T_TP_DATA", "");
            /// <summary>
			/// 业务流水号
			/// </summary>
			public readonly static Field BUSINESSID = new Field("BUSINESSID", "T_TP_DATA", "业务流水号");
        }
        #endregion
	}
}