namespace ConsoleNullObject.Models;

public class MobileRepository
{
    public Mobile GetMobileByName(string mobileName)
    {
        Mobile mobile = NullMobile.Instance;
        switch (mobileName)
        {
            case "sony":
                mobile = new SonyXperia();
                break;

            case "apple":
                mobile = new AppleIPhone();
                break;

            case "samsung":
                mobile = new SamsungGalaxy();
                break;
        }
        return mobile;
    }
}