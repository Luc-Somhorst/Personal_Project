using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business_layer.Business_objects
{
    class Cart
    {
        private List<Item> CartContent;
        private double TotalPrice;

        public Cart() {}

        public Cart(List<Item> CartItems)
        {
            CartContent = CartItems;
            foreach (Item cartItem in CartContent)
            {
                TotalPrice += cartItem.price;
            }
        }

        public void AddItem(Item NewItem)
        {
            CartContent.Add(NewItem);
        }

        public void RemoveItem(int ItemId)
        {
            CartContent.RemoveAt(CartContent.FindIndex(x => x.Id == ItemId));
        }
    }
}
