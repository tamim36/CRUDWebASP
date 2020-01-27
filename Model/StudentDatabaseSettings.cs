using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class StudentDatabaseSettings : IStudentDatabaseSettings
    {
        public string StudentsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
