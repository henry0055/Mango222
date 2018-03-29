import Vue from 'vue'
import axios from 'axios'
import Vuex from 'vuex'

import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import Componente1 from '@/components/Componente1'
import CrearUsuario from '@/components/CrearUsuario'
import Prueba from '@/components/prueba'

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
      path: '/cmp1',
      name: 'cmp1',
      component: Componente1
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
    }
  ]
})
