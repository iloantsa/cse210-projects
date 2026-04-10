
public class Product
{
    public string _productName;
    public string _productId;

    public double _productprice;
    public int _productQuantity;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productprice = price;
        _productQuantity = quantity;
        
        
    }

    public double GetTotalCost()
    {
        return _productprice * _productQuantity;
    }

    public string GetPackingLabel()
    {
        return $"{_productName} (ID: {_productId})";
    }


}