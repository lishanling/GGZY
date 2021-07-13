using Dos.ORM;
using GGZY.Services.Base;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services
{
    public class GlobalDataService
    {

        /// <summary>
        /// 构造函数必须是私有的
        /// 这样在外部便无法使用 new 来创建该类的实例
        /// </summary>
        private GlobalDataService()
        { }

        private static readonly Lazy<GlobalDataService> Linstance = new Lazy<GlobalDataService>(() => { return new GlobalDataService(); });

        public static GlobalDataService Instance { get { return Linstance.Value; } }

        static Dictionary<string, string> _Centers = null;
        protected object oLock = new object();
        /// <summary>
        /// AREA_CODE/CENTER_NAME字典表
        /// </summary>
        public Dictionary<string, string> Centers
        {
            get
            {
                if (null == _Centers)
                {
                    lock (oLock)
                    {
                        _Centers = new Dictionary<string, string>();
                        var result = ServicesFactory.GGZYJD.TradeCenterService.ListAll();
                        if (result.Success)
                        {
                            var str = Newtonsoft.Json.JsonConvert.SerializeObject(result.Data);
                            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(str);
                            list.ForEach(e =>
                            {
                                if (!_Centers.ContainsKey(e["AREA_CODE"]))
                                {
                                    _Centers.Add(e["AREA_CODE"], e["CENTER_NAME"]);
                                }
                            });
                        }
                    }
                }
                return _Centers;
            }
        }
        private Dictionary<string, string> _DIC_Trade_INFO;
        /// <summary>
        /// SYSTEM_NO/AREA_CODE 字典表
        /// </summary>
        public Dictionary<string, string> DIC_Trade_INFO

        {
            get
            {
                if (null == _DIC_Trade_INFO || _DIC_Trade_INFO.Count ==0)
                {
                    lock (oLock)
                    {
                        _DIC_Trade_INFO = new Dictionary<string, string>();
                        var list = ServicesFactory.GGZYJD.TradeCenterService.FindList(new GGZYJD.DbEntity.TRADE_CENTER());
                        if (list.Any())
                        {
                            list.Where(w => null != w.SYSTEM_NO && !String.IsNullOrEmpty(w.SYSTEM_NO)).ToList().ForEach(e =>
                             {
                                 _DIC_Trade_INFO.Add(e.SYSTEM_NO, e.AREA_CODE);
                             });
                        }
                    }
                }
                return _DIC_Trade_INFO;
            }
        }
        List<GGZYJD.DbEntity.TRADE_CENTER> _CenterList;
        /// <summary>
        /// TRADE_CENTER 数组
        /// </summary>
        public List<GGZYJD.DbEntity.TRADE_CENTER> CenterList
        {
            get
            {
                if (null == _CenterList || _CenterList.Count ==0)
                {
                    lock (oLock)
                    {
                        _CenterList = ServicesFactory.GGZYJD.TradeCenterService.FindList(new GGZYJD.DbEntity.TRADE_CENTER());
                    }
                }
                return _CenterList;
            }
        }
    }
}
