namespace api_programacion_3.entities.recursos;

public class Bibliografia 
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

    private string urlImagen;

    public string UrlImagen
    {
        get 
        {
            return this.urlImagen;
        }

        set
        {
            this.urlImagen = value;
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

    private string titulo;

    public string Titulo
    {
        get
        {
            return this.titulo;
        }

        set 
        {
            this.titulo = value;
        }
    }

    private string link;

    public string Link
    {
        get
        {
            return this.link;
        }

        set 
        {
            this.link = value;
        }
    }
}