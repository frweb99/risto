using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RCommerce.Models.Services.Infrastructure;
using RCommerce.Models.ViewModels;

namespace RCommerce.Models.Services.Application
{
    public class EfHomeService : IHomeServices
    {
        private readonly MyCourseDbContext dbcontext;

        public EfHomeService(MyCourseDbContext dbcontext)
        {
            this.dbcontext = dbcontext;

        }

        public async Task<ProductViewModel> getProductAsync(int id)
        {
            ProductViewModel product = await dbcontext.Prodotti
            .Where(prodotto => prodotto.Idprodotto == (int)id)
            .Select(prodotto => new ProductViewModel{
                ID = prodotto.Idprodotto,
                NomeProdotto = prodotto.Nomeprodotto,
                Immagine = prodotto.Immagine,
                Prezzo = prodotto.Prezzo,
                Ingrediants = prodotto.Ingrediants
                .Where(ingrediant => ingrediant.Idprodotto == prodotto.Idprodotto)
                .Select(ingrediant => new IngrediantsViewModel{
                    ID = ingrediant.Idingrediente,
                    Nome = ingrediant.Nome,
                    SurgelatoFresco = ingrediant.Surgelatofresco,
                    Allergeni = ingrediant.Allergeni
                }).ToList()
            }).SingleAsync();
            return product;
        }

        public async Task<List<ProductViewModel>> getProductsAsync()
        {
            List<ProductViewModel> products = await dbcontext.Prodotti
            .Where(prodotto => prodotto.Idcategoria == 9)
            .Select(prodotto => new ProductViewModel{
                ID = prodotto.Idprodotto,
                NomeProdotto = prodotto.Nomeprodotto,
                Immagine = prodotto.Immagine,
                Prezzo = prodotto.Prezzo,
                Ingrediants = prodotto.Ingrediants
                .Where(ingrediant => ingrediant.Idprodotto == prodotto.Idprodotto)
                .Select(ingrediant => new IngrediantsViewModel{
                    ID = ingrediant.Idingrediente,
                    Nome = ingrediant.Nome,
                    SurgelatoFresco = ingrediant.Surgelatofresco,
                    Allergeni = ingrediant.Allergeni
                }).ToList()
            }).ToListAsync();
            return products;
        }
    }
}