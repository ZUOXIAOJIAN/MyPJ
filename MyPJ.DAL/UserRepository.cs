using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPJ.IDAL;
using MyPJ.Models;


namespace MyPJ.DAL
{
    /// <summary>
    /// 用户仓库
    /// <remarks>创建：2014.02.03</remarks>
    /// </summary>
    class UserRepository : BaseRepository<User>, InterfaceUserRepository
    {
    }
    
}
