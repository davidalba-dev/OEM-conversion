using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

/// <summary>
/// Сводное описание для fulcrum
/// </summary>
public class fulcrum
{
    public string id { set; get; } //inventoryID
    public string fulcrumID { set; get; }  //fulcrumID
    public string oem_asset { set; get; } //oem_ein
    public string serial { set; get; } //serial_number
    public string make { set; get; } //make_id
    public string model { set; get; } //model_id
    public string warehouse { set; get; } //warehouse_id
    public string location { set; get; } //warehouse_location_id
    public string location1 { set; get; }
    public string comments { set; get; } //description
    public string date { set; get; }
    public string time { set; get; }
    public string typeOp { set; get; } //type of operation into fulcrum: new or edit
    


    public fulcrum()
    {
        //
        // TODO: добавьте логику конструктора
        //
    }
    public void newRecords()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        connection.Open();
        string var_sql = "INSERT INTO equipment_inventory (oem_ein, fulcrumID,serial_number,make_id,model_id,warehouse_id,warehouse_location_id,description) VALUES (@oem_ein, @fulcrumID,@serial_number,@make_id,@model_id,@warehouse_id,@warehouse_location_id,@description)";
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = var_sql;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@oem_ein", this.oem_asset);
        command.Parameters.AddWithValue("@serial_number", this.serial);
        command.Parameters.AddWithValue("@fulcrumID", this.fulcrumID);
        command.Parameters.AddWithValue("@make_id", this.make);
        command.Parameters.AddWithValue("@model_id", this.model);
        command.Parameters.AddWithValue("@warehouse_id", getWarehouseID(this.warehouse));
        command.Parameters.AddWithValue("@warehouse_location_id", getWarehouseLocationID(this.location));
        command.Parameters.AddWithValue("@description", this.comments);

