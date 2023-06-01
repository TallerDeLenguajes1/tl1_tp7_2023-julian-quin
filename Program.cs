using EmpleadoTp;
internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleados=new Empleado();
        empleados.Apellido="mario";
        Console.WriteLine(empleados.Apellido);
    }
}