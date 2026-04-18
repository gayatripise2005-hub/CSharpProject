using BookManagementApi.Entity.Model;
using BookManagementApi.Repository;
using BookManagementApi.service.Definition;

namespace BookManagementApi.service.Implmentation
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository<Review> _repository;

        public ReviewService(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task<List<Review>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Review> GetById(int id)
        {
            var review = await _repository.GetById(id);

            if (review == null)
                throw new Exception("Review not found");

            return review;
        }

        public async Task<Review> Add(Review review)
        {
            if (review == null)
                throw new Exception("Invalid Review");

            if (review.BookId <= 0)
                throw new ArgumentException("BookId is required");

            if (string.IsNullOrWhiteSpace(review.Comment))
                throw new ArgumentException("Comment is required");

            if (review.Rating < 1 || review.Rating > 5)
                throw new ArgumentException("Rating must be between 1 and 5");

            await _repository.Add(review);
            return review;
        }

        public async Task<Review> Update(Review review)
        {
            if (review == null)
                throw new Exception("Invalid Review");

            var existing = await _repository.GetById(review.Id);

            if (existing == null)
                throw new Exception("Review not found");

            await _repository.Update(review);
            return review;
        }

        public async Task<bool> Delete(int id)
        {
            var existing = await _repository.GetById(id);

            if (existing == null)
                throw new Exception("Review not found");

            await _repository.Delete(id);
            return true;
        }
    }
}
