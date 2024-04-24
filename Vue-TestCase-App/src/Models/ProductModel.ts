import type { CustomValue } from "./CustomValueModel"
import type { PriceList } from "./PriceListModel"

export type Product = {
    Id : number,
    Name : string,
    Article : number,
    CustomValues : CustomValue[]
    PriceList : PriceList
}