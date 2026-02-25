using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Smurfs.SmurfsBL.entities
{
    public abstract class Item
    {
        [Key]
        public int Idi { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Forest? Forest { get; set; }
    }
}