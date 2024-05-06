using AutoMapper;
using Hanan_csharp_backend_teamwork.src.Abstractions;
using Hanan_csharp_backend_teamwork.src.DTOs;
using Hanan_csharp_backend_teamwork.src.Entities;

namespace Hanan_csharp_backend_teamwork.src.Services
{
    public class AddressService : IAddressService
    {
        private IAddressRepoistory _addressRepoistory;
        private IMapper _mapper;
        public AddressService(IAddressRepoistory addressRepoistory, IMapper mapper)
        {
            _addressRepoistory = addressRepoistory;
            _mapper = mapper;
        }

        public Address CreateOne(AddressDTO userAddress)
        {
            return _addressRepoistory.CreateOne(_mapper.Map<Address>(userAddress));

        }

        public bool DeleteById(Guid id)
        {
            return _addressRepoistory.DeleteById(id);
        }


        public IEnumerable<Address> FindAll()
        {
            return _addressRepoistory.FindAll();
        }

        public Address? FindOne(Guid id)
        {
            return _addressRepoistory.FindOne(id);
        }
    }
}
