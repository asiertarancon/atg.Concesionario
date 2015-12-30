using atg.Concesionario.Application.Common;
using atg.Concesionario.Domain.Budgets;
using atg.Concesionario.Domain.Contracts;
using atg.Concesionario.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Services
{
    public class BudgetService : EntityService<Budget>, IBudgetService
    {
        IUnitOfWork _unitOfWork;
        IBudgetRepository _budgetRepository;

        public BudgetService(IUnitOfWork unitOfWork, IBudgetRepository budgetRepository)
            : base(unitOfWork, budgetRepository)
        {
            _unitOfWork = unitOfWork;
            _budgetRepository = budgetRepository;
        }


        //public Budget GetById(int Id)
        //{
        //    return _budgetRepository.FindBy(n=>n.Id);
        //}
    }
}
