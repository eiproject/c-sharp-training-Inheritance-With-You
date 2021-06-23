using System;
using System.Collections.Generic;
using System.Text;

namespace TheObjectType
{
  class Gallery
  {
    int pos = 0;
    internal Gallery[] Pictures = new Gallery[10];

    internal void PushData(Pict x) { Pictures[pos++] = (Gallery)x; }
    internal void PopData() { Pictures[pos--] = null; }
  }
  class Pict : Gallery
  {
    internal string Filename;
  }
}
