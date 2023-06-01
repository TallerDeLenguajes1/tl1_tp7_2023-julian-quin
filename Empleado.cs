namespace EmpleadoTp
{
        enum cargo   //constantes en enum
        {
            Auxiliar = 0,
            Administrativo = 1,
            Ingeniero = 2,
            Especialista = 3,
            Investigador = 4,
        }
        public class Empleado
        {
            private string nombre;
            private string apellido;
            private DateTime fechNac;
            private char genero;
            private DateTime fechIngreso;
            private double sueldoBasico;
            private cargo cargo;

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
            internal cargo Cargo
            { get => cargo; set => cargo = value; }

            public TimeSpan Antiguaedad(DateTime fechaIngreso)
            {
                DateTime actual = DateTime.Today;
                TimeSpan antiguedad = actual - fechaIngreso;
                return (antiguedad);
            }
        }
}
