<template>


    <div>
        <h1>AGREGAR PELICULA/SERIE</h1>

        <form v-on:submit.prevent="AgregarMedia">
            <div>
                <label for="Nombre"> Nombre</label>
                <input type="text" id="Nombre" v-model="media.nombre">
                
            </div>
            <div>
                <label for="Tipo"  > Tipo</label>
                <select id="Tipo" v-model="media.tipo">
                    <option value="Pelicula" >Pelicula</option>
                    <option value="Serie"  >Serie</option>
                </select>

                <select v-model="media.estado" >
                    <option value="Emision">En emision</option>
                    <option value="Finalizado">Finalizado</option>
                 </select>
            </div>
            <div>
                <label for="Duracion"> Duracion</label>
                <input type="number" id="horas" min="1" max="10" placeholder="0" v-model="horas" >
                <input type="number" id="minutos" min="1" max="60" placeholder="0" v-model="minutos" >
            </div>
                    
            <div>
                <label for="Temporadas"> Temporadas</label>
                <input type="number" id="Temporadas" min="1" max="50" placeholder="0" v-model="media.temporadas" >
            </div>
            <div>
                <label for="Estreno"> Estreno</label>
                <input type="date" v-model="media.estreno" >

            </div>
            <div>
                <label for="Sipnosis"> Sipnosis</label>
                <textarea maxlength="140" id="sipnosis" v-model="media.sinopsis"></textarea>
            </div>
            <button type="submit" class="btn btn-warning"  >Agregar</button>
            
        </form>

        <pre>{{$data}}</pre>
        
    
    </div>
    
  
</template>
<script type="text/javascript" >
import Datepicker from 'vuejs-datepicker';
import datepicker from 'vue-date';
import axios from 'axios';
export default {
   
  name: "AgregarMedia",
  data: function(){
      return{
          horas:'',
          minutos:'',
          media : {
              nombre :'',
              tipo :'',
              estado :'',
              duracion :this.horas + 'h'+this.minutos+'min',
              temporadas :0,
              estreno : Date() ,
              sinopsis : '',
          }
      }
  },
  methods:{

      AgregarMedia : function(){
          axios.post('http://localhost:2210/api/media/post',this.media).then(response => {
              if(response =! null){
                  swal("Agregado Correctamente", '', 'success');
                  this.media ={
                      
                      nombre :'',
                        tipo :'',
                        estado :'',
                        duracion :'',
                        temporadas :0,
                        estreno : Date() ,
                        sinopsis : '',
                    }
                   
              }else{
                  swal("Error interno", '', 'error');
              }

          });
      }
                      },

      
    
}
</script>
