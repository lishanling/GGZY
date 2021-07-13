namespace GGZY.DataV4Service.Exceptions
{
    public class ThrowHelper
    {
        public static void ThrowIfTure(bool condition, string msg)
        {
            if (condition)
            {
                throw new StrongException(msg);
            }
        }
    }
}