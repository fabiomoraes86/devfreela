namespace DevFreela.Application.InputModels
{
    public class UpdateProjectInputModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Description { get; set; }
        public decimal TotalCost { get; set; }
    }
}
