using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    //TODO: В .NET уже есть интерфейс ICloneable, свой создавать не надо https://docs.microsoft.com/ru-ru/dotnet/api/system.icloneable?view=netframework-4.8
    /// <summary>
    /// Интерфейс для создания методов копирования объектов
    /// </summary>
    public interface ICloneable
    {
        object Clone();
    }
}
