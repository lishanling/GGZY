using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Linq;
using GGZY.Services.BigData;
using GGZY.Services.DZBH;
using GGZY.Services.FuWu;
using GGZY.Services.Violation;

namespace GGZY.Services.Base
{
    public partial class ServicesFactoryFw
    {

        #region 属性

        public virtual UnifyAppService UnifyAppService { get; set; }
        public virtual UnifyAuthsService UnifyAuthsService { get; set; }
        public virtual UnifyUserService UnifyUserService { get; set; }
        public virtual AdminSuperItemInfoService AdminSuperItemInfoService { get; set; }
        public virtual AgencyAprInfoService AgencyAprInfoService { get; set; }
        public virtual AgencyQaTableService AgencyQaTableService { get; set; }
        public virtual AhwhBszxService AhwhBszxService { get; set; }
        public virtual AhwhDocumentService AhwhDocumentService { get; set; }
        public virtual AhwhGzlyService AhwhGzlyService { get; set; }
        public virtual AhwhNewsService AhwhNewsService { get; set; }
        public virtual AhwhXzfwService AhwhXzfwService { get; set; }
        public virtual AnomalyInfoService AnomalyInfoService { get; set; }
        public virtual AssigneeExInfoService AssigneeExInfoService { get; set; }
        public virtual AwardInfoService AwardInfoService { get; set; }
        public virtual BhGuaranteeResultService BhGuaranteeResultService { get; set; }
        public virtual BhJiekouUserService BhJiekouUserService { get; set; }
        public virtual BhSendApplicationFormService BhSendApplicationFormService { get; set; }
        public virtual BhSendClaimFormService BhSendClaimFormService { get; set; }
        public virtual BidDealAnnounceService BidDealAnnounceService { get; set; }
        public virtual BidDocCharactCodeService BidDocCharactCodeService { get; set; }
        public virtual BiderExInfoService BiderExInfoService { get; set; }
        public virtual BidEvaluationExpertDelService BidEvaluationExpertDelService { get; set; }
        public virtual BidEvaluationExpertService BidEvaluationExpertService { get; set; }
        public virtual BidOpeningRecordService BidOpeningRecordService { get; set; }
        public virtual BidViolationService BidViolationService { get; set; }
        public virtual BidWorkControlService BidWorkControlService { get; set; }
        public virtual BidZjrjCodeService BidZjrjCodeService { get; set; }
        public virtual BlackListService BlackListService { get; set; }
        public virtual CaImgService CaImgService { get; set; }
        public virtual CainfoService CainfoService { get; set; }
        public virtual CalcSqlService CalcSqlService { get; set; }
        public virtual CompareSelectAnnService CompareSelectAnnService { get; set; }
        public virtual CompareSelectResultService CompareSelectResultService { get; set; }
        public virtual ComplaintInfoService ComplaintInfoService { get; set; }
        public virtual ContractPerformanceService ContractPerformanceService { get; set; }
        public virtual CorrectionItemService CorrectionItemService { get; set; }
        public virtual CreditAssessmentService CreditAssessmentService { get; set; }
        public virtual CreditAttachmentsService CreditAttachmentsService { get; set; }
        public virtual DataAnalyseService DataAnalyseService { get; set; }
        public virtual DbSystemService DbSystemService { get; set; }
        public virtual DeaCarbonQuotaSellAnnoService DeaCarbonQuotaSellAnnoService { get; set; }
        public virtual DeaCarbonQuotaSellResultService DeaCarbonQuotaSellResultService { get; set; }
        public virtual DealBehaviorInfoService DealBehaviorInfoService { get; set; }
        public virtual DealLandInfoService DealLandInfoService { get; set; }
        public virtual DeaMediChangeAnnoService DeaMediChangeAnnoService { get; set; }
        public virtual DeaMediFixedPurchaseAnnoService DeaMediFixedPurchaseAnnoService { get; set; }
        public virtual DeaMediFixedPurchaseDetailService DeaMediFixedPurchaseDetailService { get; set; }
        public virtual DeaMediFixedPurchaseListService DeaMediFixedPurchaseListService { get; set; }
        public virtual DeaMediNegoPurchaseAnnoService DeaMediNegoPurchaseAnnoService { get; set; }
        public virtual DeaMediNegoPurchaseDetailService DeaMediNegoPurchaseDetailService { get; set; }
        public virtual DeaMediNegoPurchaseListService DeaMediNegoPurchaseListService { get; set; }
        public virtual DeaMediNetPurchaseAnnoService DeaMediNetPurchaseAnnoService { get; set; }
        public virtual DeaMediNetPurchaseDetailService DeaMediNetPurchaseDetailService { get; set; }
        public virtual DeaMediNetPurchaseListService DeaMediNetPurchaseListService { get; set; }
        public virtual DeaMediOtherPurchaseAnnoService DeaMediOtherPurchaseAnnoService { get; set; }
        public virtual DeaMediPurchaseOrderService DeaMediPurchaseOrderService { get; set; }
        public virtual DeaMediTenderAnnoService DeaMediTenderAnnoService { get; set; }
        public virtual DeaMediTenderDetailService DeaMediTenderDetailService { get; set; }
        public virtual DeaMediTenderListService DeaMediTenderListService { get; set; }
        public virtual DeaMediWinBidAnnoService DeaMediWinBidAnnoService { get; set; }
        public virtual DeaMediWinBidDetailService DeaMediWinBidDetailService { get; set; }
        public virtual DeaMediWinBidListService DeaMediWinBidListService { get; set; }
        public virtual DeaSewageAssigneeListService DeaSewageAssigneeListService { get; set; }
        public virtual DeaSewagePaidTransferAnnoService DeaSewagePaidTransferAnnoService { get; set; }
        public virtual DeaSewagePaidTransferResService DeaSewagePaidTransferResService { get; set; }
        public virtual DsjAreaService DsjAreaService { get; set; }
        public virtual EcaPcaxService EcaPcaxService { get; set; }
        public virtual EnterCredtiInfoService EnterCredtiInfoService { get; set; }
        public virtual EvaluationReportService EvaluationReportService { get; set; }
        public virtual EvaluationResultsService EvaluationResultsService { get; set; }
        public virtual ExpertBidEvaluationService ExpertBidEvaluationService { get; set; }
        public virtual ExpertCreditRecordService ExpertCreditRecordService { get; set; }
        public virtual ExpertEvaluationService ExpertEvaluationService { get; set; }
        public virtual ExplorBidAuctionTransAnnService ExplorBidAuctionTransAnnService { get; set; }
        public virtual ExplorBidAucTransResAnnService ExplorBidAucTransResAnnService { get; set; }
        public virtual ExplorTransPubInfoService ExplorTransPubInfoService { get; set; }
        public virtual ExTrainAndTestService ExTrainAndTestService { get; set; }
        public virtual ExtServiceAdviceService ExtServiceAdviceService { get; set; }
        public virtual FhhgService FhhgService { get; set; }
        public virtual GetDataLogService GetDataLogService { get; set; }
        public virtual GgfwProductAnalysisService GgfwProductAnalysisService { get; set; }
        public virtual GgfwSService GgfwSService { get; set; }
        public virtual GgfwStudentService GgfwStudentService { get; set; }
        public virtual IdentInformationService IdentInformationService { get; set; }
        public virtual IndividualAssigneeExInfoService IndividualAssigneeExInfoService { get; set; }
        public virtual IndividualBaseService IndividualBaseService { get; set; }
        public virtual IndividualBiderExInfoService IndividualBiderExInfoService { get; set; }
        public virtual IndividualSupplierExInfoService IndividualSupplierExInfoService { get; set; }
        public virtual IndividualSuppplierExInfoService IndividualSuppplierExInfoService { get; set; }
        public virtual LegalPersonBaseService LegalPersonBaseService { get; set; }
        public virtual LegalPersonTradePerformService LegalPersonTradePerformService { get; set; }
        public virtual LetterOfGuaranteeService LetterOfGuaranteeService { get; set; }
        public virtual ListingPubInfoPreService ListingPubInfoPreService { get; set; }
        public virtual ListingPubInfoService ListingPubInfoService { get; set; }
        public virtual ListPubInfoService ListPubInfoService { get; set; }
        public virtual LoginLogService LoginLogService { get; set; }
        public virtual LogProcessingService LogProcessingService { get; set; }
        public virtual LogReportService LogReportService { get; set; }
        public virtual MakPerService MakPerService { get; set; }
        public virtual MchgProgMgtService MchgProgMgtService { get; set; }
        public virtual MClobtestService MClobtestService { get; set; }
        public virtual MiningAttachmentsService MiningAttachmentsService { get; set; }
        public virtual MiningBidAuctionTransAnnService MiningBidAuctionTransAnnService { get; set; }
        public virtual MiningBidAucTransResAnnService MiningBidAucTransResAnnService { get; set; }
        public virtual MiningDistrictRangePubService MiningDistrictRangePubService { get; set; }
        public virtual MiningDistrivtRangePubService MiningDistrivtRangePubService { get; set; }
        public virtual MiningTransPubInfoService MiningTransPubInfoService { get; set; }
        public virtual NonOilGasExplorRegAnnService NonOilGasExplorRegAnnService { get; set; }
        public virtual NonOilGasMiningRegAnnService NonOilGasMiningRegAnnService { get; set; }
        public virtual OilGasExplorRegAnnService OilGasExplorRegAnnService { get; set; }
        public virtual OilGasMiningRegAnnService OilGasMiningRegAnnService { get; set; }
        public virtual OtherAbnormityReportService OtherAbnormityReportService { get; set; }
        public virtual OtherTradePubInfoService OtherTradePubInfoService { get; set; }
        public virtual OtherTradeResultInfoService OtherTradeResultInfoService { get; set; }
        public virtual PaymentAuditService PaymentAuditService { get; set; }
        public virtual PaymentManageService PaymentManageService { get; set; }
        public virtual PerformanceInfoService PerformanceInfoService { get; set; }
        public virtual PerformanceService PerformanceService { get; set; }
        public virtual PractitionCredtiInfoService PractitionCredtiInfoService { get; set; }
        public virtual ProductAnalysisService ProductAnalysisService { get; set; }
        public virtual ProductClassifyService ProductClassifyService { get; set; }
        public virtual ProductComponentDataService ProductComponentDataService { get; set; }
        public virtual ProductDataService ProductDataService { get; set; }
        public virtual ProductEqpService ProductEqpService { get; set; }
        public virtual ProductMaterialService ProductMaterialService { get; set; }
        public virtual ProductParameterService ProductParameterService { get; set; }
        public virtual ProductPartTableService ProductPartTableService { get; set; }
        public virtual ProductValueService ProductValueService { get; set; }
        public virtual ProExResultService ProExResultService { get; set; }
        public virtual ProExtDetRecService ProExtDetRecService { get; set; }
        public virtual ProjectAlertingInfoService ProjectAlertingInfoService { get; set; }
        public virtual ProjectAttachmentsService ProjectAttachmentsService { get; set; }
        public virtual ProjectPerformanceService ProjectPerformanceService { get; set; }
        public virtual ProjectService ProjectService { get; set; }
        public virtual ProTpotiotService ProTpotiotService { get; set; }
        public virtual PrtLogService PrtLogService { get; set; }
        public virtual PrtMenuService PrtMenuService { get; set; }
        public virtual PrtRoleMenuService PrtRoleMenuService { get; set; }
        public virtual PrtRoleService PrtRoleService { get; set; }
        public virtual PrtUserService PrtUserService { get; set; }
        public virtual PtArticleService PtArticleService { get; set; }
        public virtual CommonService CommonService { get; set; }
        public virtual PtAtypeService PtAtypeService { get; set; }
        public virtual PtCommentService PtCommentService { get; set; }
        public virtual PtLinkService PtLinkService { get; set; }
        public virtual PtTjBgService PtTjBgService { get; set; }
        public virtual PtTjDataService PtTjDataService { get; set; }
        public virtual PtTjMainService PtTjMainService { get; set; }
        public virtual PtTjTmService PtTjTmService { get; set; }
        public virtual PurchaseAgentExInfoService PurchaseAgentExInfoService { get; set; }
        public virtual PurchaseBiddingRecordService PurchaseBiddingRecordService { get; set; }
        public virtual PurchaseContractService PurchaseContractService { get; set; }
        public virtual PurchaseExInfoService PurchaseExInfoService { get; set; }
        public virtual PurchaseProjectService PurchaseProjectService { get; set; }
        public virtual PurchaseQualiInqueryAnnService PurchaseQualiInqueryAnnService { get; set; }
        public virtual PurchaseTenderListService PurchaseTenderListService { get; set; }
        public virtual QualiInqueryAppFileService QualiInqueryAppFileService { get; set; }
        public virtual QualiInqueryClariService QualiInqueryClariService { get; set; }
        public virtual QualiInqueryResultService QualiInqueryResultService { get; set; }
        public virtual QualiPersonBaseService QualiPersonBaseService { get; set; }
        public virtual QualiPersonPerformeService QualiPersonPerformeService { get; set; }
        public virtual QualiPersonQualiService QualiPersonQualiService { get; set; }
        public virtual SectionService SectionService { get; set; }
        public virtual SltScoreHistoryLogService SltScoreHistoryLogService { get; set; }
        public virtual SltScoreLogService SltScoreLogService { get; set; }
        public virtual SltScoreService SltScoreService { get; set; }
        public virtual SltStaffLogService SltStaffLogService { get; set; }
        public virtual SltStaffService SltStaffService { get; set; }
        public virtual SocialCreditInfoService SocialCreditInfoService { get; set; }
        public virtual StatlSumService StatlSumService { get; set; }
        public virtual StockListingPubInfoPreService StockListingPubInfoPreService { get; set; }
        public virtual StockListingPubInfoService StockListingPubInfoService { get; set; }
        public virtual StockTradeResultInfoService StockTradeResultInfoService { get; set; }
        public virtual StockTradeResultPreService StockTradeResultPreService { get; set; }
        public virtual StPptnRService StPptnRService { get; set; }
        public virtual StRiverRService StRiverRService { get; set; }
        public virtual StRsvrRService StRsvrRService { get; set; }
        public virtual StStbprpBService StStbprpBService { get; set; }
        public virtual StTideRService StTideRService { get; set; }
        public virtual SupervisionAttachmentsService SupervisionAttachmentsService { get; set; }
        public virtual SupplierExInfoService SupplierExInfoService { get; set; }
        public virtual SysAreaQuanguoService SysAreaQuanguoService { get; set; }
        public virtual SysAreaService SysAreaService { get; set; }
        public virtual SysAttachmentService SysAttachmentService { get; set; }
        public virtual SysAuditInfoService SysAuditInfoService { get; set; }
        public virtual SysAuditService SysAuditService { get; set; }
        public virtual SysDepartmentService SysDepartmentService { get; set; }
        public virtual SysDicService SysDicService { get; set; }
        public virtual SysDocumentsService SysDocumentsService { get; set; }
        public virtual SysInfoService SysInfoService { get; set; }
        public virtual SysLogService SysLogService { get; set; }
        public virtual SysMenuService SysMenuService { get; set; }
        public virtual SysPopedomService SysPopedomService { get; set; }
        public virtual SysPublictypeinfoService SysPublictypeinfoService { get; set; }
        public virtual SysSeqService SysSeqService { get; set; }
        public virtual SysTreeService SysTreeService { get; set; }
        public virtual SysUrlService SysUrlService { get; set; }
        public virtual SysUserroleService SysUserroleService { get; set; }
        public virtual SysUserService SysUserService { get; set; }
        public virtual Table1Service Table1Service { get; set; }
        public virtual TableFliedService TableFliedService { get; set; }
        public virtual TAnswerAnnService TAnswerAnnService { get; set; }
        public virtual TAskanswerService TAskanswerService { get; set; }
        public virtual TAttachmentService TAttachmentService { get; set; }
        public virtual TAuditDetailService TAuditDetailService { get; set; }
        public virtual TAuditService TAuditService { get; set; }
        public virtual TBaseTradeCenterService TBaseTradeCenterService { get; set; }
        public virtual TbFavoriteService TbFavoriteService { get; set; }
        public virtual TbParticipateService TbParticipateService { get; set; }
        public virtual TbReplaceService TbReplaceService { get; set; }
        public virtual TbTableconfigService TbTableconfigService { get; set; }
        public virtual TbTablefieldconfigService TbTablefieldconfigService { get; set; }
        public virtual TCaAccessService TCaAccessService { get; set; }
        public virtual TCaPloyService TCaPloyService { get; set; }
        public virtual TCertificateService TCertificateService { get; set; }
        public virtual TcpSystemService TcpSystemService { get; set; }
        public virtual TDownloadlistService TDownloadlistService { get; set; }
        public virtual TEc2AmendbulletinService TEc2AmendbulletinService { get; set; }
        public virtual TEc2BidderinfoService TEc2BidderinfoService { get; set; }
        public virtual TEc2BidinviteService TEc2BidinviteService { get; set; }
        public virtual TEc2BidsectionService TEc2BidsectionService { get; set; }
        public virtual TEc2GoodsopenbidlistService TEc2GoodsopenbidlistService { get; set; }
        public virtual TEc2OpenbidrecordService TEc2OpenbidrecordService { get; set; }
        public virtual TEc2ProjectopenbidlistService TEc2ProjectopenbidlistService { get; set; }
        public virtual TEc2ProjectService TEc2ProjectService { get; set; }
        public virtual TEc2QualifybulletinService TEc2QualifybulletinService { get; set; }
        public virtual TEc2ServiceopenbidlistService TEc2ServiceopenbidlistService { get; set; }
        public virtual TEc2TenderagencyinfoService TEc2TenderagencyinfoService { get; set; }
        public virtual TEc2TenderbulletinService TEc2TenderbulletinService { get; set; }
        public virtual TEc2TendererinfoService TEc2TendererinfoService { get; set; }
        public virtual TEc2TenderprojectService TEc2TenderprojectService { get; set; }
        public virtual TEc2WinbidbulletinService TEc2WinbidbulletinService { get; set; }
        public virtual TEc2WinbidService TEc2WinbidService { get; set; }
        public virtual TEc2WincandidatebulletinService TEc2WincandidatebulletinService { get; set; }
        public virtual TenderAbnormityReportService TenderAbnormityReportService { get; set; }
        public virtual TenderAgentExInfoService TenderAgentExInfoService { get; set; }
        public virtual TenderAnnQuaInqueryAnn1206Service TenderAnnQuaInqueryAnn1206Service { get; set; }
        public virtual TenderAnnQuaInqueryAnnService TenderAnnQuaInqueryAnnService { get; set; }
        public virtual TenderCandidateAnnounceService TenderCandidateAnnounceService { get; set; }
        public virtual TenderCandidateService TenderCandidateService { get; set; }
        public virtual TendererExInfoService TendererExInfoService { get; set; }
        public virtual TenderEvaluationService TenderEvaluationService { get; set; }
        public virtual TenderExInfoService TenderExInfoService { get; set; }
        public virtual TenderFileClariModiService TenderFileClariModiService { get; set; }
        public virtual TenderFlowMarkService TenderFlowMarkService { get; set; }
        public virtual TenderInvitationService TenderInvitationService { get; set; }
        public virtual TenderListService TenderListService { get; set; }
        public virtual TenderProjectDelService TenderProjectDelService { get; set; }
        public virtual TenderProjectGdService TenderProjectGdService { get; set; }
        public virtual TenderProjectService TenderProjectService { get; set; }
        public virtual TestService TestService { get; set; }
        public virtual TestTableService TestTableService { get; set; }
        public virtual TFindpwdService TFindpwdService { get; set; }
        public virtual TFjjAttachmentsetService TFjjAttachmentsetService { get; set; }
        public virtual TFrBaseService TFrBaseService { get; set; }
        public virtual TGqPublishService TGqPublishService { get; set; }
        public virtual TheEelExpertService TheEelExpertService { get; set; }
        public virtual TheEelRowResultService TheEelRowResultService { get; set; }
        public virtual TheEelRowService TheEelRowService { get; set; }
        public virtual TheEelSetAndAuthService TheEelSetAndAuthService { get; set; }
        public virtual TIndexshowSetService TIndexshowSetService { get; set; }
        public virtual TJiekouUserService TJiekouUserService { get; set; }
        public virtual TJyptAccessService TJyptAccessService { get; set; }
        public virtual TMedicalService TMedicalService { get; set; }
        public virtual TMedicalTestService TMedicalTestService { get; set; }
        public virtual TMedicalTotleService TMedicalTotleService { get; set; }
        public virtual TMenuService TMenuService { get; set; }
        public virtual TMessageService TMessageService { get; set; }
        public virtual TMessageTextService TMessageTextService { get; set; }
        public virtual TMssmService TMssmService { get; set; }
        public virtual TNoticeService TNoticeService { get; set; }
        public virtual TOperAskService TOperAskService { get; set; }
        public virtual TOpernoticeService TOpernoticeService { get; set; }
        public virtual TpaQaTableService TpaQaTableService { get; set; }
        public virtual TpewInfoService TpewInfoService { get; set; }
        public virtual TPopedomService TPopedomService { get; set; }
        public virtual TPushzpLogService TPushzpLogService { get; set; }
        public virtual TradeResultInfoPreService TradeResultInfoPreService { get; set; }
        public virtual TradeResultInfoService TradeResultInfoService { get; set; }
        public virtual TransferEnteHareholderService TransferEnteHareholderService { get; set; }
        public virtual TransferEnteHolderPreService TransferEnteHolderPreService { get; set; }
        public virtual TransferEnteInfoPreService TransferEnteInfoPreService { get; set; }
        public virtual TransferEnteInfoService TransferEnteInfoService { get; set; }
        public virtual TransferorExInfoService TransferorExInfoService { get; set; }
        public virtual TRowidService TRowidService { get; set; }
        public virtual TRpDbconfigService TRpDbconfigService { get; set; }
        public virtual TRpFieldService TRpFieldService { get; set; }
        public virtual TRpMenuService TRpMenuService { get; set; }
        public virtual TRpService TRpService { get; set; }
        public virtual TRpStTreeNodeService TRpStTreeNodeService { get; set; }
        public virtual TRpStTreeService TRpStTreeService { get; set; }
        public virtual TSeqLogService TSeqLogService { get; set; }
        public virtual TSeqService TSeqService { get; set; }
        public virtual TServiceDatakeyService TServiceDatakeyService { get; set; }
        public virtual TServiceLogService TServiceLogService { get; set; }
        public virtual TServiceTcidService TServiceTcidService { get; set; }
        public virtual TSignCaService TSignCaService { get; set; }
        public virtual TSignLogService TSignLogService { get; set; }
        public virtual TsInfoService TsInfoService { get; set; }
        public virtual TSmsLogService TSmsLogService { get; set; }
        public virtual TSsoAuthorizationService TSsoAuthorizationService { get; set; }
        public virtual TSsoInfoService TSsoInfoService { get; set; }
        public virtual TSsoInfoSqService TSsoInfoSqService { get; set; }
        public virtual TSsoJycenterService TSsoJycenterService { get; set; }
        public virtual TSwPublishService TSwPublishService { get; set; }
        public virtual TSysMessageService TSysMessageService { get; set; }
        public virtual TTableFieldService TTableFieldService { get; set; }
        public virtual TTimelinessCountService TTimelinessCountService { get; set; }
        public virtual TTjAlltbUploadService TTjAlltbUploadService { get; set; }
        public virtual TTransLogService TTransLogService { get; set; }
        public virtual TTuisongService TTuisongService { get; set; }
        public virtual TTuisongTotalService TTuisongTotalService { get; set; }
        public virtual TUploadErrorLogService TUploadErrorLogService { get; set; }
        public virtual TUploadErrorService TUploadErrorService { get; set; }
        public virtual TUploadOkLogService TUploadOkLogService { get; set; }
        public virtual TUploadService TUploadService { get; set; }
        public virtual TUserBanService TUserBanService { get; set; }
        public virtual TUserMenuService TUserMenuService { get; set; }
        public virtual TUserPopedomService TUserPopedomService { get; set; }
        public virtual TUserQyzcService TUserQyzcService { get; set; }
        public virtual TUserroleService TUserroleService { get; set; }
        public virtual TUserService TUserService { get; set; }
        public virtual TUserTradeplatformService TUserTradeplatformService { get; set; }
        public virtual TUserUrlService TUserUrlService { get; set; }
        public virtual TXiehuiUploadLogService TXiehuiUploadLogService { get; set; }
        public virtual TYcLogService TYcLogService { get; set; }
        public virtual TZtBiddercontractService TZtBiddercontractService { get; set; }
        public virtual TZtLegalService TZtLegalService { get; set; }
        public virtual TZtOrganqualService TZtOrganqualService { get; set; }
        public virtual TZtPersonService TZtPersonService { get; set; }
        public virtual TZtPracticequalService TZtPracticequalService { get; set; }
        public virtual TZtPractitionerachievementService TZtPractitionerachievementService { get; set; }
        public virtual TZtPractitionerService TZtPractitionerService { get; set; }
        public virtual TZtPurchasingagentService TZtPurchasingagentService { get; set; }
        public virtual TZtTransfereeService TZtTransfereeService { get; set; }
        public virtual TZtTransferService TZtTransferService { get; set; }
        public virtual UseAfterSaleService UseAfterSaleService { get; set; }
        public virtual ViolatingLawsRulesInfoService ViolatingLawsRulesInfoService { get; set; }
        public virtual WinResultAnnoService WinResultAnnoService { get; set; }
        public virtual WithdrawBlackListService WithdrawBlackListService { get; set; }
        public virtual YdEvaRoomService YdEvaRoomService { get; set; }
        public virtual YdRequisitionService YdRequisitionService { get; set; }
        public virtual YdRoomsetService YdRoomsetService { get; set; }
        public virtual ZjAwardInfoService ZjAwardInfoService { get; set; }
        public virtual ZjEnterpriseCertificateInfoService ZjEnterpriseCertificateInfoService { get; set; }
        public virtual ZjEnterpriseCreditScoreService ZjEnterpriseCreditScoreService { get; set; }
        public virtual ZjEnterpriseQualificationService ZjEnterpriseQualificationService { get; set; }
        public virtual ZjLegalPersonBaseService ZjLegalPersonBaseService { get; set; }
        public virtual ZjpriBadBehaviorService ZjpriBadBehaviorService { get; set; }
        public virtual ZjpriComprehensiveService ZjpriComprehensiveService { get; set; }
        public virtual ZjpriConstructCertifiService ZjpriConstructCertifiService { get; set; }
        public virtual ZjpriConstructEnterInfoService ZjpriConstructEnterInfoService { get; set; }
        public virtual ZjpriConstructIntermediateService ZjpriConstructIntermediateService { get; set; }
        public virtual ZjpriConstructKeypersonService ZjpriConstructKeypersonService { get; set; }
        public virtual ZjpriConstructQualiInfoService ZjpriConstructQualiInfoService { get; set; }
        public virtual ZjpriEmployeesInfoService ZjpriEmployeesInfoService { get; set; }
        public virtual ZjpriEmployeesQualiService ZjpriEmployeesQualiService { get; set; }
        public virtual ZjpriExtCompanyService ZjpriExtCompanyService { get; set; }
        public virtual ZjpriExtPeopleService ZjpriExtPeopleService { get; set; }
        public virtual ZjpriExtSelfproveService ZjpriExtSelfproveService { get; set; }
        public virtual ZjpriGoodBehaviorService ZjpriGoodBehaviorService { get; set; }
        public virtual ZjpriRegisterPersonService ZjpriRegisterPersonService { get; set; }
        public virtual ZjQualiPersonBaseService ZjQualiPersonBaseService { get; set; }
        public virtual ZjQualiPersonPerformeService ZjQualiPersonPerformeService { get; set; }
        public virtual ZjQualiPersonQualiService ZjQualiPersonQualiService { get; set; }
        public virtual ZjViolatingLawsRulesInfoService ZjViolatingLawsRulesInfoService { get; set; }
        public virtual ZpUserService ZpUserService { get; set; }

