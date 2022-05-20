using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rammstein15.Application.Common.Configuration
{
    public class AzureTableStorageSettings
    {
        public string AzureStorageConnectionString { get; set; }

        public string CustomerTableName { get; set; }
    }
}