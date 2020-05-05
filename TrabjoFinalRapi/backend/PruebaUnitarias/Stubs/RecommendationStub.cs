using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class RecommendationStub
    {
         public static Recommendation recommendation_1 = new Recommendation()
         {
            RecommendationId = 1,

            Note = "Buen comentario",

            Mark = 8.0
    };

        public static Recommendation recommendation_2 = new Recommendation()
        {
            RecommendationId= 2,

            Note = "Mal comentario",

            Mark = 1.0
        };
        public static List<Recommendation> recommendationList = new List<Recommendation>(new Recommendation[] { recommendation_1, recommendation_2 });

    }
}
