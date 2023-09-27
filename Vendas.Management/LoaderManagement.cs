using System;
using System.Windows.Forms;

namespace Vendas.Management
{
    public abstract class LoaderManagement//<T> where T : class
    {

        public abstract IView View { get; }
        public abstract bool CloseLastView { get; }

        public event EventHandler LoadSuccess, LoadFailed;

        public LoaderManagement()
        {
            LoadSuccess += OnLoadSucceededHandler;
            LoadFailed += OnLoadFailedHandler;
        }

        public abstract bool Loadable();

        protected virtual void OnLoadSucceededHandler(Object sender, EventArgs e)
        {
            AppManager.Instance.Show(this, CloseLastView);
        }

        protected virtual void OnLoadFailedHandler(Object sender, EventArgs e)
        {
            if (MessageBox.Show("You don't have access to load this page.\nThe application will exit now.") == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void OnLoadSuccess(EventArgs e)
        {
            if (LoadSuccess != null)
                LoadSuccess(this, e);
        }

        public void OnLoadFailure(EventArgs e)
        {
            if (LoadFailed != null)
                LoadFailed(this, e);
        }
    }
}
