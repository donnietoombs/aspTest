using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestTut
{
    public partial class About : Page
    {
        public List<string> Sites = new List<string> { "StackOverflow", "Super User", "Meta SO" };
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
    }

    }
}