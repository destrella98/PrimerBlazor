namespace PrimerBlazor.Data;

public class EmpleadosBDDService
{
    private List<Empleado> empleados= new();

    public EmpleadosBDDService()
    {
        empleados.Add(new Empleado("David","Estrella","Dev. Junior",500));
        empleados.Add(new Empleado("Juan","López","Dev. Senior",1500));
        empleados.Add(new Empleado("Francisco","Rodríguez","Secretario",500));
        empleados.Add(new Empleado("María","Ladelbarrio","Mng. RH",1000));
        empleados.Add(new Empleado("Pepe","Lepuu","CEO",3000));
    }
    
    public Task<List<Empleado>> ReadEmpleados()
    {
        return Task.FromResult(empleados);
    }

    public void CreateEmpleado(Empleado empleado)
    {
        empleados.Add(empleado);
    }

    public void UpdateEmpleado(int index,Empleado empleado)
    {
        empleados[index]=empleado;
    }

    public void DeleteEmpleado(int index)
    {
        empleados.RemoveAt(index);
    }
}