namespace Namespace;
public class Curso
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Curso(int id, string name) {
        this.Id = id;
        this.Name = name;
    }
}
