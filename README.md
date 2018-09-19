# Korvi.Conekta

Biblioteca diseñada para generar una alternativa a la biblioteca existente (Oficial) de conekta. 

En Korvi consideramos que con simples "Factory Methods" podemos generar una biblioteca mucho más sencilla de implementar. 

Crear un cliente y una orden se puede hacer tan fácil como el siguiente código:
```
Api _conektaApi = new Api("API KEY GOES HERE");

Customer customer = Customer.CreateCustomerObject("Fulanito Pérez", "fulanito@conekta.com", "+52181818181", "tok_test_visa_4242");
CreateCustomerResponse response = _conektaApi.CreateCustomer(customer);

List<LineItem> items = new List<LineItem>();
items.Add(new LineItem() { name = "Tacos", unit_price = 1000, quantity = 12 });

Order order = Order.CreateOrderObject("MXN", response.id, items);
var orderResponse = _conektaApi.CreateOrder(order);
```
