using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
	/// <summary>
	/// 实体类PT_ZXTS_LOOK_INTO_FEEDBACK。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public partial class V_ZXTS_LOOK_INTO_FEEDBACKCOUNT
	{

        /// <summary>
        /// 调查取证ID
        /// </summary>
        public string LOOK_ID { get; set; }
		/// <summary>
		/// 调查取证反馈数量
		/// </summary>
		public string FEEDBACK_COUNT { get; set; }


		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// 调查取证ID
			/// </summary>
			public readonly static Field LOOK_ID = new Field("LOOK_ID", "V_ZXTS_LOOK_INTO_FEEDBACKCOUNT", "调查取证ID");
			/// <summary>
			/// 调查取证反馈数量
			/// </summary>
			public readonly static Field FEEDBACK_COUNT = new Field("FEEDBACK_COUNT", "V_ZXTS_LOOK_INTO_FEEDBACKCOUNT", "调查取证反馈数量");
		}
		#endregion
	}
}