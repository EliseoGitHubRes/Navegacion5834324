namespace Navegacion5834324;

public partial class Cambio : ContentPage
{
    /// <summary>
    /// <Createddate>27/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>27/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL LABEL
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
    public Cambio()
	{
		InitializeComponent();
	}

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary> 
    private void Button_Clicked(object sender, EventArgs e)
    {
        double costo = Convert.ToDouble(costoArt.Text);
        double dinero = Convert.ToDouble(dinerocli.Text);

        double cambio = dinero - costo;

        cambioCli.Text = "EL cambio es: $" + cambio;
    }
}