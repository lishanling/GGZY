using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Extensions
{
    public static  class DbEntityExtension
    {
        /// <summary>
        /// 合同备案-更新客户端提交过来的允许编辑的数据
        /// </summary>
        /// <param name="model">数据库读取出来的模型</param>
        /// <param name="doc">客户端提交的模型</param>
        public static void Update(this RECORD_CONTRACT model,RECORD_CONTRACT doc)
        {
            if (null == doc)
            {
                throw new Exception("源模型数据不能为null");
            }
            model.BID_AMOUNT = doc.BID_AMOUNT;
            model.BID_AMOUNT_CURRENCY = doc.BID_AMOUNT_CURRENCY;
            model.BID_AMOUNT_UNIT = doc.BID_AMOUNT_UNIT;
            model.CONTRACT_AMOUNT = doc.CONTRACT_AMOUNT;
            model.CONTRACT_AMOUNT_CURRENCY = doc.CONTRACT_AMOUNT_CURRENCY;
            model.CONTRACT_AMOUNT_UNIT = doc.CONTRACT_AMOUNT_UNIT;
            model.CONTRACT_TIME = doc.CONTRACT_TIME;
            model.PARTY_A = doc.PARTY_A;
            model.PARTY_A_CODE = doc.PARTY_A_CODE;
            model.PARTY_B = doc.PARTY_B;
            model.PARTY_B_CODE = doc.PARTY_B_CODE;
            model.WIN_NOTICE_TIME = doc.WIN_NOTICE_TIME;
        }
        
        /// <summary>
        /// 招标文件备案-更新客户端提交过来的允许编辑的数据
        /// </summary>
        /// <param name="model">数据库读取出来的模型</param>
        /// <param name="doc">客户端提交的模型</param>
        public static void Update(this RECORD_BIDDOC_NORMAL model, RECORD_BIDDOC_NORMAL doc)
        {
            if (null == doc)
            {
                throw new Exception("源模型数据不能为null");
            }
            model.TENDER_DOC_GET_TIME = doc.TENDER_DOC_GET_TIME;
            model.DOC_GET_END_TIME = doc.DOC_GET_END_TIME;
            model.BID_DOC_REFER_END_TIME = doc.BID_DOC_REFER_END_TIME;
            model.BID_OPEN_TIME = doc.BID_OPEN_TIME;
            model.DOC_PRICE = doc.DOC_PRICE;
            model.DOC_PRICE_CURRENCY = doc.DOC_PRICE_CURRENCY;
            model.DOC_PRICE_UNIT = doc.DOC_PRICE_UNIT;
            model.SYNDICATED_FLAG = doc.SYNDICATED_FLAG;
            model.SYNDICATED_REQUIRE = doc.SYNDICATED_REQUIRE;
            model.SIMILAR_PROJECT_BASIC = doc.SIMILAR_PROJECT_BASIC;
            model.BID_QUALIFICATION = doc.BID_QUALIFICATION;
            model.VALID_PERIOD = doc.VALID_PERIOD;
            model.BID_DOC_REFER_METHOD = doc.BID_DOC_REFER_METHOD;
            model.MARGIN_PAY_TYPE = doc.MARGIN_PAY_TYPE;
            model.MARGIN_AMOUNT = doc.MARGIN_AMOUNT;
            model.MARGIN_UNIT = doc.MARGIN_UNIT;
            model.MARGIN_CURRENCY_CODE = doc.MARGIN_CURRENCY_CODE;
            model.CONTROL_PRICE = doc.CONTROL_PRICE;
            model.CONTROL_UNIT = doc.CONTROL_UNIT;
            model.CONTROL_CURRENCY_CODE = doc.CONTROL_CURRENCY_CODE;
            model.EVALUATING_METHOD = doc.EVALUATING_METHOD;
            model.BID_OPEN_PLACE = doc.BID_OPEN_PLACE;
            model.CLARIFY_TIME = doc.CLARIFY_TIME;
            model.TENDER_NOTICE = doc.TENDER_NOTICE;
            model.QUAL_TYPE = doc.QUAL_TYPE;
        }
        
        /// <summary>
        /// 澄清修改备案-更新客户端提交过来的允许编辑的数据
        /// </summary>
        /// <param name="model">数据库读取出来的模型</param>
        /// <param name="doc">客户端提交的模型</param>
        public static void Update(this RECORD_CLASSIFY_NORMAL model, RECORD_CLASSIFY_NORMAL doc)
        {
            if(null == doc)
            {
                throw new Exception("源模型数据不能为null");
            }
            model.TENDER_DOC_GET_TIME = doc.TENDER_DOC_GET_TIME;
            model.DOC_GET_END_TIME = doc.DOC_GET_END_TIME;
            model.BID_DOC_REFER_END_TIME = doc.BID_DOC_REFER_END_TIME;
            model.BID_OPEN_TIME = doc.BID_OPEN_TIME;
            model.DOC_PRICE = doc.DOC_PRICE;
            model.DOC_PRICE_CURRENCY = doc.DOC_PRICE_CURRENCY;
            model.DOC_PRICE_UNIT = doc.DOC_PRICE_UNIT;
            model.SYNDICATED_FLAG = doc.SYNDICATED_FLAG;
            model.SYNDICATED_REQUIRE = doc.SYNDICATED_REQUIRE;
            model.SIMILAR_PROJECT_BASIC = doc.SIMILAR_PROJECT_BASIC;
            model.BID_QUALIFICATION = doc.BID_QUALIFICATION;
            model.VALID_PERIOD = doc.VALID_PERIOD;
            model.BID_DOC_REFER_METHOD = doc.BID_DOC_REFER_METHOD;
            model.MARGIN_PAY_TYPE = doc.MARGIN_PAY_TYPE;
            model.MARGIN_AMOUNT = doc.MARGIN_AMOUNT;
            model.MARGIN_UNIT = doc.MARGIN_UNIT;
            model.MARGIN_CURRENCY_CODE = doc.MARGIN_CURRENCY_CODE;
            model.CONTROL_PRICE = doc.CONTROL_PRICE;
            model.CONTROL_UNIT = doc.CONTROL_UNIT;
            model.CONTROL_CURRENCY_CODE = doc.CONTROL_CURRENCY_CODE;
            model.EVALUATING_METHOD = doc.EVALUATING_METHOD;
            model.BID_OPEN_PLACE = doc.BID_OPEN_PLACE;
            model.CLARIFY_TIME = doc.CLARIFY_TIME;
            model.TENDER_NOTICE = doc.TENDER_NOTICE;
            model.QUAL_TYPE = doc.QUAL_TYPE;
            model.IS_POSTPONE = doc.IS_POSTPONE;
            model.DEADLINE_BIDDING2 = doc.DEADLINE_BIDDING2;
            model.POST_OPEN_TIME = doc.POST_OPEN_TIME;
            model.POST_OPEN_ADDRESS = doc.POST_OPEN_ADDRESS;
            model.CLARIFY_END_TIME = doc.CLARIFY_END_TIME;
            model.DEPOSIT_END_TIME = doc.DEPOSIT_END_TIME;
            model.CLARIFY_TITLE = doc.CLARIFY_TITLE;
            model.CLARIFY_CONTENT = doc.CLARIFY_CONTENT;
        }


        /// <summary>
        /// 住建澄清修改备案-更新客户端提交过来的允许编辑的数据
        /// </summary>
        /// <param name="model">数据库读取出来的模型</param>
        /// <param name="doc">客户端提交的模型</param>
        public static void Update(this RECORD_CLASSIFY model, RECORD_CLASSIFY doc)
        {
            if (null == doc)
            {
                throw new Exception("源模型数据不能为null");
            }
           
            model.TENDER_TYPE = doc.TENDER_TYPE;
            model.CONTROL_PRICE = doc.CONTROL_PRICE;
            model.CONTROL_UNIT = doc.CONTROL_UNIT;
            model.CONTROL_CURRENCY_CODE = doc.CONTROL_CURRENCY_CODE;
            model.TENDER_CONTENT = doc.TENDER_CONTENT;
            model.ENTERPRISE_QUALIFI_BASIC = doc.ENTERPRISE_QUALIFI_BASIC;
            model.REGISTER_CON_BASIC = doc.REGISTER_CON_BASIC;
            model.SIMILAR_PROJECT_BASIC = doc.SIMILAR_PROJECT_BASIC;
            model.ALL_LIMITE_TIME = doc.ALL_LIMITE_TIME;
            model.QUOTA_LIMIT_TIME = doc.QUOTA_LIMIT_TIME;
            model.BIDDER_QUALIFI_REQUIRE = doc.BIDDER_QUALIFI_REQUIRE;
            model.REGISTER_CON_REQUIRE = doc.REGISTER_CON_REQUIRE;
            model.SYNDICATED_FLAG = doc.SYNDICATED_FLAG;
            model.IS_COMPREHENSIVE_SCORE = doc.IS_COMPREHENSIVE_SCORE;
            model.TYPE_PERFORM_REQUIRE = doc.TYPE_PERFORM_REQUIRE;
            model.MARGIN_AMOUNT = doc.MARGIN_AMOUNT;
            model.MARGIN_UNIT = doc.MARGIN_UNIT;
            model.MARGIN_CURRENCY_CODE = doc.MARGIN_CURRENCY_CODE;
            model.TENDER_DOC_GET_METHOD = doc.TENDER_DOC_GET_METHOD;
            model.DOC_GET_START_TIME = doc.DOC_GET_START_TIME;
            model.DOC_GET_END_TIME = doc.DOC_GET_END_TIME;
            model.BID_DOC_REFER_END_TIME = doc.BID_DOC_REFER_END_TIME;
            model.BID_DOC_REFER_METHOD = doc.BID_DOC_REFER_METHOD;
            model.TENDER_NOTICE = doc.TENDER_NOTICE;
            model.DEADLINE_BIDDING = doc.DEADLINE_BIDDING;
            model.BID_OPEN_TIME = doc.BID_OPEN_TIME;
            model.PERFORM_PRICE = doc.PERFORM_PRICE;
            model.CONTRACT_SIGN_TIME = doc.CONTRACT_SIGN_TIME;
            model.ALL_EXPERT_NUM = doc.ALL_EXPERT_NUM;
            model.EXPERT_NUM = doc.EXPERT_NUM;
            model.EVALUATING_METHOD = doc.EVALUATING_METHOD;
            model.SCOPE_CONTRACT_RISK = doc.SCOPE_CONTRACT_RISK;
            model.CONTRACT_PRICE = doc.CONTRACT_PRICE;
            model.ADVANCE_CHARGE = doc.ADVANCE_CHARGE;
            model.PERCENT_PROGERESS = doc.PERCENT_PROGERESS;
            model.DEFECT_LIABILITY_PERIOD = doc.DEFECT_LIABILITY_PERIOD;
            model.QUALITY_MARGIN_AMOUNT = doc.QUALITY_MARGIN_AMOUNT;
            model.IS_POSTPONE = doc.IS_POSTPONE;
            model.DEADLINE_BIDDING2 = doc.DEADLINE_BIDDING2;
            model.POST_OPEN_TIME = doc.POST_OPEN_TIME;
            model.POST_OPEN_ADDRESS = doc.POST_OPEN_ADDRESS;
            model.CLARIFY_TITLE = doc.CLARIFY_TITLE;
            model.CLARIFY_CONTENT = doc.CLARIFY_CONTENT;
            model.CLARIFY_END_TIME = doc.CLARIFY_END_TIME;
            model.DEPOSIT_END_TIME = doc.DEPOSIT_END_TIME;
            model.QUANTITIES_DRAW_UNIT = doc.QUANTITIES_DRAW_UNIT;
            model.QUANTITIES_AUDIT_UNIT = doc.QUANTITIES_AUDIT_UNIT;
            model.CONTROL_PRICE_DRAW_UNIT = doc.CONTROL_PRICE_DRAW_UNIT;
            model.CONTROL_PRICE_AUDIT_UNIT = doc.CONTROL_PRICE_AUDIT_UNIT;
            model.PERFORM_UNIT = doc.PERFORM_UNIT;
            model.PERFORM_CURRENCY_CODE = doc.PERFORM_CURRENCY_CODE;

        }


        /// <summary>
        /// 异议处理结果备案-更新客户端提交过来的允许编辑的数据
        /// </summary>
        /// <param name="model">数据库读取出来的模型</param>
        /// <param name="doc">客户端提交的模型</param>
        public static void Update(this RECORD_HANDLE_RESULT model, RECORD_HANDLE_RESULT doc)
        {
            model.BID_SECTION_CODES = doc.BID_SECTION_CODES;
            model.DISSENT_CODE = doc.DISSENT_CODE;
            model.DISSENT_NAME = doc.DISSENT_NAME;
            model.DISSENT_CONTRACT = doc.DISSENT_CONTRACT;
            model.COMPLAINED_NAME = doc.COMPLAINED_NAME;
            model.COMPLAINED_CODE = doc.COMPLAINED_CODE;
            model.COMPLAINED_TYPE = doc.COMPLAINED_TYPE;
            model.COMPLAINED_CONTRACT = doc.COMPLAINED_CONTRACT;
            model.DISSENT_COMMIT_TIME = doc.DISSENT_COMMIT_TIME;
            model.DISSENT_TYPE = doc.DISSENT_TYPE;
            model.DISSENT_CONTENT = doc.DISSENT_CONTENT;
            model.GROUND_REASON = doc.GROUND_REASON;
            model.IS_ACCEPT_TIME = doc.IS_ACCEPT_TIME;
            model.DISSENT_OPINION = doc.DISSENT_OPINION;
            model.HANDLE_RESULT = doc.HANDLE_RESULT;
            model.HANDLE_BASIS = doc.HANDLE_BASIS;
            model.HANDLE_TIME = doc.HANDLE_TIME;
        }
        /// <summary>
        /// 招标文件备案(住建)-更新客户端提交过来的允许编辑的数据
        /// </summary>
        /// <param name="model">数据库读取出来的模型</param>
        /// <param name="doc">客户端提交的模型</param>
        public static void Update(this RECORD_RESIDENTIAL_BIDDOC model, RECORD_RESIDENTIAL_BIDDOC doc)
        {
            model.TENDER_TYPE = doc.TENDER_TYPE;
            model.CONTROL_PRICE = doc.CONTROL_PRICE;
            model.CONTROL_UNIT = doc.CONTROL_UNIT;
            model.CONTROL_CURRENCY_CODE = doc.CONTROL_CURRENCY_CODE;
            model.TENDER_CONTENT = doc.TENDER_CONTENT;
            model.ENTERPRISE_QUALIFI_BASIC = doc.ENTERPRISE_QUALIFI_BASIC;
            model.REGISTER_CON_BASIC = doc.REGISTER_CON_BASIC;
            model.SIMILAR_PROJECT_BASIC = doc.SIMILAR_PROJECT_BASIC;
            model.ALL_LIMITE_TIME = doc.ALL_LIMITE_TIME;
            model.QUOTA_LIMIT_TIME = doc.QUOTA_LIMIT_TIME;
            model.BIDDER_QUALIFI_REQUIRE = doc.BIDDER_QUALIFI_REQUIRE;
            model.REGISTER_CON_REQUIRE = doc.REGISTER_CON_REQUIRE;
            model.SYNDICATED_FLAG = doc.SYNDICATED_FLAG;
            model.IS_COMPREHENSIVE_SCORE = doc.IS_COMPREHENSIVE_SCORE;
            model.TYPE_PERFORM_REQUIRE = doc.TYPE_PERFORM_REQUIRE;
            model.MARGIN_AMOUNT = doc.MARGIN_AMOUNT;
            model.MARGIN_UNIT = doc.MARGIN_UNIT;
            model.MARGIN_CURRENCY_CODE = doc.MARGIN_CURRENCY_CODE;
            model.TENDER_DOC_GET_METHOD = doc.TENDER_DOC_GET_METHOD;
            model.DOC_GET_START_TIME = doc.DOC_GET_START_TIME;
            model.DOC_GET_END_TIME = doc.DOC_GET_END_TIME;
            model.BID_DOC_REFER_END_TIME = doc.BID_DOC_REFER_END_TIME;
            model.BID_DOC_REFER_METHOD = doc.BID_DOC_REFER_METHOD;
            model.TENDER_NOTICE = doc.TENDER_NOTICE;
            model.DEADLINE_BIDDING = doc.DEADLINE_BIDDING;
            model.BID_OPEN_TIME = doc.BID_OPEN_TIME;
            model.PERFORM_PRICE = doc.PERFORM_PRICE;
            model.CONTRACT_SIGN_TIME = doc.CONTRACT_SIGN_TIME;
            model.ALL_EXPERT_NUM = doc.ALL_EXPERT_NUM;
            model.EXPERT_NUM = doc.EXPERT_NUM;
            model.EVALUATING_METHOD = doc.EVALUATING_METHOD;
            model.SCOPE_CONTRACT_RISK = doc.SCOPE_CONTRACT_RISK;
            model.CONTRACT_PRICE = doc.CONTRACT_PRICE;
            model.ADVANCE_CHARGE = doc.ADVANCE_CHARGE;
            model.PERCENT_PROGERESS = doc.PERCENT_PROGERESS;
            model.DEFECT_LIABILITY_PERIOD = doc.DEFECT_LIABILITY_PERIOD;
            model.QUALITY_MARGIN_AMOUNT = doc.QUALITY_MARGIN_AMOUNT;
            model.TENDER_DOCNAME = doc.TENDER_DOCNAME;
            model.QUANTITIES_DRAW_UNIT = doc.QUANTITIES_DRAW_UNIT;
            model.QUANTITIES_AUDIT_UNIT = doc.QUANTITIES_AUDIT_UNIT;
            model.CONTROL_PRICE_DRAW_UNIT = doc.CONTROL_PRICE_DRAW_UNIT;
            model.CONTROL_PRICE_AUDIT_UNIT = doc.CONTROL_PRICE_AUDIT_UNIT;
            model.PERFORM_UNIT = doc.PERFORM_UNIT;
            model.PERFORM_CURRENCY_CODE = doc.PERFORM_CURRENCY_CODE;

        }
    }
}
