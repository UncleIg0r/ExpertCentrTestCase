import type { Column } from "./ColumnModel"
import type { Product } from "./ProductModel"

export type PriceList = {
    Id : number,
    Name : string,
    Products : Product[],
    Columns : Column[]
}