using Microsoft.AspNetCore.Identity;
using SMS.App.Views.IViews;
using SMS.Domain;
using SMS.Infastructure.Data;

namespace SMS.App.Presenters
{
    public class LoginPresenter
    {
        private ILoginForm _view;
        private PasswordHasher<AppUser> _passwordHasher;
        private string _message;

        public LoginPresenter(ILoginForm view)
        {
            _view = view;

            _passwordHasher = new PasswordHasher<AppUser>();

            _view.LoginEvent += Login;

        }

        private void Login(object? sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext()) 
            {
                var user = dbContext.AppUsers.Where(c => c.UserName == _view.Username).FirstOrDefault();

                if (user == null)
                {
                    _message = "User not found";
                    _view.ShowMessage(_message);

                    //gibutang ra nko ni kay dli ga update ako database :<
                    //IProgramView programView = new ProgramView();
                    //new ProgramPresenter(programView);
                    //programView.ShowForm();

                    return;
                }

                var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, _view.Password);

                if(passwordVerificationResult == PasswordVerificationResult.Success)
                {
                    _message = "Login Successful";

                    IProgramView programView = new ProgramView();
                    new ProgramPresenter(programView);

                    programView.ShowForm();
                }
                else
                {
                    _message = "Invalid password";
                    _view.ShowMessage(_message);
                    return;
                }
            }
        }
    }
}
