# MacNuget.Warehouse.Events

## Our iternal Events
### NewRefillEvent
An internal event to update (+) the quantity of the product

## External Event
### NewProductEvent
An external event to add a new product to the product directory

### NewDeleteProductEvent
An external event to delete (set true/false the availabity of a product)

### NewUpdateProductEvent
An external event to update a product (not the quantity (see NewRefillEvent for update quantity))

### NewOrderEvent
An external event to add a new order to remove the quantity of the product
