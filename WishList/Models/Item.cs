using System;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public int Id;

        [MaxLength(50)]
        public string Description;

        public Item() { }

    }
}
