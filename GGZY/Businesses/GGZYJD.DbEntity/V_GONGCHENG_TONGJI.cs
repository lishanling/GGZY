using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类V_GONGCHENG_TONGJI。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("V_GONGCHENG_TONGJI")]
    [Serializable]
    public partial class V_GONGCHENG_TONGJI : JdEntity
    {
        #region Model
        private string _GCMC;
        private string _PROJECT_TYPE;
        private string _HYFL;
        private string _BABM;
        private string _ZJLY;
        private string _ZBR;
        private string _ZBFW;
        private string _ZBDLDW;
        private string _TENDER_MODE;
        private string _ZBFS;
        private string _PBBF;
        private string _GCGM;
        private string _YSJ;
        private decimal? _ZBKZJ;
        private decimal? _ZBJ;
        private string _YYSJBJ;
        private decimal? _YKZJBJ;
        private decimal? _DEGQ;
        private decimal? _JSGQ;
        private decimal? _GQSD;
        private string _JLFWQ;
        private string _KCSJZQ;
        private string _JHQ;
        private DateTime? _KBRQ;
        private decimal? _TBDWGS;
        private string _ZBDW;
        private string _ZBDWYJ;
        private decimal? _ZBDWXYF;
        private string _ZJLGCS;
        private string _ZJLGCSYJ;
        private string _XMFZR;
        private string _XMFZRYJ;
        private string _XMJSFZR;
        private string _PBWYHCY;
        private string _BEIZHU;
        private string _PROJECT_CODE;
        private string _TENDER_PROJECT_CODE;
        private string _TENDER_PROJECT_NAME;
        private string _TENDER_PROJECT_TYPE;
        private string _ZBXMLX;
        private string _TENDER_PROJECT_CLASSIFY_CODE;
        private DateTime? _TM;

        /// <summary>
        /// 
        /// </summary>
        public string GCMC
        {
            get { return _GCMC; }
            set
            {
                this.OnPropertyValueChange(_.GCMC, _GCMC, value);
                this._GCMC = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_TYPE
        {
            get { return _PROJECT_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_TYPE, _PROJECT_TYPE, value);
                this._PROJECT_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HYFL
        {
            get { return _HYFL; }
            set
            {
                this.OnPropertyValueChange(_.HYFL, _HYFL, value);
                this._HYFL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BABM
        {
            get { return _BABM; }
            set
            {
                this.OnPropertyValueChange(_.BABM, _BABM, value);
                this._BABM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZJLY
        {
            get { return _ZJLY; }
            set
            {
                this.OnPropertyValueChange(_.ZJLY, _ZJLY, value);
                this._ZJLY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZBR
        {
            get { return _ZBR; }
            set
            {
                this.OnPropertyValueChange(_.ZBR, _ZBR, value);
                this._ZBR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZBFW
        {
            get { return _ZBFW; }
            set
            {
                this.OnPropertyValueChange(_.ZBFW, _ZBFW, value);
                this._ZBFW = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZBDLDW
        {
            get { return _ZBDLDW; }
            set
            {
                this.OnPropertyValueChange(_.ZBDLDW, _ZBDLDW, value);
                this._ZBDLDW = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TENDER_MODE
        {
            get { return _TENDER_MODE; }
            set
            {
                this.OnPropertyValueChange(_.TENDER_MODE, _TENDER_MODE, value);
                this._TENDER_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZBFS
        {
            get { return _ZBFS; }
            set
            {
                this.OnPropertyValueChange(_.ZBFS, _ZBFS, value);
                this._ZBFS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PBBF
        {
            get { return _PBBF; }
            set
            {
                this.OnPropertyValueChange(_.PBBF, _PBBF, value);
                this._PBBF = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GCGM
        {
            get { return _GCGM; }
            set
            {
                this.OnPropertyValueChange(_.GCGM, _GCGM, value);
                this._GCGM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YSJ
        {
            get { return _YSJ; }
            set
            {
                this.OnPropertyValueChange(_.YSJ, _YSJ, value);
                this._YSJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ZBKZJ
        {
            get { return _ZBKZJ; }
            set
            {
                this.OnPropertyValueChange(_.ZBKZJ, _ZBKZJ, value);
                this._ZBKZJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ZBJ
        {
            get { return _ZBJ; }
            set
            {
                this.OnPropertyValueChange(_.ZBJ, _ZBJ, value);
                this._ZBJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YYSJBJ
        {
            get { return _YYSJBJ; }
            set
            {
                this.OnPropertyValueChange(_.YYSJBJ, _YYSJBJ, value);
                this._YYSJBJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? YKZJBJ
        {
            get { return _YKZJBJ; }
            set
            {
                this.OnPropertyValueChange(_.YKZJBJ, _YKZJBJ, value);
                this._YKZJBJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DEGQ
        {
            get { return _DEGQ; }
            set
            {
                this.OnPropertyValueChange(_.DEGQ, _DEGQ, value);
                this._DEGQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? JSGQ
        {
            get { return _JSGQ; }
            set
            {
                this.OnPropertyValueChange(_.JSGQ, _JSGQ, value);
                this._JSGQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? GQSD
        {
            get { return _GQSD; }
            set
            {
                this.OnPropertyValueChange(_.GQSD, _GQSD, value);
                this._GQSD = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JLFWQ
        {
            get { return _JLFWQ; }
            set
            {
                this.OnPropertyValueChange(_.JLFWQ, _JLFWQ, value);
                this._JLFWQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KCSJZQ
        {
            get { return _KCSJZQ; }
            set
            {
                this.OnPropertyValueChange(_.KCSJZQ, _KCSJZQ, value);
                this._KCSJZQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JHQ
        {
            get { return _JHQ; }
            set
            {
                this.OnPropertyValueChange(_.JHQ, _JHQ, value);
                this._JHQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? KBRQ
        {
            get { return _KBRQ; }
            set
            {
                this.OnPropertyValueChange(_.KBRQ, _KBRQ, value);
                this._KBRQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TBDWGS
        {
            get { return _TBDWGS; }
            set
            {
                this.OnPropertyValueChange(_.TBDWGS, _TBDWGS, value);
                this._TBDWGS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZBDW
        {
            get { return _ZBDW; }
            set
            {
                this.OnPropertyValueChange(_.ZBDW, _ZBDW, value);
                this._ZBDW = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZBDWYJ
        {
            get { return _ZBDWYJ; }
            set
            {
                this.OnPropertyValueChange(_.ZBDWYJ, _ZBDWYJ, value);
                this._ZBDWYJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ZBDWXYF
        {
            get { return _ZBDWXYF; }
            set
            {
                this.OnPropertyValueChange(_.ZBDWXYF, _ZBDWXYF, value);
                this._ZBDWXYF = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZJLGCS
        {
            get { return _ZJLGCS; }
            set
            {
                this.OnPropertyValueChange(_.ZJLGCS, _ZJLGCS, value);
                this._ZJLGCS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZJLGCSYJ
        {
            get { return _ZJLGCSYJ; }
            set
            {
                this.OnPropertyValueChange(_.ZJLGCSYJ, _ZJLGCSYJ, value);
                this._ZJLGCSYJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XMFZR
        {
            get { return _XMFZR; }
            set
            {
                this.OnPropertyValueChange(_.XMFZR, _XMFZR, value);
                this._XMFZR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XMFZRYJ
        {
            get { return _XMFZRYJ; }
            set
            {
                this.OnPropertyValueChange(_.XMFZRYJ, _XMFZRYJ, value);
                this._XMFZRYJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XMJSFZR
        {
            get { return _XMJSFZR; }
            set
            {
                this.OnPropertyValueChange(_.XMJSFZR, _XMJSFZR, value);
                this._XMJSFZR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PBWYHCY
        {
            get { return _PBWYHCY; }
            set
            {
                this.OnPropertyValueChange(_.PBWYHCY, _PBWYHCY, value);
                this._PBWYHCY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BEIZHU
        {
            get { return _BEIZHU; }
            set
            {
                this.OnPropertyValueChange(_.BEIZHU, _BEIZHU, value);
                this._BEIZHU = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_CODE
        {
            get { return _PROJECT_CODE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECT_CODE, _PROJECT_CODE, value);
                this._PROJECT_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TENDER_PROJECT_CODE
        {
            get { return _TENDER_PROJECT_CODE; }
            set
            {
                this.OnPropertyValueChange(_.TENDER_PROJECT_CODE, _TENDER_PROJECT_CODE, value);
                this._TENDER_PROJECT_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TENDER_PROJECT_NAME
        {
            get { return _TENDER_PROJECT_NAME; }
            set
            {
                this.OnPropertyValueChange(_.TENDER_PROJECT_NAME, _TENDER_PROJECT_NAME, value);
                this._TENDER_PROJECT_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TENDER_PROJECT_TYPE
        {
            get { return _TENDER_PROJECT_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.TENDER_PROJECT_TYPE, _TENDER_PROJECT_TYPE, value);
                this._TENDER_PROJECT_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZBXMLX
        {
            get { return _ZBXMLX; }
            set
            {
                this.OnPropertyValueChange(_.ZBXMLX, _ZBXMLX, value);
                this._ZBXMLX = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TENDER_PROJECT_CLASSIFY_CODE
        {
            get { return _TENDER_PROJECT_CLASSIFY_CODE; }
            set
            {
                this.OnPropertyValueChange(_.TENDER_PROJECT_CLASSIFY_CODE, _TENDER_PROJECT_CLASSIFY_CODE, value);
                this._TENDER_PROJECT_CLASSIFY_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TM
        {
            get { return _TM; }
            set
            {
                this.OnPropertyValueChange(_.TM, _TM, value);
                this._TM = value;
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
            };
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.GCMC,
                _.PROJECT_TYPE,
                _.HYFL,
                _.BABM,
                _.ZJLY,
                _.ZBR,
                _.ZBFW,
                _.ZBDLDW,
                _.TENDER_MODE,
                _.ZBFS,
                _.PBBF,
                _.GCGM,
                _.YSJ,
                _.ZBKZJ,
                _.ZBJ,
                _.YYSJBJ,
                _.YKZJBJ,
                _.DEGQ,
                _.JSGQ,
                _.GQSD,
                _.JLFWQ,
                _.KCSJZQ,
                _.JHQ,
                _.KBRQ,
                _.TBDWGS,
                _.ZBDW,
                _.ZBDWYJ,
                _.ZBDWXYF,
                _.ZJLGCS,
                _.ZJLGCSYJ,
                _.XMFZR,
                _.XMFZRYJ,
                _.XMJSFZR,
                _.PBWYHCY,
                _.BEIZHU,
                _.PROJECT_CODE,
                _.TENDER_PROJECT_CODE,
                _.TENDER_PROJECT_NAME,
                _.TENDER_PROJECT_TYPE,
                _.ZBXMLX,
                _.TENDER_PROJECT_CLASSIFY_CODE,
                _.TM,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GCMC,
                this._PROJECT_TYPE,
                this._HYFL,
                this._BABM,
                this._ZJLY,
                this._ZBR,
                this._ZBFW,
                this._ZBDLDW,
                this._TENDER_MODE,
                this._ZBFS,
                this._PBBF,
                this._GCGM,
                this._YSJ,
                this._ZBKZJ,
                this._ZBJ,
                this._YYSJBJ,
                this._YKZJBJ,
                this._DEGQ,
                this._JSGQ,
                this._GQSD,
                this._JLFWQ,
                this._KCSJZQ,
                this._JHQ,
                this._KBRQ,
                this._TBDWGS,
                this._ZBDW,
                this._ZBDWYJ,
                this._ZBDWXYF,
                this._ZJLGCS,
                this._ZJLGCSYJ,
                this._XMFZR,
                this._XMFZRYJ,
                this._XMJSFZR,
                this._PBWYHCY,
                this._BEIZHU,
                this._PROJECT_CODE,
                this._TENDER_PROJECT_CODE,
                this._TENDER_PROJECT_NAME,
                this._TENDER_PROJECT_TYPE,
                this._ZBXMLX,
                this._TENDER_PROJECT_CLASSIFY_CODE,
                this._TM,
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
            public readonly static Field All = new Field("*", "V_GONGCHENG_TONGJI");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GCMC = new Field("GCMC", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_TYPE = new Field("PROJECT_TYPE", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field HYFL = new Field("HYFL", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BABM = new Field("BABM", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZJLY = new Field("ZJLY", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBR = new Field("ZBR", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBFW = new Field("ZBFW", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBDLDW = new Field("ZBDLDW", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_MODE = new Field("TENDER_MODE", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBFS = new Field("ZBFS", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PBBF = new Field("PBBF", "V_GONGCHENG_TONGJI", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GCGM = new Field("GCGM", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YSJ = new Field("YSJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBKZJ = new Field("ZBKZJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBJ = new Field("ZBJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YYSJBJ = new Field("YYSJBJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field YKZJBJ = new Field("YKZJBJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEGQ = new Field("DEGQ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field JSGQ = new Field("JSGQ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GQSD = new Field("GQSD", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field JLFWQ = new Field("JLFWQ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KCSJZQ = new Field("KCSJZQ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field JHQ = new Field("JHQ", "V_GONGCHENG_TONGJI", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field KBRQ = new Field("KBRQ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TBDWGS = new Field("TBDWGS", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBDW = new Field("ZBDW", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBDWYJ = new Field("ZBDWYJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBDWXYF = new Field("ZBDWXYF", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZJLGCS = new Field("ZJLGCS", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZJLGCSYJ = new Field("ZJLGCSYJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field XMFZR = new Field("XMFZR", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field XMFZRYJ = new Field("XMFZRYJ", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field XMJSFZR = new Field("XMJSFZR", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PBWYHCY = new Field("PBWYHCY", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BEIZHU = new Field("BEIZHU", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECT_CODE = new Field("PROJECT_CODE", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CODE = new Field("TENDER_PROJECT_CODE", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_NAME = new Field("TENDER_PROJECT_NAME", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_TYPE = new Field("TENDER_PROJECT_TYPE", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ZBXMLX = new Field("ZBXMLX", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TENDER_PROJECT_CLASSIFY_CODE = new Field("TENDER_PROJECT_CLASSIFY_CODE", "V_GONGCHENG_TONGJI", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TM = new Field("TM", "V_GONGCHENG_TONGJI", "");
        }
        #endregion
    }
}