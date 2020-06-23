using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace JTOXML
{
    /// <summary>
    /// 
    /// 
    /// 
    /// Serialize Json to XML for specific class.
    /// For each new class to serialize: add class and create a new method to be
    /// called from CLR stored procedure.
    /// 
    /// 
    /// </summary>
    public static  class SerializaToXML
    {
      

        public static string ShopifyOrderXML(string jsondata)
        {
            try
            {
                ShopifyOrderJSONData sojd = new ShopifyOrderJSONData();
                return ToXMLfromJson(sojd, jsondata);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string ShopifyTransactionXML(string jsondata)
        {
            try
            {
                ShopifyTransactionJSON stjd = new ShopifyTransactionJSON();
                return ToXMLfromJson(stjd, jsondata);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        private static string ToXMLfromJson<T>(T details, string JsonData = null)
        {
            if (JsonData == null) return null;
            var detailsData = JsonConvert.DeserializeObject<T>(JsonData);

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var stringwriter = new System.IO.StringWriter())
            {
                //var serializer1 = new XmlSerializer(details.GetType());

                serializer.Serialize(stringwriter, detailsData);
                return stringwriter.ToString();
            }
        }


    }
}
