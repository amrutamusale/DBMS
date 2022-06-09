using System;

namespace WebApplication5.Controllers
{
    internal class SampleDb1Context
    {
        public object Tblsamples { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}