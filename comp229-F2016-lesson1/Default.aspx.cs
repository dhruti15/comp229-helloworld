using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp229_F2016_lesson1
{
    public partial class _Default : Page
    {
        ///<summary>
        ///this method executes every time the page loads
        ///</summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = "Good Bye!!!!";
        }
    }
}