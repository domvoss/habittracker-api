using HabitTracker.Application.DTOs;
using HabitTracker.Domain.Entities;

namespace HabitTracker.Application.Services.TransientServices
{
    public interface IHabitTaskService : IApplicationService
    {
        HabitTaskDto MapHabitTaskIntoDto(HabitTask habitTask);
        // Other service methods...
    }
}
