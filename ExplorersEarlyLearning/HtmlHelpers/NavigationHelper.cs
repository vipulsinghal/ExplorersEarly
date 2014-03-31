using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExplorersEarlyLearning.HtmlHelpers
{
    public class MenuItem
    {
        public MenuItem() {
        }
        
        public MenuItem(string name, string url, int index) {
            this.Name = name;
            this.Url = url;
            this.Index = index;
        }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Index { get; set; }
    }
    public class TabMenuHelper
    {
        public static IList<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>() { 
                      new MenuItem("Home","/Home",1),new MenuItem("Philosophy","/Philosophy",2),
                      new MenuItem("Programs","/Programs",3),new MenuItem("Centers","#",4),
                      new MenuItem("Portfolios","/Portfolios",5),new MenuItem("Employment","/Employment",6),
                      new MenuItem("Contact us","#",7)
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
            
            foreach (var item in TabMenuHelper.GetMenuItems())
            {
                var li = new TagBuilder("li");
                var anchor = new TagBuilder("a");
                
                    anchor.MergeAttribute("href", item.Url);
                
                anchor.InnerHtml = item.Name;
                if (selectedIndex == item.Index) anchor.AddCssClass("active");
                li.InnerHtml += anchor.ToString();
                ul.InnerHtml += li.ToString();
            }
            return MvcHtmlString.Create(ul.ToString());
        }
    }
}