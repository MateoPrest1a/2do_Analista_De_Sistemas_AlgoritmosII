using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public abstract class Persona  // CLASE BASE DE ALUMNO Y EMPLEADOS
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion_Calle { get; set; }
    public int Direccion_Numero { get; set; }
    public string Numero_Telefono { get; set; }
    public string Documento { get; set; }
    public string Email { get; set; }
    public DateTime Fecha_Nacimiento { get; set; }

}

public class Alumno : Persona
{
     public int Matricula { get; set; } //PRIMARY KEY
}

public class EstadoAlumno
{
    public int ID_Estado_Alumno { get; set; } //PRIMARY KEY
    public int Matricula { get; set; } //Foreign Key De Alumno
    public string Descripcion { get; set; }
}

public class Empleado : Persona
{
    public int ID_Empleado { get; set; } //PRIMARY KEY
    public double Salario { get; set; }
    public int DiasTrabajadosMensuales { get; set; }
}

public class Especialidad
{
    public int IdEspecialidad { get; set; }
    public string especialidad { get; set; }
}

public class Materia
{
    public int ID_Materia { get; set; } //PRIMARY KEY
    public DateTime Anio_Cursada { get; set; }
    public string Nombre_Materia { get; set; }
    public int ID_Profesor { get; set; } //Foreing Key de Empleado
}

public class Carrera
{
    public int ID_Carrera { get; set; } //PRIMARY KEY
    public string Nombre_Carrera { get; set; }
    public int Num_Resolucion { get; set; }
    public int Anio_Plan_Estudio { get; set; }
}

public class Examenes
{
    public int ID_Examen { get; set; } //PRIMARY KEY
    public int ID_Carrera { get; set; } //Foreing Key De Carrera
    public int ID_Materia { get; set; } //Foreing Key De Materia
    public int Matricula { get; set; } //Foreing Key de Alumno
    public string Estado { get; set; }
    public int Calificacion { get; set; }
    public DateTime Hora_Examen { get; set; }
    public string Tipo_Examen { get; set; }
    public string Libro { get; set; }
    public int Folio { get; set; }
}

public class Permisos
{
    public int ID_Permiso { get; set; } //PRIMARY KEY
    public string Descripcion { get; set; }
    public int Tipo_Permiso { get; set; }
}

public class Perfiles
{
    public int ID_Perfil { get; set; } //PRIMARY KEY
    public int Tipo { get; set; }
}

//TABLAS PIVOT

class MateriasXCarrera
{
    public int ID_MateriasXCarrera { get; set; } //PRIMARY KEY
    public int ID_Materia { get; set; } //Foreing Key de Materia
    public int ID_Carrera { get; set; } //Foreing Key de Carreras
}

class AlumnosXCarrera
{
    public int ID_AlumnosXCarrera { get; set; } //PRIMARY KEY
    public int ID_Carrera { get; set; } //Foreing key de Carrera
    public int Matricula { get; set; } //Foreing key de Alumnos
}

class MateriasXAlumno
{
    public int ID_MateriaXAlumno { get; set; } //PRIMARY KEY
    public int Matricula { get; set; } //Foreing key de Alumnos
    public int ID_Materia { get; set; } //Foreing key de Materias

}

class PermisosXPerfiles
{
    public int ID_PermisosXPerfiles { get; set; } //PRIMARY KEY
    public int ID_Perfil { get; set; } //Foreing Key de Perfiles
    public int ID_Permiso { get; set; }//Foreing key de Permisos
}

class PerfilXAlumno
{
    public int ID_PerfilXAlumno { get; set; }//PRIMARY KEY
    public int ID_Perfil { get; set; } //FOREING KEY DE Perfiles
    public int Matricula { get; set; } //FOREING KEY DE Alumnos
    public string NombreUsuario { get; set; }
    public string Constraseña { get; set; }
}

class PerfilXPersona
{
    public int ID_PerfilXPersona { get; set; } //PRIMARY KEY
    public int ID_Perfil { get; set; } //Foreing Key de perfiles
    public int ID_Empleado { get; set; } //Foreing key de Empleados
    public string NombreUsuario { get; set; }
    public string Constraseña { get; set; }
}


public class TipoExamen     // Clase para cargar los tipo examen en los combo box.
{
    public int Id { get; set; }
    public string Descripcion { get; set; }

    public override string ToString() => Descripcion; // Para que se muestre correctamente en el ComboBox
}

/*
class Program
{
    static void Main()
    {
        /*     CONSTRUCTORES DE ALUMNOS Y EMPLEADOS

        Alumno AlumnoNuevo = new Alumno
    {
            Matricula = int.Parse(txtMatricula.Text),  //Matricula específica de Alumno
            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Direccion_Calle = txtDireccionCalle.Text,
            Direccion_Numero = int.Parse(txtDireccionNumero.Text),
            Numero_Telefono = double.Parse(txtTelefono.Text),
            Documento = double.Parse(txtDNI.Text),
            Email =txtEmail.Text,
            Fecha_Nacimiento = dtpFechaNacimiento.Value

        };

        Empleado EmpleadoNuevo = new Empleado
        {
            ID_Empleado = int.Parse(txtIDEmpleado.Text), // ID específico de Empleado
            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Direccion_Calle = txtDireccionCalle.Text,
            Direccion_Numero = int.Parse(txtDireccionNumero.Text),
            Numero_Telefono = double.Parse(txtTelefono.Text),
            Documento = double.Parse(txtDNI.Text),
            Email = txtEmail.Text,
            Fecha_Nacimiento = dtpFechaNacimiento.Value,
            Salario = int.Parse(txtSalario.Text),
            DiasTrabajadosMensuales = int.Parse(txtDiasTrabajados.Text)
        };
       
    
        

    }//llave del main
}//llave del program  */




//COMPROBACIONES DE SI EXISTEN LOS CAPOS
//PARA EMPLEADO CAMBIAR ID Y AGREGAR:

//ID_EMPLEADO
/*
if (txtID_Empleado.Text = "")
{
    MessageBox.Show("Ingrese un valor para la ID");
}
else
{
    if (int.TryParse(txtID_Empleado.Text, out int numero))
    {
        ID_Empleado = numero;
    }
    else
    {

        MessageBox.Show("Por favor ingrese un número válido.");
    }
}

//SALARIO

if (txtSalario.Text == "")
{
    MessageBox.Show("Ingrese un valor para el salario");
}
else
{
    if (int.TryParse(txtSalario.Text, out int numero))
    {
        Salario = numero;
    }
    else
    {

        MessageBox.Show("Por favor ingrese un número válido.");
    }
}

//DIAS TRABAJADOS

if(txtDiasTrabajados.Text =="")
{
    MessageBox.Show("Ingrese una cantidad de dias");
}
else
{
    if (int.TryParse(txtDiasTrabajados.Text, out int numero))
    {
        DiasTrabajados = numero;
    }
    else
    {

        MessageBox.Show("Por favor ingrese un número válido.");
    }

}
*/