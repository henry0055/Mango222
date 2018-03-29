<template>

<div>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
 <div class="text-center" style="padding:50px 0">
	<div class="nino-sectionHeading"  >login</div>
	<!-- Main Form -->
	<div class="login-form-1">
		<form id="login-form" class="text-left">
			<div class="login-form-main-message"></div>
			<div class="main-login-form">
				<div class="login-group">
					<div class="form-group">
						<label for="lg_username" class="sr-only">Username</label>
						<input type="text" class="form-control" id="lg_username" name="lg_username" placeholder="Username" v-model="usuario.username">
					</div>
					<div class="form-group">
						<label for="lg_password" class="sr-only">Password</label>
						<input type="password" class="form-control" id="lg_password" name="lg_password" placeholder="Password"v-model="usuario.password">
					</div>
					<div class="form-group login-group-checkbox">
						<input type="checkbox" id="lg_remember" name="lg_remember">
						<label for="lg_remember">remember</label>
					</div>
				</div>
				<button  class="login-button"><i class="fa fa-chevron-right" v-on:click="validacion"></i></button>
			</div>
			<div class="etc-login-form">
				<p>forgot your password? <a href="#">click here</a></p>
				<p>new user? <a href="#">create new account</a></p>
			</div>
		</form>
	</div>
	<!-- end:Main Form -->
</div>


    <pre>{{$data}}</pre>
    
</div>
  
</template>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script type="text/javascript">
import axios from 'axios';


export default {
    name:"Login",
    data:function(){
        return{
        compartido:'nana',
        
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
              }else{
                  swal("Username o password incorrectos", '', 'error');
              }
          } )
      }
  }
}
</script>
<style>
.login-form-1 .login-button {
  position: absolute;
  right: -25px;
  top: 50%;
  background: #ffffff;
  color: #999999;
  padding: 11px 0;
  width: 50px;
  height: 50px;
  margin-top: -25px;
  border: 5px solid #efefef;
  border-radius: 50%;
  transition: all ease-in-out 500ms;
}
.login-form-1 .login-button:hover {
  color: #555555;
  transform: rotate(450deg);
}
.login-form-1 .login-button.clicked {
  color: #555555;
}
.login-form-1 .login-button.clicked:hover {
  transform: none;
}
.login-form-1 .login-button.clicked.success {
  color: #2ecc71;
}
.login-form-1 .login-button.clicked.error {
  color: #e74c3c;
}
</style>

