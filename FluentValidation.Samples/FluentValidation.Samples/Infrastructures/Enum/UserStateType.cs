using System.ComponentModel;

namespace FluentValidation.Samples.Infrastructures.Enum
{
    public enum UserStateType
    {
        [Description("未激活")]
        Inactive = 1,
        [Description("已激活")]
        Activated = 2,
        [Description("已删除")]
        Deleted = 3
    }
}
