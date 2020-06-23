
using System;

public   class ShopifyOrderJSONData
{
    public Order[] orders { get; set; }
}

public class Order
{
    public long id { get; set; }
    public string email { get; set; }
    public DateTime created_at { get; set; }
    public bool test { get; set; }
    public string total_price { get; set; }
    public string subtotal_price { get; set; }
    public string total_tax { get; set; }
    public string name { get; set; }
    public int order_number { get; set; }
    public Total_Shipping_Price_Set total_shipping_price_set { get; set; }
    public Line_Items[] line_items { get; set; }
    public Billing_Address billing_address { get; set; }
    public Shipping_Address shipping_address { get; set; }
    public Customer customer { get; set; }
}

public class Total_Shipping_Price_Set
{
    public Shop_Money shop_money { get; set; }
    public Presentment_Money presentment_money { get; set; }
}

public class Shop_Money
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}

public class Presentment_Money
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}

public class Billing_Address
{
    public string first_name { get; set; }
    public string address1 { get; set; }
    public string phone { get; set; }
    public string city { get; set; }
    public string zip { get; set; }
    public string province { get; set; }
    public string country { get; set; }
    public string last_name { get; set; }
    public string address2 { get; set; }
    public object company { get; set; }
    public float? latitude { get; set; }
    public float? longitude { get; set; }
    public string name { get; set; }
    public string country_code { get; set; }
    public string province_code { get; set; }
}

public class Shipping_Address
{
    public string first_name { get; set; }
    public string address1 { get; set; }
    public string phone { get; set; }
    public string city { get; set; }
    public string zip { get; set; }
    public string province { get; set; }
    public string country { get; set; }
    public string last_name { get; set; }
    public string address2 { get; set; }
    public object company { get; set; }
    public float? latitude { get; set; }
    public float? longitude { get; set; }
    public string name { get; set; }
    public string country_code { get; set; }
    public string province_code { get; set; }
}

public class Customer
{
    public long id { get; set; }
    public string email { get; set; }
    public bool accepts_marketing { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public int orders_count { get; set; }
    public string state { get; set; }
    public string total_spent { get; set; }
    public object last_order_id { get; set; }
    public object note { get; set; }
    public bool verified_email { get; set; }
    public object multipass_identifier { get; set; }
    public bool tax_exempt { get; set; }
    public object phone { get; set; }
    public string tags { get; set; }
    public object last_order_name { get; set; }
    public string currency { get; set; }
    public DateTime accepts_marketing_updated_at { get; set; }
    public object marketing_opt_in_level { get; set; }
    public object[] tax_exemptions { get; set; }
    public string admin_graphql_api_id { get; set; }
    public Default_Address default_address { get; set; }
}

public class Default_Address
{
    public long id { get; set; }
    public long customer_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public object company { get; set; }
    public string address1 { get; set; }
    public string address2 { get; set; }
    public string city { get; set; }
    public string province { get; set; }
    public string country { get; set; }
    public string zip { get; set; }
    public string phone { get; set; }
    public string name { get; set; }
    public string province_code { get; set; }
    public string country_code { get; set; }
    public string country_name { get; set; }
    public bool _default { get; set; }
}

public class Line_Items
{
    public long id { get; set; }
    public long variant_id { get; set; }
    public string title { get; set; }
    public int quantity { get; set; }
    public string sku { get; set; }
    public string variant_title { get; set; }
    public string vendor { get; set; }
    public string fulfillment_service { get; set; }
    public long product_id { get; set; }
    public bool requires_shipping { get; set; }
    public bool taxable { get; set; }
    public bool gift_card { get; set; }
    public string name { get; set; }
    public string variant_inventory_management { get; set; }
    public object[] properties { get; set; }
    public bool product_exists { get; set; }
    public int fulfillable_quantity { get; set; }
    public int grams { get; set; }
    public string price { get; set; }
    public string total_discount { get; set; }
    public object fulfillment_status { get; set; }
    public Price_Set price_set { get; set; }
    public Total_Discount_Set total_discount_set { get; set; }
    public object[] discount_allocations { get; set; }
    public object[] duties { get; set; }
    public string admin_graphql_api_id { get; set; }
    public Tax_Lines[] tax_lines { get; set; }
    public Origin_Location origin_location { get; set; }
    public Destination_Location destination_location { get; set; }
}

public class Price_Set
{
    public Shop_Money1 shop_money { get; set; }
    public Presentment_Money1 presentment_money { get; set; }
}

public class Shop_Money1
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}

public class Presentment_Money1
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}

public class Total_Discount_Set
{
    public Shop_Money2 shop_money { get; set; }
    public Presentment_Money2 presentment_money { get; set; }
}

public class Shop_Money2
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}

public class Presentment_Money2
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}

public class Origin_Location
{
    public long id { get; set; }
    public string country_code { get; set; }
    public string province_code { get; set; }
    public string name { get; set; }
    public string address1 { get; set; }
    public string address2 { get; set; }
    public string city { get; set; }
    public string zip { get; set; }
}

public class Destination_Location
{
    public long id { get; set; }
    public string country_code { get; set; }
    public string province_code { get; set; }
    public string name { get; set; }
    public string address1 { get; set; }
    public string address2 { get; set; }
    public string city { get; set; }
    public string zip { get; set; }
}

public class Tax_Lines
{
    public string title { get; set; }
    public string price { get; set; }
    public float rate { get; set; }
    public Price_Set1 price_set { get; set; }
}

public class Price_Set1
{
    public Shop_Money3 shop_money { get; set; }
    public Presentment_Money3 presentment_money { get; set; }
}

public class Shop_Money3
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}

public class Presentment_Money3
{
    public string amount { get; set; }
    public string currency_code { get; set; }
}
