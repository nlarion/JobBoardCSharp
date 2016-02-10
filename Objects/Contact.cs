using System.Collections.Generic;

namespace JobBoard.Contacts {
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
