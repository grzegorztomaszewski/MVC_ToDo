using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ToDo.Models
{
    public class ToDo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public bool IsDone { get; set; }
    }
}