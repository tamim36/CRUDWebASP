using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Xunit;

namespace Repository.Test
{
    public class RepositoryManagementTests
    {
        IStudentDatabaseSettings _settings = new StudentDatabaseSettings() { ConnectionString = "mongodb://localhost:27017", DatabaseName = "WebApiDB", StudentsCollectionName = "Students" };

        [Fact]
        public void Get_ShouldReturnSingleRecord()
        {
            // Arrange
            IRepositoryManagement _repository = new RepositoryManagement(_settings);
            Student expected = new Student() { Name = "Tamim" , Department="EEE", PrimaryId= "5e2d33b06b8c8b280adf36f1"};

            // Actual
            Student actual = _repository.Get<Student>("5e2d33b06b8c8b280adf36f1");

            // Assert
            Assert.Equal(expected.Department, actual.Department);
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.PrimaryId, actual.PrimaryId);
        }

        [Fact]
        public void Delete_ShouldDeleteSingleRecord()
        {
            // Arrange
            IRepositoryManagement _repository = new RepositoryManagement(_settings);
            Student expected = new Student() { Name = "Tamim", Department = "EEE", PrimaryId = "5e2d33b06b8c8b280adf36f1" };

            // Actual
            Student actual = _repository.Get<Student>("5e2d33b06b8c8b280adf36f1");

            // Assert
            Assert.Equal(expected.Department, actual.Department);
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.PrimaryId, actual.PrimaryId);
        }

    }
}