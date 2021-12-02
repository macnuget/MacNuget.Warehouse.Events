# MacNuget.Warehouse.Events

## Our iternal Events
### NewRefillEvent
An internal event to update (+) the quantity of the product
 
### NewProductEvent
An internal event to add a new product to the product directory

### NewDeleteProductEvent
An internal event to delete (set true/false the availabity of a product)

### NewUpdateProductEvent
An internal event to update a product (not the quantity (see NewRefillEvent for update quantity))
