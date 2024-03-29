﻿using FinancialControlSystem.Logic.Models;

namespace FinancialControlSystem.Logic.Interfaces
{
    public interface IAdderer
    {
        public void Add<T>(T Model) where T : class;
    }
}
