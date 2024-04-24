<script lang="ts">
import { defineComponent, onMounted, ref } from 'vue';
import type {Ref} from 'vue';
import axios from 'axios';
import type { PriceList } from '@/Models/PriceListModel';
import getAllPriceLists from '@/Actions/getAllPriceLists';
import myConfig from '@/Configs/myConfig';

const HomeForm = defineComponent({
  name : "HomeView",
  components : {},
  setup(){

    let urlGetAllPriceLists = "https://localhost:7260/GetAll"
    let res : PriceList[] = [];
    let PriceLists : Ref<PriceList[]> = ref([]);
      
    onMounted(async () => {
      PriceLists.value = await getAllPriceLists(myConfig) ?? [];
        
    });

    return {
      PriceLists
    }
  }
});

export default HomeForm ;
</script>

<template>
  <main class="container">
    <h1>Прайс-листы</h1>
    <br />
    <table class="table table-hover">
      <thead>
        <th class="col">
          #
        </th>
        <th class="col">
          Название
        </th>
      </thead>
      <tbody v-for="d, index in PriceLists">
        <tr>
          <th scope="row" v-text=d.Id></th>
          <td><a v-text=d.Name></a></td>
        </tr>
      </tbody>
    </table>
  </main>
</template>
