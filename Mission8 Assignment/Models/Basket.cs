using System;
using System.Collections.Generic;
using System.Linq;

namespace BookProject.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem(Book Boo, int qty)
        {
            BasketLineItem line = Items
                .Where(p => p.Book.BookId == Boo.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = Boo,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
        public int TotalBook()
        {
            int sum = Items.Sum(x => x.Quantity++);

            return sum;
        }

    }
    public class BasketLineItem
    {
        public int LineID { get; set; }

        public Book Book { get; set; }

        public int Quantity { get; set; }

     

    } 
}
