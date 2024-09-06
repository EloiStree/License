using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EloiLaboratory 
{
    public const string EDITORMENUSTART = "ꬲ🧰";
    public const string INFOMENU = "✋ Hi you...";
   
    
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU , true, 1)]
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/❗ GitHub ", false, 10000)]
    static void Contact()
    {
        Application.OpenURL("https://github.com/EloiStree/");
    }

    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/🍺 License", false, 9996)]
    static void License()
    {
        Application.OpenURL("https://github.com/EloiStree/License");
    }
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/🌱 Support my games", false, 9996)]
    static void SupportGames()
    {
        Application.OpenURL("https://patreon.com/integergames");
    }

    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/🐞 Report Bug", false, 9997)]
    static void Issue()
    {
        Application.OpenURL("https://github.com/EloiStree/EloiStree/issues");
    }
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/💬 Discord talk", false, 9998)]
    static void Discord()
    {
        Application.OpenURL("https://discord.gg/wqaagfCJs7");
    }
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/🧰 Open UPM", false, 9998)]
    static void OpenUPM()
    {
        Application.OpenURL("https://openupm.com/packages/?sort=downloads&q=eloistree");
    }
}
