using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Options;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.AspNetCore;

using $ext_safeprojectname$.Application.Common.Interfaces;
using $ext_safeprojectname$.Application.Common.Configuration;
using $ext_safeprojectname$.Application.Features.Customer.Queries;
using $ext_safeprojectname$.Domain.Entities;

namespace $safeprojectname$.Persistence.AzureTableStorage;

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
