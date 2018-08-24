using System;
using System.Collections.Generic;
using GYM_Rocamora.Implementation;
using GYM_Rocamora.Models;

namespace GYM_Rocamora.Views
{
    public class uiAltaSocio
    {
		
		    //ATRIBUTOS
            private List<Cuota> cuotas;
			private List<Rutina> rutinas;
			private List<FichaMedica> fichasMedicas;
			private GestorSocios gestor;
            //private final PersonajesTableModel tablaPersonajesModel;
    
            //CONSTRUCTORES
		    public uiAltaSocio()
            {
			//Crear nueva instancia de GestorSocios
            this.gestor = new GestorSocios();
            //Invocar a los metodos definidos en GestorSocios
            this.cuotas = this.gestor.obtenerCuotas();
            this.rutinas = this.gestor.obtenerRutinas();
            this.fichasMedicas = this.gestor.obtenerFichasMedicas();
            //this.jFechaIngreso.getDateEditor().setEnabled(true);
            //Se asigna el modelo de datos a la tabla de personajes
            //tablaPersonajesModel = new PersonajesTableModel(this.personajes);

			Boolean validarDatos()
            {
                //Comprobar si los datos obligatorios fueron ingresados
                //en caso de que falte alguno informar al usuario
				Boolean validacion = true;
				//Console.WriteLine(jFechaIngreso.getDate());
                if (txtNombre.getText().isEmpty() || txtApellido.getText().isEmpty() || txtDomicilio.getText().isEmpty() ||
                        txtTelefono.getText().isEmpty() || txtMail.getDate() == null)
                {
                    validacion = false;
                    JOptionPane.showMessageDialog(null, "Todos los campos son obligatorios");
                }
                return validacion;
            }

			void crearSocio()
            {
                // Se obtienen los datos ingresados por el usuario asignandolos a variables locales al metodo
				String nombre = txtNombre.getText();
				String apellido = txtApellido.getText();
                String domicilio = txtDuracion.getText();
                String mail = txtMail.getText();
                int telefono = txtTelefono.getText();
                //Se crea el objeto Pelicula.
                Socio nuevoSocio = new Socio(dni, nombre, apellido, domicilio, telefono, mail);
				/*nuevoSocio.setGenero((Genero)generoCombo.getSelectedItem());
				nuevoSocio.setClasificacion((Clasificacion)clasificacionCombo.getSelectedItem());
				nuevoSocio.setPaisDeOrigen((PaisDeOrigen)paisOrigenCombo.getSelectedItem());
				nuevoSocio.setPersonajes(personajes);*/
                //Se invoca al metodo guardarPelicula(nueva) implementado en GestoPelicula
				gestor.guardarSocio(nuevoSocio);
                //Se notificamos al usuario del nuevo registro
                //JOptionPane.showMessageDialog(null, "La Película " + nueva.getNombre() + " ha sido agregada con éxito");
            }

			 BTN crearNewSocio {                                                 
        // Se validan datos obligatorios. En caso de superar la comprobacion
        if (!validarDatos()) {
           JOptionPane.showMessageDialog(null, "Todos los campos son obligatorios");
        }
        else
            // se comprueba que el nombre no corresponda a una pelicula existente.
            if (gestor.buscarSocioPorNombre(txtNombre.getText()) != null) {
                JOptionPane.showMessageDialog(null, "Ya existe una Película con ese nombre");
            }
        else {
            // se crea la instancia de una nueva pelicula
            this.crearSocio();
            txtNombre.setText("");
            txtApellido.setText("");
            txtDomicilio.setText("");
            txtTelefono.setText("");
		    txtMail.setText("");
            //jFechaIngreso.setDate(null);
           
        }
    }  

			void txtNombreFocusLost(java.awt.event.FocusEvent evt) {
            if (gestor.buscarSocioPorNombre(txtNombre.getText()) != null)
            {
                JOptionPane.showMessageDialog(null, "Ya existe una Pelicula con ese mismo nombre");
            }
        }
    }
}
