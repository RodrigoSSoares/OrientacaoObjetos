using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoImovel 
    {
        Apartamento, Casa, Loja, Fazenda 
    }
    
    
    public class Imovel
    {
        public int Id { get; set; }
        public TipoImovel TipoImovel { get; set; }  
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public byte Quartos { get; set; }
        public int Valor { get; set; }
        public string M2Contrucao { get; set; }
        public string M2Terreno { get; set; }
    }
}
