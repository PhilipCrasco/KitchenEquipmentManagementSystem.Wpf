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

namespace Wpf.ErrorHandler.LoginErrorHandler
{
    public class LoginErrorHandler
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

        public void LoginSuccess(string Firstname , string Lastname)
        {
            notifier.ShowSuccess($"Welcome  {Firstname} {Lastname}");
            Task.Delay(TimeSpan.FromSeconds(2));
        }


        public void LoginFailed()
        {
            notifier.ShowError($"Username or Password is incorrect!");
            Task.Delay(TimeSpan.FromSeconds(2));
        }

    }
}
