using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public static readonly byte Action = 1;
        public static readonly byte Comedy = 2;
        public static readonly byte Family = 3;
        public static readonly byte Romance = 4;
    }
}