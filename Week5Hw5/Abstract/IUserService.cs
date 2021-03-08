using Week5Hw5.Entities;

namespace Week5Hw5.Abstract
{
    public interface IUserService
    {
        public void Add(User user);
        public void Delete(User user);
        public void Update(User user);

    }
}
