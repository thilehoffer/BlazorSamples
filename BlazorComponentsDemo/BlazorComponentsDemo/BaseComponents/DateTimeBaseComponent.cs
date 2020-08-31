﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentsDemo.BaseComponents
{
    public class DateTimeBaseComponent :ComponentBase
    {
        public DateTime dateTime { get; set; }
    }
}
