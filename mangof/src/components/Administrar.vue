<template>
  <div>

      	<section id="nino-story">
		<div class="container">
			<h2 class="nino-sectionHeading">
				<span class="nino-subHeading">Bienvenido Administrador</span>
				Seccion de Administrador
			</h2>
			<p class="nino-sectionDesc">Seleccione que desea hacer</p>
		
		</div>		
	 </section>




      <section id="nino-counting">
    	<div class="container">
    		<div layout="row" class="verticalStretch">
    			<div class="item">
    				<div class="number"></div>
    				<div class="text"></div>
    			</div>
    			<div class="item">
                    <router-link id="textoo" to="/aa">
                        <div id="textoo">Agregar Actor</div> 
                    </router-link>
    			</div>
    			<div class="item">
    				
                    <router-link id="textoo" to="/am">
                        <div id="textoo">Agregar Pelicula/Serie</div>
                    </router-link>
    				
    			</div>
    			<div class="item">
    				<div class="number"></div>
    				<div class="text"></div>
    			</div>
    			<div class="item">
    				<div class="number"></div>
    				<div class="text"></div>
    			</div>
    		</div>
            <div layout="row" class="verticalStretch"></div>
    	</div>
    </section>
  </div>
</template>

<script>
export default {
    name:'Administrar'
  
}
</script>
<style>
.number{
    font-size: 3px;
}

#textoo{
    font-size: 30px;
    color:  white;
}
</style>
