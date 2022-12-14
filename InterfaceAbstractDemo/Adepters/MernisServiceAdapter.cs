using InterfaceAbstractDemo.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adepters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                                                 customer.FirstName.ToUpper(),
                                                 customer.LastName.ToUpper(),
                                                 customer.DateOfBirth.Year);
        }
    }
}
