using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Peristence
{
    public interface ILogging
    {
        Task AddLog(string message);
    }
}
