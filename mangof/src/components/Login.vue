
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.13.1/jquery.validate.min.js"></script>
<template>
  <div>
 <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">

<!------ Include the above in your HEAD tag ---------->

<!-- All the files that are required -->
<link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
<link href='http://fonts.googleapis.com/css?family=Varela+Round' rel='stylesheet' type='text/css'>

<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />

<!-- Where all the magic happens -->
<!-- LOGIN FORM -->
<div class="text-center" style="padding:50px 0">
	<div class="logo">login</div>
	<!-- Main Form -->
	<div class="login-form-1">
		<form  v-on:submit.prevent="validacion" id="login-form" class="text-left">
			<div class="login-form-main-message"></div>
			<div class="main-login-form">
				<div class="login-group">
					<div class="form-group">
						<label for="lg_username" class="sr-only">Username</label>
						<input  v-model="usuario.username" type="text" class="form-control" id="lg_username" name="lg_username" placeholder="username">
					</div>
					<div class="form-group">
						<label for="lg_password" class="sr-only">Password</label>
						<input  v-model="usuario.password" type="password" class="form-control" id="lg_password" name="lg_password" placeholder="password">
					</div>
					<div class="form-group login-group-checkbox">
						<input type="checkbox" id="lg_remember" name="lg_remember">
						<label for="lg_remember">remember</label>
					</div>
				</div>
				<button  type="submit" v-on:click="validacion()" class="login-button"><i class="fa fa-chevron-right"></i></button>
			</div>
			<div class="etc-login-form">
				
				<p>¿Eres nuevo? unetenos  <router-link to="/cu">aqui </router-link></p>
			</div>
		</form>
	</div>
	<!-- end:Main Form -->
</div>

<!-- REGISTRATION FORM -->



  </div>
</template>


<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script type="text/javascript">
import axios from 'axios';

export default {
    name:"Login",
    data:function(){
        return{
        
        
        usuario  :  {username : '', password : ''},
        }
    },
  methods:{
      validacion : function(){
          axios.post('http://localhost:2210/api/persona/Login',this.usuario )
          .then(response =>{
              if (response.data !=null){
                  swal("Estas logeado", '', 'success');
                 this.usuario = response.data;
                  //sesion
                  this.$session.start(),
                  this.$session.set('id',response.data.id)
                  this.$session.set('nombre',response.data.nombre)
                  this.$session.set('apellidos', response.data.apellidos )
                  this.$session.set('correo', response.data.correo )
                  this.$session.set('foto', response.data.foto )
                  this.$session.set('nacimiento', response.data.nacimiento )
                  this.$router.push('/index')
              }else{
                  swal("Username o password incorrectos", '', 'error');
              }
          } )
      }
  }
}
</script>

