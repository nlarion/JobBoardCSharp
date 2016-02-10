using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;
using JobBoard.Contacts;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_job.cshtml"];
      Get["/view_all_jobs"] = _ => {
        List<JobOpening> allJobs = JobOpening.GetAll();
        return View["view_all_jobs.cshtml", allJobs];
      };
      Post["/jobs_cleared"] = _ => {
        JobOpening.ClearAll();
        return View["jobs_cleared.cshtml"];
      };
      Post["/job_added"] = _ => {
        Contact contact = new Contact(Request.Form["posterName"],Request.Form["posterEmail"],Request.Form["posterPhone"]);
        JobOpening newJob = new JobOpening(Request.Form["jobTitle"], Request.Form["jobDescription"], contact);
        JobOpening.Save(newJob);
        return View["job_added.cshtml", newJob];
      };
    }
  }
}
