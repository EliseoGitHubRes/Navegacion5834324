namespace Navegacion5834324;

public partial class Gas : ContentPage
{
    /// <summary>
    /// <Createddate>27/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>27/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL IMAGEN
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
    public Gas()
	{
		InitializeComponent();
	}

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double galones = Convert.ToDouble(canGas.Text);

        double litros;

        litros = galones * 3.78541;

        cosTotal.Text = "El costo total es: $" + (litros * 1.168);
    }
}