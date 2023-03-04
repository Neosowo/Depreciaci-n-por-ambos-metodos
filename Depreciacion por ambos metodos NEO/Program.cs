using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Depreciacion_por_ambos_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo_por_unidades_producidas x = new Metodo_por_unidades_producidas();
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Select_Class z = new Select_Class();
            z.Saludo();
            Console.WriteLine("\n " + "PROGRAMA HECHO POR ERICK YANEZ");
            Console.ReadKey(true);
        }
    }
    public class Select_Class
    {

        public void Saludo()
        {
            Metodo_por_unidades_producidas x = new Metodo_por_unidades_producidas();
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Select_Class z = new Select_Class();
            string name = "Calculadora de depreciación";
            Console.WriteLine("¡Welcome to " + name + " program!");
            z.L();
        }
        public void L()
        {
            Metodo_por_unidades_producidas x = new Metodo_por_unidades_producidas();
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Select_Class z = new Select_Class();
            Console.WriteLine(" " + "Elegir dependiendo el numero asignado" + "\n1. Depreciación por metodo lineal" + "\n2. Depreciación por número de unidades producidas");
            int op = Convert.ToInt32(Console.ReadLine());
            while (op != 1 && op != 2)
            {
                Console.WriteLine("Ha ingresado una cantidad fuera de limites" + "\n Intentelo nuevamente");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    y.Categorias();
                    Console.ReadKey(true);
                }
                else if (op == 2)
                {
                    x.Nameofproduct();
                    Console.ReadKey(true);
                }
            }
            if (op == 1)
            {
                y.Categorias();
                Console.ReadKey(true);
            }
            else if (op == 2)
            {
                x.Nameofproduct();
                Console.ReadKey(true);
            }
        }
    }
    public class Metodo_por_unidades_producidas
    {
        public string Nameofproduct()
        {
            Metodo_por_unidades_producidas x = new Metodo_por_unidades_producidas();
            Console.WriteLine("Calculadora de depreciación (Metodo por unidades producidas) - Erick Yánez");
            Console.WriteLine("Ingrese el nombre del producto: ");
            string name = Console.ReadLine();
            NMAXUP(name);
            return name;
        }
        public int NMAXUP(string name)
        {
            Console.WriteLine("Ingrese el número maximo de unidades producidas");
            int nmax = Convert.ToInt32(Console.ReadLine());
            UPA(nmax, name);
            return nmax;
        }

        public int UPA(int nmax, string name)
        {
            Console.WriteLine("Ingrese las unidades producidas hasta la actualidad");
            int vupa = Convert.ToInt32(Console.ReadLine());
            //vupa = unidades producidas
            //nmax = numero maximo de unidades producidas
            while (nmax < vupa)
            {
                Console.WriteLine("El número de maximo de unidades es menor al número de unidades producidas a la actualidad" + "\nVuelva a ingresar el número maximo de unidades:");
                nmax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese nuevamente el número de unidades producidas:");
                vupa = Convert.ToInt32(Console.ReadLine());

            }
            while (nmax < 0)
            {
                Console.WriteLine("El número maximo de unidades es invalido" + "\nIngrese nuevamente el número maximo de unidades:");
                nmax = Convert.ToInt32(Console.ReadLine());
            }

            while (vupa < 0)
            {
                Console.WriteLine("El número de unidades producidas es invalido" + "\nIngrese nuevamente el número de unidades producidas: ");
                nmax = Convert.ToInt32(Console.ReadLine());
            }
            VNMAXUP(nmax, vupa, name);
            return vupa;
        }
        public int VNMAXUP(int nmax, int vupa, string name)
        {
            if (nmax <= vupa)
            {
                Console.WriteLine("El numero maximo de unidades no es superior, vuelva a ingresar los datos otra vez :)!");
                Console.WriteLine("Ingrese las unidades producidas hasta la actualidad");
                vupa = Convert.ToInt32(Console.ReadLine());
                while (nmax < 0)
                {
                    Console.WriteLine("El número maximo de unidades es invalido" + "\nIngrese nuevamente el número maximo de unidades:");
                    nmax = Convert.ToInt32(Console.ReadLine());
                }
                while (vupa < 0)
                {
                    Console.WriteLine("El número de unidades producidas es invalido" + "\nIngrese nuevamente el número de unidades producidas: ");
                    nmax = Convert.ToInt32(Console.ReadLine());
                }
            }
            Precio(nmax, vupa, name);
            return vupa;
        }
        public double Precio(int nmax, int vupa, string name)
        {
            Console.WriteLine("Ingrese el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());
            while (precio <= 0)
            {
                Console.WriteLine("\nPrecio menor a 0" + "Ingrese nuevamente el precio del producto");
                precio = Convert.ToDouble(Console.ReadLine());
            }
            P(nmax, vupa, precio, name);
            return precio;
        }
        public int P(int nmax, int vupa, double precio, string name)
        {
            double VDXU = precio / nmax;
            double VDT = VDXU * vupa;
            double VAA = precio - VDT;
            int xd = 0;
            Console.WriteLine("Valor depreciado por unidad: " + VDXU + "\nValor depreciado total: " + VDT + "Valor actual del activo: " + VAA);
            string owo = Renov();
            return xd;
        }

        public string Renov()
        {
            Metodo_por_unidades_producidas x = new Metodo_por_unidades_producidas();
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Select_Class z = new Select_Class();

            Console.WriteLine("¿Quiere calcular otra vez la depreciación (Responde con Si o No)" + "\n1. Si\n2. No");
            string pqwe = Console.ReadLine();
            while (pqwe != "Si" && pqwe != "No")
            {
                Console.WriteLine("A ingresado una respuesta no valida, intentelo de nuevo");
                Console.WriteLine("¿Quiere calcular otra vez la depreciación (Responde con Si o No)" + "\n1. Si\n2. No");
                pqwe = Console.ReadLine();
                if (pqwe == "Si")
                {
                    z.L();
                }
                else if (pqwe == "No")
                {
                    Environment.Exit(1);
                }
            }
            if (pqwe == "Si")
            {
                z.L();
            }
            else if (pqwe == "No")
            {
                Environment.Exit(1);
            }
            string qw = "xd";
            return qw;
        }
    }
    public class Depreciacion_por_metodo_lineal
    {
        public void Categorias()
        {
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();

            Console.WriteLine("Calculadora de depreciación (Metodo de lineal) - Erick Yánez" + "\nElige la categoría de tu producto: \n 1. Inmuebles \n 2. Maquinaria \n 3. Vehículos \n 4. Equipos informáticos");

            int op = Convert.ToInt32(Console.ReadLine());
            while (op != 1 && op != 2 && op != 3 && op != 4)
            {
                Console.WriteLine("Usted es muy tonto, elige del 1 al 4. Intentelo nuevamente uwu" + "\nElige la categoría de tu producto: \n 1. Inmuebles \n 2. Maquinaria \n 3. Vehículos \n 4. Equipos informáticos");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    int Valor = 20;
                    y.Inmueble(Valor);
                    Nameofproduct(Valor);

                    Console.ReadKey(true);
                }
                if (op == 2)
                {
                    int Valor = 10;
                    y.Maquinaria(Valor);
                    Nameofproduct(Valor);

                    Console.ReadKey(true);
                }
                if (op == 3)
                {
                    int Valor = 5;
                    y.Vehiculo(Valor);
                    Nameofproduct(Valor);

                    Console.ReadKey(true);
                }
                if (op == 4)
                {
                    int Valor = 3;
                    y.EquipoInformatico(Valor);
                    Nameofproduct(Valor);

                    Console.ReadKey(true);
                }
            }
            if (op == 1)
            {
                int Valor = 20;
                y.Inmueble(Valor);
                Nameofproduct(Valor);

                Console.ReadKey(true);
            }
            if (op == 2)
            {
                int Valor = 10;
                y.Maquinaria(Valor);
                Nameofproduct(Valor);

                Console.ReadKey(true);
            }
            if (op == 3)
            {
                int Valor = 5;
                y.Vehiculo(Valor);
                Nameofproduct(Valor);

                Console.ReadKey(true);
            }
            if (op == 4)
            {
                int Valor = 3;
                y.EquipoInformatico(Valor);
                Nameofproduct(Valor);

                Console.ReadKey(true);
            }

        }
        public string Nameofproduct(int valor)
        {
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Console.WriteLine("Ingrese el nombre del producto: ");
            string name = Console.ReadLine();
            AñoDeCompra(name, valor);
            return name;
        }

        public int AñoDeCompra(string name, int valor)
        {
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Console.WriteLine("Ingrese el año de compra: ");
            int AC = Convert.ToInt32(Console.ReadLine());
            while (AC < 0)
            {
                Console.WriteLine("Su año de compra es menor a 0, usted es muy tonto.  \nIngreselo nuevamente:");
                AC = Convert.ToInt32(Console.ReadLine());
            }
            while (AC > 2022)
            {
                int AQ = AC - 2022;
                Console.WriteLine("Se ha ingresado una fecha que excede por " + AQ + " años, al año actual." + "\nIngrese nuevamente el año de compra");
                AC = Convert.ToInt32(Console.ReadLine());
            }

            Precio(name, valor, AC);
            return AC;
        }

        public double Precio(string name, int valor, int AC)
        {
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Console.WriteLine("Ingrese el precio");
            double precio = Convert.ToDouble(Console.ReadLine());
            while (precio < 0)
            {
                Console.WriteLine("A dado un valor por debajo de 0. Intentelo nuevamente");
                Console.WriteLine("Ingrese el precio");
                precio = Convert.ToSingle(Console.ReadLine());
            }

            AñoaDepreciar(name, valor, AC, precio);
            return precio;
        }

        public int AñoaDepreciar(string name, int valor, int AC, double precio)
        {
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Console.WriteLine("Ingrese el año en el que quiere depreciar el producto");
            int AD = Convert.ToInt32(Console.ReadLine());
            while (AD <= 0)
            {
                Console.WriteLine("Su año a depreciar es menor a 0, usted es muy tonto.  \nIngreselo nuevamente:");
                AC = Convert.ToInt32(Console.ReadLine());
            }
            while (AD > 2023)
            {
                int AQ = AD - 2023;
                Console.WriteLine("Se ha ingresado una fecha que excede por " + AQ + " años, al año actual." + "\nIngrese nuevamente el año de compra");
                AC = Convert.ToInt32(Console.ReadLine());
            }
            while (AC > AD)
            {
                Console.WriteLine("El año que ingreso es inferior al año de compra. \n Intentelo otra vez:");
                AD = Convert.ToInt32(Console.ReadLine());
            }
            int restanio = AD - AC;
            Valordepreciao(name, AC, AD, restanio, precio, valor);
            return AD;
        }
        public double Valordepreciao(string name, int añoc, int añod, int restanio, double precio, int valor)
        {
            double rest = precio / valor;
            Console.WriteLine("Año de compra: " + añoc);
            Console.WriteLine("Valor depreciar por año: " + rest);
            int x = 0; int y = añoc + 1;
            if (restanio >= valor)
            {
                Console.WriteLine("Contablemente no vale nada.");
            }
            else if (restanio < valor)
            {
                Console.WriteLine("\n" + "Devaluación de " + name);
                while (x < restanio)
                {
                    precio -= rest;
                    Console.WriteLine("Año " + y + " - " + precio);
                    y++; x++;
                }
            }

            ValordeActivo(restanio, precio, valor);
            return precio;
        }

        public double ValordeActivo(int añot, double precio, double valor)
        {
            if (añot >= valor)
            {
                Console.WriteLine("\n" + "El valor del activo es: 0" + "\n");
            }
            else if (añot <= valor)
            {
                Console.WriteLine("\n" + "El valor del activo es: " + precio + "\n");
            }

            string renov = Renov();
            return precio;
        }

        public string Renov()
        {
            Metodo_por_unidades_producidas x = new Metodo_por_unidades_producidas();
            Depreciacion_por_metodo_lineal y = new Depreciacion_por_metodo_lineal();
            Select_Class z = new Select_Class();

            Console.WriteLine("¿Quiere calcular otra vez la depreciación (Responde con Si o No)" + "\n1. Si\n2. No");
            string pqwe = Console.ReadLine();
            while (pqwe != "Si" && pqwe != "No")
            {
                Console.WriteLine("A ingresado una respuesta no valida, intentelo de nuevo");
                Console.WriteLine("¿Quiere calcular otra vez la depreciación (Responde con Si o No)" + "\n1. Si\n2. No");
                pqwe = Console.ReadLine();
                if (pqwe == "Si")
                {
                    z.L();
                }
                else if (pqwe == "No")
                {
                    Environment.Exit(1);
                }
            }
            if (pqwe == "Si")
            {
                z.L();
            }
            else if (pqwe == "No")
            {
                Environment.Exit(1);
            }
            string qw = "xd";
            return qw;
        }
        public double Inmueble(int valor)
        {
            string name = Nameofproduct(valor);
            int añoc = AñoDeCompra(name, valor);
            double precio = Precio(name, valor, añoc);
            int añod = AñoaDepreciar(name, valor, añoc, precio);
            int restanio = añod - añoc;
            double Vp = Valordepreciao(name, añoc, añod, restanio, precio, valor);
            double Va = ValordeActivo(restanio, precio, valor);
            return Va;
        }
        public double Maquinaria(int valor)
        {
            string name = Nameofproduct(valor);
            int añoc = AñoDeCompra(name, valor);
            double precio = Precio(name, valor, añoc);
            int añod = AñoaDepreciar(name, valor, añoc, precio);
            int restanio = añod - añoc;
            double Vp = Valordepreciao(name, añoc, añod, restanio, precio, valor);
            double Va = ValordeActivo(restanio, precio, valor);
            return Va;
        }
        public double Vehiculo(int valor)
        {
            string name = Nameofproduct(valor);
            int añoc = AñoDeCompra(name, valor);
            double precio = Precio(name, valor, añoc);
            int añod = AñoaDepreciar(name, valor, añoc, precio);
            int restanio = añod - añoc;
            double Vp = Valordepreciao(name, añoc, añod, restanio, precio, valor);
            double Va = ValordeActivo(restanio, precio, valor);
            return Va;
        }
        public double EquipoInformatico(int valor)
        {
            string name = Nameofproduct(valor);
            int añoc = AñoDeCompra(name, valor);
            double precio = Precio(name, valor, añoc);
            int añod = AñoaDepreciar(name, valor, añoc, precio);
            int restanio = añod - añoc;
            double Vp = Valordepreciao(name, añoc, añod, restanio, precio, valor);
            double Va = ValordeActivo(restanio, precio, valor);
            return Va;
        }
    }
}
