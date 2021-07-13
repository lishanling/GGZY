using System;

namespace GGZY.Services.Infrastructure.Model.FuWu
{
    public partial  class TradeInfoModel
    {
		#region Model

		/// <summary>
		/// 
		/// </summary>
		public string KIND { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string TITLE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string GGTYPE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string NAME { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal? M_ID { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string PLATFORM_CODE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string PLATFORM_NAME { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM1 { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string PROCODE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string AREACODE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string AREANAME { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string PROTYPE_TEXT { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string PROTYPE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string M_DATA_SOURCE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? M_TM { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string M_PROJECT_TYPE { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TM { get; set; }
		#endregion

        public bool IS_NEW => TM.HasValue && TM.Value >= DateTime.Today;
    }
}