using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = { "12.3", "45", "ABC", "11", "DEF"};
string message = "";
string total;

// Crie um loop que ira passar por todos os índices => foreach ou for


// Se o valor for um número adicione a "total" caso contrario concatene com "message"