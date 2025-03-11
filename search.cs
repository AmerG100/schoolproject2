using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for search
/// </summary>
public class search
{
    public search()
    {
    }
    public static string GetKeyWords(string textsearch, string fld)
    {
        // textsearch - content of textbox of search
        //fld - field in which we want to search



        //---getting search parameters
        int maxcounter, counter;
        string tempinput, whereclause, thisword;
        //---handling key words
        if (textsearch != "") //
        {
            string[] allwords;
            tempinput = textsearch.Trim().Replace('*', '%');
            //    Replace(Trim(textsearch), "*", "%");
            tempinput = textsearch.Trim().Replace('?', '_');
            allwords = tempinput.Split(' ');
            maxcounter = allwords.Length;
            //tempinput = Replace(tempinput, "?", "_");
            //allwords = Split(tempinput, " ");
            //maxcounter = ubound(allwords);

            whereclause = " ( " + fld + " like'%" + allwords[0] + "%'";// OR lname like'%" + allwords[0] + "%'";


            for (counter = 1; counter < maxcounter; counter++)
            {

                thisword = allwords[counter];
                whereclause = whereclause + " OR " + fld + " like'%" + thisword + "%'";// OR lname like'%" + thisword + "%'";

            }
            whereclause = whereclause + ")";


            return whereclause;
        }
        return "nothing";
    }
}
