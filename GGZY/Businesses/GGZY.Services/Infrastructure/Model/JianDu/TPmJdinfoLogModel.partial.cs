namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public partial class TPmJdinfoLogModel
    {
        private string _U_ID_TEXT;

        public string LEVEL_TYPE_OLD_TEXT
        {
            get
            {
                var txt = "无";
                switch (LEVEL_TYPE_OLD)
                {
                    case "1":
                        txt = "绿灯";
                        break;
                    case "2":
                        txt = "黄灯";
                        break;
                    case "3":
                        txt = "红灯";
                        break;
                }
                return txt;
            }
        }

        public string LEVEL_TYPE_TEXT
        {
            get
            {
                var txt = "无";
                switch (LEVEL_TYPE)
                {
                    case "1":
                        txt = "绿灯";
                        break;
                    case "2":
                        txt = "黄灯";
                        break;
                    case "3":
                        txt = "红灯";
                        break;
                }
                return txt;
            }
        }

        public string U_ID_NAME
        {
            get
            {
                if (U_ID=="-1")
                {
                    _U_ID_TEXT = "系统";
                }
                return _U_ID_TEXT;
            }
            set => _U_ID_TEXT = value;
        }
    }
}