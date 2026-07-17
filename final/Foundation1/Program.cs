using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("I Survived 100 Days in Hardcore Minecraft", "PixelPioneer27", 900);
        Video video2 = new Video("Testing Every Viral Kitchen Gadget So You Don't Have To", "WhiskWizard_", 243);
        Video video3 = new Video("Every Pokémon I Use Has to Be Shiny", "TheCaramelCrow", 1920);
    
        video1.AddComment("BlockBuilder88", "This was one of the best Hardcore runs I've seen!");
        video1.AddComment("jayden_525", "I can't believe you survived that creeper explosion");
        video1.AddComment("cloudydayy", "I love the cozy pond you made!");

        video2.AddComment("cocoa_addict33", "I actually own that first hadget and it broke after a week. 😭");
        video2.AddComment("breezy_princess", "I laughed way harder than I should have at the egg slicer.");
        video2.AddComment("loafkitty808", "This saved me from buying a bunch of stuff I don't need.");

        video3.AddComment("Soul_merchant", "I would've lost my patience after the first shiny hunt.");
        video3.AddComment("KingScizor", "Please do a shiny-only Nuzlocke next!");
        video3.AddComment("IEatUrFridge", "That shiny team looked incredible!");

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    
    }   
}