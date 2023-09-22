using Vendas.Entity.Entities;

namespace Vendas.Service.Controllers
{
    public interface IBaseController<T> where T : BaseEntity
    {
        void Save(T entity);
        void SelectAll();
        void Exclude(T entity);
        void SelectById(int id);
        void Filter(string condition);

    }
}