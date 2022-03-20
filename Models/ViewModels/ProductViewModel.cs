using System;
using System.Collections.Generic;
using System.Data;

namespace RCommerce.Models.ViewModels
{
    public class ProductViewModel
    {
        
        private int _id;
        private string _nomeprodotto;
        private string _immagine;
        private double _prezzo;
        private List<IngrediantsViewModel> _ingrediants;

        public int ID{
            get{
                return _id;
            }
            set{
                _id = value;
            }
        }

        public string NomeProdotto{
            get{
                return _nomeprodotto;
            }
            set{
                _nomeprodotto = value;
            }
        }

        public string Immagine{
            get{
                return _immagine;
            }
            set{
                _immagine = value;
            }
        }

        public double Prezzo{
            get{
                return _prezzo;
            }
            set{
                _prezzo = value;
            }
        }

        public List<IngrediantsViewModel> Ingrediants{
            get{
                return _ingrediants;
            }
            set{
                _ingrediants = value;
            }
        }

        public static ProductViewModel FromData(DataRow r)
        {
            ProductViewModel product = new ProductViewModel();
            product.ID = (int)r["idprodotto"];
            product.NomeProdotto = (string)r["nomeprodotto"];
            product.Immagine = (string)r["immagine"];
            product.Prezzo = (double)r["prezzo"];
            return product;
        }

    }
}