namespace PrimerBlazor.Data;
public class Empleado
{
    string nombre="";
    string apellido="";
    string cargo="";
    double salario=0;

    public Empleado(string nombre,string apellido,string cargo,double salario)
    {
        this.Nombre=nombre;
        this.Apellido=apellido;
        this.Cargo=cargo;
        this.Salario=salario;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Cargo { get => cargo; set => cargo = value; }
    public double Salario { get => salario; set => salario = value; }
}