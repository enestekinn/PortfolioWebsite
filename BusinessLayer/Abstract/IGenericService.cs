using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
        List<T> TGetListByFilter();
    }
}