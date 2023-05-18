using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ICRUData<T>
    {
        List<T> EntityList();
        void CreateItem(T oEntity);
        void UpdateItem(T oEntity);
    }
}
