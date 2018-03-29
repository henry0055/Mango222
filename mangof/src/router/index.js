import Vue from 'vue'
import axios from 'axios'
import Vuex from 'vuex'
import 'vue-use-vuex'
import Router  from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import CrearUsuario from '@/components/CrearUsuario'
import Prueba from '@/components/prueba'
import ListarUsuario from '@/components/ListarUsuario'
import AgregarMedia from  '@/components/AgregarMedia'
import Login from '@/components/Login'
import Index from '@/components/Index'
import AgregarActor from '@/components/AgregarActor'
import Administrar from '@/components/Administrar'
import SingleMedia from '@/components/SingleMedia'
import dd from '@/components/ddddddddddddddddddddddd'
import VueRouter from 'vue-router'

Vue.use(VueRouter)
Vue.use(Vuex)
Vue.prototype.$ajax = axios

Vue.use(Router)
Vue.use(axios)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HelloWorld',
      component: HelloWorld
    },
    
    {
      path: '/cu',
      name: 'cu',
      component: CrearUsuario
    },
    {
      path: '/pu',
      name: 'pu',
      component: Prueba
    },
    {
      path: '/lu',
      name: 'lu',
      component: ListarUsuario
    },
    {
      path: '/am',
      name: 'am',
      component: AgregarMedia
    },
    {
      path: '/login',
      name: 'login',
      component: Login
    },
    {
      path: '/index',
      name: 'index',
      component: Index
    },
    {
      path: '/aa',
      name: 'aa',
      component: AgregarActor
    },
    {
      path: '/ad',
      name: 'ad',
      component: Administrar
    },
    {
      path: '/sm/:id',
      name: 'sm',
      component: SingleMedia
    },
    {
      path: '/dd',
      name: 'dd',
      component: dd
    },

  ]
})
