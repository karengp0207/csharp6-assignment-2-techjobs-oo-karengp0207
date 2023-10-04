
using System.Data;
using System.Xml.Linq;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), 
            new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), 
            new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job5 = new Job("Product tester", new Employer("ACME"), new Location(""), 
            new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        /* task 4.1 Test the Empty Constructor */
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1.Id, job2.Id);

            Assert.AreEqual(job1.Id + 1, job2.Id);
        }

        [TestMethod]
        /* task 4.2 Test the Full Constructor */
        public void TestJobConstructorSetsAllFields()
        {
            string expectedName = "Product tester";
            string expectedEmployerName = "ACME";
            string expectedEmployerLocation = "Desert";
            string expectedJobType = "Quality control";
            string expectedJobCoreCompetency = "Persistence";

            Assert.AreEqual(expectedName, job3.Name);
            Assert.AreEqual(expectedEmployerName, job3.EmployerName.Value);
            Assert.AreEqual(expectedEmployerLocation, job3.EmployerLocation.Value);
            Assert.AreEqual(expectedJobType, job3.JobType.Value);
            Assert.AreEqual(expectedJobCoreCompetency, job3.JobCoreCompetency.Value);
         }

        [TestMethod]
        /* task 4.3 Test the Equals() Method */
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        /* task 5.1 First Test for ToString() */
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith("\n"));
            Assert.IsTrue(job3.ToString().EndsWith("\n"));
        }

        [TestMethod]
        /* task 5.2 Test ToString() contains Labels */
        public void TestToStringContainsCorrectLablesAndData()
        {
            string expected = "\nID: " + job3.Id + "\nName: " + job3.Name + "\nEmployer: " + job3.EmployerName
                 + "\nLocation: " + job3.EmployerLocation + "\nPosition Type: " + job3.JobType
                 + "\nCore Competency: " + job3.JobCoreCompetency + "\n";

            Assert.AreEqual(expected, job3.ToString());
        }

        [TestMethod]
        /* task 5.3 Test ToString() contains Empty Fields */
        public void TestToStringHandlesEmptyField()
        {
            Assert.IsTrue(job5.ToString().Contains(" Data not available"));
        }
    }
}

/* from Job.cs:
    public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
            :this()
        {
    Name = name;
    EmployerName = employerName;
    EmployerLocation = employerLocation;
    JobType = jobType;
    JobCoreCompetency = jobCoreCompetency;

}*/