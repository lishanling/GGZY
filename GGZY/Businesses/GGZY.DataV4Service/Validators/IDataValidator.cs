using System.Data;

namespace GGZY.DataV4Service.Validators
{
    public interface IDataValidator
    {
        string GetName();
        void Validate(DataTable dtTitle,DataTable dtContext);

    }
}