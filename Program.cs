﻿using First_meeting_with_interface;

internal class Program
{
    private static void Main(string[] args)
    {
        TallGuy tallGuy = new TallGuy(height:176, name:"Jasiek");
        tallGuy.TalkAboutYourlself();
    }
}

class TallGuy:IClown
{
    public string Name;
    public int Height;


    public TallGuy(string name, int height) {

        Name = name;
        Height = height;
    }

    public void TalkAboutYourlself()
    {
        Console.WriteLine($"Nazywam sie: {Name}. Mam wzrostu: {Height}");
    }
    public void Honk()
    {
        Console.WriteLine("Bip, Bip!");
    }
    public string FunnyThingIHave
    {
        get
        {
            return "wielkie buty";
        }
    }
}