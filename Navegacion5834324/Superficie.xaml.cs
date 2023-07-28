namespace Navegacion5834324;

public partial class Superficie : ContentPage
{
    /// <summary>
    /// <Createddate>27/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>27/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL ENTRY
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
    public Superficie()
	{
		InitializeComponent();
	}

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double b = Convert.ToDouble(baseTri.Text);
        double a = Convert.ToDouble(altTri.Text);

        double s = b * a;

        supTri.Text = "La superficie es : " + s;
    }
}