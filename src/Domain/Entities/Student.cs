using clen_code_project.Domain.Common;
using clen_code_project.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace clen_code_project.Domain.Entities
{
    public class Student : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
