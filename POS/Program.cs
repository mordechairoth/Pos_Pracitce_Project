using POS.Repositories;
using System;
using System.Linq;

namespace POS
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyRepo = new CompanyRepository();
            var company = companyRepo.All().First();
            company.Name = "this is the latest and greatest update in the db";
            companyRepo.Update(company);

            Console.WriteLine(companyRepo.All().FirstOrDefault().Name);
        }
    }
}
