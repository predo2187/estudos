using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dapper_Project_CRUD_MVC.Models
{
    public class EmployeeModel
    { 
        public int Employeeid { get; set; }//como trabalhamos muito com uma váriavel chamada id, é melhor não deixar o id do item apenas como "id"
        public string name { get; set; }
        public string position { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
    }
}