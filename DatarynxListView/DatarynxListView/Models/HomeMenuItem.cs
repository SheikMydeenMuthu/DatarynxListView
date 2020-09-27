using System;
using System.Collections.Generic;
using System.Text;

namespace DatarynxListView.Models
{
    public enum MenuItemType
    {
        About,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
