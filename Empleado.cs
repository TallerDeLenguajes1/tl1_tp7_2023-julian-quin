namespace EmpleadoTp
{
    public enum cargoEmpleado   //constantes en enum
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechNac;
        private char genero;
        private DateTime fechIngreso;
        private double sueldoBasico;
        private cargoEmpleado cargo;

        public string Nombre
        { get => nombre; set => nombre = value; }
        public string Apellido
        { get => apellido; set => apellido = value; }
        public DateTime FechNac
        { get => fechNac; set => fechNac = value; }
        public char Genero
        { get => genero; set => genero = value; }
        public DateTime FechIngreso
        { get => fechIngreso; set => fechIngreso = value; }
        public double SueldoBasico
        { get => sueldoBasico; set => sueldoBasico = value; }
        public cargoEmpleado Cargo { get => cargo; set => cargo = value; }

        public int Antiguaedad()
        {
            //int antiguedad;
            var fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual.Subtract(FechIngreso);
            int antiguedadAnios = diferencia.Days / 365;
            //antiguedad = "Antigüedad del empleado: " + antiguedadAnios + " años, " + antiguedadMeses + " meses y " + antiguedadDias + " días";
            return (antiguedadAnios);
        }

        public int edadEmpleado()
        {
            var anioActual = DateTime.Now;
            int retorno;
            int edad = anioActual.Year - FechNac.Year;
            retorno = edad;
            return retorno;
        }

        public int jubilo(int edad)
        {
            int faltan;
            if (Genero == 'm' || Genero == 'M')
            {
                if (edad < 65)
                {
                    faltan = 65 - edad;
                    return faltan;
                }

            }
            else
            {
                if (edad < 60)
                {
                    faltan = 60 - edad;
                    return faltan;
                }
            }

            return 0;


        }
        public double Salario(int antiguedad, int estadoCivil)
        {
            double SalarioNeto;
            double Adicional;

            if (antiguedad <= 20)
            {
                Adicional = (SueldoBasico / 100) * antiguedad;

            }
            else
            {
                Adicional = (SueldoBasico * 25 / 100) * antiguedad;
            }
            if (Cargo == cargoEmpleado.Ingeniero || Cargo == cargoEmpleado.Especialista)
            {
                Adicional += (Adicional * 50) / 100;
            }

            if (estadoCivil == 1)
            {
                Adicional += 15000;
            }

            SalarioNeto = Adicional + SueldoBasico;

            return SalarioNeto;

        }

    }
}
