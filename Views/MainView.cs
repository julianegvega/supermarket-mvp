﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnProviders.Click += delegate { ShowProvidersView?.Invoke(this, EventArgs.Empty); };
            BtnExit.Click += delegate { this.Close(); };
        }

        Action<object?, EventArgs> IMainView.ShowProvidersView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowProvidersView;
        public event EventHandler ShowCategoriesView;
        public event EventHandler ShowCustomerView;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
