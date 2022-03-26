using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_final_cine
{
    public partial class frmConsultas : Form
    {
        DataAccess dato = new DataAccess(@"Provider=SQLNCLI11;Data Source=MANU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Complejo_Cinema_Paradiso");
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            lblEnunciado.Text = "Seleccione una consulta";
        }
        private void generar_consulta(string sql,string lbl)
        {
            grdConsulta.DataSource = dato.consultar(sql);
            lblEnunciado.Text = lbl;
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select p.nom_pelicula 'Pelicula', count (s.nom_sala) 'Cantidad de salas',avg(s.cant_butacas) 'butacas promedio'
from Peliculas p join Peliculas_Salas ps on p.cod_pelicula=ps.cod_pelicula 
join Salas s on s.cod_sala=ps.cod_sala 
join Clasificaciones c on p.cod_clasificacion = c.cod_clasificacion
where ps.fec_inicial < getdate() and ps.fec_final > getdate() and c.nom_clasificacion like 'Apta para todo público'
group by nom_pelicula", "Emitir un listado de las peliculas aptas para todo publico en exibicion en este momento, en que cantidad de salas se encuentran disponible\n y la cantidad de butacas promedio");    
       }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            generar_consulta(@"Select sum(dc.cantidad) 'Total de Tickets', a.nom_actor +' '+a.ape_actor 'Nombre','Actor'
from detalle_compra dc join peliculas p on dc.cod_pelicula = p.cod_pelicula
join Actores_Peliculas ap on p.cod_pelicula = ap.cod_pelicula
join Actores a on ap.cod_actor = a.cod_actor
group by a.nom_actor,a.ape_actor
UNION 
Select sum(dc.cantidad) 'Total de Tickets',d.nom_director +' '+d.ape_director 'Nombre','Director'
from detalle_compra dc join peliculas p on dc.cod_pelicula = p.cod_pelicula
join Directores d on p.cod_director = d.cod_director
group by d.nom_director,d.ape_director
order by  1 desc", "Emitir un listado de la cantidad de tickets que vendio cada actor y director\n ordenarlos segun cual fue el mas taquillero");

        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select p.cod_pelicula 'codigo', p.nom_pelicula ' Pelicula'
from Peliculas p join Peliculas_Salas ps on p.cod_pelicula = ps.cod_pelicula 
where p.cod_pelicula not in (select cod_pelicula
			     from detalle_compra
			     where getdate() between ps.fec_inicial and ps.fec_final)
group by p.cod_pelicula,nom_pelicula", "Se requeire un listado de peliculas en cartelera que no vendieron entradas");
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select fec_ticket,count(*) 'Cantidad de Tickets'
from detalle_tickets 
where month(fec_ticket) not in (1,2,3,4,5,9,10,11,12)
group by fec_ticket", "Cantidad de Tickets emitidos en Vacaciones de Invierno");
        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select nro_ticket 'Ticket',sum(monto*cantidad) 'Monto Total', avg(cantidad*monto) 'Promedio' 
from detalle_compra 
group by nro_ticket 
having sum(cantidad)> 3 and sum(monto*cantidad)> 100 ", "Importe y el promedio total vendido por factura, para los casos en que la cantidad total vendida sea superior a 3 y que el importe total sea superior a 20. ");
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select max(cantidad) Maxima, min(cantidad) Minima
from detalle_compra
where cod_pelicula = 32", "Se quiere saber cual fue la maxima y la minima cantidad que se vendio para la pelicula 32");
        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select p.cod_pelicula 'Código de Película', avg(dc.monto) 'Monto Promedio', sum (dc.monto) 'Monto Total'
from peliculas p
join detalle_compra dc on p.cod_pelicula = dc.cod_pelicula
where p.nom_pelicula not like 'c%'
group by p.cod_pelicula
having sum (dc.monto) >=70 or count (dc.cantidad) between 3 and 5", "Se solicita un reporte que muestre el monto promedio y el monto total de peliculas emitidas que no comiencen con no comiencen con “C”\n, y que su monto total sea 70 o más o que la cantidad de tickets oscile entre 3 y 5");
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select p.cod_pelicula 'Código', p.nom_pelicula 'Nombre', 'Película' as 'Tipo'
from peliculas p
join detalle_compra dc on p.cod_pelicula = dc.cod_pelicula
where dc.monto>100 and year(p.fec_estreno) between 2000 and 2016  
UNION
select d.cod_director 'Código', d.ape_director +' '+d.nom_director 'Nombre', 'Director' as 'Tipo'
from directores d
UNION
select a.cod_actor 'Código', a.ape_actor +' '+a.nom_actor 'Nombre', 'Actor' as 'Tipo'
from actores a
order by 1, 3", "Emitir un listado donde se muestren qué peliculas fueron estrenadas entre el 2000 y 2016 cuyo monto fue mayor a $100,\n listar además los directores y actores que hay en la base de datos.");
        }

        private void btnConsulta9_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select p.cod_pelicula, p.nom_pelicula 'Pelicula', avg (dc.monto) 'Monto Promedio', sum (dc.monto)
from peliculas p
join detalle_compra dc on p.cod_pelicula = dc.cod_pelicula
join detalle_tickets dt on p.cod_pelicula = dt.cod_pelicula
where dt.nro_ticket not in (2,10,7,13,22) 
group by p.cod_pelicula, p.nom_pelicula
having avg(dc.monto) < (select avg (dc.monto)
						from detalle_compra dc
						where p.cod_pelicula=dc.cod_pelicula)", "Por cada película que se ha a proyectado, se quiere saber el monto promedio cobrado, la cantidad total vendida por pelicula, para los casos en que los números de compra no sean uno de los siguientes: 2, 10, 7, 13, 22\n y que ese monto promedio sea inferior al importe promedio de esa pelicula.");
        }

        private void btnConsulta10_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select dc.fec_compra 'Fecha', min (fec_estreno) 'Primera película', sum (dc.monto) 'Monto total'
