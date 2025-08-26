using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews
{
    public record AdministradorModelView
    {
        
        public int Id { get;  set; }
        public string Email { get; set; } = default!;
        public String Perfil { get; set; } = default!;
    }
}