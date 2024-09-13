using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using System.Web.Mvc;

namespace CustomHelper
{
    public static class customeHelper
    {
        public static IHtmlString Mytag(string txt)
        {
            //string ans = "<b>" + txt + "</b>";
            string ans = "<img src='" + txt + "' alt='no data'>";
            return new MvcHtmlString(ans);
        }
        public static IHtmlString my(this HtmlHelper helper, string txt)
        {
            //string ans = "<b>" + txt + "</b>";
            string ans = "<img src='" + txt + "' alt='no data'>";
            return new MvcHtmlString(ans);
        }
        public static IHtmlString myt(this HtmlHelper helper, string txt)
        {
            TagBuilder t = new TagBuilder("img");
            t.Attributes.Add("src", txt);
            t.Attributes.Add("alt", "no data");
            return new MvcHtmlString(t.ToString());
        }
    }
}