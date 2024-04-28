using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BorderControl
{
    public class Robots : Iindetification
    {
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get; set; }
        public string Id { get; set; }
    }
}
