using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Linq;
using GGZY.Services.BigData;
using GGZY.Services.JianDu;
using GGZY.Services.Violation;

namespace GGZY.Services.Base
{
    public partial class ServicesFactoryJd
    {
        #region 属性
        public virtual AwardInfoService AwardInfoService { get; set; }
        public virtual BakLegalPersonBaseService BakLegalPersonBaseService { get; set; }
        public virtual BakPtArticleService BakPtArticleService { get; set; }
        public virtual BakPtComplainService BakPtComplainService { get; set; }
        public virtual BakPtZxtsService BakPtZxtsService { get; set; }
        public virtual BakTAccesstoapplicationService BakTAccesstoapplicationService { get; set; }
        public virtual BakTDishonestyExposureService BakTDishonestyExposureService { get; set; }
        public virtual BakTIllegalService BakTIllegalService { get; set; }
        public virtual BascResultService BascResultService { get; set; }
        public virtual BlackListService BlackListService { get; set; }
        public virtual CommonService CommonService { get; set; }
        public virtual JdPortalObjectionService JdPortalObjectionService { get; set; }
        public virtual GetdatalogService GetdatalogService { get; set; }
        public virtual JtBidDocCharactCodeService JtBidDocCharactCodeService { get; set; }
        public virtual JtBidEvaluationExpertService JtBidEvaluationExpertService { get; set; }
        public virtual JtBidOpeningRecordService JtBidOpeningRecordService { get; set; }
        public virtual JtCivilConTenderFileService JtCivilConTenderFileService { get; set; }
        public virtual JtConstructTenderFileService JtConstructTenderFileService { get; set; }
        public virtual JtConsultSubmitReportService JtConsultSubmitReportService { get; set; }
        public virtual JtContractPerformanceService JtContractPerformanceService { get; set; }
        public virtual JtContructSuperTimeService JtContructSuperTimeService { get; set; }
        public virtual JtDesignerApproachTimeService JtDesignerApproachTimeService { get; set; }
        public virtual JtDesignMainLivingService JtDesignMainLivingService { get; set; }
        public virtual JtEnginConTenderFileService JtEnginConTenderFileService { get; set; }
        public virtual JtEquipMinMachineryService JtEquipMinMachineryService { get; set; }
        public virtual JtEvaluationReportService JtEvaluationReportService { get; set; }
        public virtual JtGenralConTenderFile01Service JtGenralConTenderFile01Service { get; set; }
        public virtual JtGenralConTenderFileService JtGenralConTenderFileService { get; set; }
        public virtual JtGenSuperTenderFileService JtGenSuperTenderFileService { get; set; }
        public virtual JtGenSurveyTenderFileService JtGenSurveyTenderFileService { get; set; }
        public virtual JtHighwayOtherContentService JtHighwayOtherContentService { get; set; }
        public virtual JtLetterOfGuaranteeService JtLetterOfGuaranteeService { get; set; }
        public virtual JtMachEleTenderFileService JtMachEleTenderFileService { get; set; }
        public virtual JtMainProjectRequireService JtMainProjectRequireService { get; set; }
        public virtual JtMinRequirePersonnelService JtMinRequirePersonnelService { get; set; }
        public virtual JtOrdMainTenderFileService JtOrdMainTenderFileService { get; set; }
        public virtual JtOtherRequirePersonnelService JtOtherRequirePersonnelService { get; set; }
        public virtual JtOwnerDocWorkplanService JtOwnerDocWorkplanService { get; set; }
        public virtual JtPerformanceService JtPerformanceService { get; set; }
        public virtual JtPortConTenderFileService JtPortConTenderFileService { get; set; }
        public virtual JtPortSuperTenderFileService JtPortSuperTenderFileService { get; set; }
        public virtual JtProjectService JtProjectService { get; set; }
        public virtual JtQualificationRequireService JtQualificationRequireService { get; set; }
        public virtual JtQualiInqueryAppFileService JtQualiInqueryAppFileService { get; set; }
        public virtual JtQualiInqueryClariService JtQualiInqueryClariService { get; set; }
        public virtual JtQualiInqueryResultService JtQualiInqueryResultService { get; set; }
        public virtual JtSectionService JtSectionService { get; set; }
        public virtual JtSubgradeTenderFileService JtSubgradeTenderFileService { get; set; }
        public virtual JtSubSupTenderFileService JtSubSupTenderFileService { get; set; }
        public virtual JtSuperTenderFileService JtSuperTenderFileService { get; set; }
        public virtual JtSurveyTenderFileService JtSurveyTenderFileService { get; set; }
        public virtual JtTenderAbnormityReportService JtTenderAbnormityReportService { get; set; }
        public virtual JtTenderCandidateAnnService JtTenderCandidateAnnService { get; set; }
        public virtual JtTenderCandidateService JtTenderCandidateService { get; set; }
        public virtual JtTenderEvaluationService JtTenderEvaluationService { get; set; }
        public virtual JtTenderFileClariModiService JtTenderFileClariModiService { get; set; }
        public virtual JtTenderInvitationService JtTenderInvitationService { get; set; }
        public virtual JtTenderListService JtTenderListService { get; set; }
        public virtual JtTenderProjectService JtTenderProjectService { get; set; }
        public virtual JtTenderQuaInqueryAnnService JtTenderQuaInqueryAnnService { get; set; }
        public virtual JtTestBidTenderFileService JtTestBidTenderFileService { get; set; }
        public virtual JtTestTenderFileService JtTestTenderFileService { get; set; }
        public virtual JtVehicleRequirementService JtVehicleRequirementService { get; set; }
        public virtual JtWinResultAnnoService JtWinResultAnnoService { get; set; }
        public virtual LegalPersonBaseService LegalPersonBaseService { get; set; }
        public virtual LoginLogService LoginLogService { get; set; }
        public virtual MgrLogService MgrLogService { get; set; }
        public virtual MvGcjsGgxxHistoryService MvGcjsGgxxHistoryService { get; set; }
        public virtual MvGcjsGgxxService MvGcjsGgxxService { get; set; }
        public virtual OpertionRecordService OpertionRecordService { get; set; }
        public virtual ProjectService ProjectService { get; set; }
        public virtual PtArticleService PtArticleService { get; set; }
        public virtual PtAtypeService PtAtypeService { get; set; }
        public virtual PtCommentService PtCommentService { get; set; }
        public virtual PtComplainService PtComplainService { get; set; }
        public virtual PtExposureService PtExposureService { get; set; }
        public virtual PtLinkService PtLinkService { get; set; }
        public virtual PtTxteditService PtTxteditService { get; set; }
        public virtual PtZxtsBtsrService PtZxtsBtsrService { get; set; }
        public virtual PtZxtsDepconfigService PtZxtsDepconfigService { get; set; }
        public virtual PtZxtsLogService PtZxtsLogService { get; set; }
        public virtual PtZxtsRevokeService PtZxtsRevokeService { get; set; }
        public virtual PtZxtsService PtZxtsService { get; set; }
        public virtual PtZxtsLookIntoService PtZxtsLookIntoService { get; set; }
        public virtual RecordAttachmentService RecordAttachmentService { get; set; }
        public virtual RecordBiddingWriteService RecordBiddingWriteService { get; set; }
        public virtual RecordBiddocNormalService RecordBiddocNormalService { get; set; }
        public virtual RecordClassifyNormalService RecordClassifyNormalService { get; set; }
        public virtual RecordClassifyService RecordClassifyService { get; set; }
        public virtual RecordContractService RecordContractService { get; set; }
        public virtual RecordCreditDeductionService RecordCreditDeductionService { get; set; }
        public virtual RecordHandleResultService RecordHandleResultService { get; set; }
        public virtual RecordLogService RecordLogService { get; set; }
        public virtual RecordResidentialBiddocService RecordResidentialBiddocService { get; set; }
        public virtual RecordReviewService RecordReviewService { get; set; }
        public virtual RecordSectionInfoService RecordSectionInfoService { get; set; }
        public virtual RecordWrittenService RecordWrittenService { get; set; }
        public virtual ReviewButtonService ReviewButtonService { get; set; }
        public virtual ReviewDepconfigService ReviewDepconfigService { get; set; }
        public virtual ReviewInstanceService ReviewInstanceService { get; set; }
        public virtual ReviewLogService ReviewLogService { get; set; }
        public virtual ReviewMainService ReviewMainService { get; set; }
        public virtual ReviewNodeService ReviewNodeService { get; set; }
        public virtual ReviewOpersService ReviewOpersService { get; set; }
        public virtual SectionService SectionService { get; set; }
        public virtual SlBidderQualifiRequireService SlBidderQualifiRequireService { get; set; }
        public virtual SlBidDocCharactCodeService SlBidDocCharactCodeService { get; set; }
        public virtual SlBidEvaluationExpertService SlBidEvaluationExpertService { get; set; }
        public virtual SlBidOpeningRecordService SlBidOpeningRecordService { get; set; }
        public virtual SlConstructBidocRequireService SlConstructBidocRequireService { get; set; }
        public virtual SlConstructSuperRequireService SlConstructSuperRequireService { get; set; }
        public virtual SlContractPerformanceService SlContractPerformanceService { get; set; }
        public virtual SlEvaluationReportService SlEvaluationReportService { get; set; }
        public virtual SlItemControlPriceService SlItemControlPriceService { get; set; }
        public virtual SlLetterOfGuaranteeService SlLetterOfGuaranteeService { get; set; }
        public virtual SlMinimumEquipRequireService SlMinimumEquipRequireService { get; set; }
        public virtual SlOtherRequireService SlOtherRequireService { get; set; }
        public virtual SlPerformanceService SlPerformanceService { get; set; }
        public virtual SlProjectService SlProjectService { get; set; }
        public virtual SlQualiInqueryAppFileService SlQualiInqueryAppFileService { get; set; }
        public virtual SlQualiInqueryClariService SlQualiInqueryClariService { get; set; }
        public virtual SlQualiInqueryResultService SlQualiInqueryResultService { get; set; }
        public virtual SlSectionService SlSectionService { get; set; }
        public virtual SlSurveyDesignRequireService SlSurveyDesignRequireService { get; set; }
        public virtual SlTenderAbnormityReportService SlTenderAbnormityReportService { get; set; }
        public virtual SlTenderCandidateAnnService SlTenderCandidateAnnService { get; set; }
        public virtual SlTenderCandidateService SlTenderCandidateService { get; set; }
        public virtual SlTenderEvaluationService SlTenderEvaluationService { get; set; }
        public virtual SlTenderFileClariModiService SlTenderFileClariModiService { get; set; }
        public virtual SlTenderInvitationService SlTenderInvitationService { get; set; }
        public virtual SlTenderListService SlTenderListService { get; set; }
        public virtual SlTenderProjectService SlTenderProjectService { get; set; }
        public virtual SlTenderQuaInqueryAnnService SlTenderQuaInqueryAnnService { get; set; }
        public virtual SlWinResultAnnoService SlWinResultAnnoService { get; set; }
        public virtual SysAreaQuanguoBakService SysAreaQuanguoBakService { get; set; }
        public virtual SysAreaQuanguoService SysAreaQuanguoService { get; set; }
        public virtual SysAreaService SysAreaService { get; set; }
        public virtual SysAttachmentService SysAttachmentService { get; set; }
        public virtual SysDataLogService SysDataLogService { get; set; }
        public virtual SysDepartmentService SysDepartmentService { get; set; }
        public virtual SysDicnewService SysDicnewService { get; set; }
        public virtual SysDicService SysDicService { get; set; }
        public virtual SysDocumentsService SysDocumentsService { get; set; }
        public virtual SysInfoService SysInfoService { get; set; }
        public virtual SysLogService SysLogService { get; set; }
        public virtual SysMenuBackService SysMenuBackService { get; set; }
        public virtual SysMenuService SysMenuService { get; set; }
        public virtual SysPopedomService SysPopedomService { get; set; }
        public virtual SysPublictypeinfoService SysPublictypeinfoService { get; set; }
        public virtual SysTreeService SysTreeService { get; set; }
        public virtual SysUrlService SysUrlService { get; set; }
        public virtual SysUserroleService SysUserroleService { get; set; }
        public virtual SysUserService SysUserService { get; set; }
        public virtual TAccessDataService TAccessDataService { get; set; }
        public virtual TAccesstoapplicationService TAccesstoapplicationService { get; set; }
        public virtual TAfcChangeService TAfcChangeService { get; set; }
        public virtual TAfcLogService TAfcLogService { get; set; }
        public virtual TAfcProjectService TAfcProjectService { get; set; }
        public virtual TSuperviseResultService TSuperviseResultService { get; set; }
        public virtual TSuperviseService TSuperviseService { get; set; }
        public virtual TAfcSecondaryService TAfcSecondaryService { get; set; }
        public virtual TAfcFixedService TAfcFixedService { get; set; }
        public virtual TAfcXmcodeService TAfcXmcodeService { get; set; }
        public virtual TAttachmentService TAttachmentService { get; set; }
        public virtual TAuditDetailService TAuditDetailService { get; set; }
        public virtual TAuditService TAuditService { get; set; }
        public virtual TBaseTradeCenterService TBaseTradeCenterService { get; set; }
        public virtual TbFavoriteService TbFavoriteService { get; set; }
        public virtual TbReplaceService TbReplaceService { get; set; }
        public virtual TbTableconfigService TbTableconfigService { get; set; }
        public virtual TbTablefieldconfigService TbTablefieldconfigService { get; set; }
        public virtual TComplainService TComplainService { get; set; }
        public virtual TComplaintsProcessService TComplaintsProcessService { get; set; }
        public virtual TCreditBonusService TCreditBonusService { get; set; }
        public virtual TCopysendService TCopysendService { get; set; }
        public virtual TDishonestyExposureService TDishonestyExposureService { get; set; }
        public virtual TenderDocTransLogService TenderDocTransLogService { get; set; }
        public virtual TenderProjectDelService TenderProjectDelService { get; set; }
        public virtual TenderProjectService TenderProjectService { get; set; }
        public virtual TEvaluationService TEvaluationService { get; set; }
        public virtual TExpertBlacklistService TExpertBlacklistService { get; set; }
        public virtual TExpertEvaluationInfoService TExpertEvaluationInfoService { get; set; }
        public virtual TExpertExtractionService TExpertExtractionService { get; set; }
        public virtual TFindpwdService TFindpwdService { get; set; }
        public virtual TFraudService TFraudService { get; set; }
        public virtual TFrBaseService TFrBaseService { get; set; }
        public virtual TGqPublishService TGqPublishService { get; set; }
        public virtual THolidayService THolidayService { get; set; }
        public virtual TIllegalService TIllegalService { get; set; }
        public virtual TJiekouUser20180330Service TJiekouUser20180330Service { get; set; }
        public virtual TJiekouUserService TJiekouUserService { get; set; }
        public virtual TMessageService TMessageService { get; set; }
        public virtual TMpPlanInfoService TMpPlanInfoService { get; set; }
        public virtual TMpPlanService TMpPlanService { get; set; }
        public virtual TMsgStateService TMsgStateService { get; set; }
        public virtual TMultimediaDataService TMultimediaDataService { get; set; }
        public virtual TNoticeService TNoticeService { get; set; }
        public virtual TPcNodeService TPcNodeService { get; set; }
        public virtual TPcPathService TPcPathService { get; set; }
        public virtual TPewPinfoService TPewPinfoService { get; set; }
        public virtual TPmJdinfoLogService TPmJdinfoLogService { get; set; }
        public virtual TPmJdinfoService TPmJdinfoService { get; set; }
        public virtual TPmMsgmodelService TPmMsgmodelService { get; set; }
        public virtual TPmRelationService TPmRelationService { get; set; }
        public virtual TProjectBrowseService TProjectBrowseService { get; set; }
        public virtual TProjectDataService TProjectDataService { get; set; }
        public virtual TProjectWarnService TProjectWarnService { get; set; }
        public virtual TProSupervisionService TProSupervisionService { get; set; }
        public virtual TPunishService TPunishService { get; set; }
        public virtual TradeEvaRoomService TradeEvaRoomService { get; set; }
        public virtual TRecordOperationAttachmentService TRecordOperationAttachmentService { get; set; }
        public virtual TRecordProjectinfoService TRecordProjectinfoService { get; set; }
        public virtual TRecordRegulatorService TRecordRegulatorService { get; set; }
        public virtual TRecordReviewNewService TRecordReviewNewService { get; set; }
        public virtual TRecordReviewService TRecordReviewService { get; set; }
        public virtual TSeqService TSeqService { get; set; }
        public virtual TServiceLogService TServiceLogService { get; set; }
        public virtual TServiceTcid20170315Service TServiceTcid20170315Service { get; set; }
        public virtual TServiceTcidService TServiceTcidService { get; set; }
        public virtual TSmsLogService TSmsLogService { get; set; }
        public virtual TSmsSendService TSmsSendService { get; set; }
        public virtual TTableFieldService TTableFieldService { get; set; }
        public virtual TTenderProjectService TTenderProjectService { get; set; }
        public virtual TTpColumnsService TTpColumnsService { get; set; }
        public virtual TTpDataService TTpDataService { get; set; }
        public virtual TTpMainService TTpMainService { get; set; }
        public virtual TTpNodeService TTpNodeService { get; set; }
        public virtual TTpTacheService TTpTacheService { get; set; }
        public virtual TTuisongService TTuisongService { get; set; }
        public virtual TTuisongTotalService TTuisongTotalService { get; set; }
        public virtual TUpdateemailService TUpdateemailService { get; set; }
        public virtual TUserDepartmentService TUserDepartmentService { get; set; }
        public virtual TUserExtendService TUserExtendService { get; set; }
        public virtual TUserMenuService TUserMenuService { get; set; }
        public virtual TUserMsgService TUserMsgService { get; set; }
        public virtual TUserPopedomService TUserPopedomService { get; set; }
        public virtual TUserRoleService TUserRoleService { get; set; }
        public virtual TUserService TUserService { get; set; }
        public virtual TUserTradeplatformService TUserTradeplatformService { get; set; }
        public virtual TUserUrlService TUserUrlService { get; set; }
        public virtual VVideobasicinfoService VVideobasicinfoService { get; set; }
        public virtual VVideopointinfoService VVideopointinfoService { get; set; }
        public virtual ZjBidDocCharactCodeService ZjBidDocCharactCodeService { get; set; }
        public virtual ZjBidEvaluationExpertService ZjBidEvaluationExpertService { get; set; }
        public virtual ZjBidOpeningRecordService ZjBidOpeningRecordService { get; set; }
        public virtual ZjBidWinningNoticeService ZjBidWinningNoticeService { get; set; }
        public virtual ZjContractPerformanceService ZjContractPerformanceService { get; set; }
        public virtual ZjEvaluationReportService ZjEvaluationReportService { get; set; }
        public virtual ZjExpertFineScoreService ZjExpertFineScoreService { get; set; }
        public virtual ZjLetterOfGuaranteeService ZjLetterOfGuaranteeService { get; set; }
        public virtual ZjPerformanceService ZjPerformanceService { get; set; }
        public virtual ZjProjectService ZjProjectService { get; set; }
        public virtual ZjQualiInqueryAppFileService ZjQualiInqueryAppFileService { get; set; }
        public virtual ZjQualiInqueryClariService ZjQualiInqueryClariService { get; set; }
        public virtual ZjQualiInqueryResultService ZjQualiInqueryResultService { get; set; }
        public virtual ZjRecordReviewMtService ZjRecordReviewMtService { get; set; }
        public virtual ZjRecordReviewMzService ZjRecordReviewMzService { get; set; }
        public virtual ZjReviewContentService ZjReviewContentService { get; set; }
        public virtual ZjSectionService ZjSectionService { get; set; }
        public virtual ZjTenderAbnormityReportService ZjTenderAbnormityReportService { get; set; }
        public virtual ZjTenderCandidateAnnService ZjTenderCandidateAnnService { get; set; }
        public virtual ZjTenderCandidateService ZjTenderCandidateService { get; set; }
        public virtual ZjTenderEvaluationService ZjTenderEvaluationService { get; set; }
        public virtual ZjTenderFileClariModiService ZjTenderFileClariModiService { get; set; }
        public virtual ZjTenderInvitationService ZjTenderInvitationService { get; set; }
        public virtual ZjTenderListService ZjTenderListService { get; set; }
        public virtual ZjTenderProjectService ZjTenderProjectService { get; set; }
        public virtual ZjTenderQuaInqueryAnnService ZjTenderQuaInqueryAnnService { get; set; }
        public virtual ZjWinResultAnnoService ZjWinResultAnnoService { get; set; }
        public virtual ZjWrittenReportService ZjWrittenReportService { get; set; }
        public virtual ZyJiekouUserService ZyJiekouUserService { get; set; }
        public virtual YdpbEvalRoomService YdpbEvalRoomService { get; set; }

