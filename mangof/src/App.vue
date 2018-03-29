
<template >

  <div id="app"  >
	  
	  
	  
		<div data-target="#nino-navbar" data-spy="scroll">
<header id="nino-header" >    
<div id="nino-headerInner" >
    	<nav id="nino-navbar" class="navbar navbar-default" role="navigation">
				<div class="container">

					<!-- Brand and toggle get grouped for better mobile display -->
					<div class="navbar-header">
						<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#nino-navbar-collapse">
							<span class="sr-only">Toggle navigation</span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
						</button>
					<router-link  to="/index"><a class="navbar-brand" href="homepage.html">Mango</a> </router-link>
						
					</div>

					<!-- Collect the nav links, forms, and other content for toggling -->
					<div class="nino-menuItem pull-right">
						<div class="collapse navbar-collapse pull-left" id="nino-navbar-collapse">
							<ul class="nav navbar-nav">
								<li ><router-link to="/index">Home</router-link></li>
								<!-- class="active" -->
								<li><router-link to="/ad"> Administrar </router-link></li>
								<li><router-link to="/dd"> dd </router-link></li>
								
								<!-- <li><router-link to="/lu">Listar Usuario</router-link></li> -->
								<li><router-link to="/login"> LOGIN </router-link></li>
								<li><router-link to="/cu">Registrarse </router-link></li>
								<li><router-link to="/pu"> TM </router-link></li>
							</ul>
						</div><!-- /.navbar-collapse -->
						<ul class="nino-iconsGroup nav navbar-nav">
							
							<li><a href="#" class="nino-search"><i class="mdi mdi-magnify nino-icon"></i></a></li>
						</ul>
					</div>
				</div><!-- /.container-fluid -->
			</nav>
		 </div>
			
 </header>
		</div>



   <router-view/>
  </div>
 
</template>


<script>
import vuex from 'vuex';
import 'vue-use-vuex';

const store = new vuex.Store({
	state:{
		message : 'Hello , funciono',
		count : 0,
	},
	mutations:{
		
	},
	getters:{
		
	},
})


export default {
  name: 'App',
  data:function(){
	  return{

		  funciona : "Esta es la variable"
	  }
  }
}
</script>

<style>
#app {
  /* font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 0px;	
   */
}
form{
	text-align: center;
	
}

.number{
    font-size: 3px;
}

</style>


