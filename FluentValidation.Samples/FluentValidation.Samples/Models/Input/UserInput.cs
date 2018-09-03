using FluentValidation.Samples.Infrastructures.Enum;

namespace FluentValidation.Samples.Models.Input
{
    public class UserInput
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool? Gender { get; set; }
        public string Email { get; set; }
        public UserStateType UserState { get; set; }
        public string[] Pictures { get; set; }

    }
}
