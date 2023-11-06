namespace Webapiaspnet.Data.DTO
{
    public class ReadNoticiaDto
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}
