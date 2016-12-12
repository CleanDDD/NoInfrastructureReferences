using Core.Entities;

namespace Core.Interfaces
{
    public interface IGuestbookRepository
    {
        Guestbook GetById(int id);
    }
}