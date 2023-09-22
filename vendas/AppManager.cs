using System;
using System.Threading;
using System.Windows.Forms;
using Vendas.Controller.controller;
using Vendas.Entity.Entities;

namespace Vendas.View
{
    class AppManager
    {
        public AppManager() { }
        private static bool _started;
        private IView _currentView;
        private static AppManager _instance;
        private User user;
        public static AppManager Instance
        {
            get
            {
                if (!_started)
                    throw new Exception("Tried to call the singleton instance of the AppManager before the AppManager started.");

                return _instance;
            }
        }
        public void Show<T>(Controller<T> controller) where T: class
        {
            if (_currentView != null)
            {
                _currentView.Close();
                _currentView.Form.Dispose();
            }
            _currentView = controller.View;

            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public static void Start<T>()
            where T : Controller<User>
        {
            if (_started) return;

            _started = true;

            T controller = Activator.CreateInstance<T>();

            if (controller != null)
            {
                _instance = new AppManager()
                {
                    _currentView = controller.View
                };

                _instance.openForm();
            }
            else
                Application.Exit();
        }

        public void Load<T, Y>()
            where T : Controller<Y> where Y : class
        {
            T controller = Activator.CreateInstance<T>();

            if (controller != null)
            {
                if (controller.Loadable())
                    controller.OnLoadSuccess(EventArgs.Empty);
                else
                    controller.OnLoadFailure(EventArgs.Empty);
            }
            else
                Application.Exit();
        }
        private void openForm()
        {
            Application.Run(_currentView.Form);
        }
    }
}
