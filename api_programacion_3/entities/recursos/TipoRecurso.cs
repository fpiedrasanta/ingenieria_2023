namespace api_programacion_3.entities.recursos;

public class TipoRecurso
{
    private long id;

    public long Id 
    {
        get 
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }
    
    private string descripcion;

    public string Descripcion
    {
        get
        {
            return this.descripcion;
        }

        set 
        {
            this.descripcion = value;
        }
    }
}