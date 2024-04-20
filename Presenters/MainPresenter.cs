using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowProvidersView += ShowProvidersView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
        }

        private void ShowCategoriesView(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ICategoriesView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoriesRepository repository = new CategoriesRepository(sqlConnectionString);
            new CategoriesPresenter(view, repository);
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowProvidersView(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            IProvidersView view = ProvidersView.GetInstance((MainView)mainView);
            IProvidersRepository repository = new ProvidersRepository(sqlConnectionString);
            new ProvidersPresenter(view, repository);
        }
    }

    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
    }

    internal interface IProvidersRepository
    {
    }

    internal class ProvidersRepository
    {
        private string sqlConnectionString;

        public ProvidersRepository(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }
    }

    internal class ProvidersView
    {
        internal static IProvidersView GetInstance(MainView mainView)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IProvidersView
    {
    }

    internal class PayModeView
    {
        internal static IPayModeView GetInstance(MainView mainView)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IPayModeView
    {
        Action<object?, EventArgs> SearchEvent { get; set; }
        Action<object?, EventArgs> AddNewEvent { get; set; }
        Action<object?, EventArgs> EditEvent { get; set; }
        Action<object?, EventArgs> DeleteEvent { get; set; }
        Action<object?, EventArgs> SaveEvent { get; set; }
        Action<object?, EventArgs> CancelEvent { get; set; }
        bool PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservation { get; set; }
        bool IsEdit { get; set; }
        string Message { get; set; }
        bool IsSuccesful { get; set; }
        string? SearchValue { get; set; }

        void SetPayModeListBildingSource(BindingSource payModeBindingSource);
        void Show();
    }

    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
    }

    internal class ProductRepository : IProductRepository
    {
        public ProductRepository(string sqlConnectionString)
        {
        }
    }

    internal interface IProductRepository
    {
    }

    internal class ProductView
    {
        internal static IProductView GetInstance(MainView mainView)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IProductView
    {
    }

    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
    }

    internal class CategoriesRepository : ICategoriesRepository
    {
        public CategoriesRepository(string sqlConnectionString)
        {
        }
    }

    internal interface ICategoriesRepository
    {
    }

    internal class CategoriesView
    {
        internal static ICategoriesView GetInstance(MainView mainView)
        {
            throw new NotImplementedException();
        }
    }

    internal interface ICategoriesView
    {
    }
}
