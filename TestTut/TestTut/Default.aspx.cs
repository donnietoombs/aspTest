using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestTut
{
    
    public partial class _Default : Page
    {
        public List<string> Sites = new List<string> { "StackOverflow", "Super User", "Meta SO" };

        protected void Page_Load(object sender, EventArgs e)
          {
             
          }

        protected void GetEmployeesBtn_Click(object sender, EventArgs e) => Sites = new List<string> { "hello", "donnie", "toombs" };

        

        protected void GetCustomers_Click(object sender, EventArgs e)
        {
            GetAllEmployees();
        }

        private void GetAllEmployees()
        {
            GridView1.DataSource = ExecuteStoredProcedure();
            GridView1.DataBind();
        }
    }
}
      


