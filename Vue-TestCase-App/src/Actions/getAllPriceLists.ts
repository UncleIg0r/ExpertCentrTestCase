import axios from "axios";
import myConfig from "@/Configs/myConfig"
import type { PriceList } from "@/Models/PriceListModel";

export default async function getAllPriceLists(config: typeof myConfig):Promise<PriceList[] | null>{
    const url = config.addr + config.Endpoints.getAllPriceLists;
    return (await axios.get(url)).data
}