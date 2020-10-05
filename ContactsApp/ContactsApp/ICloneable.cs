using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
   /// <summary>
   /// Интерфейс для создания методов копирования объектов
   /// </summary>
    public interface ICloneable
    {
        object Clone();
    }
}
