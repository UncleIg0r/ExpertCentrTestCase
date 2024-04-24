import type { Column } from "./ColumnModel"
import type { Product } from "./ProductModel"

export type CustomValue = {
    Id : number,
    Value : string,
    Column : Column,
    Product : Product
}