using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service.implementation
{
    public class ServiceDetailsService : IServiceDetailsService
    {
        private IServiceDetailsRepository serviceDetailsRepository;
        public ServiceDetailsService(IServiceDetailsRepository serviceDetailsRepository)
        {
            this.serviceDetailsRepository=serviceDetailsRepository;
        }

        public bool Delete(int id)
        {
            return serviceDetailsRepository.Delete(id);
        }

        public ServiceDetails Get(int id)
        {
            return serviceDetailsRepository.Get(id);
        }

        public IEnumerable<ServiceDetailsViewModel> Get3LastServices()
        {
            return serviceDetailsRepository.Get3LastServices();
        }

        public IEnumerable<ServiceDetails> GetAll()
        {
            return serviceDetailsRepository.GetAll();
        }

        public IEnumerable<ServiceDetailsViewModel> GetAllDetails()
        {
            return serviceDetailsRepository.GetAllDetails();
        }

        public IEnumerable<ServiceDetailsViewModel> GetServicioById(int id)
        {
            return serviceDetailsRepository.GetServicioById(id);
        }

        public IEnumerable<ServiceDetailsViewModel> GetServiciosByLowCost()
        {
            return serviceDetailsRepository.GetServiciosByLowCost();
        }

        public IEnumerable<ServiceDetailsViewModel> GetServiciosByLowCostAndName(string nombre)
        {
            return serviceDetailsRepository.GetServiciosByLowCostAndName(nombre);
        }

        public IEnumerable<ServiceDetailsViewModel> GetServiciosByNombre(string nombre)
        {
            return serviceDetailsRepository.GetServiciosByNombre(nombre);
        }

        public bool Save(ServiceDetails entity)
        {
            return serviceDetailsRepository.Save(entity);
        }

        public bool SaveServicio(ServiceDetailsViewModel entity)
        {
            return serviceDetailsRepository.SaveServicio(entity);
        }

        public bool Update(ServiceDetails entity)
        {
            return serviceDetailsRepository.Update(entity);
        }
    }
}