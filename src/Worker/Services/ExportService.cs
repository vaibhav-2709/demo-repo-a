using AutoMapper;

namespace Worker.Services
{
    public class ExportService
    {
        private readonly IMapper _mapper;

        public ExportService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public object MapToDto(object entity)
        {
            return _mapper.Map<object>(entity);
        }
    }
}
