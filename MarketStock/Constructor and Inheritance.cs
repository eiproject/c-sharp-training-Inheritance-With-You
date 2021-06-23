using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStock
{
  class Movie
  {
    internal string Title;
    internal Movie() { }
    internal Movie(string title) { this.Title = title; }
  }

  class Detail : Movie
  {
    internal string Genre;
    /*internal Detail(string title) { Title = title; } // Title OK */
    /*internal Detail(string title) { } // Title became null*/
    internal Detail() { }
    internal Detail(string title): base (title) { } // Title OK
  }

  class Genre : Detail
  {
    internal Genre() { }
    /*internal Genre(string genre) { Genre = genre; } // Genre OK*/
    /*internal Genre(string genre): base(genre) { } // Genre became null, Title filled*/

    internal Genre(string title, string genre): base(title) { Genre = genre; } // Genre OK
  }  

}
