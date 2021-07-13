using System;
using GGZYJD.DbEntity;

namespace GGZY.Services.Infrastructure.Model.JianDu
{
    public class ProjectSupervisionResponseJwModel
    {
        private string _TYPE_TEXT;
        public string ID { get; set; }
        public DateTime? TM { get; set; }

        public string CODE { get; set; }
        public string NAME { get; set; }

        public string TYPE { get; set; }

        public string TYPE_TEXT
        {
            get => _TYPE_TEXT;
            set => _TYPE_TEXT = value;
        }

        //public string MODULE_TYPE { get; set; }
    }
}