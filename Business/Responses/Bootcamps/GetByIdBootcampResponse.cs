﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Bootcamps
{
    public class GetByIdBootcampResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public DateTime InstructorDateOfBirth { get; set; }
        public string InstructorNationalIdentity { get; set; }
        public string InstructorEmail { get; set; }
        public string InstructorCompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BootcampStateName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
