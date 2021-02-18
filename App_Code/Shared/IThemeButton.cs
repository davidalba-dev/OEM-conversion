
using Microsoft.VisualBasic;
  
namespace OEMConversion.UI
{

  

    public interface IThemeButton {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
        System.Web.UI.WebControls.Literal PageTitle {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  