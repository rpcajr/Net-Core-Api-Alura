using System;
using System.ComponentModel.DataAnnotations;

namespace Filmes.Models.Dto
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Duração é obrigatório")]
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
