using System;

public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Identificacion { get; set; }
}

public class Empleado : MiembroDeLaComunidad
{
    public string Puesto { get; set; }
    public decimal Salario { get; set; }
}

public class Estudiante : MiembroDeLaComunidad
{
    public string Matricula { get; set; }
    public string Carrera { get; set; }
}

public class ExAlumno : MiembroDeLaComunidad
{
    public int AñoGraduacion { get; set; }
    public string Profesion { get; set; }
}

public class Docente : Empleado
{
    public string Departamento { get; set; }
    public string NivelAcademico { get; set; }
}

public class Administrativo : Empleado
{
    public string Area { get; set; }
    public string Turno { get; set; }
}

public class Administrador : Docente
{
    public string Cargo { get; set; }
    public int AñosExperiencia { get; set; }
}

public class Maestro : Docente
{
    public string Especialidad { get; set; }
    public int AñosEnseñanza { get; set; }
}