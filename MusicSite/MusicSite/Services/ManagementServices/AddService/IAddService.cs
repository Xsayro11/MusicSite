﻿using System.Collections.Generic;

namespace MusicSite.Services.ManagementServices.AddServices
{
    public interface IAddService<T> where T : class
    {
        T Add(T model, List<T> models);
    }
}