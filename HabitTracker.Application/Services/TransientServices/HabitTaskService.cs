using AutoMapper;
using HabitTracker.Application.DTOs;
using HabitTracker.Domain.Entities;

namespace HabitTracker.Application.Services.TransientServices
{
    public class HabitTaskService : ApplicationService, IHabitTaskService
    {
        private readonly IMapper _mapper;

        public HabitTaskService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public HabitTaskDto MapHabitTaskIntoDto(HabitTask habitTask)
        {
            return _mapper.Map<HabitTaskDto>(habitTask);
        }
    }
}
