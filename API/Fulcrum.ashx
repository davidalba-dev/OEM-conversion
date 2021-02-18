<%@ WebHandler Language="C#" Class="Fulcrum" %>

using System;
using System.Web;



public class Fulcrum : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        fulcrum fulcrumData = new fulcrum();
        fulcrumData.id=context.Request.QueryString["id"];
        fulcrumData.oem_asset = context.Request.QueryString["oem_asset"];
        fulcrumData.serial = context.Request.QueryString["serial"];
        fulcrumData.make = context.Request.QueryString["make"];
        fulcrumData.model = context.Request.QueryString["model"];
        fulcrumData.warehouse = context.Request.QueryString["warehouse"];
        fulcrumData.location = context.Request.QueryString["location"];
        fulcrumData.location1 = context.Request.QueryString["location1"];
        fulcrumData.comments = context.Request.QueryString["comments"];
        fulcrumData.date = context.Request.QueryString["date"];
        fulcrumData.time = context.Request.QueryString["time"];
        fulcrumData.typeOp = context.Request.QueryString["typeOp"];

        switch(fulcrumData.typeOp)
        {
                case "new":
                    fulcrumData.newRecords();
                    break;
                case "edit":
                    fulcrumData.updateRecords();
                    break;
                case "exportNew":
                    fulcrumData.InsertIntofulcrum();
                    break;
        }
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}