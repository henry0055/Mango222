// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import vuex from 'vuex'
import router from './router'
import axios from 'axios'
import Datepicker from 'vuejs-datepicker';
import bootstrapmin from './assets/css/bootstrap.min.css'
import swal from 'sweetalert'
import materialDesing from './assets/css/materialdesignicons.min.css'
import prettyPhoto from './assets/css/prettyPhoto.css'
import template from './assets/css/template.css'
import VueSession from 'vue-session'

//import jquery from './assets/css/jquery.mCustomScrollbar.min.css'
//import unslider from '/assets/css/unslider.css'
require('./assets/js/jquery.min.js')
 require('./assets/js/bootstrap.min.js')

require('./assets/js/template.js')
require ('./assets/js/unslider-min.js')
require('./assets/js/jquery.hoverdir.js')
require('./assets/js/jquery.mCustomScrollbar.concat.min.js')
//require('./assets/js/jquery.prettyPhoto.js')
  //require('./assets/js/isotope.pkgd.min.js')
  
 
  //require('./assets/js/modernizr.custom.97074.js')
Vue.use(axios)
Vue.use(vuex)
Vue.use(VueSession)

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
