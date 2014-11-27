using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    class ObtenCURP
    {
        public String unoAP;
        public String dosAP;
        public String tresAM;
        public String cuatroNom;
        public String fecha;
        public String sexo;
        public String entidad;
        public String c1;
        public String c2;
        public String c3;
        public String homoclave ="0";
        public String verificador ="0";

        public void obtenAP(String apellidoP) { 
            unoAP= apellidoP.Substring(0,1);
            Boolean pasa = false;
            int i =0;
            while (!pasa)
            {
                i++;
                pasa = esVocal(apellidoP.Substring(i,1));
                
            }
            dosAP = apellidoP.Substring(i, 1);
            int j = 0;
            while (pasa)
            {
                j++;
                pasa = esVocal(apellidoP.Substring(j, 1));

            }
            c1 = apellidoP.Substring(j, 1);
        }
        public void obtenAM(String apellidoM)
        {
            tresAM = apellidoM.Substring(0, 1);
            Boolean pasa = true;
            int j = 0;
            while (pasa)
            {
                j++;
                pasa = esVocal(apellidoM.Substring(j, 1));
            }
            c2 = apellidoM.Substring(j, 1);
        }
        public String obtenNombre(String nombre)
        {
            cuatroNom = nombre.Substring(0, 1);
            Boolean pasa = true;
            int j = 1;
            while (pasa)
            {
                j++;
                pasa = esVocal(nombre.Substring(j, 1));
            }
            c3 = nombre.Substring(j, 1);
            return c3;
        }
        public void obtenFecha(String f)
        {
            fecha = f;
        }
        public void obtenEntidad(String estado)
        {
            String[] estados = new String[32];
            String[] abreviaciones = new String[32];
            estados[0] = "Aguascalientes";
            estados[1] = "Baja California";
            estados[2] = "Baja California Sur";
            estados[3] = "Campeche";
            estados[4] = "Chiapas";
            estados[5] = "Chihuahua";
            estados[6] = "Coahulia";
            estados[7] = "Colima";
            estados[8] = "Distrito Federal";
            estados[9] = "Durango";
            estados[10] = "Guanajuato";
            estados[11] = "Guerrero";
            estados[12] = "Hidalgo";
            estados[13] = "Jalisco";
            estados[14] = "Estado de Mexico";
            estados[15] = "Michoacan";
            estados[16] = "Morelos";
            estados[17] = "Nayarit";
            estados[18] = "Nuevo Leon";
            estados[19] = "Oaxaca";
            estados[20] = "Puebla";
            estados[21] = "Queretaro";
            estados[22] = "Quintana Roo";
            estados[23] = "San Luis Potosi";
            estados[24] = "Sinaloa";
            estados[25] = "Sonora";
            estados[26] = "Tabasco";
            estados[27] = "Tamaulipas";
            estados[28] = "Tlaxcala";
            estados[29] = "Veracruz";
            estados[30] = "Yucatan";
            estados[31] = "Zacatecas";

            abreviaciones[0] = "AG";
            abreviaciones[1] = "BC";
            abreviaciones[2] = "BS";
            abreviaciones[3] = "CM";
            abreviaciones[4] = "CS";
            abreviaciones[5] = "CH";
            abreviaciones[6] = "CO";
            abreviaciones[7] = "CL";
            abreviaciones[8] = "DF";
            abreviaciones[9] = "DG";
            abreviaciones[10] = "GT";
            abreviaciones[11] = "GR";
            abreviaciones[12] = "HG";
            abreviaciones[13] = "JC";
            abreviaciones[14] = "MC";
            abreviaciones[15] = "MN";
            abreviaciones[16] = "MS";
            abreviaciones[17] = "NT";
            abreviaciones[18] = "NL";
            abreviaciones[19] = "OC";
            abreviaciones[20] = "PL";
            abreviaciones[21] = "QT";
            abreviaciones[22] = "QR";
            abreviaciones[23] = "SP";
            abreviaciones[24] = "SL";
            abreviaciones[25] = "SR";
            abreviaciones[26] = "TC";
            abreviaciones[27] = "TS";
            abreviaciones[28] = "TL";
            abreviaciones[29] = "VZ";
            abreviaciones[30] = "YN";
            abreviaciones[31] = "ZS";
            int i =0;
            Boolean bandera = false;
            while ( !bandera) {
                if (estado.Equals(estados[i]))
                {
                    entidad = abreviaciones[i];
                    bandera = true;
                }
                i++;
            }
            


        }
        public void obtenSexo(string sex)
        {
            sexo = sex;
        }

        public Boolean esVocal(String letra)
        {
            Boolean bandera = false;
            switch (letra)
            {
                case "A":
                    bandera = true;
                    break;
                case "E":
                    bandera = true;
                    break;
                case "I":
                    bandera = true;
                    break;
                case "O":
                    bandera = true;
                    break;
                case "U":
                    bandera = true;
                    break;
                default:
                    break;
            }
            return bandera;
        }
        public String creaCURP(String ap, String am, String n, String f, String s, String e)
        {
            String curp;
            obtenAP(ap);
            obtenAM(am);
            obtenNombre(n);
            obtenEntidad(e);
            obtenFecha(f);
            obtenSexo(s);
            curp = unoAP + dosAP + tresAM + cuatroNom + fecha + sexo + entidad + c1 + c2 + c3 + homoclave + verificador;

            return curp;
    }
   
}
}
