<template>
  <div >
      <div >
          
              
      <form id="form"class="nino-subscribeForm">

          <div class="form-group" >
              <label  for="username" class="nino-sectionHeading" > Nombre de Usuario</label>
              <input type="text" id="username" v-model="usuario.username" >
            </div>

          <div class="form-group" id="divForm" >
              <label class="nino-sectionHeading" for="exampleInputPassword1" > Password</label>
              <input type="password" id="exampleInputPassword1"  v-model="usuario.password" >
          </div >

          <div>
              <label for="nombre" class="nino-sectionHeading"> Nombre </label>
              <input type="text"   id="nombre" v-model="usuario.nombre">
              
          </div >
          <div class="form-group">
              <label for="apellidos" class="nino-sectionHeading"> Apellidos</label>
              <input type="text" id="apellidos" v-model="usuario.apellidos" >
          </div>
          <div class="form-group">
              <label for="correo"class="nino-sectionHeading" > Correo</label>
              <input type="text" id="correo" v-model="usuario.correo">
          </div>
          <div>
              <input type="file"  @change="subirImagen($e)" >
          </div>
          <div class="form-group">
          <!-- <button v-on:click="AgregarUsuario">Agregar</button> -->
          
          <button class="btn success" v-on:click="agregarUsuario">Agregar</button>
<pre>{{$data}}</pre>
          </div>
      </form>
      </div>
  </div>
</template>

<script src="https://cdn.jsdelivr.net/npm/vue"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/vue-resource/1.5.0/vue-resource.min.js"></script>
<script src="https://cdn.jsdelivr.net/vue.resource/1.0.3/vue-resource.min.js"></script>s
<script src="https://cdnjs.cloudflare.com/ajax/libs/vue/1.0.18/vue.min.js"></script>
<script src="https://unpkg.com/axios/dist/axios.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>


<script type="text/javascript">
import axios from "axios";
export default {
  name:"CrearUsuario",

  data: function () {
      return {
          usuario : {username:'' ,password:'',nombre:'',apellidos:'',correo:'',foto:''},
          usuarios: []  ,
          file : {},

      }
    
  },
  methods:{


        agregarUsuario:function(){
            axios.post('http://localhost:2210/api/persona/post' , this.usuario).then(response => {
                        if(response.data != null){
                            swal("Agregado Exitosmente", '', 'success');
                            this.usuario = {username:'' ,password:'',nombre:'',apellidos:'',correo:'',foto:''};
                            
                        } else {
                            swal("Error interno", '', 'error');
                        }
                    });
                },

            subirImagen : function(e){
            this.file = e.files[0];
        }
        
        },

        
        
            
}
  
  

</script>

<style>
#divForm {

  
 
  align-content: center;
}

.pass{
    display: block;
    width: 50%;
    height: 34px;
    padding: 6px 12px;
    font-size: 14px;
    line-height: 1.42857143;
    color: #555;
    background-color: #fff;
    background-image: none;
    border: 1px solid #ccc;
    border-radius: 4px;

 }


</style>
