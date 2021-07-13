using System.Collections.Generic;
using GGZY.DataV4Service.Validators;

namespace GGZY.DataV4Service.Dto
{
    public class ValidatorDictionary : Dictionary<string, object>
    {
        public IDataValidator Validator { get; set; }
    }
}