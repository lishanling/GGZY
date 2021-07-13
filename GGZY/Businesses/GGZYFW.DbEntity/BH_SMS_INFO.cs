using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类BH_SMS_INFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("BH_SMS_INFO")]
    [Serializable]
    public partial class BH_SMS_INFO : FwEntity
    {
        #region Model
        private string _GUID;
        private string _CODE;
        private DateTime? _CREATE_TIME;
        private DateTime? _OVER_TIME;
        private string _PHONE;
        private decimal? _IS_USE;
        private string _MSG;
        private string _ORDER_ID;
        private string _GUARANTEE_NO;

        /// <summary>
        /// 
        /// </summary>
        public string GUID
        {
            get { return _GUID; }
            set
            {
                this.OnPropertyValueChange(_.GUID, _GUID, value);
                this._GUID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CODE
        {
            get { return _CODE; }
            set
            {
                this.OnPropertyValueChange(_.CODE, _CODE, value);
                this._CODE = value;
            }
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public DateTime? OVER_TIME
        {
            get { return _OVER_TIME; }
            set
            {
                this.OnPropertyValueChange(_.OVER_TIME, _OVER_TIME, value);
                this._OVER_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PHONE
        {
            get { return _PHONE; }
            set
            {
                this.OnPropertyValueChange(_.PHONE, _PHONE, value);
                this._PHONE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? IS_USE
        {
            get { return _IS_USE; }
            set
            {
                this.OnPropertyValueChange(_.IS_USE, _IS_USE, value);
                this._IS_USE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MSG
        {
            get { return _MSG; }
            set
            {
                this.OnPropertyValueChange(_.MSG, _MSG, value);
                this._MSG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORDER_ID
        {
            get { return _ORDER_ID; }
            set
            {
                this.OnPropertyValueChange(_.ORDER_ID, _ORDER_ID, value);
                this._ORDER_ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GUARANTEE_NO
        {
            get { return _GUARANTEE_NO; }
            set
            {
                this.OnPropertyValueChange(_.GUARANTEE_NO, _GUARANTEE_NO, value);
                this._GUARANTEE_NO = value;
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
                _.GUID,
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.GUID,
                _.CODE,
                _.CREATE_TIME,
                _.OVER_TIME,
                _.PHONE,
                _.IS_USE,
                _.MSG,
                _.ORDER_ID,
                _.GUARANTEE_NO,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GUID,
                this._CODE,
                this._CREATE_TIME,
                this._OVER_TIME,
                this._PHONE,
                this._IS_USE,
                this._MSG,
                this._ORDER_ID,
                this._GUARANTEE_NO,
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
            public readonly static Field All = new Field("*", "BH_SMS_INFO");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CODE = new Field("CODE", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OVER_TIME = new Field("OVER_TIME", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PHONE = new Field("PHONE", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_USE = new Field("IS_USE", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MSG = new Field("MSG", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ORDER_ID = new Field("ORDER_ID", "BH_SMS_INFO", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUARANTEE_NO = new Field("GUARANTEE_NO", "BH_SMS_INFO", "");
        }
        #endregion
    }
}