        public virtual BdHardwareMultiService BdHardwareMultiService { get; set; }


        public virtual BdViolationPointService BdViolationPointService { get; set; }


        public virtual BdViolationPointDetailService BdViolationPointDetailService { get; set; }

        public virtual BdInquireRecordService BdInquireRecordService { get; set; }

        public virtual BdViolationRecordService BdViolationRecordService { get; set; }

        public virtual BdViolationEntityService BdViolationEntityService { get; set; }
        public virtual WarnFeedbackService WarnFeedBackService { get; set; }

        public virtual WarnExpressionService WarnExpressionService { get; set; }
        public virtual WarnTemplateService WarnTemplateService { get; set; }

        public virtual WarnExpressionDetailService WarnExpressionDetailService { get; set; }
        public virtual WarnResultService WarnResultService { get; set; }
        public virtual WarnRecordService WarnRecordService { get; set; }

        public virtual VProjectRegisterService VProjectRegisterService { get; set; }

        public virtual TMacService TMacService { get; set; }
        public virtual TMacResultThirdService TMacResultThirdService { get; set; }
        public virtual TMacResultSecondService TMacResultSecondService { get; set; }
        public virtual TMacResultFirstService TMacResultFirstService { get; set; }

        public virtual TenderListStatisticsService TenderListStatisticsService { get; set; }

