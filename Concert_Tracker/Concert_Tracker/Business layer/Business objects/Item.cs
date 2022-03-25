using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;

namespace Business_layer.Business_objects
{
    class Item
    {
        public int id;
        public double price;
        public string name;
        public Blob showImage;
        public string description;
        public int amount;
        public Band band;
    }
}
