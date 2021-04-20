// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil
  {
  public string Title
  {get; protected set;}

  public Pupil(string title)
  {
    Title = title;
  }

  public Storm CastWindStorm()
  {
    Storm pupilStorm = new Storm("wind", false, Title);
  return pupilStorm;
  }
  }
}
