using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IStudentDatabaseSettings
    {
        string StudentsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
