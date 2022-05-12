using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    class Class1
    {
    }

    public class Projects
    {
        public int Id { get; set; }
        public string Project_Title { get; set; }
        public string Project_Type { get; set; }
        public string Department_Id { get; set; }
        public string Project_Summary { get; set; }
        public string Comments { get; set; }
        public string Challenges { get; set; }
        public string Projects_Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string Modifiedby { get; set; }
        public DateTime DateAuthorised { get; set; }
        public string AuthorisedBy { get; set; }
        public char Record_Status { get; set; }
    }

    public class Activity
    {
        public int Id { get; set; }
        public string Activity_Name { get; set; }
        public string Activity_Type { get; set; }
        public DateTime Start_Date { get; set; }
        public string Activity_Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string Modifiedby { get; set; }
        public DateTime DateAuthorised { get; set; }
        public string AuthorisedBy { get; set; }
        public char Record_Status { get; set; }
    }

    public class Task
    {
        public int Id { get; set; }
        public string Task_Name { get; set; }
        public string Assignedto { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Task_Status { get; set; }
        public string Time_Dedication { get; set; }
        public string Daily_Time_Ded { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string Modifiedby { get; set; }
        public char Record_Status { get; set; }
    }

    public class TimeAvailablity
    {
        public int Id { get; set; }
        public string Project_Function { get; set; }
        public string Activity_Type { get; set; }
        public string Time_Per_Day { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public char Record_Status { get; set; }
    }

    public class ResourceCalender
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Role { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public char Record_Status { get; set; }
    }

    public class ProjectResourceSchedule
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Taskid { get; set; }
        public DateTime Schedule_Date { get; set; }
        public char Work_Day { get; set; }
        public string Dedicated_Hours { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public char Record_Status { get; set; }
    }

}
