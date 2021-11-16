using AutoMapper;
using ProjectA;

namespace ProjectB
{
    public class MyCustomAutoMapper : IMyMapper
    {
        private readonly IMapper _mapper;

        public MyCustomAutoMapper()
        {
            _mapper = new AutoMapper.Mapper(null);
        }

        public object Map(object A, object B)
        {
            return _mapper.Map(A, B);
        }
    }
}