using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuote.Models
{
    public class InsuranceGetQuote
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int newQuote { get; set; }
    }
    public abstract class BirthYear
    {
        public DateTime Now { get; }
        public int Year { get; }
    }
}