        command.ExecuteNonQuery();
        connection.Close();

        
    }
    public string getWarehouseID(string warehouseName)
    {
        string retValue = "0";
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        connection.Open();
        string var_sql = "SELECT warehouse_id FROM warehouse WHERE warehouse.warehouse_name=@warehouseName";
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = var_sql;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@warehouseName", warehouseName);

        SqlDataReader sqlreader = command.ExecuteReader();
        if (sqlreader.Read())
        {
            retValue = sqlreader.GetInt32(sqlreader.GetOrdinal("warehouse_id")).ToString();
        }
        sqlreader.Close();
        connection.Close();

        return retValue;

    }
    public string getWarehouseLocationID(string warehouseName)
    {
        string retValue = "0";
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        connection.Open();
        string var_sql = "SELECT warehouse_location_id FROM warehouse_location WHERE .warehouse_location.warehouse_location=@warehouseName";
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = var_sql;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@warehouseName", warehouseName);

        SqlDataReader sqlreader = command.ExecuteReader();
        if (sqlreader.Read())
        {
            retValue = sqlreader.GetInt32(sqlreader.GetOrdinal("warehouse_location_id")).ToString();
        }
        sqlreader.Close();
        connection.Close();

        return retValue;

    }
    public void updateRecords()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        connection.Open();
        string var_sql = "UPDATE equipment_inventory SET oem_ein=@oem_ein, serial_number=@serial_number,make_id=@make_id,model_id=@model_id,warehouse_id=@warehouse_id,warehouse_location_id=@warehouse_location_id,description=@description WHERE fulcrumID=@fulcrumID";
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = var_sql;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@oem_ein", this.oem_asset);
        command.Parameters.AddWithValue("@serial_number", this.serial);
        command.Parameters.AddWithValue("@fulcrumID", this.fulcrumID);
        command.Parameters.AddWithValue("@make_id", this.make);
        command.Parameters.AddWithValue("@model_id", this.model);
        command.Parameters.AddWithValue("@warehouse_id", getWarehouseID(this.warehouse));
        command.Parameters.AddWithValue("@warehouse_location_id", getWarehouseLocationID(this.location));
        command.Parameters.AddWithValue("@description", this.comments);

        command.ExecuteNonQuery();
        connection.Close();
    }
    public void updateWarehouseDataIntoFulcrum(string fulcrumID, string inventoryID, string warehouse, string warehouseLocation)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseAYS_OEM"].ConnectionString);
        connection.Open();
        string var_sql = "UPDATE equipment_inventory SET fulcrumID=@fulcrumID WHERE inventory_id=@inventory_id";
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = var_sql;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@inventory_id", inventoryID);
        command.Parameters.AddWithValue("@fulcrumID", fulcrumID);
        command.ExecuteNonQuery();
        connection.Close();
        string endPoint = ConfigurationManager.AppSettings["FulcrumFormUpdateData"];
        string tokenAPI = ConfigurationManager.AppSettings["FulcrumToken"];
        string formInventoryID = ConfigurationManager.AppSettings["FormInventoryID"];
        endPoint = endPoint + fulcrumID + ".json";

        HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(endPoint);
        myHttpWebRequest.Method = "GET";
        myHttpWebRequest.ContentType = "application/json";
        myHttpWebRequest.Accept = "application/json";
        myHttpWebRequest.Headers.Add("X-ApiToken", tokenAPI);
        HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
        dynamic jsonResult;
        using (Stream dataStream = myHttpWebResponse.GetResponseStream())
        {
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  

            jsonResult = JsonConvert.DeserializeObject(responseFromServer);

        }

        string data = "{\"record\":";
        data += "{\"form_id\": \"" + jsonResult.record.form_id + "\",";
        data += "\"form_values\": {";
        data += "\"75a5\": \"" + jsonResult.record.form_values["75a5"] + "\","; //OEM Asset
        data += "\"b56a\": \"" + jsonResult.record.form_values["b56a"] + "\","; //Serial Number
        data += "\"83de\": \"" + jsonResult.record.form_values["83de"] + "\","; //Make
        data += "\"1b90\": \"" + jsonResult.record.form_values["1b90"] + "\","; //model
        data += "\"2263\": {\"choice_values\": [\""+ warehouse+"\"]},"; //warehouse
        data += "\"40dd\": {\"choice_values\": [\""+ warehouseLocation+"\"]},"; //location
        data += "\"b728\": \"" + jsonResult.record.form_values["b728"] + "\"}"; //comments
        data += "}";
        data += "}";
                     
        myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(endPoint);
        myHttpWebRequest.Method = "PUT";
        myHttpWebRequest.ContentType = "application/json";
        myHttpWebRequest.Accept = "application/json";
        myHttpWebRequest.Headers.Add("X-ApiToken", tokenAPI);
        using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
        {
            
            JObject JSONbody = JObject.Parse(data);
            streamWriter.Write(JSONbody);
            streamWriter.Flush();
            streamWriter.Close();
        }
         myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
        using (Stream dataStream = myHttpWebResponse.GetResponseStream())
        {
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
           
            jsonResult = JsonConvert.DeserializeObject(responseFromServer);
            
        }

        // Close the response.  
        myHttpWebResponse.Close();
    }
    public string updateIntofulscrum(string inventoryID)
    {
        //declaration of objects
        string retValue = "";
        string formInventoryID = ConfigurationManager.AppSettings["FormInventoryID"];
        string endPoint = ConfigurationManager.AppSettings["FulcrumFormInsertData"];
        string tokenAPI = ConfigurationManager.AppSettings["FulcrumToken"];
        dynamic jsonResult;

        //collent info from database about updated record
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseAYS_OEM"].ConnectionString);
        connection.Open();
        string var_sql = "SELECT equipment_inventory.fulcrumID AS fulcrumID";
        var_sql+= ",equipment_inventory.oem_ein AS oem_ein";
        var_sql += ",equipment_inventory.description AS description";
        var_sql += ",equipment_inventory.serial_number AS serial_number";
        var_sql += ",equipment_inventory.model_id AS model_id";
        var_sql += ",equipment_inventory.make_id AS make_id";
        var_sql += ",IsNULL(warehouse.warehouse_name,'') AS warehouse_name";
        var_sql += ",IsNULL(warehouse_location.warehouse_location,'') AS warehouse_location";
        var_sql += " FROM equipment_inventory";
        var_sql += " LEFT OUTER JOIN warehouse ON warehouse.warehouse_id=equipment_inventory.warehouse_id";
        var_sql += " LEFT OUTER JOIN warehouse_location ON warehouse_location.warehouse_location_id=equipment_inventory.warehouse_location_id";
        var_sql += " WHERE inventory_id=@inventory_id";

        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = var_sql;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@inventory_id", inventoryID);

        SqlDataReader sqlreader = command.ExecuteReader();

        if (sqlreader.Read())
        {
            this.id = inventoryID;
            this.fulcrumID = sqlreader.IsDBNull(sqlreader.GetOrdinal("fulcrumID")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("fulcrumID"));
            this.comments= sqlreader.IsDBNull(sqlreader.GetOrdinal("description")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("description"));
            this.oem_asset= sqlreader.IsDBNull(sqlreader.GetOrdinal("oem_ein")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("oem_ein"));
            this.serial = sqlreader.IsDBNull(sqlreader.GetOrdinal("serial_number")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("serial_number"));
            this.model = sqlreader.IsDBNull(sqlreader.GetOrdinal("model_id")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("model_id"));
            this.make = sqlreader.IsDBNull(sqlreader.GetOrdinal("make_id")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("make_id"));
            this.warehouse = sqlreader.IsDBNull(sqlreader.GetOrdinal("warehouse_name")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("warehouse_name"));
            this.location = sqlreader.IsDBNull(sqlreader.GetOrdinal("warehouse_location")) ? "" : sqlreader.GetString(sqlreader.GetOrdinal("warehouse_location"));

        }
        sqlreader.Close();
       

        if (String.IsNullOrEmpty(this.fulcrumID))
        {
            this.fulcrumID = this.InsertIntofulcrum();
            var_sql = "UPDATE equipment_inventory SET fulcrumID=@fulcrumID WHERE inventory_id=@inventory_id";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = var_sql;
            command.Parameters.Clear();
            
            command.Parameters.AddWithValue("@fulcrumID", this.fulcrumID);
            command.Parameters.AddWithValue("@inventory_id", this.id);
            command.ExecuteNonQuery();

        }
        else
        {
            endPoint = endPoint + this.fulcrumID + ".json";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(endPoint);
            myHttpWebRequest.Method = "PUT";
            myHttpWebRequest.ContentType = "application/json";
            myHttpWebRequest.Accept = "application/json";
            myHttpWebRequest.Headers.Add("X-ApiToken", tokenAPI);

            using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
            {
                string data = "{\"record\":";
                data += "{\"form_id\": \"" + formInventoryID + "\",";
                data += "\"form_values\": {";
                data += "\"75a5\": \"" + this.oem_asset + "\","; //OEM Asset
                data += "\"b56a\": \"" + this.serial + "\","; //Serial Number
                data += "\"83de\": \"" + this.make + "\","; //Make
                data += "\"1b90\": \"" + this.model + "\","; //model
                data += "\"2263\": {\"choice_values\": [\"" + this.warehouse + "\"]},"; //warehouse
                data += "\"40dd\": {\"choice_values\": [\"" + this.location + "\"]},"; //location
                data += "\"b728\": \"" + this.comments + "\"}"; //comments
                data += "}";
                data += "}";
                JObject JSONbody = JObject.Parse(data);
                streamWriter.Write(JSONbody);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            using (Stream dataStream = myHttpWebResponse.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  

                jsonResult = JsonConvert.DeserializeObject(responseFromServer);

            }

            // Close the response.  
            myHttpWebResponse.Close();

        }
        connection.Close();


       


        return retValue;
    }
    public string InsertIntofulcrum()
    {
        string retParam = "";
        
        string endPoint = ConfigurationManager.AppSettings["FulcrumFormInsertData"];
        string tokenAPI= ConfigurationManager.AppSettings["FulcrumToken"];
        string formInventoryID= ConfigurationManager.AppSettings["FormInventoryID"];
        //Create Request
        HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(endPoint);
        myHttpWebRequest.Method = "POST";
        myHttpWebRequest.ContentType = "application/json";
        myHttpWebRequest.Accept = "application/json";
        myHttpWebRequest.Headers.Add("X-ApiToken",tokenAPI);

        using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
        {
            string data = "{\"record\":";
            data += "{\"form_id\": \"" + formInventoryID + "\",";
            data += "\"form_values\": {";
            data += "\"75a5\": \""+ this.oem_asset+"\","; //OEM Asset
            data += "\"b56a\": \""+ this.serial+"\","; //Serial Number
            data += "\"83de\": \""+ this.make+"\","; //Make
            data += "\"1b90\": \"" + this.model+"\","; //model
            data += "\"2263\": {\"choice_values\": [\"\"]},"; //warehouse
            data += "\"40dd\": {\"choice_values\": [\"\"]},"; //location
            data += "\"b728\": \""+ this.comments+"\"}"; //comments
            data += "}";
            data += "}";
            JObject JSONbody = JObject.Parse(data);
            streamWriter.Write(JSONbody);
            streamWriter.Flush();
            streamWriter.Close();
        }

        //Get Response
        HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

        
        // Display the status.  
        // Get the stream containing content returned by the server. 
        // The using block ensures the stream is automatically closed. 
        using (Stream dataStream = myHttpWebResponse.GetResponseStream())
        {
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            retParam = responseFromServer;
            dynamic jsonResult = JsonConvert.DeserializeObject(retParam);
            retParam = jsonResult.record.id.ToString();
        }

        // Close the response.  
        myHttpWebResponse.Close();

        return retParam;

    }
}