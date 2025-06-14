using AutoMapper;
using HabitTracker.Application.DTOs;
using HabitTracker.Domain.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<HabitTask, HabitTaskDto>();
        CreateMap<HabitTaskDto, HabitTask>();
    }
}