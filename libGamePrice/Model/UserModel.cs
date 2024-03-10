using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libGamePrice.Model
{
    public class UserModel
    {
        string email { get; set;}
        
        string cpf { get; set;}
        
        string nome { get; set;}

        string senha { get; set;}

        int pontos{ get; set;}
    }
}