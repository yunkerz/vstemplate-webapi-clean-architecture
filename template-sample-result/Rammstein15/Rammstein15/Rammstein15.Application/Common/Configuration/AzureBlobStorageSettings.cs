﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rammstein15.Application.Common.Configuration
{
    public class AzureBlobStorageSettings
    {
        public string AzureStorageConnectionString { get; set; }

        public string CustomerBlobContainerName { get; set; }
    }
}
