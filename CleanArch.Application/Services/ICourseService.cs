using System.Collections.Generic;
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetAll();
        
    }
}