using System;

class Program
{
    //job = "";
    static void Main(string[] args)
    {
        Job job1  = new Job();
        job1._jobTitle = "Front End Developer";
        job1._companyName = "Bountiful Engineering";
        job1._startYear = 2014;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Social Media Manager";
        job2._companyName = "Zion Helping Hand Foundation";
        job2._startYear = 2018;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Evans Amenorfe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        

    }
}