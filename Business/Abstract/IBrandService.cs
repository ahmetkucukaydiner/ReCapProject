﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetById(int id);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);

    }
}