using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using libGamePrice.Model;

namespace libGamePrice.Repository.Interface
{
    public interface IAnuncioRepository
    {
        List<dynamic> getAnuncios();

        dynamic cadastraAnuncio();

        AnuncioModel getAnuncio();

        List<dynamic> getAnunciosByGenero();
        
        // List<dynamic> getAnunciosByGenero();
        // List<dynamic> getAnunciosByGenero();
    }
}