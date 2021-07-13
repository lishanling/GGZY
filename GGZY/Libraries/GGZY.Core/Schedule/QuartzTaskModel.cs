using System;

namespace GGZY.Core.Schedule
{
    /// <summary>
    /// 实体类GGZY_QUARTZ_TASK。(属性说明自动提取数据库字段的描述信息)
    /// </summary>   
    [Serializable]
    public partial class QuartzTaskModel
    {
        #region Model
        private string _TASKID = "";
        /// <summary>
        /// 任务ID
        /// </summary>
        public string TASKID
        {
            get { return _TASKID; }
            set { _TASKID = value; }
        }
        private string _TASNNAME = "";
        /// <summary>
        /// 任务名称
        /// </summary>
        public string TASNNAME
        {
            get { return _TASNNAME; }
            set { _TASNNAME = value; }
        }
        private string _TASKPARAM = "";
        /// <summary>
        /// 任务执行参数
        /// </summary>
        public string TASKPARAM
        {
            get { return _TASKPARAM; }
            set { _TASKPARAM = value; }
        }
        private string _CRONEXPRESSIONSTRING = "";
        /// <summary>
        /// 运行频率设置
        /// </summary>
        public string CRONEXPRESSIONSTRING
        {
            get { return _CRONEXPRESSIONSTRING; }
            set { _CRONEXPRESSIONSTRING = value; }
        }
        private string _CRONREMARK = "";
        /// <summary>
        /// 任务运频率中文说明
        /// </summary>
        public string CRONREMARK
        {
            get { return _CRONREMARK; }
            set { _CRONREMARK = value; }
        }
        private string _ASSEMBLYNAME = "";
        /// <summary>
        /// 任务所在DLL对应的程序集名称
        /// </summary>
        public string ASSEMBLYNAME
        {
            get { return _ASSEMBLYNAME; }
            set { _ASSEMBLYNAME = value; }
        }
        private string _CLASSNAME = "";
        /// <summary>
        /// 任务所在类
        /// </summary>
        public string CLASSNAME
        {
            get { return _CLASSNAME; }
            set { _CLASSNAME = value; }
        }
        private decimal? _STATE;
        /// <summary>
        /// 任务状态中文说明
        /// </summary>
        public decimal? STATE
        {
            get { return _STATE; }
            set { _STATE = value; }
        }
        private string _CREATEDBY = "";
        /// <summary>
        /// 任务创建人
        /// </summary>
        public string CREATEDBY
        {
            get { return _CREATEDBY; }
            set { _CREATEDBY = value; }
        }
        private string _CREATEDTIME = "";
        /// <summary>
        /// 任务创建时间
        /// </summary>
        public string CREATEDTIME
        {
            get { return _CREATEDTIME; }
            set { _CREATEDTIME = value; }
        }
        private string _MODIFIEDBY = "";
        /// <summary>
        /// 任务修改人
        /// </summary>
        public string MODIFIEDBY
        {
            get { return _MODIFIEDBY; }
            set { _MODIFIEDBY = value; }
        }
        private string _MODIFIEDTIME = "";
        /// <summary>
        /// 任务修改时间
        /// </summary>
        public string MODIFIEDTIME
        {
            get { return _MODIFIEDTIME; }
            set { _MODIFIEDTIME = value; }
        }
        private string _RECENTRUNTIME = "";
        /// <summary>
        /// 任务最近运行时间
        /// </summary>
        public string RECENTRUNTIME
        {
            get { return _RECENTRUNTIME; }
            set { _RECENTRUNTIME = value; }
        }
        private string _LASTRUNTIME = "";
        /// <summary>
        /// 任务下次运行时间
        /// </summary>
        public string LASTRUNTIME
        {
            get { return _LASTRUNTIME; }
            set { _LASTRUNTIME = value; }
        }
        private string _REMARK = "";
        /// <summary>
        /// 任务备注
        /// </summary>
        public string REMARK
        {
            get { return _REMARK; }
            set { _REMARK = value; }
        }
        #endregion

        /// <summary>
        /// 任务状态枚举
        /// </summary>
        public enum TaskState
        {
            /// <summary>
            /// 运行状态
            /// </summary>
            RUN = 0,

            /// <summary>
            /// 停止状态
            /// </summary>
            STOP = 1
        }
    }


}