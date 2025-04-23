namespace SMS.App.Views.IViews
{
    public interface ILoginForm
    {
        string Password { get; }
        string Username { get; }

        event EventHandler LoginEvent;

        void ShowMessage(string message);

    }
}