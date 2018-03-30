<template>
  <div>
	  
      <section id="nino-services">
    	<div class="container">
    		<h2 class="nino-sectionHeading">
				<span class="nino-subHeading"> </span>
				Peliculas
			</h2>
			<div class="sectionContent">			
				<div class="fw" layout="row">

					<div class="col-md-4 col-sm-6 item " :key="media.id" v-for="media in medias" v-if="media.tipo == 'Pelicula'" >
						<div layout="row">
							<i class="mdi mdi-apple-keyboard-command nino-icon fsr"></i>
							<div>
								<router-link v-bind:to="{name: 'sm', params: {id: media.id}}">
									<img src="@/assets/images/story\img-3.jpg" alt="">
								</router-link>
								<h4 class="nino-serviceTitle">{{media.nombre}}</h4>
								<h4 class="nino-serviceTitle">{{media.id}}</h4>
								<p> {{media.sinopsis}}</p>
								<button class="btn btn-danger" v-on:click="EliminarMedia(media.id)">Borrar</button>
							</div>
						</div>
					</div>

				</div>
			</div>
    	</div>
    </section>

	 <section id="nino-services">
    	<div class="container">
    		<h2 class="nino-sectionHeading">
				<span class="nino-subHeading"> </span>
				Series
			</h2>
			<div class="sectionContent">			
				<div class="fw" layout="row">

					<div class="col-md-4 col-sm-6 item " :key="media.id" v-for="media in medias" v-if="media.tipo == 'Serie'" >
						<div layout="row">
							<i class="mdi mdi-apple-keyboard-command nino-icon fsr"></i>
							<div>
								<router-link v-bind:to="{name: 'sm', params: {id: media.id}}">
									
									<!-- <img src="@/assets/images/story\img-1.jpg" alt=""> -->
									<img src="@/assets/images/what-we-do/img-1.jpg" alt="">
								</router-link>
								<h4 class="nino-serviceTitle">{{media.nombre}}</h4>
								<h4 class="nino-serviceTitle">{{media.estreno}}</h4>
								<p>Photography is the science, art and practice of creating durable images by recording light or other electromagnetic radiation</p>
								<button class="btn btn-danger" v-on:click="EliminarMedia(media.id)">Borrar</button>
							</div>
						</div>
					</div>

				</div>
			</div>
    	</div>
    </section>

	 <section id="nino-services">
    	<div class="container">
    		<h2 class="nino-sectionHeading">
				<span class="nino-subHeading"> </span>
				Actores
			</h2>
			<div class="sectionContent">			
				<div class="fw" layout="row">

					<div class="col-md-4 col-sm-6 item " :key="actor.id" v-for="actor in actores" >
						<div layout="row">
							<i class="mdi mdi-apple-keyboard-command nino-icon fsr"></i>
							<div>
								<h4 class="nino-serviceTitle">{{actor.nombre}}</h4>
								<p>Photography is the science, art and practice of creating durable images by recording light or other electromagnetic radiation</p>
								<button class="btn btn-danger" v-on:click="EliminarActor(actor.id)">Borrar</button>
							</div>
						</div>
					</div>

				</div>
			</div>
    	</div>
    </section>
<pre>{{$data}}</pre>
</div>
</template>



<script>
import axios from 'axios';
import vuex from 'vuex';
import 'vue-use-vuex';
import compartido from '@/components/Login'
import store from '@/App'
export default {
	name:'Index',
	
	
    data:function(){
        return{
			mensaje : compartido.compartido,
			medias : [] ,
			actores:[],
			actores : ( axios.get('http://localhost:2210/api/actor/getRandom/'+ 6).then(response => {
                        if(response.data != null){
							this.actores = response.data;
							
                        } else {
                            swal("Error internoo , Actores", '', 'error');
                        }
					})),

            medias : ( axios.get('http://localhost:2210/api/media/getRandom/'+6).then(response => {
                        if(response.data != null){
							this.medias = response.data;
							
                        } else {
                            swal("Error internoo , Medias", '', 'error');
                        }
					}))
					


		
		
		} 
	},
			methods:{
					 EliminarMedia : function(id){
                   		 axios.post('http://localhost:2210/api/media/Delete/'+id).then(response => {
							if(response.data=! null){
								swal("Borrado correctamente", '', 'success');
								this.CargarMedia();
							
								
							} else {
								swal("Error interno", '', 'error');
							}
                    })

			},
					EliminarActor : function(id){
						axios.post('http://localhost:2210/api/actor/Delete/'+id).then(response => {
							if(response.data=! null){
								swal("Actor borrado correctamente", '', 'success');
								this.CargarActor();
					
							} else {
								swal("Error interno", '', 'error');
							}
					});
			},
					CargarActor : function(tabla){
						axios.get('http://localhost:2210/api/actor/getRandom/'+6).then(response => {
                        if(response.data != null){
							this.actores = response.data;
							
                        } else {
                            swal("Error internoo , cargando actores", '', 'error');
                        }
					})

					},
					CargarMedia : function(){
						axios.get('http://localhost:2210/api/media/getRandom/'+6).then(response => {
                        if(response.data != null){
							this.medias = response.data;
							
                        } else {
                            swal("Error internoo , cargando media", '', 'error');
                        }
					})

					}

		},////metodos
				
 
}
</script>
