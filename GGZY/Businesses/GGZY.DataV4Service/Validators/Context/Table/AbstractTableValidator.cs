using System.Data;

namespace GGZY.DataV4Service.Validators.Context.Table
{
    public abstract class AbstractTableValidator : AbstractValidator
    {
        public virtual void DoAfterSaveData(DataTable dtTitle, DataTable dtContext)
        {
            
        }
    }
}