class InscripcionesPersonas
{
    private List<Persona> listado { get; set; }

    public void inscribir(Persona persona){
        listado.Add(persona);
    }
    public void eliminar(Persona persona){
        listado.RemoveAt(buscarPersona(persona));
    }
    private int buscarPersona(Persona persona){
        return listado.FindIndex(person => person.ID == persona.ID);
    }
    public void actualizar(Persona persona){
        listado[buscarPersona(persona)] = persona;
    }

    public void guardarInformacion(Persona persona){

    }
    public void cargarDatos(){

    }
}