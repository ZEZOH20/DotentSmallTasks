using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetTranning.src.DB;
using DotnetTranning.src.Models;

namespace DotnetTranning.src.Repositorys
{
    public class UserRepository
    {
        public Repository<User>_Repository;
        public UserRepository(){
            ApplicationDbContext DbContext = new ApplicationDbContext();
           _Repository = new Repository<User>(DbContext); 
        }
    }
}