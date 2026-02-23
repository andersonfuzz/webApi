public class PersonModel
{
    public Guid Id { get; init; }
    public string Name { get; private set; }
    public int Age
    {
        get
        {
            DateTime today = DateTime.Today; //data de hoje
            var age = today.Year - DateOfBirth.Year; //Calcula diferença de anos ignorando mês/dia
            if (DateOfBirth.Date > today.AddYears(-age)) age--; //today.AddYears(-age) Volta essa quantidade de anos na data atual,Compara com a data real de nascimento,Se ainda não chegou no aniversário → diminui 1
            return age;
        }
    }
    public DateTime DateOfBirth { get; private set; }
    public PersonModel(string name, DateTime dateOfBirth)
    {
        Id = Guid.NewGuid();
        Name = name;
        DateOfBirth = dateOfBirth;
    }
}
