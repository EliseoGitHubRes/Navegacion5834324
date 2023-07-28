namespace Navegacion5834324;

public partial class MainPage : ContentPage
{

    /// <summary>
    /// <Createddate>27/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>27/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL BUTTON
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
    public MainPage()
	{
		InitializeComponent();
	}


    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Cambiobtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cambio());
    }

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Dinobtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dinosaurio());
    }

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Gasbtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gas());
    }

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Superficiebtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Superficie());
    }

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Acercabtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acerca());
    }
}

