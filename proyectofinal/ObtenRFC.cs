using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFC
{
    class ObtenRFC
    {
        public String unoAP;
        public String dosAP;
        public String tresAM;
        public String cuatroNom;
        public String anio;
        public String mes;
        public String dia;
        public String homo_clave = "XX";
        public String verificador = "0";


        public void obtenAP(String apellidoP)
        {
            unoAP = apellidoP.Substring(0, 1);
            dosAP = apellidoP.Substring(1, 1);
        }
        public void obtenAM(String apellidoM)
        {
            tresAM = apellidoM.Substring(0, 1);
        }
        public void obtenN(String nombre)
        {
            cuatroNom = nombre.Substring(0, 1);
        }
        public void obtenFecha(String fecha)
        {
            String[] words = fecha.Split(' ');
            dia = words[0];
            switch (words[2])
            {
                case "enero":
                    mes = "01";
                    break;
                case "febrero":
                    mes = "02";
                    break;
                case "marzo":
                    mes = "03";
                    break;
                case "abril":
                    mes = "04";
                    break;
                case "mayo":
                    mes = "05";
                    break;
                case "junio":
                    mes = "06";
                    break;
                case "julio":
                    mes = "07";
                    break;
                case "agosto":
                    mes = "08";
                    break;
                case "septiembre":
                    mes = "09";
                    break;
                case "octubre":
                    mes = "10";
                    break;
                case "noviembre":
                    mes = "11";
                    break;
                case "diciembre":
                    mes = "03";
                    break;
            }
            anio = words[4].Substring(2, 1) + words[4].Substring(3, 1);


        }
        public String obtenRFC(String apellidoP, String apellidoM, String nombre, String fecha)
        {
            obtenAP(apellidoP);
            obtenAM(apellidoM);
            obtenN(nombre);
            obtenFecha(fecha);


            return unoAP + dosAP + tresAM + cuatroNom + anio + mes + dia + homo_clave + verificador;
        }
    }

}
