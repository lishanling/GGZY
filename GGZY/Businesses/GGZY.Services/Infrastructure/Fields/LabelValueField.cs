using Dos.ORM;

namespace GGZY.Services.Infrastructure.Fields
{
    [Table("Tmp")]
    public class LabelValueField:Dos.ORM.Entity
    {
        public readonly static Dos.ORM.Field Label = new Dos.ORM.Field("Label");
        public readonly static Dos.ORM.Field Value = new Dos.ORM.Field("Value");
    }
}