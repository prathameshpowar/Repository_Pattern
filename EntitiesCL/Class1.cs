﻿using System;

namespace EntitiesCL
{
    public class Class1
    {
    }

    public class Institution
    {
        public long InstitutionID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }

    public class Course
    {
        public long CourseID { get; set; }
        public long InstitutionID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
