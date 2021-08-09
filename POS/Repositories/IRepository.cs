using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Repositories
{
    public interface IRepository<TViewModel>
    {
        public void Add(TViewModel viewModel);
    }
}
