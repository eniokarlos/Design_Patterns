namespace flyweight;

public class FormFactory
{
    private static Dictionary<string, IForm> forms = new Dictionary<string, IForm>();

    public static IForm GetForm(string key)
    {
        IForm form;
        if(forms.ContainsKey(key))
            return forms[key];
        else
        {
            if (key == "Circle")
            {
                form = new Circle();
                forms.Add(key, form);
            }
            else
                throw new Exception("This object type cannot be created");
        }
        return form;
    }
}