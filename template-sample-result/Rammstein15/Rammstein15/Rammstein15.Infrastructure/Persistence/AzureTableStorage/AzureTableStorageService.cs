using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.AspNetCore;
using Microsoft.Extensions.Options;
using Rammstein15.Application.Common.Configuration;
using Rammstein15.Application.Common.Interfaces;
using Rammstein15.Application.Features.Customer.Queries;
using Rammstein15.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rammstein15.Infrastructure.Persistence.AzureTableStorage
{
    public class AzureTableStorageService : IApplicationTableStorage
    {
        #region Properties

        private readonly AzureTableStorageSettings _configurationSettings;
        private readonly TelemetryClient _telemetryClient;

        #endregion

        #region Constructor

        public AzureTableStorageService(IOptions<AzureTableStorageSettings> settings, TelemetryClient telemetryClient)
        {
            _configurationSettings = settings.Value;
            _telemetryClient = telemetryClient;
        }


        #endregion

        public async Task<Customer> GetCustomerByCustomerId(GetCustomerByCustomerIdQuery request)
        {
            try
            {
                string customerTableName = _configurationSettings.CustomerTableName;

                // Return mocked-up data for this example. In real life, do the things and await stuff.
                return new Customer()
                {
                    CustomerId = "324323b-CST",
                    CustomerName = "Tampa Bay Bossa Nova Industries, LLC",
                    IsActive = true
                };
            }
            catch (Exception ex)
            {
                _telemetryClient.TrackException(ex, null, null);
                throw;
            }

        }
    }
}