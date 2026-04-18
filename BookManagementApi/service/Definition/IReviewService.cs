using BookManagementApi.Entity.Model;

namespace BookManagementApi.service.Definition
{
    public interface IReviewService
    {
        Task<List<Review>> GetAll();
        Task<Review> GetById(int id);
        Task<Review> Add(Review review);
        Task<Review> Update(Review review);
        Task<bool> Delete(int id);
    }
}
