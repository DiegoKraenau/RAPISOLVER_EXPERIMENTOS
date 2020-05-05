using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PruebaUnitarias.MockRepositories;
using PruebaUnitarias.Stubs;
using RapiSolver.Api.Controllers;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Service;
using RapiSolver.Service.implementation;
using System.Collections;
using System.Collections.Generic;

namespace PruebaUnitarias
{
    [TestClass]
    public class RecommendationTest
    {
        private static IRecommendationService _recommendationService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IRecommendationRepository> _recommendationRepository = new RecommendationRepositoryMock().recommendationRepository;

            _recommendationService = new RecommendationService(_recommendationRepository.Object);

        }
        [TestMethod]
        public void Save_Objrecommendation_ReturnTrue()
        {
            
            var result = _recommendationService.Save(RecommendationStub.recommendation_1);
            Assert.AreEqual(true, result);
        

        }
        [TestMethod]
        public void GetById_SingleNumber_ReturnRecommendation()
        {
            var result = _recommendationService.Get(1);

            result.RecommendationId.Should().Be(1);
            result.Note.Should().NotBeNullOrEmpty();
            result.Note.Should().Be("Buen comentario");
            


        }
       
          [TestMethod]
          public void GetAll_Empty_ReturnrecommendationList()
          {

              var result = _recommendationService.GetAll();
              result.Should().NotBeNullOrEmpty();
              result.Should().HaveCountGreaterOrEqualTo(2);


          }


          [TestMethod]
          public void UpdateById_Objrecommendation_ReturnTrue()
          {
              var result = _recommendationService.Update(RecommendationStub.recommendation_1);
              Assert.AreEqual(true, result);
          }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _recommendationService.Delete(1);
            Assert.AreEqual(true, result);
        }
         
    }
        



}
