using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class InMemoryGuestbookRepository : IGuestbookRepository
    {
        public Guestbook GetById(int id)
        {
            return new Guestbook() {Id = id, Name = "A Guestbook From Infrastructure"};
        }
    }
}