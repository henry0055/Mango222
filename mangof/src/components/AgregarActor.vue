<template>
  <div>
      <form>
          <div>
              <label for="Nombre">Nombre</label>
              <input type="text" id="Nombre" v-model="actor.Nombre"  >
          </div>
           <div>
              <label for="Apellido">Apellido</label>
              <input type="text" id="" v-model="actor.Apellido">
          </div>
           <div>
              <label for="Nacionalidad">Nacionalidad</label>
              <input type="text" id="Nacionalidad" v-model="actor.Nacionalidad">
          </div>
           <div>
              <label for="Descripcion">Descripcion</label>
              <input type="text" id="Descripcion" v-model="actor.Descripcion">
          </div>
 
           <div>
              <label for="">Edad</label>
              <input type="number" id="Edad" min="1" max="200" placeholder="0" v-model="actor.Edad">
          </div>
          <button v-on:click="AgregarActor" >Agregar</button>
      </form>




   
<pre>{{$data}}</pre>
  </div>
</template>

<script type="text/javascript" >
import axios from 'axios'
export default {
     name:"AgregarActor",
     data:function()
     {
         return{
             actor : {Nombre:'',Apellido:'',Nacionalidad:'',Descripcion:'',Edad:0}
         }
     },
     methods:{

         AgregarActor:function(){
             axios.post('http://localhost:2210/api/actor/post',this.actor).then(response => {
                 if(response.data =! null){
                     this.actor = {Nombre:'',Apellido:'',Nacionalidad:'',Descripcion:'',Edad:0};
                     swal("Actor Agregado Correctamente", '', 'succes');
                 }else{
                     swal("Error interno", '', 'error');
                 }
             })
         }

     }
}
</script>
