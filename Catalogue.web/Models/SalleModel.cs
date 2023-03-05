namespace Catalogue.web.Models
{
    public class SalleModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Libelle { get; set;}
        public string Description { get; set;}
        public string Picture { get; set; }
        public Boolean isReserve { get; set; }
        public SalleModel() { }
        public SalleModel(int id, string numero, string libelle, string description, string picture, bool isReserve)
        {
            Id = id;
            Numero = numero;
            Libelle = libelle;
            Description = description;
            Picture = picture;
            this.isReserve = isReserve;
        }
    }
}
