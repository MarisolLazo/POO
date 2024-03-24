// Primero, crearemos dos módulos: uno para manejar la lógica del programa y otro para la interfaz de usuario.
class Programa {
  constructor() {
    this.valor = 0;
  }

  incrementar() {
    this.valor++;
  }

  decrementar() {
    this.valor--;
  }
}

// Módulo para la interfaz de usuario
class Interfaz {
  constructor() {
    this.valorElemento = document.getElementById('valor');
    this.incrementarBtn = document.getElementById('incrementar');
    this.decrementarBtn = document.getElementById('decrementar');
  }

  actualizarValor(valor) {
    this.valorElemento.textContent = valor;
  }

  manejarIncremento(callback) {
    this.incrementarBtn.addEventListener('click', callback);//Cuando presione este boton va a ir incrementando de 1 en 1
  }

  manejarDecremento(callback) {
    this.decrementarBtn.addEventListener('click', callback);//Cuando presione este boton va a ir decrementando de -1 en -1
  }
}

// Crear instancias de los módulos
const programa = new Programa();
const interfaz = new Interfaz();

// Funciones para manejar los eventos
function incrementarValor() {
  programa.incrementar();
  interfaz.actualizarValor(programa.valor);
}

function decrementarValor() {
  programa.decrementar();
  interfaz.actualizarValor(programa.valor);
}

// Asociar eventos a las funciones
interfaz.manejarIncremento(incrementarValor);
interfaz.manejarDecremento(decrementarValor);
