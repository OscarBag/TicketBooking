using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingCore
{
    public class TicketBookingSupport 
    {
        public static T Create<T>(TicketBookingRequest request) where T :
        TicketBookingBase, new()
        {
            return new T
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };
        }
    }
}
