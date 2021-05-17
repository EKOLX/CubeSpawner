public class MainController
{
    private MainModel mainModel;

    public MainController()
    {
        mainModel = new MainModel();
    }

    public string HandleClck()
    {
        return (mainModel.ClickCount++).ToString();
    }
}
