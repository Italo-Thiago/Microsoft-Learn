// SKU = Stock Keeping Unit
// SKU value format: <product #>-<2-letter color code>-<size code>

string sku = "01-MN-L";

string[] product = sku.Split('-');

// Refactor
string type = product[0] switch
{
    "01" => type = "Sweat shirt",
    "02" => type = "T-Shirt",
    "03" => type = "Sweat pants",
    _    => type = "Other"
};

string color = product[1] switch
{
    "BL" => color = "Black",
    "MN" => color = "Marron",
    _    => color = "White"
};

string size = product[2] switch
{
    "S" => size = "Small",
    "M" => size = "Medium",
    "L" => size = "Large",
    _   => size = "One Size Fits All"
};


/* Normal
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}
*/
/* color
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Marron";
        break;
    default:
        color = "White";
        break;
}
*/
/* size
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
*/
Console.WriteLine($"Product: {size} {color} {type}");
