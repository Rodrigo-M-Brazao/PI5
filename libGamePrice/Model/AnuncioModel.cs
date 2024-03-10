using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libGamePrice.Model
{
    public class AnuncioModel
    {
        string nome {get; set;}

        string link {get; set;}

        int likes {get; set;}

        int dislikes {get; set;}

        string genero {get; set;}// id do Genero

        double preco {get; set;}

        UserModel user{ get; set;}
    }
}