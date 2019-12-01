using easy_immo_framework.Helper;
using easy_immo_framework.Interface;
using System;

namespace easy_immo_framework.Model
{
    public class Appart : IModel
    {
        public Appart()
        {
        }

        public DateTime DateMutation { get; set; }

        public string NatureMutation { get; set; }

        public double ValeurFonciere { get; set; }
        public int Numero { get; set; }

        public string Adresse { get; set; }

        public string CodeVoie { get; set; }
        public string CodePostal { get; set; }
        public string CodeCommune { get; set; }
        public string NomCommune { get; set; }
        public string CodeDepartement { get; set; }

        public string TypeLocal { get; set; }

        public double Surface { get; set; }

        public int NombrePrice { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public IModel Build(string[] lines)
        {
            try
            {
                return new Appart
                {
                    DateMutation = lines[1].ToDate(),
                    NatureMutation = lines[3],
                    ValeurFonciere = lines[4].ToDouble(),
                    Numero = lines[5].ToInteger(),
                    Adresse = lines[7],
                    CodeVoie = lines[8],
                    CodePostal = lines[9],
                    CodeCommune = lines[10],
                    NomCommune = lines[11],
                    CodeDepartement = lines[12],
                    TypeLocal = lines[30],
                    Surface = lines[31].ToDouble(),
                    NombrePrice = lines[32].ToInteger(),
                    Longitude = lines[38].ToDouble(),
                    Latitude = lines[39].ToDouble()
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}