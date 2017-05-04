namespace RazorDeepDive.Services
{
    public interface IUserConfiguration
    {
        string Name { get; }
    }

    public class UserConfiguration : IUserConfiguration
    {
        public string Name => "Gilfoyle";
    }
}