using System.ComponentModel.DataAnnotations;
using System.Data;
namespace web_api_db.Models{
    public class Medicines {
        [Key]
        public int id {get;set;}
        public string name {get;set;}
        public double price {get;set;}
        public string mark {get;set;}
        public string description {get;set;}
        public string image {get;set;}
        public int stocks {get;set;}
    }
}