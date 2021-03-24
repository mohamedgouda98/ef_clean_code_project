using clen_code_project.Application.Common.Interfaces;
using System;

namespace clen_code_project.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
