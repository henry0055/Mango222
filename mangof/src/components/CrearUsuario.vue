<template>
  <div >
  <div>


      <div class="text-center" style="padding:50px 0">
	<div class="logo">Registrate</div>
	<!-- Main Form -->
	<div class="login-form-1">
		<form v-on:submit.prevent="agregarUsuario" id="register-form" class="text-left">
			<div class="login-form-main-message"></div>
			<div class="main-login-form">
				<div class="login-group">
					<div class="form-group">
						<label for="reg_username" class="sr-only">Email address</label>
						<input v-model="usuario.username" type="text" class="form-control" id="reg_username" name="reg_username" placeholder="usuario">
					</div>
					<div class="form-group">
						<label for="reg_password" class="sr-only">Password</label>
						<input v-model="usuario.password" type="password" class="form-control" id="reg_password" name="reg_password" placeholder="clave">
					</div>
					<div class="form-group">
						<label for="reg_password_confirm" class="sr-only">Password Confirm</label>
						<input v-model="confirmacionPass" type="password" class="form-control" id="reg_password_confirm" name="reg_password_confirm" placeholder="Confima clave">
					</div>
					
					<div class="form-group">
						<label for="reg_email" class="sr-only">Email</label>
						<input v-model="usuario.correo" type="text" class="form-control" id="reg_email" name="reg_email" placeholder="Correo">
					</div>
					<div class="form-group">
						<label for="reg_fullname" class="sr-only">Full Name</label>
						<input v-model="usuario.nombre" type="text" class="form-control" id="reg_fullname" name="reg_fulllname" placeholder="Nombre">
					</div>
					<div class="form-group">
						<label for="reg_fullname" class="sr-only">Full Name</label>
						<input v-model="usuario.apellidos" type="text" class="form-control" id="reg_fullname" name="reg_fullname" placeholder="Apellido">
					</div>
					
				</div>
				<button  type="submit" class="login-button"><i class="fa fa-chevron-right"></i></button>
			</div>
			<div class="etc-login-form">
				<p>¿Ya tienes una cuenta? <router-link to="/login">accede aqui </router-link></p>
			</div>
		</form>
	</div>
	<!-- end:Main Form -->
</div>

 
      <pre>{{$data}}</pre>
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
  name: "CrearUsuario",

  data: function() {
    return {
      confirmacionPass: "",
      usuario: {
        username: "",
        password: "",
        nombre: "",
        apellidos: "",
        correo: "",
        foto: ""
      },
      usuarios: [],
      file: {}
    };
  },
  methods: {
    agregarUsuario: function() {
      if (this.usuario.password == this.confirmacionPass) {//Verifica si coinciden las claves
        axios
          .post("http://localhost:2210/api/persona/post", this.usuario)
          .then(response => {
            if (response.data != null) {
              swal("Agregado Exitosmente", "", "success");

              this.usuario = {//vaciar el objeto
                username: "",
                password: "",
                nombre: "",
                apellidos: "",
                correo: "",
                foto: ""
              };
            } else {
              swal("Error interno", "", "error");
            }
          });
      } else {
        swal("Alerta", "Las claves no coinciden", "warning");
        (this.usuario.password = ""), (this.confirmacionPass = "");//Si no coinciden las claves , vacia los campos
      }
    },

    subirImagen: function(e) {
      this.file = e.files[0];
    }
  }
};
</script>

<style>
#divForm {
  align-content: center;
}

.pass {
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
