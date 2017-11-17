using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervivientesNet.Negocios
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Dia { get; set; }
        public int Bloque { get; set; }
        public string Username { get; set; }
        public int Infraestructura { get; set; }

        public Pedido()
        {
            Id = 0;
            Dia = 0;
            Bloque = 0;
            Username = "";
            Infraestructura = 0;
        }

        public Pedido(int i, int day, int block, string user, int inf)
        {
            Id = i;
            Dia = day;
            Bloque = block;
            Username = user;
            Infraestructura = inf;
        }

        public bool Create()
        {
            try
            {
                Datos.petition reserva = new Datos.petition();
                reserva.idpetition = ultimoId()+1;
                reserva.dayoftheweek = Dia;
                reserva.block = Bloque;
                reserva.account = Username;
                reserva.infrastructure = Infraestructura;
                Conexion.AutomatizacionDB.petition.Add(reserva);
                Conexion.AutomatizacionDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Datos.petition reserva = Conexion.AutomatizacionDB.petition.First(re => re.idpetition == Id);
                Id = reserva.idpetition;
                Dia = reserva.dayoftheweek;
                Bloque = reserva.block;
                Username = reserva.account;
                Infraestructura = reserva.infrastructure;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Datos.petition reserva = Conexion.AutomatizacionDB.petition.First(re => re.idpetition == Id);
                reserva.dayoftheweek = Dia;
                reserva.block = Bloque;
                reserva.account = Username;
                reserva.infrastructure = Infraestructura;
                Conexion.AutomatizacionDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Datos.petition reserva = Conexion.AutomatizacionDB.petition.First(re => re.dayoftheweek == Dia && re.block == Bloque && re.infrastructure == Infraestructura && re.account == Username);
                Conexion.AutomatizacionDB.petition.Remove(reserva);
                Conexion.AutomatizacionDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int ultimoId()
        {
            try
            {
                return Conexion.AutomatizacionDB.petition.Max(re => re.idpetition);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
        public bool existePedido()
        {
            try
            {
                Datos.petition reserva = Conexion.AutomatizacionDB.petition.First(re => re.dayoftheweek == Dia && re.block == Bloque && re.infrastructure == Infraestructura);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
