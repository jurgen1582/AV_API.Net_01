using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AvAPI.Models
{
    public class Jogador
    {
        public Jogador()
        {
        }

        public Jogador(int atleta_id, string nome_popular, string nome, string posicao, string sigla, int camisa)
        {
            Atleta_id = atleta_id;
            Nome_popular = nome_popular;
            Nome = nome;
            Posicao = posicao;
            Sigla = sigla;
            Camisa = camisa;
        }

        public int Atleta_id { get; set; }
        public String Nome_popular { get; set; }
        public String Nome { get; set; }
        public String Posicao { get; set; }
        public String Sigla { get; set; }
        public int Camisa { get; set; }

        public List<Jogador> listaJogadores(string marcador)
        {
            string jsonString = File.ReadAllText(@"Data/Base.json");
            //var text = Encoding.GetEncoding(File.ReadAllText(@"Data/Base.json"));

            var listaJogadores = JsonConvert.DeserializeObject<List<Jogador>>(jsonString).ToList();

            if (marcador == "C")
            {
                var order = listaJogadores.OrderBy(x => x.Camisa).ToList();
                return order;
            }
            if (marcador == "P")
            {
                var order = listaJogadores.OrderBy(x => x.Posicao).ToList();
                return order;
            }

            return listaJogadores;
        }
    }
}