        public virtual EnterpriseInfoService EnterpriseInfoService { get; set; }

        #endregion

        #region 自定义属性


        public virtual DZBHService DZBHService { get; set; }
        public virtual ClaimService ClaimService { get; set; }
        public virtual BhSignService BhSignService { get; set; }
        public virtual ExChangeService ExChangeService { get; set; }
        public virtual GetDataService GetDataService { get; set; }


        public virtual MvJyxxHistoryService MvJyxxHistoryService { get; set; }

        public virtual MvJyxxService MvJyxxService { get; set; }

        public virtual MvTjAllcreateXzjdService MvTjAllcreateXzjdService { get; set; }
        public virtual MvTjAllresultXzjdService MvTjAllresultXzjdService { get; set; }
        public virtual MvUserTenderListService MvUserTenderListService { get; set; }
        public virtual VUnifyUserService VUnifyUserService { get; set; }
        public virtual ParseFileService ParseFileService { get; set; }
        public virtual OfdApiService OfdApiService { get; set; }
        public virtual TModifyApplicationService TModifyApplicationService { get; set; }
        public virtual AssistCorrectInfoService AssistCorrectInfoService { get; set; }
        public virtual MvGgxxXzjdService MvGgxxXzjdService { get; set; }


        //公安厅外网
        public virtual BidderProjectMemberService BidderProjectMemberService { get; set; }
        #endregion





































