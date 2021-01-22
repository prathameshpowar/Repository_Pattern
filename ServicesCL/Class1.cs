using EntitiesCL;
using System;

namespace ServicesCL
{
    public class Class1
    {
    }

    public interface IInstututionService
    {
        Institution GetInstitutionByID(long institutionID);
    }

    public interface ICourseService
    {
        Course GetCourseByID(long courseID);
    }


    public class InstitutionService : IInstututionService
    {
        public Institution GetInstitutionByID(long institutionID)
        {
            return new Institution()
            {
                InstitutionID = institutionID,
                Name = "Demo Institution",
                Address = "Demo Address",
                Telephone = "0123456789"
            };
        }
    }

    public class CourseService : ICourseService
    {
        public Course GetCourseByID(long courseID)
        {
            return new Course
            {
                CourseID = courseID,
                Description = "Demo course description",
                InstitutionID = 1,
                Title = "Demo Course Title"
            };
        }
    }

}
