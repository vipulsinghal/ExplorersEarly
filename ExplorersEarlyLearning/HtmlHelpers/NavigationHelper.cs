using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExplorersEarlyLearning.HtmlHelpers
{
    public class TabMenuHelper
    {
        public static IList<String> GetMenuItems()
        {
            List<String> menuItems = new List<String>() { 
                      "Home","philosophy","programs","centers","portfolios","employment","contact us"
                };
            return menuItems;
        }

    }
    public static class NavigationHelper
    {
        public static MvcHtmlString NavMenu(int selectedIndex)
        {
            var ul = new TagBuilder("ul");
            //var url = new UrlHelper(helper.ViewContext.RequestContext);
            int i = 1;
            foreach (var item in TabMenuHelper.GetMenuItems())
            {
                var li = new TagBuilder("li");
                var anchor = new TagBuilder("a");
                if (i > 2) {
                    anchor.MergeAttribute("href", "#");
                }
                else
                {
                    anchor.MergeAttribute("href", item);
                }
                anchor.InnerHtml = item;
                if (i == selectedIndex) anchor.AddCssClass("active");
                li.InnerHtml += anchor.ToString();
                ul.InnerHtml += li.ToString();
                i++;
            }
            return MvcHtmlString.Create(ul.ToString());
        }
    }
}