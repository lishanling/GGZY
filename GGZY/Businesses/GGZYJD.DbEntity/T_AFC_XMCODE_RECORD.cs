using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_XMCODE_RECORD。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("T_AFC_XMCODE_RECORD")]
    [Serializable]
    public partial class T_AFC_XMCODE_RECORD : JdEntity
    {
        #region Model
        private string _GUID;
        private DateTime? _SYNCTIME;
        private string _APPROVALSTAGESTATE;
        private string _BUILTAREA;
        private string _BUILTAREASPECIFIED;
        private string _CATALOGNAME;
        private string _CATALOGUUID;
        private string _CHANGETYPE;
        private string _CIVILINVESTMENT;
        private string _CIVILINVESTMENTSPECIFIED;
        private string _CONSTRUCTIONLICENCENO;
        private string _CONSTRUCTIONLICENCETYPE;
        private string _CONSTRUCTIONNAME;
        private string _CONTRACTNUMBER;
        private DateTime? _CURRENTAPPROVALSTAGETIME;
        private string _CURRENTAPPROVALSTAGETIMESPE;
        private string _DEVICETECHINVESTMENT;
        private string _DEVICETECHINVESTMENTSPECIFIED;
        private string _DIVISIONCODE;
        private string _ENDTIME;
        private string _ENTERPRISETYPE;
        private string _FOREIGNABROADFLAG;
        private string _FUNDSOURCE;
        private string _GETLANDMODE;
        private string _IMPORTDEVICETECHINVESTMENT;
        private string _IMPORTDEVICETECHINVESTMENTSPE;
        private string _INDUSTRY;
        private string _INDUSTRYSTRUCTURE;
        private string _ISADDLANDAREA;
        private string _ISADDLANDAREASPECIFIED;
        private string _ISCENTRALCODE;
        private string _ISCOMPLETEDREGIONAL;
        private string _ISLANDDESIGNPLAN;
        private string _ISPLANNED;
        private string _LANDAREA;
        private string _LANDAREASPECIFIED;
        private string _LANDINCREMENTORNOT;
        private string _LANDINCREMENTORNOTSPECIFIED;
        private string _MAJOR;
        private DateTime? _MODIFYTIME;
        private string _MODIFYTIMESPECIFIED;
        private string _NATURE;
        private string _OPERATEACTION;
        private string _OPERATORNAME;
        private string _OTHERINVESTMENT;
        private string _OTHERINVESTMENTSPECIFIED;
        private string _PARENTPROJECTCODE;
        private string _PARENTSHORTPROREGIONCODE;
        private string _PERIODIZATIONTYPE;
        private string _PLACECODE;
        private string _PLACECODEDETAIL;
        private string _PLACECODEX;
        private string _PLACECODEXSPECIFIED;
        private string _PLACECODEY;
        private string _PLACECODEYSPECIFIED;
        private string _PLACEDETAILADDRESS;
        private string _PROJECTATTRIBUTES;
        private string _PROJECTBTNTYPE;
        private string _PROJECTCLASSIFY;
        private string _PROJECTCODE;
        private DateTime? _PROJECTENDTIME;
        private string _PROJECTENDTIMESPECIFIED;
        private string _PROJECTNAME;
        private string _PROJECTNATURE;
        private string _PROJECTOTHERATTRIBUTES;
        private DateTime? _PROJECTREGISTERTIME;
        private string _PROJECTREGISTERTIMESPECIFIED;
        private string _PROJECTRESPONSIBILITYNAME;
        private DateTime? _PROJECTSTARTTIME;
        private string _PROJECTSTARTTIMESPECIFIED;
        private string _PROJECTTAG;
        private string _PROJECTTYPE;
        private string _PROJECTTYPEGJ;
        private string _PROPHASEPLAN;
        private string _QUERYMESSAGEUUID;
        private string _RECORDITEM;
        private string _REPORTBUILDINGNUMBER;
        private string _SCALECONTENT;
        private string _SCALELENGTH;
        private string _SCALELENGTHSPECIFIED;
        private string _SCALEWIDTH;
        private string _SCALEWIDTHSPECIFIED;
        private string _SHORTPROJECTREGIONCODE;
        private string _SOURCESYSTEM;
        private string _STARTTIME;
        private string _STATUS;
        private string _SYNRECORD;
        private string _SYNRECORDSPECIFIED;
        private string _THEINDUSTRY;
        private string _TOTALINVESTMENT;
        private string _TOTALINVESTMENTSPECIFIED;
        private string _TOTALMONEYEXPLAIN;
        private string _TZXMPROJECTAGENTINFOBO;
        private string _TZXMPROJECTATTACHMENTS;
        private string _TZXMPROJECTFOREIGNINFOBO;
        private string _TZXMPROJECTLEGALINFOBOS;
        private string _UPGRADEREASON;
        private string _UPGRADESOURCE;
        private string _VERSION;

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
        public DateTime? SYNCTIME
        {
            get { return _SYNCTIME; }
            set
            {
                this.OnPropertyValueChange(_.SYNCTIME, _SYNCTIME, value);
                this._SYNCTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string APPROVALSTAGESTATE
        {
            get { return _APPROVALSTAGESTATE; }
            set
            {
                this.OnPropertyValueChange(_.APPROVALSTAGESTATE, _APPROVALSTAGESTATE, value);
                this._APPROVALSTAGESTATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BUILTAREA
        {
            get { return _BUILTAREA; }
            set
            {
                this.OnPropertyValueChange(_.BUILTAREA, _BUILTAREA, value);
                this._BUILTAREA = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BUILTAREASPECIFIED
        {
            get { return _BUILTAREASPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.BUILTAREASPECIFIED, _BUILTAREASPECIFIED, value);
                this._BUILTAREASPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CATALOGNAME
        {
            get { return _CATALOGNAME; }
            set
            {
                this.OnPropertyValueChange(_.CATALOGNAME, _CATALOGNAME, value);
                this._CATALOGNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CATALOGUUID
        {
            get { return _CATALOGUUID; }
            set
            {
                this.OnPropertyValueChange(_.CATALOGUUID, _CATALOGUUID, value);
                this._CATALOGUUID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHANGETYPE
        {
            get { return _CHANGETYPE; }
            set
            {
                this.OnPropertyValueChange(_.CHANGETYPE, _CHANGETYPE, value);
                this._CHANGETYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CIVILINVESTMENT
        {
            get { return _CIVILINVESTMENT; }
            set
            {
                this.OnPropertyValueChange(_.CIVILINVESTMENT, _CIVILINVESTMENT, value);
                this._CIVILINVESTMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CIVILINVESTMENTSPECIFIED
        {
            get { return _CIVILINVESTMENTSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.CIVILINVESTMENTSPECIFIED, _CIVILINVESTMENTSPECIFIED, value);
                this._CIVILINVESTMENTSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONSTRUCTIONLICENCENO
        {
            get { return _CONSTRUCTIONLICENCENO; }
            set
            {
                this.OnPropertyValueChange(_.CONSTRUCTIONLICENCENO, _CONSTRUCTIONLICENCENO, value);
                this._CONSTRUCTIONLICENCENO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONSTRUCTIONLICENCETYPE
        {
            get { return _CONSTRUCTIONLICENCETYPE; }
            set
            {
                this.OnPropertyValueChange(_.CONSTRUCTIONLICENCETYPE, _CONSTRUCTIONLICENCETYPE, value);
                this._CONSTRUCTIONLICENCETYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONSTRUCTIONNAME
        {
            get { return _CONSTRUCTIONNAME; }
            set
            {
                this.OnPropertyValueChange(_.CONSTRUCTIONNAME, _CONSTRUCTIONNAME, value);
                this._CONSTRUCTIONNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CONTRACTNUMBER
        {
            get { return _CONTRACTNUMBER; }
            set
            {
                this.OnPropertyValueChange(_.CONTRACTNUMBER, _CONTRACTNUMBER, value);
                this._CONTRACTNUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CURRENTAPPROVALSTAGETIME
        {
            get { return _CURRENTAPPROVALSTAGETIME; }
            set
            {
                this.OnPropertyValueChange(_.CURRENTAPPROVALSTAGETIME, _CURRENTAPPROVALSTAGETIME, value);
                this._CURRENTAPPROVALSTAGETIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CURRENTAPPROVALSTAGETIMESPE
        {
            get { return _CURRENTAPPROVALSTAGETIMESPE; }
            set
            {
                this.OnPropertyValueChange(_.CURRENTAPPROVALSTAGETIMESPE, _CURRENTAPPROVALSTAGETIMESPE, value);
                this._CURRENTAPPROVALSTAGETIMESPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DEVICETECHINVESTMENT
        {
            get { return _DEVICETECHINVESTMENT; }
            set
            {
                this.OnPropertyValueChange(_.DEVICETECHINVESTMENT, _DEVICETECHINVESTMENT, value);
                this._DEVICETECHINVESTMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DEVICETECHINVESTMENTSPECIFIED
        {
            get { return _DEVICETECHINVESTMENTSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.DEVICETECHINVESTMENTSPECIFIED, _DEVICETECHINVESTMENTSPECIFIED, value);
                this._DEVICETECHINVESTMENTSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DIVISIONCODE
        {
            get { return _DIVISIONCODE; }
            set
            {
                this.OnPropertyValueChange(_.DIVISIONCODE, _DIVISIONCODE, value);
                this._DIVISIONCODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENDTIME
        {
            get { return _ENDTIME; }
            set
            {
                this.OnPropertyValueChange(_.ENDTIME, _ENDTIME, value);
                this._ENDTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ENTERPRISETYPE
        {
            get { return _ENTERPRISETYPE; }
            set
            {
                this.OnPropertyValueChange(_.ENTERPRISETYPE, _ENTERPRISETYPE, value);
                this._ENTERPRISETYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FOREIGNABROADFLAG
        {
            get { return _FOREIGNABROADFLAG; }
            set
            {
                this.OnPropertyValueChange(_.FOREIGNABROADFLAG, _FOREIGNABROADFLAG, value);
                this._FOREIGNABROADFLAG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FUNDSOURCE
        {
            get { return _FUNDSOURCE; }
            set
            {
                this.OnPropertyValueChange(_.FUNDSOURCE, _FUNDSOURCE, value);
                this._FUNDSOURCE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GETLANDMODE
        {
            get { return _GETLANDMODE; }
            set
            {
                this.OnPropertyValueChange(_.GETLANDMODE, _GETLANDMODE, value);
                this._GETLANDMODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IMPORTDEVICETECHINVESTMENT
        {
            get { return _IMPORTDEVICETECHINVESTMENT; }
            set
            {
                this.OnPropertyValueChange(_.IMPORTDEVICETECHINVESTMENT, _IMPORTDEVICETECHINVESTMENT, value);
                this._IMPORTDEVICETECHINVESTMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IMPORTDEVICETECHINVESTMENTSPE
        {
            get { return _IMPORTDEVICETECHINVESTMENTSPE; }
            set
            {
                this.OnPropertyValueChange(_.IMPORTDEVICETECHINVESTMENTSPE, _IMPORTDEVICETECHINVESTMENTSPE, value);
                this._IMPORTDEVICETECHINVESTMENTSPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INDUSTRY
        {
            get { return _INDUSTRY; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRY, _INDUSTRY, value);
                this._INDUSTRY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INDUSTRYSTRUCTURE
        {
            get { return _INDUSTRYSTRUCTURE; }
            set
            {
                this.OnPropertyValueChange(_.INDUSTRYSTRUCTURE, _INDUSTRYSTRUCTURE, value);
                this._INDUSTRYSTRUCTURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ISADDLANDAREA
        {
            get { return _ISADDLANDAREA; }
            set
            {
                this.OnPropertyValueChange(_.ISADDLANDAREA, _ISADDLANDAREA, value);
                this._ISADDLANDAREA = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ISADDLANDAREASPECIFIED
        {
            get { return _ISADDLANDAREASPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.ISADDLANDAREASPECIFIED, _ISADDLANDAREASPECIFIED, value);
                this._ISADDLANDAREASPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ISCENTRALCODE
        {
            get { return _ISCENTRALCODE; }
            set
            {
                this.OnPropertyValueChange(_.ISCENTRALCODE, _ISCENTRALCODE, value);
                this._ISCENTRALCODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ISCOMPLETEDREGIONAL
        {
            get { return _ISCOMPLETEDREGIONAL; }
            set
            {
                this.OnPropertyValueChange(_.ISCOMPLETEDREGIONAL, _ISCOMPLETEDREGIONAL, value);
                this._ISCOMPLETEDREGIONAL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ISLANDDESIGNPLAN
        {
            get { return _ISLANDDESIGNPLAN; }
            set
            {
                this.OnPropertyValueChange(_.ISLANDDESIGNPLAN, _ISLANDDESIGNPLAN, value);
                this._ISLANDDESIGNPLAN = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ISPLANNED
        {
            get { return _ISPLANNED; }
            set
            {
                this.OnPropertyValueChange(_.ISPLANNED, _ISPLANNED, value);
                this._ISPLANNED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LANDAREA
        {
            get { return _LANDAREA; }
            set
            {
                this.OnPropertyValueChange(_.LANDAREA, _LANDAREA, value);
                this._LANDAREA = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LANDAREASPECIFIED
        {
            get { return _LANDAREASPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.LANDAREASPECIFIED, _LANDAREASPECIFIED, value);
                this._LANDAREASPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LANDINCREMENTORNOT
        {
            get { return _LANDINCREMENTORNOT; }
            set
            {
                this.OnPropertyValueChange(_.LANDINCREMENTORNOT, _LANDINCREMENTORNOT, value);
                this._LANDINCREMENTORNOT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LANDINCREMENTORNOTSPECIFIED
        {
            get { return _LANDINCREMENTORNOTSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.LANDINCREMENTORNOTSPECIFIED, _LANDINCREMENTORNOTSPECIFIED, value);
                this._LANDINCREMENTORNOTSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MAJOR
        {
            get { return _MAJOR; }
            set
            {
                this.OnPropertyValueChange(_.MAJOR, _MAJOR, value);
                this._MAJOR = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? MODIFYTIME
        {
            get { return _MODIFYTIME; }
            set
            {
                this.OnPropertyValueChange(_.MODIFYTIME, _MODIFYTIME, value);
                this._MODIFYTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MODIFYTIMESPECIFIED
        {
            get { return _MODIFYTIMESPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.MODIFYTIMESPECIFIED, _MODIFYTIMESPECIFIED, value);
                this._MODIFYTIMESPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NATURE
        {
            get { return _NATURE; }
            set
            {
                this.OnPropertyValueChange(_.NATURE, _NATURE, value);
                this._NATURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OPERATEACTION
        {
            get { return _OPERATEACTION; }
            set
            {
                this.OnPropertyValueChange(_.OPERATEACTION, _OPERATEACTION, value);
                this._OPERATEACTION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OPERATORNAME
        {
            get { return _OPERATORNAME; }
            set
            {
                this.OnPropertyValueChange(_.OPERATORNAME, _OPERATORNAME, value);
                this._OPERATORNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OTHERINVESTMENT
        {
            get { return _OTHERINVESTMENT; }
            set
            {
                this.OnPropertyValueChange(_.OTHERINVESTMENT, _OTHERINVESTMENT, value);
                this._OTHERINVESTMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OTHERINVESTMENTSPECIFIED
        {
            get { return _OTHERINVESTMENTSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.OTHERINVESTMENTSPECIFIED, _OTHERINVESTMENTSPECIFIED, value);
                this._OTHERINVESTMENTSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PARENTPROJECTCODE
        {
            get { return _PARENTPROJECTCODE; }
            set
            {
                this.OnPropertyValueChange(_.PARENTPROJECTCODE, _PARENTPROJECTCODE, value);
                this._PARENTPROJECTCODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PARENTSHORTPROREGIONCODE
        {
            get { return _PARENTSHORTPROREGIONCODE; }
            set
            {
                this.OnPropertyValueChange(_.PARENTSHORTPROREGIONCODE, _PARENTSHORTPROREGIONCODE, value);
                this._PARENTSHORTPROREGIONCODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PERIODIZATIONTYPE
        {
            get { return _PERIODIZATIONTYPE; }
            set
            {
                this.OnPropertyValueChange(_.PERIODIZATIONTYPE, _PERIODIZATIONTYPE, value);
                this._PERIODIZATIONTYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACECODE
        {
            get { return _PLACECODE; }
            set
            {
                this.OnPropertyValueChange(_.PLACECODE, _PLACECODE, value);
                this._PLACECODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACECODEDETAIL
        {
            get { return _PLACECODEDETAIL; }
            set
            {
                this.OnPropertyValueChange(_.PLACECODEDETAIL, _PLACECODEDETAIL, value);
                this._PLACECODEDETAIL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACECODEX
        {
            get { return _PLACECODEX; }
            set
            {
                this.OnPropertyValueChange(_.PLACECODEX, _PLACECODEX, value);
                this._PLACECODEX = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACECODEXSPECIFIED
        {
            get { return _PLACECODEXSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.PLACECODEXSPECIFIED, _PLACECODEXSPECIFIED, value);
                this._PLACECODEXSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACECODEY
        {
            get { return _PLACECODEY; }
            set
            {
                this.OnPropertyValueChange(_.PLACECODEY, _PLACECODEY, value);
                this._PLACECODEY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACECODEYSPECIFIED
        {
            get { return _PLACECODEYSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.PLACECODEYSPECIFIED, _PLACECODEYSPECIFIED, value);
                this._PLACECODEYSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PLACEDETAILADDRESS
        {
            get { return _PLACEDETAILADDRESS; }
            set
            {
                this.OnPropertyValueChange(_.PLACEDETAILADDRESS, _PLACEDETAILADDRESS, value);
                this._PLACEDETAILADDRESS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTATTRIBUTES
        {
            get { return _PROJECTATTRIBUTES; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTATTRIBUTES, _PROJECTATTRIBUTES, value);
                this._PROJECTATTRIBUTES = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTBTNTYPE
        {
            get { return _PROJECTBTNTYPE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTBTNTYPE, _PROJECTBTNTYPE, value);
                this._PROJECTBTNTYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTCLASSIFY
        {
            get { return _PROJECTCLASSIFY; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTCLASSIFY, _PROJECTCLASSIFY, value);
                this._PROJECTCLASSIFY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTCODE
        {
            get { return _PROJECTCODE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTCODE, _PROJECTCODE, value);
                this._PROJECTCODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PROJECTENDTIME
        {
            get { return _PROJECTENDTIME; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTENDTIME, _PROJECTENDTIME, value);
                this._PROJECTENDTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTENDTIMESPECIFIED
        {
            get { return _PROJECTENDTIMESPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTENDTIMESPECIFIED, _PROJECTENDTIMESPECIFIED, value);
                this._PROJECTENDTIMESPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTNAME
        {
            get { return _PROJECTNAME; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTNAME, _PROJECTNAME, value);
                this._PROJECTNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTNATURE
        {
            get { return _PROJECTNATURE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTNATURE, _PROJECTNATURE, value);
                this._PROJECTNATURE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTOTHERATTRIBUTES
        {
            get { return _PROJECTOTHERATTRIBUTES; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTOTHERATTRIBUTES, _PROJECTOTHERATTRIBUTES, value);
                this._PROJECTOTHERATTRIBUTES = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PROJECTREGISTERTIME
        {
            get { return _PROJECTREGISTERTIME; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTREGISTERTIME, _PROJECTREGISTERTIME, value);
                this._PROJECTREGISTERTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTREGISTERTIMESPECIFIED
        {
            get { return _PROJECTREGISTERTIMESPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTREGISTERTIMESPECIFIED, _PROJECTREGISTERTIMESPECIFIED, value);
                this._PROJECTREGISTERTIMESPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTRESPONSIBILITYNAME
        {
            get { return _PROJECTRESPONSIBILITYNAME; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTRESPONSIBILITYNAME, _PROJECTRESPONSIBILITYNAME, value);
                this._PROJECTRESPONSIBILITYNAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PROJECTSTARTTIME
        {
            get { return _PROJECTSTARTTIME; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTSTARTTIME, _PROJECTSTARTTIME, value);
                this._PROJECTSTARTTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTSTARTTIMESPECIFIED
        {
            get { return _PROJECTSTARTTIMESPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTSTARTTIMESPECIFIED, _PROJECTSTARTTIMESPECIFIED, value);
                this._PROJECTSTARTTIMESPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTTAG
        {
            get { return _PROJECTTAG; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTTAG, _PROJECTTAG, value);
                this._PROJECTTAG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTTYPE
        {
            get { return _PROJECTTYPE; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTTYPE, _PROJECTTYPE, value);
                this._PROJECTTYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTTYPEGJ
        {
            get { return _PROJECTTYPEGJ; }
            set
            {
                this.OnPropertyValueChange(_.PROJECTTYPEGJ, _PROJECTTYPEGJ, value);
                this._PROJECTTYPEGJ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROPHASEPLAN
        {
            get { return _PROPHASEPLAN; }
            set
            {
                this.OnPropertyValueChange(_.PROPHASEPLAN, _PROPHASEPLAN, value);
                this._PROPHASEPLAN = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QUERYMESSAGEUUID
        {
            get { return _QUERYMESSAGEUUID; }
            set
            {
                this.OnPropertyValueChange(_.QUERYMESSAGEUUID, _QUERYMESSAGEUUID, value);
                this._QUERYMESSAGEUUID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RECORDITEM
        {
            get { return _RECORDITEM; }
            set
            {
                this.OnPropertyValueChange(_.RECORDITEM, _RECORDITEM, value);
                this._RECORDITEM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REPORTBUILDINGNUMBER
        {
            get { return _REPORTBUILDINGNUMBER; }
            set
            {
                this.OnPropertyValueChange(_.REPORTBUILDINGNUMBER, _REPORTBUILDINGNUMBER, value);
                this._REPORTBUILDINGNUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SCALECONTENT
        {
            get { return _SCALECONTENT; }
            set
            {
                this.OnPropertyValueChange(_.SCALECONTENT, _SCALECONTENT, value);
                this._SCALECONTENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SCALELENGTH
        {
            get { return _SCALELENGTH; }
            set
            {
                this.OnPropertyValueChange(_.SCALELENGTH, _SCALELENGTH, value);
                this._SCALELENGTH = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SCALELENGTHSPECIFIED
        {
            get { return _SCALELENGTHSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.SCALELENGTHSPECIFIED, _SCALELENGTHSPECIFIED, value);
                this._SCALELENGTHSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SCALEWIDTH
        {
            get { return _SCALEWIDTH; }
            set
            {
                this.OnPropertyValueChange(_.SCALEWIDTH, _SCALEWIDTH, value);
                this._SCALEWIDTH = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SCALEWIDTHSPECIFIED
        {
            get { return _SCALEWIDTHSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.SCALEWIDTHSPECIFIED, _SCALEWIDTHSPECIFIED, value);
                this._SCALEWIDTHSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SHORTPROJECTREGIONCODE
        {
            get { return _SHORTPROJECTREGIONCODE; }
            set
            {
                this.OnPropertyValueChange(_.SHORTPROJECTREGIONCODE, _SHORTPROJECTREGIONCODE, value);
                this._SHORTPROJECTREGIONCODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SOURCESYSTEM
        {
            get { return _SOURCESYSTEM; }
            set
            {
                this.OnPropertyValueChange(_.SOURCESYSTEM, _SOURCESYSTEM, value);
                this._SOURCESYSTEM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STARTTIME
        {
            get { return _STARTTIME; }
            set
            {
                this.OnPropertyValueChange(_.STARTTIME, _STARTTIME, value);
                this._STARTTIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STATUS
        {
            get { return _STATUS; }
            set
            {
                this.OnPropertyValueChange(_.STATUS, _STATUS, value);
                this._STATUS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SYNRECORD
        {
            get { return _SYNRECORD; }
            set
            {
                this.OnPropertyValueChange(_.SYNRECORD, _SYNRECORD, value);
                this._SYNRECORD = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SYNRECORDSPECIFIED
        {
            get { return _SYNRECORDSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.SYNRECORDSPECIFIED, _SYNRECORDSPECIFIED, value);
                this._SYNRECORDSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string THEINDUSTRY
        {
            get { return _THEINDUSTRY; }
            set
            {
                this.OnPropertyValueChange(_.THEINDUSTRY, _THEINDUSTRY, value);
                this._THEINDUSTRY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TOTALINVESTMENT
        {
            get { return _TOTALINVESTMENT; }
            set
            {
                this.OnPropertyValueChange(_.TOTALINVESTMENT, _TOTALINVESTMENT, value);
                this._TOTALINVESTMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TOTALINVESTMENTSPECIFIED
        {
            get { return _TOTALINVESTMENTSPECIFIED; }
            set
            {
                this.OnPropertyValueChange(_.TOTALINVESTMENTSPECIFIED, _TOTALINVESTMENTSPECIFIED, value);
                this._TOTALINVESTMENTSPECIFIED = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TOTALMONEYEXPLAIN
        {
            get { return _TOTALMONEYEXPLAIN; }
            set
            {
                this.OnPropertyValueChange(_.TOTALMONEYEXPLAIN, _TOTALMONEYEXPLAIN, value);
                this._TOTALMONEYEXPLAIN = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TZXMPROJECTAGENTINFOBO
        {
            get { return _TZXMPROJECTAGENTINFOBO; }
            set
            {
                this.OnPropertyValueChange(_.TZXMPROJECTAGENTINFOBO, _TZXMPROJECTAGENTINFOBO, value);
                this._TZXMPROJECTAGENTINFOBO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TZXMPROJECTATTACHMENTS
        {
            get { return _TZXMPROJECTATTACHMENTS; }
            set
            {
                this.OnPropertyValueChange(_.TZXMPROJECTATTACHMENTS, _TZXMPROJECTATTACHMENTS, value);
                this._TZXMPROJECTATTACHMENTS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TZXMPROJECTFOREIGNINFOBO
        {
            get { return _TZXMPROJECTFOREIGNINFOBO; }
            set
            {
                this.OnPropertyValueChange(_.TZXMPROJECTFOREIGNINFOBO, _TZXMPROJECTFOREIGNINFOBO, value);
                this._TZXMPROJECTFOREIGNINFOBO = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TZXMPROJECTLEGALINFOBOS
        {
            get { return _TZXMPROJECTLEGALINFOBOS; }
            set
            {
                this.OnPropertyValueChange(_.TZXMPROJECTLEGALINFOBOS, _TZXMPROJECTLEGALINFOBOS, value);
                this._TZXMPROJECTLEGALINFOBOS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UPGRADEREASON
        {
            get { return _UPGRADEREASON; }
            set
            {
                this.OnPropertyValueChange(_.UPGRADEREASON, _UPGRADEREASON, value);
                this._UPGRADEREASON = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UPGRADESOURCE
        {
            get { return _UPGRADESOURCE; }
            set
            {
                this.OnPropertyValueChange(_.UPGRADESOURCE, _UPGRADESOURCE, value);
                this._UPGRADESOURCE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VERSION
        {
            get { return _VERSION; }
            set
            {
                this.OnPropertyValueChange(_.VERSION, _VERSION, value);
                this._VERSION = value;
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
                _.SYNCTIME,
                _.APPROVALSTAGESTATE,
                _.BUILTAREA,
                _.BUILTAREASPECIFIED,
                _.CATALOGNAME,
                _.CATALOGUUID,
                _.CHANGETYPE,
                _.CIVILINVESTMENT,
                _.CIVILINVESTMENTSPECIFIED,
                _.CONSTRUCTIONLICENCENO,
                _.CONSTRUCTIONLICENCETYPE,
                _.CONSTRUCTIONNAME,
                _.CONTRACTNUMBER,
                _.CURRENTAPPROVALSTAGETIME,
                _.CURRENTAPPROVALSTAGETIMESPE,
                _.DEVICETECHINVESTMENT,
                _.DEVICETECHINVESTMENTSPECIFIED,
                _.DIVISIONCODE,
                _.ENDTIME,
                _.ENTERPRISETYPE,
                _.FOREIGNABROADFLAG,
                _.FUNDSOURCE,
                _.GETLANDMODE,
                _.IMPORTDEVICETECHINVESTMENT,
                _.IMPORTDEVICETECHINVESTMENTSPE,
                _.INDUSTRY,
                _.INDUSTRYSTRUCTURE,
                _.ISADDLANDAREA,
                _.ISADDLANDAREASPECIFIED,
                _.ISCENTRALCODE,
                _.ISCOMPLETEDREGIONAL,
                _.ISLANDDESIGNPLAN,
                _.ISPLANNED,
                _.LANDAREA,
                _.LANDAREASPECIFIED,
                _.LANDINCREMENTORNOT,
                _.LANDINCREMENTORNOTSPECIFIED,
                _.MAJOR,
                _.MODIFYTIME,
                _.MODIFYTIMESPECIFIED,
                _.NATURE,
                _.OPERATEACTION,
                _.OPERATORNAME,
                _.OTHERINVESTMENT,
                _.OTHERINVESTMENTSPECIFIED,
                _.PARENTPROJECTCODE,
                _.PARENTSHORTPROREGIONCODE,
                _.PERIODIZATIONTYPE,
                _.PLACECODE,
                _.PLACECODEDETAIL,
                _.PLACECODEX,
                _.PLACECODEXSPECIFIED,
                _.PLACECODEY,
                _.PLACECODEYSPECIFIED,
                _.PLACEDETAILADDRESS,
                _.PROJECTATTRIBUTES,
                _.PROJECTBTNTYPE,
                _.PROJECTCLASSIFY,
                _.PROJECTCODE,
                _.PROJECTENDTIME,
                _.PROJECTENDTIMESPECIFIED,
                _.PROJECTNAME,
                _.PROJECTNATURE,
                _.PROJECTOTHERATTRIBUTES,
                _.PROJECTREGISTERTIME,
                _.PROJECTREGISTERTIMESPECIFIED,
                _.PROJECTRESPONSIBILITYNAME,
                _.PROJECTSTARTTIME,
                _.PROJECTSTARTTIMESPECIFIED,
                _.PROJECTTAG,
                _.PROJECTTYPE,
                _.PROJECTTYPEGJ,
                _.PROPHASEPLAN,
                _.QUERYMESSAGEUUID,
                _.RECORDITEM,
                _.REPORTBUILDINGNUMBER,
                _.SCALECONTENT,
                _.SCALELENGTH,
                _.SCALELENGTHSPECIFIED,
                _.SCALEWIDTH,
                _.SCALEWIDTHSPECIFIED,
                _.SHORTPROJECTREGIONCODE,
                _.SOURCESYSTEM,
                _.STARTTIME,
                _.STATUS,
                _.SYNRECORD,
                _.SYNRECORDSPECIFIED,
                _.THEINDUSTRY,
                _.TOTALINVESTMENT,
                _.TOTALINVESTMENTSPECIFIED,
                _.TOTALMONEYEXPLAIN,
                _.TZXMPROJECTAGENTINFOBO,
                _.TZXMPROJECTATTACHMENTS,
                _.TZXMPROJECTFOREIGNINFOBO,
                _.TZXMPROJECTLEGALINFOBOS,
                _.UPGRADEREASON,
                _.UPGRADESOURCE,
                _.VERSION,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GUID,
                this._SYNCTIME,
                this._APPROVALSTAGESTATE,
                this._BUILTAREA,
                this._BUILTAREASPECIFIED,
                this._CATALOGNAME,
                this._CATALOGUUID,
                this._CHANGETYPE,
                this._CIVILINVESTMENT,
                this._CIVILINVESTMENTSPECIFIED,
                this._CONSTRUCTIONLICENCENO,
                this._CONSTRUCTIONLICENCETYPE,
                this._CONSTRUCTIONNAME,
                this._CONTRACTNUMBER,
                this._CURRENTAPPROVALSTAGETIME,
                this._CURRENTAPPROVALSTAGETIMESPE,
                this._DEVICETECHINVESTMENT,
                this._DEVICETECHINVESTMENTSPECIFIED,
                this._DIVISIONCODE,
                this._ENDTIME,
                this._ENTERPRISETYPE,
                this._FOREIGNABROADFLAG,
                this._FUNDSOURCE,
                this._GETLANDMODE,
                this._IMPORTDEVICETECHINVESTMENT,
                this._IMPORTDEVICETECHINVESTMENTSPE,
                this._INDUSTRY,
                this._INDUSTRYSTRUCTURE,
                this._ISADDLANDAREA,
                this._ISADDLANDAREASPECIFIED,
                this._ISCENTRALCODE,
                this._ISCOMPLETEDREGIONAL,
                this._ISLANDDESIGNPLAN,
                this._ISPLANNED,
                this._LANDAREA,
                this._LANDAREASPECIFIED,
                this._LANDINCREMENTORNOT,
                this._LANDINCREMENTORNOTSPECIFIED,
                this._MAJOR,
                this._MODIFYTIME,
                this._MODIFYTIMESPECIFIED,
                this._NATURE,
                this._OPERATEACTION,
                this._OPERATORNAME,
                this._OTHERINVESTMENT,
                this._OTHERINVESTMENTSPECIFIED,
                this._PARENTPROJECTCODE,
                this._PARENTSHORTPROREGIONCODE,
                this._PERIODIZATIONTYPE,
                this._PLACECODE,
                this._PLACECODEDETAIL,
                this._PLACECODEX,
                this._PLACECODEXSPECIFIED,
                this._PLACECODEY,
                this._PLACECODEYSPECIFIED,
                this._PLACEDETAILADDRESS,
                this._PROJECTATTRIBUTES,
                this._PROJECTBTNTYPE,
                this._PROJECTCLASSIFY,
                this._PROJECTCODE,
                this._PROJECTENDTIME,
                this._PROJECTENDTIMESPECIFIED,
                this._PROJECTNAME,
                this._PROJECTNATURE,
                this._PROJECTOTHERATTRIBUTES,
                this._PROJECTREGISTERTIME,
                this._PROJECTREGISTERTIMESPECIFIED,
                this._PROJECTRESPONSIBILITYNAME,
                this._PROJECTSTARTTIME,
                this._PROJECTSTARTTIMESPECIFIED,
                this._PROJECTTAG,
                this._PROJECTTYPE,
                this._PROJECTTYPEGJ,
                this._PROPHASEPLAN,
                this._QUERYMESSAGEUUID,
                this._RECORDITEM,
                this._REPORTBUILDINGNUMBER,
                this._SCALECONTENT,
                this._SCALELENGTH,
                this._SCALELENGTHSPECIFIED,
                this._SCALEWIDTH,
                this._SCALEWIDTHSPECIFIED,
                this._SHORTPROJECTREGIONCODE,
                this._SOURCESYSTEM,
                this._STARTTIME,
                this._STATUS,
                this._SYNRECORD,
                this._SYNRECORDSPECIFIED,
                this._THEINDUSTRY,
                this._TOTALINVESTMENT,
                this._TOTALINVESTMENTSPECIFIED,
                this._TOTALMONEYEXPLAIN,
                this._TZXMPROJECTAGENTINFOBO,
                this._TZXMPROJECTATTACHMENTS,
                this._TZXMPROJECTFOREIGNINFOBO,
                this._TZXMPROJECTLEGALINFOBOS,
                this._UPGRADEREASON,
                this._UPGRADESOURCE,
                this._VERSION,
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
            public readonly static Field All = new Field("*", "T_AFC_XMCODE_RECORD");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GUID = new Field("GUID", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYNCTIME = new Field("SYNCTIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field APPROVALSTAGESTATE = new Field("APPROVALSTAGESTATE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUILTAREA = new Field("BUILTAREA", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BUILTAREASPECIFIED = new Field("BUILTAREASPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CATALOGNAME = new Field("CATALOGNAME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CATALOGUUID = new Field("CATALOGUUID", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CHANGETYPE = new Field("CHANGETYPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CIVILINVESTMENT = new Field("CIVILINVESTMENT", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CIVILINVESTMENTSPECIFIED = new Field("CIVILINVESTMENTSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONSTRUCTIONLICENCENO = new Field("CONSTRUCTIONLICENCENO", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONSTRUCTIONLICENCETYPE = new Field("CONSTRUCTIONLICENCETYPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONSTRUCTIONNAME = new Field("CONSTRUCTIONNAME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CONTRACTNUMBER = new Field("CONTRACTNUMBER", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CURRENTAPPROVALSTAGETIME = new Field("CURRENTAPPROVALSTAGETIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CURRENTAPPROVALSTAGETIMESPE = new Field("CURRENTAPPROVALSTAGETIMESPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEVICETECHINVESTMENT = new Field("DEVICETECHINVESTMENT", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DEVICETECHINVESTMENTSPECIFIED = new Field("DEVICETECHINVESTMENTSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DIVISIONCODE = new Field("DIVISIONCODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENDTIME = new Field("ENDTIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTERPRISETYPE = new Field("ENTERPRISETYPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FOREIGNABROADFLAG = new Field("FOREIGNABROADFLAG", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FUNDSOURCE = new Field("FUNDSOURCE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GETLANDMODE = new Field("GETLANDMODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IMPORTDEVICETECHINVESTMENT = new Field("IMPORTDEVICETECHINVESTMENT", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IMPORTDEVICETECHINVESTMENTSPE = new Field("IMPORTDEVICETECHINVESTMENTSPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRY = new Field("INDUSTRY", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field INDUSTRYSTRUCTURE = new Field("INDUSTRYSTRUCTURE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISADDLANDAREA = new Field("ISADDLANDAREA", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISADDLANDAREASPECIFIED = new Field("ISADDLANDAREASPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISCENTRALCODE = new Field("ISCENTRALCODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISCOMPLETEDREGIONAL = new Field("ISCOMPLETEDREGIONAL", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISLANDDESIGNPLAN = new Field("ISLANDDESIGNPLAN", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ISPLANNED = new Field("ISPLANNED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LANDAREA = new Field("LANDAREA", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LANDAREASPECIFIED = new Field("LANDAREASPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LANDINCREMENTORNOT = new Field("LANDINCREMENTORNOT", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field LANDINCREMENTORNOTSPECIFIED = new Field("LANDINCREMENTORNOTSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MAJOR = new Field("MAJOR", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MODIFYTIME = new Field("MODIFYTIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MODIFYTIMESPECIFIED = new Field("MODIFYTIMESPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field NATURE = new Field("NATURE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPERATEACTION = new Field("OPERATEACTION", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OPERATORNAME = new Field("OPERATORNAME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OTHERINVESTMENT = new Field("OTHERINVESTMENT", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OTHERINVESTMENTSPECIFIED = new Field("OTHERINVESTMENTSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PARENTPROJECTCODE = new Field("PARENTPROJECTCODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PARENTSHORTPROREGIONCODE = new Field("PARENTSHORTPROREGIONCODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PERIODIZATIONTYPE = new Field("PERIODIZATIONTYPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACECODE = new Field("PLACECODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACECODEDETAIL = new Field("PLACECODEDETAIL", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACECODEX = new Field("PLACECODEX", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACECODEXSPECIFIED = new Field("PLACECODEXSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACECODEY = new Field("PLACECODEY", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACECODEYSPECIFIED = new Field("PLACECODEYSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PLACEDETAILADDRESS = new Field("PLACEDETAILADDRESS", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTATTRIBUTES = new Field("PROJECTATTRIBUTES", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTBTNTYPE = new Field("PROJECTBTNTYPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTCLASSIFY = new Field("PROJECTCLASSIFY", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTCODE = new Field("PROJECTCODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTENDTIME = new Field("PROJECTENDTIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTENDTIMESPECIFIED = new Field("PROJECTENDTIMESPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTNAME = new Field("PROJECTNAME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTNATURE = new Field("PROJECTNATURE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTOTHERATTRIBUTES = new Field("PROJECTOTHERATTRIBUTES", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTREGISTERTIME = new Field("PROJECTREGISTERTIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTREGISTERTIMESPECIFIED = new Field("PROJECTREGISTERTIMESPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTRESPONSIBILITYNAME = new Field("PROJECTRESPONSIBILITYNAME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTSTARTTIME = new Field("PROJECTSTARTTIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTSTARTTIMESPECIFIED = new Field("PROJECTSTARTTIMESPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTTAG = new Field("PROJECTTAG", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTTYPE = new Field("PROJECTTYPE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROJECTTYPEGJ = new Field("PROJECTTYPEGJ", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROPHASEPLAN = new Field("PROPHASEPLAN", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field QUERYMESSAGEUUID = new Field("QUERYMESSAGEUUID", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RECORDITEM = new Field("RECORDITEM", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field REPORTBUILDINGNUMBER = new Field("REPORTBUILDINGNUMBER", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCALECONTENT = new Field("SCALECONTENT", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCALELENGTH = new Field("SCALELENGTH", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCALELENGTHSPECIFIED = new Field("SCALELENGTHSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCALEWIDTH = new Field("SCALEWIDTH", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SCALEWIDTHSPECIFIED = new Field("SCALEWIDTHSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SHORTPROJECTREGIONCODE = new Field("SHORTPROJECTREGIONCODE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SOURCESYSTEM = new Field("SOURCESYSTEM", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STARTTIME = new Field("STARTTIME", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field STATUS = new Field("STATUS", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYNRECORD = new Field("SYNRECORD", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SYNRECORDSPECIFIED = new Field("SYNRECORDSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field THEINDUSTRY = new Field("THEINDUSTRY", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTALINVESTMENT = new Field("TOTALINVESTMENT", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTALINVESTMENTSPECIFIED = new Field("TOTALINVESTMENTSPECIFIED", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TOTALMONEYEXPLAIN = new Field("TOTALMONEYEXPLAIN", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TZXMPROJECTAGENTINFOBO = new Field("TZXMPROJECTAGENTINFOBO", "T_AFC_XMCODE_RECORD", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TZXMPROJECTATTACHMENTS = new Field("TZXMPROJECTATTACHMENTS", "T_AFC_XMCODE_RECORD", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TZXMPROJECTFOREIGNINFOBO = new Field("TZXMPROJECTFOREIGNINFOBO", "T_AFC_XMCODE_RECORD", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TZXMPROJECTLEGALINFOBOS = new Field("TZXMPROJECTLEGALINFOBOS", "T_AFC_XMCODE_RECORD", DbType.AnsiString, null, "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPGRADEREASON = new Field("UPGRADEREASON", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UPGRADESOURCE = new Field("UPGRADESOURCE", "T_AFC_XMCODE_RECORD", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field VERSION = new Field("VERSION", "T_AFC_XMCODE_RECORD", "");
        }
        #endregion
    }
}