using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PushBullet
{

  public abstract class Data
  {
    public string type;
    public string _csrf;
    public int device_id;
    public string title;
  }

  public class NoteData : Data
  {

    public string body;

  }

  public class LinkData : Data
  {

    public string url;

  }
}
