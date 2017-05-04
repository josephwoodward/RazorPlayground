namespace RazorDeepDive.Services
{
    public interface IUserConfiguration
    {
        string Name { get; }

        bool LoggedIn { get; }
    }

    public class UserConfiguration : IUserConfiguration
    {
        public string Name => "Gilfoyle";

        public bool LoggedIn => true;
    }
}