/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:atg.Concesionario.PresentationLayer.WPF"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using atg.Concesionario.Domain.Contracts;
using atg.Concesionario.Domain.Contracts.Repositories;
using atg.Concesionario.Domain.Services;
using atg.Concesionario.Persistence;
using atg.Concesionario.Persistence.Repositories;
using atg.Concesionario.Persistence.UnitOfWork;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace atg.Concesionario.PresentationLayer.WPF.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IUnitOfWork, EFUnitOfWork>();
            SimpleIoc.Default.Register<ICustomerRepository, CustomerRepository>();
            SimpleIoc.Default.Register<ICustomerService,CustomerService>();
            SimpleIoc.Default.Register<AuthorizedDealerDBContext>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CustomerListViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public CustomerListViewModel CustomerListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CustomerListViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}