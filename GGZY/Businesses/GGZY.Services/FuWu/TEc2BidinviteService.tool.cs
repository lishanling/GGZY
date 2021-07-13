using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TEc2BidinviteService : BaseServiceT<T_EC2_BIDINVITE>
    {
        #region 接口实现
        
		public List<T_EC2_BIDINVITE> FindList(T_EC2_BIDINVITE model)
        {
            var condition = ConditionBuilder(model);
            var list = FindList(condition);
            return list;
        }

        public BootstrapTableResult<T_EC2_BIDINVITE> PageList(T_EC2_BIDINVITE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count =  Count(condition);
       var pageList =PageList(condition,search, T_EC2_BIDINVITE._.BIDINVITECODE.Desc).ToBootstrapTableList(count);

            
            return pageList;
        }

       
		/// <summary>
        /// 查看
        /// </summary>
      /// <param name="BIDINVITECODE">投标邀请书编号</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
       public GeneralResult ViewByPk(string BIDINVITECODE,string BIDSECTIONCODE)

        
        {
            var result = new GeneralResult();
			var condition=new WhereClipBuilder();
			condition.And(T_EC2_BIDINVITE._.BIDINVITECODE == BIDINVITECODE);
			condition.And(T_EC2_BIDINVITE._.BIDSECTIONCODE == BIDSECTIONCODE);
			
			  var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                result.SetSuccess(dbModel);
            }
            return result;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Edit(T_EC2_BIDINVITE model)
        {
            var result = new GeneralResult();
            try
            {
		var viewResult=ViewByPk(model.BIDINVITECODE,model.BIDSECTIONCODE);
	
	if(viewResult.Success  && viewResult.Data is T_EC2_BIDINVITE entity)
	{		
		entity.Attach();
		entity.BIDINVITECODE=model.BIDINVITECODE;
		entity.BIDSECTIONCODE=model.BIDSECTIONCODE;
		entity.BIDQUALIFICATION=model.BIDQUALIFICATION;
		entity.BIDDERCODETYPE=model.BIDDERCODETYPE;
		entity.BIDDERCODE=model.BIDDERCODE;
		entity.BIDDERNAME=model.BIDDERNAME;
		entity.TENDERDOCGETSTARTTIME=model.TENDERDOCGETSTARTTIME;
		entity.TENDERDOCDEADLINE=model.TENDERDOCDEADLINE;
		entity.TENDERDOCGETMETHOD=model.TENDERDOCGETMETHOD;
		entity.BIDDOCREFERENDTIME=model.BIDDOCREFERENDTIME;
		entity.BIDDOCREFERMETHOD=model.BIDDOCREFERMETHOD;
		entity.BIDINVITEENDTIME=model.BIDINVITEENDTIME;
		entity.BIDINVITEISSUETIME=model.BIDINVITEISSUETIME;
		entity.EXAMINERNAME=model.EXAMINERNAME;
		entity.EXAMINERCODETYPE=model.EXAMINERCODETYPE;
		entity.EXAMINERCODE=model.EXAMINERCODE;
		entity.ATTACHMENTCODE=model.ATTACHMENTCODE;
		entity.VERSION=model.VERSION;
		entity.ISOPEN=model.ISOPEN;
		entity.OPENTYPE=model.OPENTYPE;
		entity.VERIFYTIME=model.VERIFYTIME;
		entity.DATA_SOURCE=model.DATA_SOURCE;
		entity.CREATE_TIME=model.CREATE_TIME;
		Update(entity);
		result.SetSuccess(entity);
	}
	else
	{
		result.SetFail(viewResult.Msg);
	}
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result; 
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Add(T_EC2_BIDINVITE model)
        {
            var result = new GeneralResult();
            try
            {
                Insert(model);
                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result; 
        }
		
		
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public GeneralResult Delete(params string[] ids)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                List<string>idArr=new List<string>();
                foreach (var id in ids)
                {
                    idArr.AddRange(id.Split(','));
                }
				
                if (idArr.Any())
                {
                    Delete(T_EC2_BIDINVITE._.BIDINVITECODE.SelectIn(idArr));
                    result.SetSuccess(ids);
                }
                else
                {
                    result.SetFail($"请选择要删除的记录");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result.SetFail(e.Message, e);
            }
            return result;
        }
		
		/// <summary>
        /// 导入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Import(List<T_EC2_BIDINVITE> model)
		{
            GeneralResult result = new GeneralResult();
            try
            {
               
                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;			
		}

      
        #endregion

        #region Utils
       	protected WhereClipBuilder ConditionBuilder(T_EC2_BIDINVITE model)
	{
		WhereClipBuilder condition = new WhereClipBuilder();
				if(!string.IsNullOrWhiteSpace(model.BIDINVITECODE))
				{
				  condition.And(T_EC2_BIDINVITE._.BIDINVITECODE.Contain(model.BIDINVITECODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDSECTIONCODE))
				{
				  condition.And(T_EC2_BIDINVITE._.BIDSECTIONCODE.Contain(model.BIDSECTIONCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDQUALIFICATION))
				{
				  condition.And(T_EC2_BIDINVITE._.BIDQUALIFICATION.Contain(model.BIDQUALIFICATION));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDERCODETYPE))
				{
				  condition.And(T_EC2_BIDINVITE._.BIDDERCODETYPE.Contain(model.BIDDERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDERCODE))
				{
				  condition.And(T_EC2_BIDINVITE._.BIDDERCODE.Contain(model.BIDDERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDERNAME))
				{
				  condition.And(T_EC2_BIDINVITE._.BIDDERNAME.Contain(model.BIDDERNAME));
				}
				if(model.TENDERDOCGETSTARTTIME!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.TENDERDOCGETSTARTTIME==(model.TENDERDOCGETSTARTTIME));
				}
				if(model.TENDERDOCDEADLINE!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.TENDERDOCDEADLINE==(model.TENDERDOCDEADLINE));
				}
				if(!string.IsNullOrWhiteSpace(model.TENDERDOCGETMETHOD))
				{
				  condition.And(T_EC2_BIDINVITE._.TENDERDOCGETMETHOD.Contain(model.TENDERDOCGETMETHOD));
				}
				if(model.BIDDOCREFERENDTIME!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.BIDDOCREFERENDTIME==(model.BIDDOCREFERENDTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.BIDDOCREFERMETHOD))
				{
				  condition.And(T_EC2_BIDINVITE._.BIDDOCREFERMETHOD.Contain(model.BIDDOCREFERMETHOD));
				}
				if(model.BIDINVITEENDTIME!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.BIDINVITEENDTIME==(model.BIDINVITEENDTIME));
				}
				if(model.BIDINVITEISSUETIME!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.BIDINVITEISSUETIME==(model.BIDINVITEISSUETIME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERNAME))
				{
				  condition.And(T_EC2_BIDINVITE._.EXAMINERNAME.Contain(model.EXAMINERNAME));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODETYPE))
				{
				  condition.And(T_EC2_BIDINVITE._.EXAMINERCODETYPE.Contain(model.EXAMINERCODETYPE));
				}
				if(!string.IsNullOrWhiteSpace(model.EXAMINERCODE))
				{
				  condition.And(T_EC2_BIDINVITE._.EXAMINERCODE.Contain(model.EXAMINERCODE));
				}
				if(!string.IsNullOrWhiteSpace(model.ATTACHMENTCODE))
				{
				  condition.And(T_EC2_BIDINVITE._.ATTACHMENTCODE.Contain(model.ATTACHMENTCODE));
				}
				if(model.VERSION!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.VERSION==(model.VERSION));
				}
				if(!string.IsNullOrWhiteSpace(model.ISOPEN))
				{
				  condition.And(T_EC2_BIDINVITE._.ISOPEN.Contain(model.ISOPEN));
				}
				if(!string.IsNullOrWhiteSpace(model.OPENTYPE))
				{
				  condition.And(T_EC2_BIDINVITE._.OPENTYPE.Contain(model.OPENTYPE));
				}
				if(model.VERIFYTIME!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.VERIFYTIME==(model.VERIFYTIME));
				}
				if(!string.IsNullOrWhiteSpace(model.DATA_SOURCE))
				{
				  condition.And(T_EC2_BIDINVITE._.DATA_SOURCE.Contain(model.DATA_SOURCE));
				}
				if(model.CREATE_TIME!=null)
				{
				  condition.And(T_EC2_BIDINVITE._.CREATE_TIME==(model.CREATE_TIME));
				}
		return condition;
	}
        #endregion
    }
}