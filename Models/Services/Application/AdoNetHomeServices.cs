using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using RCommerce.Models.Services.Infrastructure;
using RCommerce.Models.ViewModels;

namespace RCommerce.Models.Services.Application
{
    public class AdoNetHomeServices : IHomeServices
    {
        private readonly IDatabaseAccessor db;

        public AdoNetHomeServices(IDatabaseAccessor db)
        {
            this.db = db;

        }
        public async Task<ProductViewModel> getProductAsync(int id)
        {
            FormattableString query = $"SELECT * FROM prodotti WHERE idprodotto = {id}";
            DataSet dataset = await db.QueryAsync(query);
            DataTable dt = dataset.Tables[0];
            DataRow r = dt.Rows[0];
            ProductViewModel product = ProductViewModel.FromData(r);
            return product;
        }

        public async Task<List<ProductViewModel>> getProductsAsync()
        {
            FormattableString query = $"SELECT * FROM prodotti WHERE idcategoria = {9}";
            DataSet dataset = await db.QueryAsync(query);
            DataTable dt = dataset.Tables[0];
            List<ProductViewModel> listaprodotti = new List<ProductViewModel>();
            foreach(DataRow r in dt.Rows){
                ProductViewModel product = ProductViewModel.FromData(r);
                listaprodotti.Add(product);
            }
            return listaprodotti;
        }
    }
}