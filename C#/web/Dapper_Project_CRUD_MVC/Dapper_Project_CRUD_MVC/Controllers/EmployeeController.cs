using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.Mvc;
//adicionados
using Dapper_Project_CRUD_MVC.Models;
using Dapper;
using System.Data.SqlClient;

namespace Dapper_Project_CRUD_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<EmployeeModel>("EmployeeViewAll"));
        }
        
        [HttpGet]//não pode esquecer desse parametro, o mesmo para os de baixo
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0) return View();//esse define define se a página será usada para cadastrar um funcionário ou para editar um existente           
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@EmployeeId", id);
                return View(DapperORM.ReturnList<EmployeeModel>("EmployeeViewById", param).FirstOrDefault<EmployeeModel>());
                
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(EmployeeModel emp)//o emp está herdando o objeto EmployeeModel
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@EmployeeId", emp.Employeeid);
            param.Add("@Name", emp.name);
            param.Add("@Position", emp.position);
            param.Add("@Age", emp.age);
            param.Add("@Salary", emp.salary);   
            //DapperORM.ExecuteWithoutReturn("EmployeeAddOrEdit", param);//dentro das aspas é o nome da procedure, basicamento está pegando a procedura no banco de dados e está passando parametros da mesma forma de sempre
            DapperORM.ExecuteWithoutReturnLocalQuery("if @EmployeeId = 0 "+
                                                         "insert into tblEmployee(Name, Position, Age, Salary) values(@Name, @Position, @Age, @Salary) "+
                                                         "else "+//não esquece de dar espaço
                                                         "update tblEmployee set Name = @Name, Position = @Position, Age = @Age, Salary = @Salary where EmployeeId = @EmployeeId;", param);

            
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@EmployeeId", id);
            DapperORM.ExecuteWithoutReturn("EmployeeDeleteById", param);
            return RedirectToAction("Index");

        }
    }
}