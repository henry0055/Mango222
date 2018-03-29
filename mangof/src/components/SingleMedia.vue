<template>
  <div>

    <section id="nino-whatWeDo">
    	<div class="container">
    		<h2  class="nino-sectionHeading">
				<span class="nino-subHeading"></span>
				 {{media.nombre}} 9.0
			 
			</h2>
			
			<div class="sectionContent">
				<div class="row">
					<div class="col-md-6">
						<div class="text-center">
							<img src="@/assets/images/what-we-do/img-1.jpg" alt="">
						</div>
					</div>
					<div class="col-md-6">
						<div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
							<div class="panel panel-default">
								<div class="panel-heading" role="tab" id="headingOne">
									<h4 class="panel-title">
										<a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
											<i class="mdi mdi-chevron-up nino-icon arrow"></i>
											<i class="mdi mdi-camera nino-icon"></i> 
											DATOS GENERALES
										</a>
									</h4>
								</div>
								<div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
									<div class="panel-body">
										
										
										<h5>Nombre :  {{media.nombre}}</h5>
										<h5>Duracion :  {{media.duracion}}</h5>
										<h5 v-if="media.tipo == 'Serie'"> temporadas : {{media.temporadas}}</h5>
										<h5>Estado : {{media.estado}}</h5>
										<h5>Estreno : {{media.estreno}}</h5>
										
										
										
									</div>
								</div>
							</div>
							<div class="panel panel-default">
								<div class="panel-heading" role="tab" id="headingTwo">
									<h4 class="panel-title">
										<a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
											<i class="mdi mdi-chevron-up nino-icon arrow"></i>
											<i class="mdi mdi-owl nino-icon"></i> 
											SINOPSIS
										</a>
									</h4>
								</div>
								<div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
									<div class="panel-body">
										<h5>{{media.sipnosis}}</h5>
									</div>
								</div>
							</div>
							
						</div>
					</div>
				</div>
			</div>
    	</div>
    </section><!--/#nino-whatWeDo-->


    <section class="nino-testimonial">
    	<div class="container">
    		<div class="nino-testimonialSlider">
				<ul>
					<li :key="comentario.id" v-for="comentario in comentarios">
						<div layout="row">
							<div class="nino-symbol fsr">
								<i class="mdi mdi-comment-multiple-outline nino-icon"></i>
							</div>
							<div>
								<p class="quote">{{comentario.contenido}}</p>
								<span class="name">Jon Doe</span>
							</div>
						</div>
					</li>
					<li >
						<div layout="row">
							<div class="nino-symbol fsr">
								<i class="mdi mdi-comment-multiple-outline nino-icon"></i>
							</div>
							<div>
								<textarea id="textArea" rows="4" cols="118"  v-model="comentario.contenido"></textarea>
								<button v-on:click="comentar()" >Comentar</button>
							</div>
						</div>
					</li>
				</ul>
			</div>
    	</div>
		<form>

		</form>
    </section><!--/#nino-testimonial-->
	<pre>{{$data}}</pre>
  </div>
</template>
<script>
import axios from 'axios'
export default {
	
  name:"SingleMedia",
  data:function(){
	  return{
	  nada : 'nadai' ,
	  rating :0,
	  comentarios:[],
	  id : this.$route.params.id,
	  numero : 1008,	
	  media:{},
	  usuario:{
		  id:this.$session.get('id')
	  },
	  comentario :{contenido:'', IdPersona :0  ,IdMedia:this.$route.params.id },
	 
	  media : 
			(axios.get('http://localhost:2210/api/media/GetSingle/'+ this.$route.params.id).then(response => {
					if(response.data != null){
						this.media = response.data;

					}else{
						swal("Error internoo , Media", '', 'error');
					}
				},
			)) ,
		
		
		comentarios:
			(axios.get('http://localhost:2210/api/comentario/GetComentarios/'+ this.$route.params.id ).then(response =>{
				if(response.data != null){
					this.comentarios = response.data;

				}else{
					swal("Error internoo , Media, comentarios", '', 'error');
				}
			}))

      }
   },

   methods:{
	   comentar:function(){
		   axios.post('http://localhost:2210/api/comentario/post',this.comentario).then(response => {
			   if(response.data != null){
				   swal("Tu comentario ha sido agregado exitosamente, comentarios", '', 'success');
				   this.comentario = {contenido:'', IdPersona :0 },
				   this.CargarComentarios()

			   }else{
				   	swal("Error internoo Agregando Comentario, comentarios", '', 'error');
			   }
		   })
	   },
	   CargarComentarios : function(){
		   axios.get('http://localhost:2210/api/comentario/GetComentarios/'+ this.$route.params.id ).then(response =>{
				if(response.data != null){
					this.comentarios = response.data;

				}else{
					swal("Error internoo , Media, comentarios", '', 'error');
				}
			})
	   }

   }
  }
</script>