        public virtual YdpbEvalRoomCameraService YdpbEvalRoomCameraService { get; set; }

        public virtual YdpbEvalRoomSeatService YdpbEvalRoomSeatService { get; set; }

        public virtual YdpbFileService YdpbFileService { get; set; }

        public virtual YdpbEvalApplyService YdpbEvalApplyService { get; set; }

        public virtual YdpbEvalApplyDetailService YdpbEvalApplyDetailService { get; set; }

        public virtual YdpbEvalApplyRecordService YdpbEvalApplyRecordService { get; set; }

        public virtual VYdpbApplyAllService VYdpbApplyAllService { get; set; }

        public virtual VYdpbApplyTradeService VYdpbApplyTradeService { get; set; }



        #endregion

        #region 自定义属性

        public virtual VGongChengTongJiService VGongChengTongJiService { get; set; }

        public virtual YdpbEvalRoomSeatRecordService YdpbEvalRoomSeatRecordService { get; set; }

        public virtual VYdpbRoomSeatService VYdpbRoomSeatService { get; set; }

        public virtual YdpbEvalExpertRecordService YdpbEvalExpertRecordService { get; set; }

        public virtual TradeCenterService TradeCenterService { get; set; }
        public virtual TUserMenuV2Service TUserMenuV2Service { get; set; }
        public virtual TUserPopedomV2Service TUserPopedomV2Service { get; set; }

