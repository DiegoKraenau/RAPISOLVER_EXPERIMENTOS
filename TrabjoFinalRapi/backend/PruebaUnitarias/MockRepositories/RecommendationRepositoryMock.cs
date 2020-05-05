using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class RecommendationRepositoryMock
    {
        public Mock<IRecommendationRepository> recommendationRepository { get; set; }

        public RecommendationRepositoryMock()
        {
            recommendationRepository = new Mock<IRecommendationRepository>();
            Setup();
        }

        private void Setup()
        {

            recommendationRepository.Setup((x) => x.Save(It.IsAny<Recommendation>())).Returns(true);
            recommendationRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(RecommendationStub.recommendation_1);
            recommendationRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            recommendationRepository.Setup((x) => x.GetAll()).Returns(RecommendationStub.recommendationList);
            recommendationRepository.Setup((x) => x.Update(It.IsAny<Recommendation>())).Returns(true);


        }
    }
}
