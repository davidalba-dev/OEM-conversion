using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealSignature;

public partial class TestSignature : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.IO.Stream s;

        s = this.WebSignature1.ImageMemoryStream; 

        
    }
}