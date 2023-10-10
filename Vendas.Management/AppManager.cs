using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Vendas.Management
{
    public class AppManager
    {

        public AppManager() { }
        private static bool _started;
        private readonly List<IView> _currentViews = new List<IView>();
        private static AppManager _instance;
        //private User user;
        public static AppManager Instance
        {
            get
            {
                if (!_started)
                    throw new Exception("Tried to call the singleton instance of the AppManager before the AppManager started.");
                return _instance;
            }
        }
        public void Show(LoaderManagement controller, bool closeLast)
        {
            if (closeLast)
            {
                _currentViews[_currentViews.Count-1].Close();
                _currentViews[_currentViews.Count - 1].Form.Dispose();
            }
            _currentViews.Add(controller.View);

            Thread th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public static void Start<T>(IView view)
            where T : LoaderManagement
        {
            if (_started) return;

            _started = true;

            T controller = Activator.CreateInstance<T>();

            if (controller != null)
            {
                _instance = new AppManager() { };
                _instance._currentViews.Add(view);

                _instance.OpenForm();
            }
            else
                Application.Exit();
        }

        public void Load<T, Y>(IView view)
            where T : LoaderManagement
        {
            if (Activator.CreateInstance(typeof(T), view) is T controller)
            {
                if (controller.Loadable())
                    controller.OnLoadSuccess(EventArgs.Empty);
                else
                    controller.OnLoadFailure(EventArgs.Empty);
            }
            else
                Application.Exit();
        }
        private void OpenForm()
        {
            Application.Run(_currentViews[_currentViews.Count-1].Form);
        }

        public void CloseForm(int form = 0, IView view = null) {
            var closeForm = view ?? _currentViews[_currentViews.Count - 1 - form];
            _currentViews.Remove(closeForm);
            closeForm.Close();
        }
    }
}
