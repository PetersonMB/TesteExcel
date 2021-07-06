using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesExcel2
{
    class Program
    {
        static void Main(string[] args)
        {
            var excel = new ExcelQueryFactory(@"C:\TRINDADE\SUPORTE\Layout Mediatorie\COMISSÃO MEDIATORIE CLUBE 1 COMP 05.2021 - Editado.xlsx");

            excel.AddMapping<Complemento>(x => x.CodVendedor, "COD VENDEDOR");
            excel.AddMapping<Complemento>(x => x.CodVendedor, "CPF VENDEDOR");
            excel.AddMapping<Complemento>(x => x.CodVendedor, "TIPO VEND");


            List<Complemento> Testes2 = excel.Worksheet<Complemento>("COMISSÃO MEDIATORIE 05.2021").ToList();


            Console.ReadKey();

        }
    }
}
