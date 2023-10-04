using System;

namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
            public Job()
            {
            Id = nextId;
            nextId++;
            }

            public Job(string name, Employer employerName, Location employerLocation, 
                PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;

        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }




        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            //string jobListings = "\n" + "\nID: " + this.Id + "\nName: " + this.Name + "\nEmployer: "
            //+ this.EmployerName + "\nLocation: " + this.EmployerLocation + "\nPosition Type: " 
            //+ this.JobType + "\nCore Competency: " + this.JobCoreCompetency + "\n";

            string jobListings = "\nID: " + this.Id;

            if(this.Name == "")
            {
                jobListings += "\nName: Data not available"; 
            }else
            {
                jobListings += "\n" + "Name: " + this.Name;
            }

            if (this.EmployerName.Value == "")
            {
                jobListings += "\nEmployer: Data not available";
            } else
            {
                jobListings += "\n" + "Employer: " + this.EmployerName.Value;
            }

            if (this.EmployerLocation.Value == "")
            {
                jobListings += "\nLocation: Data not available";
            }
            else
            {
                jobListings += "\n" + "Location: " + this.EmployerLocation.Value;
            }

            if (this.JobType.Value == "")
            {
                jobListings += "\nPosition: Data not available";
            }
            else
            {
                jobListings += "\n" + "Position Type: " + this.JobType.Value;
            }

            if (this.JobCoreCompetency.Value == "")
            {
                jobListings += "\nCore Competency: Data not available";
            }
            else
            {
                jobListings += "\n" + "Core Competency: " + this.JobCoreCompetency.Value + "\n";
            }
            
            return jobListings;

            
        }


    }
}

