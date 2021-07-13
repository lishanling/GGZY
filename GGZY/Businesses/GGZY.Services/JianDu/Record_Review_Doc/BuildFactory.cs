using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.JianDu.Record_Review_Doc
{
    public class BuildFactory
    {
        public static BuildDoc CreateRep(string OPButtType, string ReviewType, int RECORD_ID)
        {
            BuildDoc RepData = null;           
            switch (OPButtType)
            {
                case "2":
                case "3":
                case "8":
                    RepData = new ReplaceQSD(RECORD_ID, ReviewType);
                    break;
                case "5":
                case "6":
                    RepData = new ReplaceZGD(RECORD_ID, ReviewType);
                    break;
                case "9":
                    RepData = new ReplaceYJZGS(RECORD_ID, ReviewType);
                    break;
            }
            return RepData;
        }


        public static ZJ_BuildDoc ZJ_CreateRep(string OPButtType, string ReviewType, int RECORD_ID, string Version)
        {
            ZJ_BuildDoc RepData = null;
            switch (OPButtType)
            {
                case "2":
                case "3":
                case "8":
                    RepData = new ZJ_ReplaceQSD(RECORD_ID, ReviewType, Version);
                    break;
                case "5":
                case "6":
                case "9":
                    RepData = new ZJ_ReplaceZGD(RECORD_ID, ReviewType, Version);
                    break;
            }
            return RepData;
        }
    }
}