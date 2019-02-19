using FiLogger.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiLogger.Tests.MockData
{
    public static class MockCustomerData
    {
        public static CustomerDetails MockCustomerDetails()
        {
            return new CustomerDetails()
            {
                CustomerId = 1,
                FirstName = "Tommy",
                Surname = "Test",
                ContactConsent = false,
                TitleId = 1,
                HasCustomerInitiated = false,
                DistanceSellingId = 1,
                PolicyStatusId = 1,
                FranchiseId = 1,
                SalesPersonId = 1,
                RetailManagerId = 1,
                SdnId = 1,
                IsOrgansiation = false,
                DeferedSalesStatusId = 1
            };
        }

        public static IEnumerable<CustomerDetails> MockCustomerDetailsList()
        {
            return new List<CustomerDetails>()
            {
                new CustomerDetails{ 
                    CustomerId = 1,
                    FirstName = "Tommy",
                    Surname = "Test",
                    ContactConsent = false,                    
                    TitleId = 1,
                    HasCustomerInitiated = false,
                    DistanceSellingId = 1,
                    PolicyStatusId = 1,
                    FranchiseId = 1,
                    SalesPersonId = 1,
                    RetailManagerId = 1,
                    SdnId = 1,
                    IsOrgansiation = false,
                    DeferedSalesStatusId = 1
                },
                 new CustomerDetails{
                    CustomerId = 2,
                    FirstName = "John",
                    Surname = "Smith",
                    ContactConsent = true,                    
                    TitleId = 4,
                    HasCustomerInitiated = true,
                    DistanceSellingId = 2,
                    PolicyStatusId = 1,
                    FranchiseId = 2,
                    SalesPersonId = 1,
                    RetailManagerId = 2,
                    SdnId = 2,
                    IsOrgansiation = true,
                    DeferedSalesStatusId = 1,
                    OrgansiationName="New Company LTD"
                },
                  new CustomerDetails{
                    CustomerId = 3,
                    FirstName = "Jane",
                    Surname = "Jones",
                    ContactConsent = false,               
                    TitleId = 2,
                    HasCustomerInitiated = false,
                    DistanceSellingId = 1,
                    PolicyStatusId = 1,
                    FranchiseId = 2,
                    SalesPersonId = 2,
                    RetailManagerId = 1,
                    SdnId = 3,
                    IsOrgansiation = false,
                    DeferedSalesStatusId = 2
                }

            };
        }
    }
}