from peliculas p, detalle_compra dc
where p.cod_pelicula = dc.cod_pelicula
group by dc.fec_compra 
having sum(dc.cantidad)>10", "Se quiere saber la fecha de la primera película, la cantidad total de películas emitidas\n y la cantidad total de películas que superen los 10 tickets vendidos por día");
        }

        private void btnConsulta11_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select p.cod_pelicula 'Código de película', min (dc.monto) 'Monto mínimo', max (dc.monto) 'Monto máximo', sum (dc.monto) 'Monto total'
from peliculas p, detalle_compra dc, formas_pago fp
where p.cod_pelicula = dc.cod_pelicula and fp.cod_forma_pago = dc.cod_forma_pago and p.nom_pelicula like '%' and fp.nom_forma_pago = 'Efectivo'
group by p.cod_pelicula
having sum (dc.monto) > 50 and count (dc.cantidad) < 100", "Liste el monto máximo y mínimo y monto total de películas emitidas donde su forma de pago sea en Efectivo\n y el monto total sea mayor a 50 y la cantidad de tickets menor a 100");
        }

        private void btnConsulta12_Click(object sender, EventArgs e)
        {
            generar_consulta(@"select p.cod_pelicula 'Código', p.nom_pelicula 'Nombre', 'Película' as 'Descripción'
from peliculas p, generos g
where p.cod_genero = g.cod_genero and g.nom_genero = 'Argentinas'
union
select a.cod_actor, a.ape_actor +' '+ a.nom_actor 'Nombre', 'Actor' as 'Descripción'
from actores a
union 
select d.cod_director, d.ape_director+' '+ d.nom_director 'Nombre', 'Director' as 'Descripción'
from directores d
order by 3 desc,2 ", "Listar películas argentinas que la cantidad de tickets supere los 15. Se quiere saber también qué actores y directores hay en la base de datos.\nSe deberá visualizar el código, nombre y si se trata de un actor o de un director.\nDetermine los campos a mostrar y su ordenamiento.");
        }
    }
}
