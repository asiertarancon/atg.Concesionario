using atg.Concesionario.Domain.Contracts;
using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Domain.Services;
using atg.Concesionario.PresentationLayer.WPF.Helper;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.PresentationLayer.WPF.ViewModels
{
    public class CustomerListViewModel : ViewModelBase
    {
        private readonly ICustomerService _customerService;
        public CustomerListViewModel(ICustomerService customerService)
        {
            _customerService = customerService;

            Customers = _customerService.GetAll().ToList();
        }

        private IEnumerable<Customer> _customers;
        public IEnumerable<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {                
                Set(() => Customers, ref _customers, value);
            }
        }

    }
}
