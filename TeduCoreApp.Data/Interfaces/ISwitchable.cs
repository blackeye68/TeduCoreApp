using TeduCoreApp.Data.Enums;

namespace TeduCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}