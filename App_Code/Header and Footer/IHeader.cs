
using Microsoft.VisualBasic;
  
namespace OEMConversion.UI
{

  

    public interface IHeader {

#region Interface Properties
        
        System.Web.UI.WebControls.ImageButton HeaderSettings {get;}
                
        System.Web.UI.WebControls.Label Label {get;}
                
        System.Web.UI.WebControls.Image Logo {get;}
                
        System.Web.UI.WebControls.Literal PageTitle {get;}
                OEMConversion.UI.Controls.Header.Repair_order_requestTableControl Repair_order_requestTableControl {get;}
                
        System.Web.UI.WebControls.LinkButton SignIn {get;}
                
        System.Web.UI.WebControls.HyperLink SkipNavigationLinks {get;}
                
        System.Web.UI.WebControls.Label UserStatusLbl {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  