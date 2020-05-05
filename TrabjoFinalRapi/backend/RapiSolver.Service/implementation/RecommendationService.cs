using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service.implementation
{
    public class RecommendationService : IRecommendationService
    {

        private IRecommendationRepository recommendationRepository;
        public RecommendationService(IRecommendationRepository recommendationRepository)
        {
            this.recommendationRepository=recommendationRepository;
        }
        public bool Delete(int id)
        {
            return recommendationRepository.Delete(id);
        }

        public Recommendation Get(int id)
        {
            return recommendationRepository.Get(id);
        }

        public IEnumerable<Recommendation> GetAll()
        {
            return recommendationRepository.GetAll();
        }

        public IEnumerable<RecommendationViewModel> GetRecommendationsBySupplierId(int id)
        {
            return recommendationRepository.GetRecommendationsBySupplierId(id);
        }

        public bool Save(Recommendation entity)
        {
            return recommendationRepository.Save(entity);
        }

        public bool Update(Recommendation entity)
        {
            return recommendationRepository.Update(entity);
        }
    }
}