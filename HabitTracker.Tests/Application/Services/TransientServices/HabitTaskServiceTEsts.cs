using AutoMapper;
using HabitTracker.Application.DTOs;
using HabitTracker.Application.Services.TransientServices;
using HabitTracker.Domain.Entities;
using Xunit;

namespace HabitTracker.Tests.Application.Services.TransientServices
{
    public class HabitTaskServiceTests
    {
        private readonly IMapper _mapper;
        private readonly HabitTaskService _service;

        public HabitTaskServiceTests()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>(); // your AutoMapper profile class
            });
            _mapper = config.CreateMapper();

            _service = new HabitTaskService(_mapper);
        }

        [Fact]
        public void MapHabitTaskToDto_ShouldCopyTitle()
        {
            // Arrange
            HabitTask habitTask = new()
            {
                Id = Guid.NewGuid(),
                Title = "Test Entity",
                Description = "Desc",
                StartDate = DateTime.Today,
                Frequency = "Daily",
                IsComplete = false
            };

            // Act
            HabitTaskDto dto = _service.MapHabitTaskIntoDto(habitTask);

            // Assert
            Assert.Equal("Test Entity", dto.Title);
        }
    }
}