        #region MyRegion

        /// <summary>
        /// 使用指定的程序集和反射上下文的累初始化
        /// </summary>
        public static AssemblyCatalog AssemblyCatalog
        {
            get
            {
                var builder = new RegistrationBuilder();
                builder
                    .ForTypesMatching(c => c.Name.EndsWith("Service"))
                    .Export();
                builder
                    .ForType<ServicesFactoryFw>()
                    .Export()
                    .ImportProperties(c => c.Name.EndsWith("Service"));
                var cat =
                    new AssemblyCatalog(typeof(ServicesFactoryFw).Assembly, builder);
                return cat;
            }
        }
        /// <summary>
        /// 自动生成Service属性
        /// </summary>
        public static void InitProperty()
        {
            Console.WriteLine("#region 属性");
            foreach (var item in AssemblyCatalog.Parts)
            {
                foreach (var exportDefinition in item.ExportDefinitions)
                {
                    var service = exportDefinition.ContractName.Split('.').LastOrDefault();
                    if (new List<string> { "BaseService", "ServicesFactoryFw" }.Any(c => c == service)
                        || !exportDefinition.ContractName.Contains("FuWu"))
                    {
                        continue;
                    }

                    Console.WriteLine($"public virtual {service} {service} {{ get; set; }}");
                }
            }

            Console.WriteLine("#endregion");
        }

        #endregion


    }
}