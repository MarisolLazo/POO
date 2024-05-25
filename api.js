const express = require('express');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const hogares = require('./rutas/hogar');

const app = express();
const port = 3000;

app.use(bodyParser.json());

app.get('/', (req, res)=>{
    res.send('Un mensaje para saber que la api ESTA funcionando')
})

app.use('/api/hogar', hogares);

//conectarse a la BD
mongoose.connect('mongodb://localhost:27017/db_vivienda');

const db = mongoose.connection;
db.on('error', console.error.bind(console, 'Error en la conexion a MongoBD'));
db.once('open', ()=> {
    console.log('Conectado a la BD')
})

app.listen(port, () => {
    console.log(`Funcionando API`)
    console.log(`http://localhost:${port}`)
})