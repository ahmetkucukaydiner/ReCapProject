﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int id);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
