﻿using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace AzureFunctionsTODO.TableStorage
{
    public class TodoTableEntity : TableEntity
    {
        public DateTime CreatedTime { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
