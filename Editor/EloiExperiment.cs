using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EloiExperiment : MonoBehaviour
{
    public const string EDITORMENUSTART = "ꬲ🧰";
    public const string INFOMENU = "Info on ꬲ🧰";
   
    [MenuItem(EDITORMENUSTART + "/"+ INFOMENU + "/💲 Applied License", false, 10000)]
    static void License()
    {
        Application.OpenURL("https://eloistree.page.link/license");
    }

    [MenuItem(EDITORMENUSTART + "/" + INFOMENU , true, 1)]
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/❗ Information", false, 9996)]
    static void Contact()
    {
        Application.OpenURL("https://eloistree.page.link/contact");
    }
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/🐞 Bug + Issue", false, 9997)]
    static void Issue()
    {
        Application.OpenURL("https://eloistree.page.link/issue");
    }
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/💬 Discord talk", false, 9998)]
    static void Discord()
    {
        Application.OpenURL("https://eloistree.page.link/discord");
    }
    [MenuItem(EDITORMENUSTART + "/" + INFOMENU + "/📡 RSS Stay Tuned", false, 9999)]
    static void RSS()
    {
        Application.OpenURL("https://eloistree.page.link/rss");
    }
    [MenuItem(EDITORMENUSTART + "/☕ Ko-Fi", false, 10001)]
    static void KoFi()
    {
        Application.OpenURL("https://eloistree.page.link/donation");
    }

}
