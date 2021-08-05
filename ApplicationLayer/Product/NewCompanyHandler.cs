using POS.Repositories;
using POS.ViewModels.Product;
using System;

namespace ApplicationLayer.Product
{
    public class NewCompanyHandler
    {
        public NewCompanyHandler()
        {
            Company = new CompanyVm();
        }

        public event EventHandler NewCompanySavedEventHandler;
        public CompanyVm Company { get; set; }
        public bool IsSaved { get; set; }

        public void Save()
        {
            var companyRepository = new CompanyRepository();
            companyRepository.Add(Company);
            IsSaved = true;
            OnCompanySaved();
        }

        protected virtual void OnCompanySaved()
        {
            NewCompanySavedEventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}
