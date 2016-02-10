using System.Collections.Generic;
using JobBoard.Contacts;

namespace JobBoard.Objects
{
  public class JobOpening
  {
    private string _description;
    private string _title;
    private Contact _contact;
    private static List<JobOpening> _jobs = new List<JobOpening> {};

    public JobOpening (string title, string description, Contact contact)
    {
      _description = description;
      _title =  title;
      _contact = contact;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public Contact GetContact()
    {
      return _contact;
    }
    public void SetContact(Contact newContact)
    {
      _contact = newContact;
    }
    public static List<JobOpening> GetAll()
    {
      return _jobs;
    }
    public static void Save(JobOpening job)
    {
      _jobs.Add(job);
    }
    public static void ClearAll()
    {
      _jobs.Clear();
    }
  }

}
