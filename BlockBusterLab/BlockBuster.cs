using System;
using System.Collections.Generic;


namespace BlockBusterLab
{
    class BlockBuster
    {
        public List<Movie> Movies = new List<Movie>();
        Movie lionKing = new VHS("The Lion King", Genre.Comedy, 120, new List<string>(), 0);
    }
}
