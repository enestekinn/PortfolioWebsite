
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
 public class PortfolioManager : IPortfolioService
 {
  IPortfolioDal _portfolioDal;

  public PortfolioManager(IPortfolioDal portfolioDal)
  {
   _portfolioDal = portfolioDal;
  }

  public void TAdd(Portfolio t)
  {
   _portfolioDal.Insert(t);
  }

  public void TDelete(Portfolio t)
  {
   _portfolioDal.Delete(t);
  }

  public List<Portfolio> TGetList()
  {
   return _portfolioDal.GetList();
  }

  public Portfolio TGetById(int id)
  {
   return  _portfolioDal.GetById(id);
  }

  public List<Portfolio> TGetListByFilter()
  {
   throw new System.NotImplementedException();
  }

  public void TUpdate(Portfolio t)
  {
   _portfolioDal.Update(t);
  }

 }
}