        public virtual TUserRoleV2Service TUserRoleV2Service { get; set; }
        public virtual TGeneralAttributeV2Service TGeneralAttributeV2Service { get; set; }
        /// <summary>
        /// 交易中心API对接接口地址配置
        /// </summary>
        public virtual YdpbNotifyConfigService YdpbNotifyConfigService { get; set; }

        public virtual YdpbBranchService YdpbBranchService { get; set; }
        public virtual PunishService PunishService { get; set; }
        public virtual TUserBindAccountService TUserBindAccountService { get; set; }
        public virtual BigDataMainService BigDataMainService { get; set; }

        public virtual JcTransDetailService JcTransDetailService { get; set; }

        public virtual JcTransEntityService JcTransEntityService { get; set; }

        public virtual JcTransRecordService JcTransRecordService { get; set; }

        public virtual JcTransResultService JcTransResultService { get; set; }

        public virtual JcTransProjectService JcTransProjectService { get; set; }

        public virtual JcTransPersonService JcTransPersonService { get; set; }

        #region 工程领域监察大数据服务系统-综合统计-招标人情况

        public virtual DashboardService DashboardService { get; set; }
        public virtual StatisticsBidderService StatisticsBidderService { get; set; }
        public virtual StatisticsAgencyService StatisticsAgencyService { get; set; }
        public virtual StatisticsTenderService StatisticsTenderService { get; set; }
        public virtual StatisticsExpertService StatisticsExpertService { get; set; }
        public virtual CorrelationService CorrelationService { get; set; }
        public virtual StatisticsSupervisionService StatisticsSupervisionService { get; set; }

        #endregion





        #endregion



        public virtual ProjectSupervisionService ProjectSupervisionService { get; set; }
        #region 公安厅外网系统
       // public virtual ProjectQueryService ProjectQueryService { get; set; }
        #endregion


















        #region MyRegion

        public static AssemblyCatalog AssemblyCatalog
        {
            get
            {
                var builder = new RegistrationBuilder();
                builder
                    .ForTypesMatching(c => c.Name.EndsWith("Service"))
                    .Export();
                builder
                    .ForType<ServicesFactoryJd>()
                    .Export()
                    .ImportProperties(c => c.Name.EndsWith("Service"));
                var cat =
                    new AssemblyCatalog(typeof(ServicesFactoryJd).Assembly, builder);
                return cat;
            }
        }

        public static void InitProperty4JianDu()
        {
            Console.WriteLine("#region 属性");
            foreach (var item in AssemblyCatalog.Parts)
            {
                foreach (var exportDefinition in item.ExportDefinitions)
                {
                    var service = exportDefinition.ContractName.Split('.').LastOrDefault();
                    if (new List<string> { "BaseService", "ServicesFactory" }.Any(c => c == service)
                        || !exportDefinition.ContractName.Contains("JianDu"))
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