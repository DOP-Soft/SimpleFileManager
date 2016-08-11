﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileManager.Repositories.Interfaces
{
    interface IIOEntityRepository<T>
    {
        IEnumerable<T> GetRootEntries();
        IEnumerable<T> Get(string path);
    }
}
