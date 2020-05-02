namespace RapiSolver.Entity
{
    public class Recommendation
    {
        public int RecommendationId{get;set;}

        public Usuario Usuario{get;set;}

        public Supplier Supplier{get;set;}

        public int UsuarioId{get;set;}

        public int SupplierId{get;set;}

        public string Note{get;set;}
        
        public double Mark{get;set;}
    }
}