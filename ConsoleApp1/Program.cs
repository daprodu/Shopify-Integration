using System;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using JTOXML;

namespace ConsoleApp1
{
    public class Program
    {

 

        static void Main(string[] args)
        {
            #region Test Setup
            // New methods which will be used to call different parts of the 
            // Shopify store
            var jsondata = GetOrdersJSON();
            //    jsondata = GetPaymentTransaction();

            #endregion

            // This is called for Batch Orders
            string tt = SerializaToXML.ShopifyOrderXML(jsondata);
             
            // This is called for the payment transaction
           // tt = SerializaToXML.ShopifyTransactionXML(jsondata);

            Console.WriteLine(tt);
            Console.ReadKey();
        }

        static string GetOrdersJSON()
        {
            string url = "https://beauti-logistix.myshopify.com/admin/api/2020-04/orders.json/?fields=id,order_number,line_items,name,total_price,subtotal_price,email,test,total_tax,billing_address,shipping_address,CUSTOMER,created_at,total_shipping_price_set&since_id=2351848161359";
            return ReturnJSONFromShopify( url);
        }

       private static string ReturnJSONFromShopify(  string url)
        {
            var AccessToken = "MmRkYzUzYWI3Yjg2NTZjZWFmMmEyZjU1MjM5ZjJiZmY6NDdlZjY1NTVkNTQ0ZTcwNzZkYTgxODg2OTc2Y2ExYzE=";
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            var myUri = new Uri(url);
            var myWebRequest = WebRequest.Create(myUri);
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Basic " + AccessToken);
            myHttpWebRequest.UserAgent = "Mozilla / 5.0(Windows NT 6.1) AppleWebKit / 537.36(KHTML, like Gecko)";
            myHttpWebRequest.Accept = "application/json";

            var myWebResponse = myWebRequest.GetResponse();
            var responseStream = myWebResponse.GetResponseStream();
            if (responseStream == null) return null;

            var myStreamReader = new StreamReader(responseStream, Encoding.Default);
            var json = myStreamReader.ReadToEnd();

            responseStream.Close();
            myWebResponse.Close();



            return json;
        }
        public static string  GetPaymentTransaction()
        {
            string url = "https://beauti-logistix.myshopify.com/admin/api/2020-01/orders/2352082616399/transactions.json?fields=authorization,order_id";
            return ReturnJSONFromShopify(url);
        }
      

        public static string Serialize100<T>(T value)
        {

            if (value == null)
            {
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Encoding = new UnicodeEncoding(false, false), // no BOM in a .NET string
                Indent = false,
                OmitXmlDeclaration = false,
                
            };

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, value);
                }
                return textWriter.ToString();
            }
        }

        public static T Deserialize<T>(string xml)
        {

            if (string.IsNullOrEmpty(xml))
            {
                return default(T);
            }
           
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            XmlReaderSettings settings = new XmlReaderSettings();
            // No settings need modifying here

            using (StringReader textReader = new StringReader(xml))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return (T)serializer.Deserialize(xmlReader);
                }
            }
        }
       
    }
}
