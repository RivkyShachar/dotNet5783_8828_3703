using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi;

public interface IDal
{
    public IProduct Product { get;}
    public IOrderItem OrderItem { get;}
    public IOrder order { get;}
}
