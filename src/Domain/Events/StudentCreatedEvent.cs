using clen_code_project.Domain.Common;
using clen_code_project.Domain.Entities;

namespace clen_code_project.Domain.Events
{
    public class StudentCreatedEvent : DomainEvent
    {
        public StudentCreatedEvent(Student student)
        {
            Student = student;
        }

        public Student Student { get; }
    }
}
