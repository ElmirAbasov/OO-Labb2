using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Labb2
{
    public interface IMessageService
    {
        void Send(Order order, string subject, string message);
    }
}
