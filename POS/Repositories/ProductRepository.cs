using Dapper;
using POS.DbEntities;
using POS.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;


namespace POS.Repositories
{
    public class ProductRepository : BaseRepository<Products, ProductVm>
    {
        
    }
}
