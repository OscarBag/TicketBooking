using System.Runtime.InteropServices;

namespace TicketBookingCore
{
    public class TicketBookingRequestProcessor
    {
        private readonly ITicketBookingRepository _Ticket;
        public TicketBookingRequestProcessor(ITicketBookingRepository ticketBookingRepository)
        {
            _Ticket = ticketBookingRepository;
        }

        public TicketBookingResponse Book(TicketBookingRequest request)
        {
            if(request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            _Ticket.Save(TicketBookingSupport.Create<TicketBooking>(request));

            return TicketBookingSupport.Create<TicketBookingResponse>(request);

        }


    }
}