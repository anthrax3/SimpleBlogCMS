﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleBlog.Core
{
    public interface IModuleInitializer
    {
        void Init(IServiceCollection serviceCollection);
    }
}
