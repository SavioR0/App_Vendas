﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;

namespace Vendas.Service.Interfaces
{
    public interface ISaleController
    {
        string Save(SaleOrderCompleteDTO entity);
        string Exclude(Sale entity);
        string Exclude(int id);
        IQueryable<Sale> Filter(Expression<Func<Sale, bool>> condition);
        IQueryable<SaleDTO> FilterDTO(Expression<Func<SaleDTO, bool>> condition, TypeUser typeUser);
        List<SaleDTO> SelectAllDTO(TypeUser typeUSer);
        IQueryable<Sale> GetAll();

    }
}