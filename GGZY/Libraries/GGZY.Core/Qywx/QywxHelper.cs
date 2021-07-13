using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Extensions;
using GGZY.Core.Utils;
using Newtonsoft.Json;

namespace GGZY.Core.Qywx
{
    public class QywxHelper
    {
        private string _user { get; set; }
        private string _content { get; set; }
        /// <summary>
        /// 企业微信帮助类
        /// </summary>
        /// <param name="user">用户列表</param>
        /// <param name="content">内容</param>
        public QywxHelper(string content, string user = "")
        {
            _user = string.IsNullOrWhiteSpace(user) ? "ysf|wei" : user;
            _content = content;
        }

        public bool Send()
        {
            string token = GetToken();
            string url = "https://qyapi.weixin.qq.com/cgi-bin/message/send?access_token=" + token;

            Dictionary<string, object> ht = new Dictionary<string, object>();
            ht["touser"] = _user;
            ht["toparty"] = "";
            ht["totag"] = "";
            ht["msgtype"] = "text";
            ht["agentid"] = "1000003";

            Hashtable htcontent = new Hashtable();
            htcontent["content"] = _content;
            ht["text"] = htcontent;

            ht["safe"] = "0";

            WebUtils wu = new WebUtils();
            string res = wu.DoPost(url, ht.Serializer());
            Hashtable htRes = JsonConvert.DeserializeObject<Hashtable>(res);
            string errmsg = htRes["errmsg"].ToString();

            if (errmsg.ToUpper() == "OK")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GetToken()
        {
            string url = "https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid=ww47ef09ffa77d670e&corpsecret=GiVlAv7Tegt9B0CgxbXNNgA2ivr99hT5_cTcuWUeYMg";
            WebUtils wu = new WebUtils();
            string res = wu.DoPost(url, new Dictionary<string, string>());
            Hashtable htRes = JsonConvert.DeserializeObject<Hashtable>(res);
            return htRes["access_token"].ToString();
        }
    }
}
