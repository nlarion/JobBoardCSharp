using System.Collections.Generic;

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

  public class Contact
  {
    private string _posterName;
    private string _posterEmail;
    private string _posterPhone;

    public Contact (string posterName, string posterEmail, string posterPhone)
    {
      _posterName = posterName;
      _posterEmail = posterEmail;
      _posterPhone = posterPhone;
    }
    public string GetPosterName ()
    {
      return _posterName;
    }
    public void SetPosterName (string posterName)
    {
        _posterName = posterName;
    }
    public string GetPosterEmail ()
    {
      return _posterEmail;
    }
    public void SetPosterEmail (string posterEmail)
    {
        _posterEmail = posterEmail;
    }
    public string GetPosterPhone ()
    {
      return _posterPhone;
    }
    public void SetPosterPHone (string posterPhone)
    {
        _posterPhone = posterPhone;
    }

  }
}
