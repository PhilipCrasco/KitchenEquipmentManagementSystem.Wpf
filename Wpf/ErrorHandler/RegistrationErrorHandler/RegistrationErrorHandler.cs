using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace Wpf.ErrorHandler.RegistrationErrorHandler
{
    public class RegistrationErrorHandler
    {
        Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.TopRight,
                offsetX: 10,
                offsetY: 10);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(3),
                maximumNotificationCount: MaximumNotificationCount.FromCount(3));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });


        public void RegistrationSuccess()
        {
            notifier.ShowSuccess("Successfully Register");
            Task.Delay(TimeSpan.FromSeconds(2));

        }

        public void FullNameNull()
        {
            notifier.ShowError("FullName must be fill!");
            Task.Delay(TimeSpan.FromSeconds(2));

        }


        public void LastNameNull()
        {
            notifier.ShowError("LastName must be fill!");
            Task.Delay(TimeSpan.FromSeconds(2));

        }

        public void EmailNull()
        {
            notifier.ShowError("Email Address must be fill!");
            Task.Delay(TimeSpan.FromSeconds(2));

        }

        public void UserNameNull()
        {
            notifier.ShowError("UserName must be fill!");
            Task.Delay(TimeSpan.FromSeconds(2));

        }

        public void PasswordNull()
        {
            notifier.ShowError("Password must be fill!");
            Task.Delay(TimeSpan.FromSeconds(2));

        }










    }
}
