﻿
using Microsoft.VisualBasic;
  
namespace OEMConversion.UI
{

  

    public interface IMenu_Item_HighlightedVertical {

#region Interface Properties
        
        System.Web.UI.WebControls.LinkButton Button {get;}
                
      bool Visible {get; set;}
      string ID {get; set;}
         

#endregion

    }

  
}
  