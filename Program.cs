using EmpleadoTp;
internal class Program
{
    private static void Main(string[] args)
    {
        string texto;
        char auxgenero;
        int anio,mes,dia,civil=10,texAnum;
        double TotalSalarios=0;
        Empleado [] empleados = new Empleado[2];


        Console.WriteLine("\tJULIAN CORPORATION && COMPANY\n");
        for (int i = 0; i < 2; i++)
        {
            empleados[i] = new Empleado();
            Console.WriteLine("ingrese nombre");
            texto = Console.ReadLine();
            empleados[i].Nombre = texto;
            Console.WriteLine("ingrese Apellido");
            empleados[i].Apellido= Console.ReadLine();
            Console.WriteLine("ingrese fecha de nacimiento");
            empleados[i].FechNac = ingresarFecha();
            Console.WriteLine("ingresa tu genero m=(masculino) o f=(femenino)");
            texto = Console.ReadLine();
            char.TryParse(texto, out auxgenero);
            empleados[i].Genero = auxgenero;
            Console.WriteLine("ingrese la fecha de ingreso");
            empleados[i].FechIngreso=ingresarFecha();
            Console.WriteLine("ingresa sueldo basico");
            texto = Console.ReadLine();
            int.TryParse(texto , out texAnum);
            empleados[i].SueldoBasico = texAnum;
            Console.WriteLine("Ingrese cargo ( Auxiliar = 0 ,Administrativo = 1, Ingeniero = 2, Especialista = u3,Investigador = 4)");
            texto = Console.ReadLine();
            int.TryParse(texto , out texAnum);
            
            switch (texAnum)
            {
                case 0:
                    empleados[i].Cargo = cargoEmpleado.Auxiliar;
                break; 
                case 1: 
                    empleados[i].Cargo =  cargoEmpleado.Administrativo;
                break;
                case 2:
                    empleados[i].Cargo = cargoEmpleado.Ingeniero;
                break;
                case 3:
                    empleados[i].Cargo = cargoEmpleado.Especialista;
                break;
                case 4:
                    empleados[i].Cargo = cargoEmpleado.Investigador;
                break;
            }
            Console.WriteLine("¿ Sos casado ? (si = 1 y no = 0)");
            texto = Console.ReadLine();
            int.TryParse(texto , out civil);

        }

        for (int i = 0; i < empleados.Length; i++) TotalSalarios += empleados[i].Salario(empleados[i].Antiguaedad(),civil);
        MostrarEmpleado(DeterminarCercanoJubilo(empleados), civil);
        Console.WriteLine("total Salarios: $ "+ TotalSalarios);





        DateTime ingresarFecha() // las funciones ven las variables fuera de ellas, pero desde afuera no se ven las variables declaradas dentro de las mismas
        {
            Console.WriteLine("ingrese en formato: año-mes-dia (con espacios de delimitacion)\n");
            texto = Console.ReadLine();
            string [] fechaArreglo = texto.Split(" ");
            int.TryParse(fechaArreglo[0], out anio);
            int.TryParse(fechaArreglo[1], out mes);
            int.TryParse(fechaArreglo[2], out dia);
            var fechaingresado= new DateTime (anio,mes,dia);
            return fechaingresado;
        }

        Empleado DeterminarCercanoJubilo (Empleado [] empleados)
        {
            Empleado Amostrar=null;
            int jubiloAnterior=9999;
            int edad;
            for (int i = 0; i < empleados.Length; i++)
            {
                
                edad = empleados[i].edadEmpleado();
                if (empleados[i].jubilo(edad) < jubiloAnterior)
                {
                    Amostrar=empleados[i]; 
                    jubiloAnterior = empleados[i].jubilo(edad);

                }
            }
            return Amostrar;
        }

        void MostrarEmpleado(Empleado empleadoo, int civil)
        {
            Console.WriteLine("Empleado Proximo a jubilarse");
            Console.WriteLine("nombres: "+ empleadoo.Nombre);
            Console.WriteLine("apellido: "+ empleadoo.Apellido);
            Console.WriteLine("edad: "+ empleadoo.edadEmpleado());
            Console.WriteLine("antiguedad "+ empleadoo.Antiguaedad() + " años");
            Console.WriteLine("Julbilo en: "+ empleadoo.jubilo(empleadoo.edadEmpleado()) + " años");
            Console.WriteLine("Sueldo Basico: "+ empleadoo.SueldoBasico);
            Console.WriteLine("salario: " + empleadoo.Salario(empleadoo.Antiguaedad(),civil));
            
        }
    }
}