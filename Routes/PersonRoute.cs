public static class PersonRoute{

    public static void Routes(this WebApplication app) // extension methods(Só adicionou o this dentro parametro do metodo
    {
        app.MapGet("person",()=>new PersonModel("Anderson",new DateTime(1991,01,04)));
    }
}